'Option Strict Off
'Option Explicit On
'Module FileVersion
'	Private Declare Function lstrcpy Lib "kernel32"  Alias "lstrcpyA"(ByVal lpString1 As String, ByVal lpString2 As Integer) As Integer

'	'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FAE78A8D-8978-4FD4-8208-5B7324A8F795"'
'	Private Declare Sub MoveMemory Lib "kernel32"  Alias "RtlMoveMemory"(ByRef dest As Any, ByVal Source As Integer, ByVal Length As Integer)

'	'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FAE78A8D-8978-4FD4-8208-5B7324A8F795"'
'	'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FAE78A8D-8978-4FD4-8208-5B7324A8F795"'
'	Private Declare Function VerQueryValue Lib "Version.dll"  Alias "VerQueryValueA"(ByRef pBlock As Any, ByVal lpSubBlock As String, ByRef lplpBuffer As Any, ByRef puLen As Integer) As Integer

'	'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FAE78A8D-8978-4FD4-8208-5B7324A8F795"'
'	Private Declare Function GetFileVersionInfo Lib "Version.dll"  Alias "GetFileVersionInfoA"(ByVal lptstrFilename As String, ByVal dwhandle As Integer, ByVal dwlen As Integer, ByRef lpData As Any) As Integer

'	Private Declare Function GetFileVersionInfoSize Lib "Version.dll"  Alias "GetFileVersionInfoSizeA"(ByVal lptstrFilename As String, ByRef lpdwHandle As Integer) As Integer

'	Function GetFileVersion(ByRef FullFileName As String) As String

'		Dim Buffer As String
'		Dim rc As Integer
'		Dim lBufferLen, lDummy As Integer
'		Dim sBuffer() As Byte
'		Dim lVerPointer As Integer
'		Dim bytebuffer(255) As Byte
'		Dim Lang_Charset_String As String
'		Dim HexNumber As Integer
'		Dim strVersionInfo(7) As String
'		Dim i As Short
'		Dim strTemp As String

'		'*** Get size ****
'		lBufferLen = GetFileVersionInfoSize(FullFileName, lDummy)
'		If lBufferLen < 1 Then
'			Exit Function
'		End If


'		ReDim sBuffer(lBufferLen)
'		rc = GetFileVersionInfo(FullFileName, 0, lBufferLen, sBuffer(0))
'		If rc = 0 Then
'			Exit Function
'		End If

'		rc = VerQueryValue(sBuffer(0), "\VarFileInfo\Translation", lVerPointer, lBufferLen)

'		If rc = 0 Then
'			Exit Function
'		End If
'		'lVerPointer is a pointer to four 4 bytes of Hex number,
'		'first two bytes are language id, and last two bytes are code
'		'page. However, Lang_Charset_String needs a  string of
'		'4 hex digits, the first two characters correspond to the
'		'language id and last two the last two character correspond
'		'to the code page id.


'		MoveMemory(bytebuffer(0), lVerPointer, lBufferLen)

'		HexNumber = bytebuffer(2) + bytebuffer(3) * &H100 + bytebuffer(0) * &H10000 + bytebuffer(1) * &H1000000
'		Lang_Charset_String = Hex(HexNumber)
'		'now we change the order of the language id and code page
'		'and convert it into a string representation.
'		'For example, it may look like 040904E4
'		'Or to pull it all apart:
'		'04------        = SUBLANG_ENGLISH_USA
'		'--09----        = LANG_ENGLISH
'		' ----04E4 = 1252 = Codepage for Windows:Multilingual

'		Do While Len(Lang_Charset_String) < 8
'			Lang_Charset_String = "0" & Lang_Charset_String
'		Loop 


'		strVersionInfo(0) = "CompanyName"
'		strVersionInfo(1) = "FileDescription"
'		strVersionInfo(2) = "FileVersion"
'		strVersionInfo(3) = "InternalName"
'		strVersionInfo(4) = "LegalCopyright"
'		strVersionInfo(5) = "OriginalFileName"
'		strVersionInfo(6) = "ProductName"
'		strVersionInfo(7) = "ProductVersion"

'		For i = 7 To 7
'			Buffer = New String(Chr(0), 255)
'			strTemp = "\StringFileInfo\" & Lang_Charset_String & "\" & strVersionInfo(i)
'			rc = VerQueryValue(sBuffer(0), strTemp, lVerPointer, lBufferLen)

'			If rc = 0 Then
'				Exit Function
'			End If

'			lstrcpy(Buffer, lVerPointer)
'			Buffer = Mid(Buffer, 1, InStr(Buffer, Chr(0)) - 1)
'			GetFileVersion = Trim(Buffer)
'		Next i

'	End Function
'End Module