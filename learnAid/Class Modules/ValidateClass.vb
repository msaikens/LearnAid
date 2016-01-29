Option Strict Off
Option Explicit On
Friend Class ValidateClass
	Dim sCommand As String
	Dim AllowAccentuation As Boolean
	Dim AllowLetters As Boolean
	Dim AllowDigits As Boolean
	Dim AllowWhiteSpaces As Boolean
	Dim AllowOthers As Boolean
	Dim sOther As String
	Dim Required As Boolean
	
	Dim UseAreaCode As Boolean
	
	Dim MinLength As Short
	Dim MaxLength As Short
	
	Dim EnableMustBeParameters As Boolean
	Dim MustBeOperators As New Collection
	Dim MustBeOperands As New Collection
	
	Dim sInvalidValueMSG As String
	
	Dim sOutOfRangeMSG As String
	
	Dim sLengthMSG As String
	
	Dim sRequiredMSG As String
	

#Region "LEVEL ONE ROUTINES"
    Function ValidateForm(ByRef frm As System.Windows.Forms.Form) As Boolean
        Dim C As System.Windows.Forms.Control
        Try
            For Each C In frm.Controls
                ValidateForm = ValidateControl(C)
                If Not ValidateForm Then
                    Exit For
                End If
            Next C
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
#End Region
#Region " LEVEL TWO ROUTINES"
    Function ValidateControl(ByRef objControl As System.Windows.Forms.Control) As Boolean
        Dim PosChar As Short
        Dim PosSpace As Short
        Dim iStart As Short
        Dim ValidateType As String
        Dim sParameters As String
        Dim sValue As String

        Me.Init()

        iStart = 1

        On Error Resume Next
        If objControl.GetType() Is GetType(TextBox) Then
            sValue = objControl.Text
        Else
            sValue = objControl.ToString()
        End If
        sCommand = objControl.Tag
        On Error GoTo 0
        If Left(sCommand, 9).ToUpper = "VALIDATE " Then
            PosChar = GetNextChar(sCommand, 10)
            If PosChar > 0 Then
                PosSpace = GetNextSpace(sCommand, PosChar)
                If PosSpace > 0 Then
                    ValidateType = Mid2(sCommand, PosChar, PosSpace - 1).Trim
                    sParameters = Mid2(sCommand, PosSpace, sCommand.Length).Trim
                Else
                    ValidateType = Mid2(sCommand, PosChar, sCommand.Length).Trim
                    sParameters = String.Empty
                End If
                Select Case ValidateType.ToUpper
                    Case "TEXT"
                        Me.ProcessText(sParameters)
                        ValidateControl = CheckText(sValue)
                    Case "PHONE"
                        Me.ProcessPhone(sParameters)
                        ValidateControl = CheckPhone(sValue)
                    Case "ZIPCODE"
                        Call ProcessZipCode(sParameters)
                        ValidateControl = CheckZipCode(sValue)
                End Select
            End If
        Else
            ValidateControl = True
        End If
    End Function
#End Region
#Region "LEVEL THREE ROUTINES"
    Private Function CheckPhone(ByRef s As String) As Boolean
        CheckPhone = False
        Dim B As Boolean

        If Required = True Then
            If s.Trim = "" Then
                MsgBox(sRequiredMSG, MsgBoxStyle.Information)
                Exit Function
            End If
        End If

        If s.Trim <> "" Then
            If UseAreaCode Then
                B = IsInFormat(s, "(###)###-####") Or IsInFormat(s, "(###) ###-####")
            Else
                B = IsInFormat(s, "(###)###-####") Or IsInFormat(s, "(###) ###-####") Or IsInFormat(s, "###-####")
            End If
            If Not B Then
                MsgBox(sInvalidValueMSG, MsgBoxStyle.Information)
                Exit Function
            End If
        End If
        CheckPhone = True
    End Function
    Private Function CheckText(ByRef s As String) As Boolean
        Dim bTemp As Boolean
        Dim CorrectRange As Boolean
        Dim Char_Renamed As String
        Dim iCounter1 As Integer
        Dim ValidValue As Boolean

        CheckText = False

        If AllowLetters Or AllowWhiteSpaces Or AllowDigits Or AllowOthers Then
            ValidValue = True
            For iCounter1 = 1 To s.Length
                Char_Renamed = Mid(s, iCounter1, 1)
                bTemp = False
                If AllowAccentuation Then
                    bTemp = bTemp Or IsAccentuation(Char_Renamed)
                End If
                If AllowLetters Then
                    bTemp = bTemp Or IsLetter(Char_Renamed)
                End If
                If AllowWhiteSpaces Then
                    bTemp = bTemp Or (Char_Renamed = " ")
                End If
                If AllowDigits Then
                    bTemp = bTemp Or IsDigit(Char_Renamed)
                End If
                If AllowOthers Then
                    bTemp = bTemp Or IsOther(Char_Renamed, sOther)
                End If
                ValidValue = ValidValue And bTemp
                If ValidValue = False Then
                    Exit For
                End If
            Next iCounter1

            If ValidValue = False Then
                MsgBox(sInvalidValueMSG, MsgBoxStyle.Information)
                Exit Function
            End If
        End If
        If Required = True Then
            If Not AllowWhiteSpaces And Trim(s) = String.Empty Then
                MsgBox(sRequiredMSG, MsgBoxStyle.Information)
                Exit Function
            ElseIf s = String.Empty Then
                MsgBox(sRequiredMSG, MsgBoxStyle.Information)
                Exit Function
            End If
        End If

        If MinLength > 0 Then
            If s.Length < MinLength Then
                MsgBox(sLengthMSG, MsgBoxStyle.Information)
                Exit Function
            End If
        End If

        If MaxLength > 0 Then
            If s.Length > MaxLength Then
                MsgBox(sLengthMSG, MsgBoxStyle.Information)
                Exit Function
            End If
        End If

        '******************************************************************
        'LA LONGA
        '******************************************************************

        CorrectRange = True
        If s.Trim <> "" Then
            If EnableMustBeParameters = True Then
                For iCounter1 = 1 To MustBeOperators.Count()
                    Select Case MustBeOperators.Item(iCounter1)
                        Case ">="
                            bTemp = (Val(s) >= Val(MustBeOperands.Item(iCounter1)))
                            CorrectRange = bTemp And CorrectRange
                        Case ">"
                            bTemp = (Val(s) > Val(MustBeOperands.Item(iCounter1)))
                            CorrectRange = bTemp And CorrectRange
                        Case "<="
                            bTemp = (Val(s) <= Val(MustBeOperands.Item(iCounter1)))
                            CorrectRange = bTemp And CorrectRange
                        Case "<"
                            bTemp = (Val(s) < Val(MustBeOperands.Item(iCounter1)))
                            CorrectRange = bTemp And CorrectRange
                        Case "="
                            bTemp = (Val(s) = Val(MustBeOperands.Item(iCounter1)))
                            CorrectRange = bTemp And CorrectRange
                    End Select
                Next iCounter1
                If Not CorrectRange Then
                    MsgBox(sOutOfRangeMSG, MsgBoxStyle.Information)
                    Exit Function
                End If
            End If
        End If
        CheckText = True
    End Function
    Private Function CheckZipCode(ByRef s As String) As Boolean
        CheckZipCode = False
        Dim B As Boolean

        If Required = True Then
            If Trim(s) = "" Then
                MsgBox(sRequiredMSG, MsgBoxStyle.Information)
                Exit Function
            End If
        End If

        If Trim(s) <> "" Then
            B = IsInFormat(s, "#####-####") Or IsInFormat(s, "#####")
            If Not B Then
                MsgBox(sInvalidValueMSG, MsgBoxStyle.Information)
                Exit Function
            End If
        End If
        CheckZipCode = True
    End Function
    Private Function GetNextChar(ByRef s As String, ByRef Start As Short) As Short
        Dim iCounter1 As Integer
        For iCounter1 = Start To s.Length
            If Mid(s, iCounter1, 1) <> " " Then
                GetNextChar = iCounter1
                Exit For
            End If
        Next iCounter1
    End Function
    Private Function GetNextSpace(ByRef s As String, ByRef Start As Short) As Short
        Dim iCounter1 As Integer
        For iCounter1 = Start To s.Length
            If Mid(s, iCounter1, 1) = " " Then
                GetNextSpace = iCounter1
                Exit For
            End If
        Next iCounter1
    End Function
    Private Sub Init()
        AllowAccentuation = False
        AllowLetters = False
        AllowDigits = False
        AllowWhiteSpaces = False
        AllowOthers = False
        sOther = String.Empty
        Required = False
        MinLength = -1
        MaxLength = -1
        UseAreaCode = False
        EnableMustBeParameters = False
        While MustBeOperators.Count() > 0
            Call MustBeOperators.Remove(1)
            Call MustBeOperands.Remove(1)
        End While

        sInvalidValueMSG = String.Empty
        sOutOfRangeMSG = String.Empty
        sLengthMSG = String.Empty
        sRequiredMSG = String.Empty

    End Sub
    Private Sub ProcessPhone(ByRef sParameters As String)
        Dim iCounter As Integer
        Dim Params() As String

        Params = Split(sParameters, "-")
        For iCounter1 = 0 To UBound(Params, 1)
            If Left(Params(iCounter1), 15).ToUpper = "INVALIDVALUEMSG" Then
                sInvalidValueMSG = Trim(Right(Params(iCounter1), Params(iCounter1).Length - 15))
            ElseIf Left(Params(iCounter1), 11).ToUpper = "REQUIREDMSG" Then
                sRequiredMSG = Trim(Right(Params(iCounter1), Params(iCounter1).Length - 11))
            ElseIf Left(Params(iCounter1), 8).ToUpper = "REQUIRED" Then
                Required = True
            ElseIf Left(Params(iCounter1), 11).ToUpper = "USEAREACODE" Then
                UseAreaCode = True
            End If
        Next iCounter1
    End Sub
    Private Sub ProcessText(ByRef sParameters As String)
        Dim iCounter1 As Integer
        Dim Params() As String

        Params = Split(sParameters, "-")
        For iCounter1 = 0 To UBound(Params, 1)
            If Left(Params(iCounter1), 12).ToUpper = "ALLOWLETTERS" Then
                AllowLetters = True
            ElseIf Left(Params(iCounter1), 17).ToUpper = "ALLOWACCENTUATION" Then
                AllowAccentuation = True
            ElseIf Left(Params(iCounter1), 11).ToUpper = "ALLOWDIGITS" Then
                AllowDigits = True
            ElseIf Left(Params(iCounter1), 16).ToUpper = "ALLOWWHITESPACES" Then
                AllowWhiteSpaces = True
            ElseIf Left(Params(iCounter1), 10).ToUpper = "ALLOWOTHER" Then
                AllowOthers = True
                sOther = Trim(Mid2(Params(iCounter1), 11, Params(iCounter1).Length))
            ElseIf Left(Params(iCounter1), 9).ToUpper = "MINLENGTH" Then
                MinLength = Val(Trim(Right(Params(iCounter1), Params(iCounter1).Length - 9)))
            ElseIf Left(Params(iCounter1), 9).ToUpper = "MAXLENGTH" Then
                MaxLength = Val(Trim(Right(Params(iCounter1), Params(iCounter1).Length - 9)))
            ElseIf Left(Params(iCounter1), 11).ToUpper = "FIELDMUSTBE" Then
                Call SetFieldMustBe(Trim(Right(Params(iCounter1), Params(iCounter1).Length - 11)))
            ElseIf Left(Params(iCounter1), 15).ToUpper = "INVALIDVALUEMSG" Then
                sInvalidValueMSG = Trim(Right(Params(iCounter1), Params(iCounter1).Length - 15))
            ElseIf Left(Params(iCounter1), 13).ToUpper = "OUTOFRANGEMSG" Then
                sOutOfRangeMSG = Trim(Right(Params(iCounter1), Params(iCounter1).Length - 13))
            ElseIf Left(Params(iCounter1), 9).ToUpper = "LENGTHMSG" Then
                sLengthMSG = Trim(Right(Params(iCounter1), Params(iCounter1).Length - 11))
            ElseIf Left(Params(iCounter1), 11).ToUpper = "REQUIREDMSG" Then
                sRequiredMSG = Trim(Right(Params(iCounter1), Params(iCounter1).Length - 11))
            ElseIf Left(Params(iCounter1), 8).ToUpper = "REQUIRED" Then
                Required = True
            End If
        Next iCounter1
    End Sub
    Private Sub ProcessZipCode(ByRef sParameters As String)
        Dim iCounter1 As Integer
        Dim Params() As String

        Params = Split(sParameters, "-")
        For iCounter1 = 0 To UBound(Params, 1)
            If Left(Params(iCounter1), 15).ToUpper = "INVALIDVALUEMSG" Then
                sInvalidValueMSG = Trim(Right(Params(iCounter1), Params(iCounter1).Length - 15))
            ElseIf Left(Params(iCounter1), 11).ToUpper = "REQUIREDMSG" Then
                sRequiredMSG = Trim(Right(Params(iCounter1), Params(iCounter1).Length - 11))
            ElseIf Left(Params(iCounter1), 8).ToUpper = "REQUIRED" Then
                Required = True
            End If
        Next iCounter1
    End Sub
#End Region
#Region "LEVEL FOUR ROUTINES"
    Private Function IsAccentuation(ByRef s As String) As Boolean
        IsAccentuation = (s = "á" Or s = "é" Or s = "í" Or s = "ó" Or s = "ú" Or s = "ñ" Or s = "Á" Or s = "É" Or s = "Í" Or s = "Ó" Or s = "Ú" Or s = "Ñ")
    End Function
    Private Function IsDigit(ByRef s As String) As Boolean
        IsDigit = (s >= "0" And s <= "9")
    End Function
    Private Function IsInFormat(ByRef s As String, ByVal strformat As String) As Boolean
        Dim FChar As String
        Dim I As Short
        Dim rValue As Boolean = True
        Dim SChar As String
        Dim tmpFormat As String
        Dim tmpS As String

        tmpS = s
        tmpFormat = strformat

        If tmpS.Length = tmpFormat.Length Then
            While rValue = True And I < tmpS.Length
                I += 1
                FChar = Mid(tmpFormat, I, 1)
                SChar = Mid(tmpS, I, 1)
                Select Case FChar
                    Case "#"
                        If SChar < "0" Or SChar > "9" Then
                            rValue = False
                        End If
                    Case "@"
                        If Not ((SChar >= "a" And SChar <= "z") Or (SChar >= "A" And SChar <= "Z")) Then
                            rValue = False
                        End If
                    Case Else
                        If SChar <> FChar Then
                            rValue = False
                        End If
                End Select
            End While
        Else
            rValue = False
        End If
        IsInFormat = rValue
    End Function

    Private Function IsLetter(ByRef s As String) As Boolean
        IsLetter = (s >= "A" And s <= "Z") Or (s >= "a" And s <= "z") Or (s = "-")
    End Function
    Private Function IsOther(ByRef s As String, ByRef sOther As String) As Boolean
        Dim iCounter1 As Integer
        Dim B As Boolean = False

        For iCounter1 = 1 To sOther.Length
            If s = Mid(sOther, iCounter1, 1) Then
                B = True
                Exit For
            End If
        Next iCounter1
        IsOther = B
    End Function
    Private Sub SetFieldMustBe(ByRef sParameters As String)
        Dim I As Short = 1
        Dim sOperator As String = String.Empty
        Dim sOperand As String = String.Empty

        EnableMustBeParameters = True

        Do
            I = GetNextOperator(sParameters, I + sOperator.Length, sOperator, sOperand)
            If I > 0 Then
                MustBeOperators.Add(sOperator)
                MustBeOperands.Add(Trim(sOperand))
            End If
        Loop Until I = 0
    End Sub
#End Region
#Region "LEVEL FIVE ROUTINES"
    Private Function GetNextOperator(ByRef sParameters As String, ByRef Start As Short, ByRef sOperator As String, ByRef sOperand As String) As Short
        Dim I As Short = 0
        Dim PosNextOp As Short

        sOperator = String.Empty
        sOperand = String.Empty
        GetNextOperator = 0
        While Start + I < sParameters.Length
            Select Case Mid(sParameters, Start + I, 1)
                Case ">"
                    If Mid(sParameters, Start + I, 2) = ">=" Then
                        sOperator = ">="
                    Else
                        sOperator = ">"
                    End If
                    PosNextOp = GetPosNextOperator(sParameters, Start + I + sOperator.Length)
                    If PosNextOp = 0 Then
                        sOperand = Mid2(sParameters, Start + I + Len(sOperator), Len(sParameters))
                    Else
                        sOperand = Mid2(sParameters, Start + I + Len(sOperator), PosNextOp - 1)
                    End If
                    GetNextOperator = Start + I
                    Exit Function
                Case "<"
                    If Mid(sParameters, Start + I, 2) = "<=" Then
                        sOperator = "<="
                    Else
                        sOperator = "<"
                    End If
                    PosNextOp = GetPosNextOperator(sParameters, Start + I + Len(sOperator))
                    If PosNextOp = 0 Then
                        sOperand = Mid2(sParameters, Start + I + Len(sOperator), Len(sParameters))
                    Else
                        sOperand = Mid2(sParameters, Start + I + Len(sOperator), PosNextOp - 1)
                    End If
                    GetNextOperator = Start + I
                    Exit Function
                Case "="
                    sOperator = "="
                    PosNextOp = GetPosNextOperator(sParameters, Start + I + Len(sOperator))
                    If PosNextOp = 0 Then
                        sOperand = Mid2(sParameters, Start + I + Len(sOperator), Len(sParameters))
                    Else
                        sOperand = Mid2(sParameters, Start + I + Len(sOperator), PosNextOp - 1)
                    End If
                    GetNextOperator = Start + I
                    Exit Function
            End Select
            I += 1
        End While
    End Function
#End Region

#Region "LEVEL SIX ROUTINES"
    Private Function GetPosNextOperator(ByRef sParameters As String, ByRef Start As Short) As Short
        Dim I As Short = 0
        GetPosNextOperator = 0

        While Start + I < sParameters.Length
            Select Case Mid(sParameters, Start + I, 1)
                Case ">"
                    GetPosNextOperator = Start + I
                    Exit Function
                Case "<"
                    GetPosNextOperator = Start + I
                    Exit Function
                Case "="
                    GetPosNextOperator = Start + I
                    Exit Function
            End Select
            I += 1
        End While
    End Function
    Private Function Mid2(ByVal s As String, ByVal iStart As Short, ByVal iEnd As Short) As String
        Mid2 = Mid(s, iStart, iEnd - iStart + 1)
    End Function

#Region "Unused/Unknown Routines"
    Function ValidateValue(ByRef Value As String, ByRef ValidateString As String) As Boolean
        Dim PosChar As Short
        Dim PosSpace As Short
        Dim iStart As Short
        Dim ValidateType As String
        Dim sParameters As String
        Dim sValue As String

        sValue = Value

        Call Init()

        iStart = 1

        sCommand = ValidateString

        If UCase(Left(sCommand, 9)) = "VALIDATE " Then
            PosChar = GetNextChar(sCommand, 10)
            If PosChar > 0 Then
                PosSpace = GetNextSpace(sCommand, PosChar)
                If PosSpace > 0 Then
                    ValidateType = UCase(Mid2(sCommand, PosChar, PosSpace - 1))
                    sParameters = Mid2(sCommand, PosSpace, Len(sCommand))
                Else
                    ValidateType = UCase(Mid2(sCommand, PosChar, Len(sCommand)))
                    sParameters = ""
                End If

                Select Case ValidateType
                    Case "TEXT"
                        Call ProcessText(sParameters)
                        ValidateValue = CheckText(sValue)
                    Case "PHONE"
                        Call ProcessPhone(sParameters)
                        ValidateValue = CheckPhone(sValue)
                    Case "ZIPCODE"
                        Call ProcessZipCode(sParameters)
                        ValidateValue = CheckZipCode(sValue)
                End Select

            End If
        Else
            ValidateValue = True
        End If

    End Function
#End Region
#End Region
End Class