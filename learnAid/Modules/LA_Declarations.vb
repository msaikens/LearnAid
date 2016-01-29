Option Strict Off
Option Explicit On

Imports ADODB
Imports System.Runtime.InteropServices
Imports learnAid.BLL
Imports CRAXDRT
Imports learnAid.Forms.MasterForms
Imports learnAid.Forms.UserLoginForms
Imports learnAid.Forms.StudentsForm
Imports Microsoft.VisualBasic.Compatibility.VB6
Imports System.Data.SqlClient

Module LA_Declarations
    Public Fac_Total As Double
#Region "Declares And Type Definitions"
    ' -- ******************************************************************************************
    ' -- Declarations for Getting Windows Directories
    ' -- ******************************************************************************************
    Declare Function GetWindowsDirectory Lib "kernel32" Alias "GetWindowsDirectoryA" (ByVal lpBuffer As String, ByVal nSize As Integer) As Integer
    Declare Function GetSystemDirectory Lib "kernel32" Alias "GetSystemDirectoryA" (ByVal lpBuffer As String, ByVal nSize As Integer) As Integer

    ' -- ******************************************************************************************
    ' -- Declarations for INI file access
    ' -- ******************************************************************************************
    Declare Function WriteProfileString Lib "kernel32" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpString As String) As Short
    Declare Function GetProfileInt Lib "kernel32" Alias "GetProfileIntA" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal nDefault As Integer) As Integer
    Declare Function GetProfileString Lib "kernel32" Alias "GetProfileStringA" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Integer) As Integer
    Declare Function GetPrivateProfileInt Lib "kernel32" Alias "GetPrivateProfileIntA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal nDefault As Integer, ByVal lpFileName As String) As Integer
    'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FAE78A8D-8978-4FD4-8208-5B7324A8F795"'
    ''' <param name="lpApplicationName"></param>
    ''' <param name="lpKeyName"></param>
    ''' <param name="lpDefault"></param>
    ''' <param name="lpReturnedString"></param>
    ''' <param name="nSize"></param>
    ''' <param name="lpFileName"></param>
    ''' <remarks>
    '''           Called By: LA_Declarations.GetINIValue()
    ''' </remarks>
    Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FAE78A8D-8978-4FD4-8208-5B7324A8F795"'
    'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FAE78A8D-8978-4FD4-8208-5B7324A8F795"'
    Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Integer

    '//////////////////////////////////////////////////////////////////
    '   BROWSE FOR FOLDERS DECLARATIONS
    '//////////////////////////////////////////////////////////////////
    Public Structure BrowseInfo
        Dim hwndOwner As Integer
        Dim pIDLRoot As Integer
        Dim pszDisplayName As Integer
        Dim lpszTitle As Integer
        Dim ulFlags As Integer
        Dim lpfnCallback As Integer
        Dim lParam As Integer
        Dim iImage As Integer
    End Structure

    Public Const BIF_RETURNONLYFSDIRS As Short = 1
    Public Const MAX_PATH As Short = 260
    'Called By: Me.BrowsForFolder()
    Public Declare Sub CoTaskMemFree Lib "OLE32.DLL" (ByVal hMem As Integer)
    Public Declare Function lstrcat Lib "kernel32" Alias "lstrcatA" (ByVal lpString1 As String, ByVal lpString2 As String) As Integer
    'UPGRADE_WARNING: Structure BrowseInfo may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
    'Called By: Me.BrowseForFolder()
    Public Declare Function SHBrowseForFolder Lib "shell32" (ByRef lpbi As BrowseInfo) As Integer
    'Called By: Me.BrowseForFolder()
    Public Declare Function SHGetPathFromIDList Lib "shell32" (ByVal pidList As Integer, ByVal lpBuffer As String) As Integer


    ' -- ******************************************************************************************
    ' -- Declarations
    ' -- ******************************************************************************************
    '- Alco
    Public objNomina As New Nomina
    Public CalendarValue As Object

    Enum enumLanguages
        English = 0
        Spanih = 1
    End Enum

    Enum enumConsultantType
        ctExaminer = 0
        ctConsultant = 1
    End Enum


    Enum enumReportTypes
        OfficeTesting = 0
        Entrance = 1
        Regular = 2
        AcomodoRazonable = 3
    End Enum
    Enum enumReportSections
        Individual = 0
        General = 1
        Destrezas = 2
    End Enum

    Enum enumSecurityLevel
        DataEntry = 0
        Consultant = 1
        accounting = 2
        Administrator = 3
        Inactive = 4
    End Enum

    Public Structure UserInfo
        Dim UserID As String
        Dim UserType As enumSecurityLevel
        Dim Cons_ID As Double
    End Structure

    Structure ConfigurationType
        '//////////////////////////
        'System Settings Variables
        '//////////////////////////
        Dim Environment As String
        Dim FirstExecution As Boolean
        Dim DataSource As String
        Dim DbUserID As String
        Dim DbBlankPWD As Boolean
        Dim DbPassword As String
        Dim DatabaseName As String
        Dim DataFilesPath As String
        Dim ConsultantsPath As String
        Dim PluginsPath As String
        Dim ReportsPath As String
        Dim ConnectionString As String
        Dim ConnectionStringAdo As String
        Dim COMP_ID As String
        Dim EnableLog As Boolean
        '//////////////////////////
        'GUI Settings Variables
        '//////////////////////////
        Dim ShowStartUp As Boolean
        Dim SchoolWindowVisible As Boolean
        Dim SchoolWindowDocked As Boolean
        Dim PropertiesWindowVisible As Boolean
        Dim PropertiesWindowDocked As Boolean
        Dim ButtonPanelVisible As Boolean
        Dim OnStartUpShowWindow As String
    End Structure


    Public Config As ConfigurationType
    Public Jobs_WhereStatement As String
    Public ConnectionString As String
    Public LoggedUser As UserInfo 'información del usuario logeado
    Public CalCaller As String 'Se usa en la forma del Consultant

    '-- Declarations to launch MS Word
    Private Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" (ByVal hwnd As Integer, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Integer) As Integer


    Private Declare Function GetDesktopWindow Lib "user32" () As Integer

    Private Const SW_SHOWNORMAL As Short = 1


    ' -- ******************************************************************************************
    ' -- Declarations for Getting File Information
    ' -- ******************************************************************************************
    Private Structure FILETIME
        Dim dwLowDateTime As Integer
        Dim dwHighDateTime As Integer
    End Structure

    Private Structure WIN32_FIND_DATA '  318  Bytes
        Dim dwFileAttributes As Integer
        Dim ftCreationTime As FILETIME
        Dim ftLastAccessTime As FILETIME
        Dim ftLastWriteTime As FILETIME
        Dim nFileSizeHigh As Integer
        Dim nFileSizeLow As Integer
        Dim dwReserved As Integer
        Dim dwReserved1 As Integer
        'UPGRADE_WARNING: Fixed-length string size must fit in the buffer. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="3C1E4426-0B80-443E-B943-0627CD55D48B"'
        <VBFixedString(MAX_PATH), MarshalAs(UnmanagedType.ByValArray, SizeConst:=MAX_PATH)> Public cFileName() As Char
        'UPGRADE_WARNING: Fixed-length string size must fit in the buffer. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="3C1E4426-0B80-443E-B943-0627CD55D48B"'
        <VBFixedString(14), MarshalAs(UnmanagedType.ByValArray, SizeConst:=14)> Public cAlternate() As Char
    End Structure

    'UPGRADE_WARNING: Structure WIN32_FIND_DATA may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
    Private Declare Function FindFirstFile Lib "kernel32" Alias "FindFirstFileA" (ByVal lpFileName As String, ByRef lpFindFileData As WIN32_FIND_DATA) As Integer

    Private Win32FindData As WIN32_FIND_DATA
    Private Const INVALID_HANDLE_VALUE As Short = -1
    Private Const ERROR_NO_MORE_FILES As Short = 18

    'frmPreJob.cmdProgram_Click()
    Public bTITULO1 As Boolean

    Public Const iMaxConn As Short = 900

#End Region
#Region "Routines Called From Forms"

#Region "LEVEL ONE ROUTINES"
    'Called By: frmOptions.Command2_Click()
    'Called By: frmOptions.Command3_Click()
    'Called By: frmOptions.Command4_Click()
    'Called By: frmOptions.Command5_Click()
    Public Function BrowseForFolder(ByRef hwndOwner As Integer, ByRef sPrompt As String) As String
        'declare variables to be used
        Dim iNull As Short
        Dim lpIDList As Integer
        Dim lResult As Integer
        Dim sPath As String = Nothing
        Dim udtBI As BrowseInfo

        'initialise variables
        With udtBI
            .hwndOwner = hwndOwner
            .lpszTitle = lstrcat(sPrompt, "")
            .ulFlags = BIF_RETURNONLYFSDIRS
        End With

        'Call the browse for folder API
        lpIDList = SHBrowseForFolder(udtBI)

        'get the resulting string path
        If lpIDList Then
            sPath = New String(Chr(0), MAX_PATH)
            lResult = SHGetPathFromIDList(lpIDList, sPath)
            CoTaskMemFree(lpIDList)
            iNull = InStr(sPath, vbNullChar)
            If iNull Then
                sPath = Left(sPath, iNull - 1)
            End If
        End If
        'If cancel was pressed, sPath = ""
        BrowseForFolder = sPath
    End Function

    'Called By: frmOptions.LoadData()
    Function CBool2Int(ByRef Value As Boolean) As Short
        If Value Then
            CBool2Int = 1
        Else
            CBool2Int = 0
        End If
    End Function

    'Called By: frmAdjustment.Command2_Click()
    Function GetNRandom(ByRef iAmount As Short) As String
        Dim i As Short
        Dim tempname As String = ""
        Randomize()
        For i = 1 To iAmount
            tempname &= CStr(Int(Rnd() * 9) + 1)
        Next i
        GetNRandom = tempname
        Exit Function
    End Function

    'Called By: frmAdjustment.Command2_Click()
    Function GetXRandom(ByRef iAmount As Short) As String
        Dim i As Short
        Dim tempname As String
        tempname = ""
        Randomize()
        For i = 1 To iAmount
            tempname &= Chr(Int(90 - (Rnd() * 25)))
        Next i
        GetXRandom = tempname
        Exit Function
    End Function


    ''' <remarks>
    '''           Called By: frmMain.Main()
    ''' </remarks>
    Sub Init()
        LA_Declarations.GetSystemSettings()
    End Sub

    'Called By: frmOptions.cmdApply_Click()
    'Called By: frmOptions.cmdOK_Click()
    Sub RegisterPlugins()
        Dim i As Integer
        Dim sFiles As String
        Dim vFiles() As String
        Dim sFilename As String
        'UPGRADE_WARNING: Couldn't resolve default property of object GetFilesinDir(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        sFiles = GetFilesinDir(Config.PluginsPath)
        vFiles = Split(sFiles, "|")
        For i = 0 To UBound(vFiles, 1)
            If UCase(Right(vFiles(i), 4)) = ".EXE" Then
                sFilename = Config.PluginsPath & vFiles(i)
                Call Shell(sFilename, AppWinStyle.MinimizedNoFocus)
            End If
        Next i
    End Sub

    'Called By: frmOptions.cmdApply_Click()
    'Called By: frmOptions.cmdOK_Click()
    Sub SaveSystemSettings()

        '////////////////////////////////////////////////////////////////////////////
        '    Save the system settings
        '////////////////////////////////////////////////////////////////////////////

        Call SetINIValue(GetAppPath() & "LearnAid.ini", "System.Settings", "FirstExecution", CStr(CBool2Int(Config.FirstExecution)))
        Call SetINIValue(GetAppPath() & "LearnAid.ini", "System.Settings", "DataSource", Config.DataSource)
        Call SetINIValue(GetAppPath() & "LearnAid.ini", "System.Settings", "DBUserID", Config.DbUserID)
        Call SetINIValue(GetAppPath() & "LearnAid.ini", "System.Settings", "DatabaseName", Config.DatabaseName)
        Call SetINIValue(GetAppPath() & "LearnAid.ini", "System.Settings", "BlankPWD", CStr(CBool2Int(Config.DbBlankPWD)))
        Call SetINIValue(GetAppPath() & "LearnAid.ini", "System.Settings", "DBPassword", Config.DbPassword)


        Call SetINIValue(GetAppPath() & "LearnAid.ini", "System.Settings", "DataFilesPath", Config.DataFilesPath)
        Call SetINIValue(GetAppPath() & "LearnAid.ini", "System.Settings", "PluginsPath", Config.PluginsPath)
        Call SetINIValue(GetAppPath() & "LearnAid.ini", "System.Settings", "ConsultantsPath", Config.ConsultantsPath)
        Call SetINIValue(GetAppPath() & "LearnAid.ini", "System.Settings", "ReportsPath", Config.ReportsPath)
        Call SetINIValue(GetAppPath() & "LearnAid.ini", "System.Settings", "ComputerID", Config.COMP_ID)
        Call SetINIValue(GetAppPath() & "LearnAid.ini", "System.Settings", "EnableLog", CStr(CBool2Int(Config.EnableLog)))
        '////////////////////////////////////////////////////////////////////////////
        '    Save the GUI or Interface settings
        '////////////////////////////////////////////////////////////////////////////
        Call SetINIValue(GetAppPath() & "LearnAid.ini", "GUI.Settings", "SchoolsWindowVisible", CStr(CBool2Int(Config.SchoolWindowVisible)))
        Call SetINIValue(GetAppPath() & "LearnAid.ini", "GUI.Settings", "SchoolsWindowDocked", CStr(CBool2Int(Config.SchoolWindowDocked)))

        Call SetINIValue(GetAppPath() & "LearnAid.ini", "GUI.Settings", "PropertiesWindowVisible", CStr(CBool2Int(Config.PropertiesWindowVisible)))
        Call SetINIValue(GetAppPath() & "LearnAid.ini", "GUI.Settings", "PropertiesWindowDocked", CStr(CBool2Int(Config.PropertiesWindowDocked)))

        Call SetINIValue(GetAppPath() & "LearnAid.ini", "GUI.Settings", "ButtonPanelVisible", CStr(CBool2Int(Config.ButtonPanelVisible)))
        Call SetINIValue(GetAppPath() & "LearnAid.ini", "GUI.Settings", "ShowStartUp", CStr(CBool2Int(Config.ShowStartUp)))
        Call SetINIValue(GetAppPath() & "LearnAid.ini", "GUI.Settings", "OnStartUpShowWindow", Config.OnStartUpShowWindow)
        '////////////////////////////////////////////////////////////////////////////
        '    Save the LogIn settings
        '////////////////////////////////////////////////////////////////////////////
        Call SetINIValue(GetAppPath() & "LearnAid.ini", "LogIn", "LastUserLogged", LoggedUser.UserID)
    End Sub


#End Region

#Region "LEVEL TWO ROUTINES"
    'Called By: Me.RegisterPlugins()
    Function GetFilesinDir(ByRef sDir As String) As String
        Dim MyName As String
        Dim MyPath As String
        Dim vTheFiles As String

        If Right(sDir, 1) = "/" Then sDir = Left(sDir, Len(sDir) - 1)
        MyPath = sDir
        'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        MyName = Dir(MyPath, FileAttribute.Normal)
        Do While MyName <> ""
            If MyName <> "." And MyName <> ".." Then
                vTheFiles = vTheFiles & MyName & "|"
            End If
            'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
            MyName = Dir()
        Loop
        If Trim(vTheFiles) <> "" Then
            vTheFiles = vTheFiles.Substring(0, vTheFiles.Length - 1)
            'vTheFiles = Left(vTheFiles, Len(vTheFiles) - 1)
        End If
        GetFilesinDir = vTheFiles
    End Function

    ''' <remarks>
    '''            Called By: LA_Declarations.Init()
    ''' </remarks>
    Sub GetSystemSettings()
        '////////////////////////////////////////////////////////////////////////////
        '    Get the system settings
        '////////////////////////////////////////////////////////////////////////////
        Config.Environment = LA_Declarations.GetINIValue(LA_Declarations.GetAppPath() & "Learnaid.ini", "System.Settings", "Environment")
        Config.FirstExecution = (LA_Declarations.GetINIValue(LA_Declarations.GetAppPath() & "Learnaid.ini", "System.Settings", "FirstExecution") = "1")
        Config.DataFilesPath = LA_Declarations.GetINIValue(LA_Declarations.GetAppPath() & "Learnaid.ini", "System.Settings", "DataFilesPath")
        Config.PluginsPath = LA_Declarations.GetINIValue(LA_Declarations.GetAppPath() & "Learnaid.ini", "System.Settings", "PluginsPath")
        Config.ConsultantsPath = LA_Declarations.GetINIValue(LA_Declarations.GetAppPath() & "Learnaid.ini", "System.Settings", "ConsultantsPath")

        ' CP 2015.04.08 - modified to use correct path
        If Config.Environment = "DEVELOPMENT" Then
            Config.ReportsPath = LA_Declarations.GetINIValue(LA_Declarations.GetAppPath() & "Learnaid.ini", "System.Settings", "ReportsPath")
        Else
            Config.ReportsPath = System.Environment.CurrentDirectory & LA_Declarations.GetINIValue(LA_Declarations.GetAppPath() & "Learnaid.ini", "System.Settings", "ReportsPath")
        End If

        Config.DbUserID = LA_Declarations.GetINIValue(LA_Declarations.GetAppPath() & "Learnaid.ini", "System.Settings", "DBUserID")
        Config.DataSource = LA_Declarations.GetINIValue(LA_Declarations.GetAppPath() & "Learnaid.ini", "System.Settings", "DataSource")
        Config.DatabaseName = LA_Declarations.GetINIValue(LA_Declarations.GetAppPath() & "Learnaid.ini", "System.Settings", "DatabaseName")
        Config.DbPassword = LA_Declarations.GetINIValue(LA_Declarations.GetAppPath() & "Learnaid.ini", "System.Settings", "DBPassword")

        Config.DbBlankPWD = (LA_Declarations.GetINIValue(LA_Declarations.GetAppPath() & "Learnaid.ini", "System.Settings", "BlankPWD") = "1")
        Config.ConnectionString = LA_Declarations.GetConnectionString(Config.DbUserID, Config.DbPassword, Config.DatabaseName, Config.DataSource, Config.DbBlankPWD)
        'Config.ConnectionStringAdo

        Config.COMP_ID = LA_Declarations.GetINIValue(LA_Declarations.GetAppPath() & "Learnaid.ini", "System.Settings", "ComputerID")
        Config.EnableLog = (LA_Declarations.GetINIValue(LA_Declarations.GetAppPath() & "Learnaid.ini", "System.Settings", "EnableLog") = "1")

        '////////////////////////////////////////////////////////////////////////////
        '    GEt the LogIn settings
        '////////////////////////////////////////////////////////////////////////////
        LoggedUser.UserID = GetINIValue(GetAppPath() & "Learnaid.ini", "Login", "LastUserLogged")

        '////////////////////////////////////////////////////////////////////////////
        '    GEt the GUI settings
        '////////////////////////////////////////////////////////////////////////////
        Config.ShowStartUp = (GetINIValue(GetAppPath() & "Learnaid.ini", "GUI.Settings", "ShowStartUp") = "1")

        Config.SchoolWindowVisible = (GetINIValue(GetAppPath() & "Learnaid.ini", "GUI.Settings", "SchoolsWindowVisible") = "1")
        Config.SchoolWindowDocked = (GetINIValue(GetAppPath() & "Learnaid.ini", "GUI.Settings", "SchoolsWindowDocked") = "1")

        Config.PropertiesWindowVisible = (GetINIValue(GetAppPath() & "Learnaid.ini", "GUI.Settings", "PropertiesWindowVisible") = "1")
        Config.PropertiesWindowDocked = (GetINIValue(GetAppPath() & "Learnaid.ini", "GUI.Settings", "PropertiesWindowDocked") = "1")

        Config.ButtonPanelVisible = (GetINIValue(GetAppPath() & "Learnaid.ini", "GUI.Settings", "ButtonPanelVisible") = "1")
        Config.OnStartUpShowWindow = GetINIValue(GetAppPath() & "Learnaid.ini", "GUI.Settings", "OnStartUpShowWindow")

        ''Open global connection
        Try
            GlobalResources.OpenConnection()
        Catch ex As Exception
            MessageBox.Show(ex.Message + "\n" + ex.InnerException.Message + "\n" + ex.StackTrace)
        End Try
    End Sub
#End Region

#Region "LEVEL THREE ROUTINES"
    'Called By: frmOptoions.SaveData()
    'Called By: frmOptions.TestConnection()

    ''' <param name="userId"></param>
    ''' <param name="password"></param>
    ''' <param name="databaseName"></param>
    ''' <param name="dataSource"></param>
    ''' <param name="blankPassword"></param>
    ''' <returns>
    '''           Returns the connection string
    ''' </returns>
    ''' <remarks>
    '''           Called By: LA_Declarations.GetSystemSettings()
    ''' </remarks>
    Function GetConnectionString(ByRef userId As String, ByRef password As String, ByRef databaseName As String, ByRef dataSource As String, ByRef blankPassword As Boolean) As String
        If blankPassword = True Then
            'Return "Provider=SQLNCLI11;Server=SERVER3\LEARNAID;Database=LA;User ID=sa;DataCompatibility=80;"
            Return "Provider=SQLOLEDB.1;Data Source=SERVER3\LEARNAID;Initial Catalog=LA;Persist Security Info=False;User ID=sa"
            'Return "Server=SERVER3\LEARNAID;Database=LA;User ID=sa"
            '"Data Source=SERVER3\LEARNAID;Initial Catalog=LA;Integrated Security=True"
            ' Return "Provider = SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog = " & databaseName & ";Data Source = " & dataSource
        Else
            Return "Provider=SQLOLEDB.1;User ID= " & userId & ";Initial Catalog=" & databaseName &
                ";Data Source = " & dataSource & ";Use Procedure for Prepare=1;Auto Translate=True;Packet Size=4096;Workstation ID=MITCHELLPC;Initial File Name="";Use Encryption for Data=False;Tag with column collation when possible=False;MARS Connection=False;DataTypeCompatability=0;Trust Server Certificate=False;Application Intent=READWRITE;"
        End If
    End Function

    'Called By: Me.GetSystemSettings() 22 Calls
    ''' <param name="INIFile"></param>
    ''' <param name="Section"></param>
    ''' <param name="Entry"></param>
    ''' <remarks>
    '''           Called By: LA_Declaractions.GetSystemSettings()
    ''' </remarks>
    Function GetINIValue(ByVal INIFile As String, ByVal Section As String, ByVal Entry As String) As String
        Dim X As Short

        Static Result As New FixedLengthString(1024)
        Result.Value = Space(1024)
        X = GetPrivateProfileString(Section, Entry, "", Result.Value, 1024, INIFile)
        GetINIValue = RTrim(INIField(Result.Value, Chr(0), 1))
    End Function

    'Called By: Me.SaveSystemSettings() 20 Calls
    Sub SetINIValue(ByVal INIFile As String, ByVal Section As String, ByVal Entry As String, ByVal Value As String)
        Dim z As Short
        z = WritePrivateProfileString(Section, Entry, Value, INIFile)
    End Sub
#End Region

#Region "LEVEL FOUR ROUTINES"


#End Region

#End Region

    Dim counter As Integer = 0


    Function Capitalize(ByVal Name As String) As String
        Dim i As Integer
        Dim tmp As String
        tmp = LCase(Name)
        Mid(tmp, 1, 1) = UCase(Mid(tmp, 1, 1))
        For i = 1 To Len(tmp) - 1
            'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If Mid(tmp, i, 1) = " " Or Mid(tmp, i, 1) = "," Then
                'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                Mid(tmp, i + 1, 1) = UCase(Mid(tmp, i + 1, 1))
            End If
        Next i
        Capitalize = tmp
    End Function


    Function GetSemesterFromReport(ByVal iRep As Integer) As Short

        Dim Cn As New Connection
        Dim Rs As New Recordset
        Dim Ret As Short
        Dim SQL As String
        Dim sDate As Date

        'OpenConnection(Cn, Config.ConnectionString)
        OpenConnection(Cn, Config.ConnectionStringAdo)

        SQL = "select Rep_serv_date from Reports where rep_id = " & iRep
        Rs.Open(SQL, Cn, 3, 3)

        Ret = 0
        If Rs.RecordCount = 1 Then
            If IsDate(Rs.Fields("rep_serv_date").Value) Then
                sDate = Rs.Fields("rep_serv_date").Value
                If Month(sDate) >= 8 And Month(sDate) <= 12 Then
                    Ret = 1
                Else
                    Ret = 2
                End If
            End If
        End If
        Rs.Close()
        Cn.Close()

        GetSemesterFromReport = Ret

    End Function

    Function Replace_Chars(ByRef s As String) As String

        's = Replace(s, "á", "a")
        's = Replace(s, "é", "e")
        's = Replace(s, "í", "i")
        's = Replace(s, "ó", "o")
        's = Replace(s, "ú", "u")
        's = Replace(s, "Á", "A")
        's = Replace(s, "É", "E")
        's = Replace(s, "Í", "I")
        's = Replace(s, "Ó", "O")
        's = Replace(s, "Ú", "U")
        's = Replace(s, "Ñ", "N")
        's = Replace(s, "ñ", "n")
        s = Replace(s, "ü", "u")
        s = Replace(s, "&", "and")

        Replace_Chars = s

    End Function

    Sub ShowCalendar(ByRef TextField As Object, Optional ByVal StartupDate As Object = Nothing)
        'UPGRADE_NOTE: IsMissing() was changed to IsNothing(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8AE1CB93-37AB-439A-A4FF-BE3B6760BB23"'
        If Not IsNothing(StartupDate) Then
            'UPGRADE_ISSUE: Load statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B530EFF2-3132-48F8-B8BC-D88AF543D321"'
            frmGenericCal.Show()
            'UPGRADE_WARNING: Couldn't resolve default property of object StartupDate. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'frmGenericCal.Calendar1.Value = StartupDate
        Else
            'UPGRADE_WARNING: Couldn't resolve default property of object StartupDate. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            StartupDate = Today
        End If
        'UPGRADE_WARNING: Couldn't resolve default property of object StartupDate. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object CalendarValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        CalendarValue = StartupDate
        frmGenericCal.ShowDialog()
        'UPGRADE_WARNING: Couldn't resolve default property of object CalendarValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object TextField. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        TextField = CalendarValue
    End Sub

    Function FormatName(ByRef sName As String) As String
        Dim sEdad As String
        Dim sSex As String
        Dim arrName() As String
        Dim sLName1 As String
        Dim sLName2 As String
        Dim sFName As String

        arrName = Split(sName, "/")
        If UBound(arrName) > 2 Then
            MsgBox("Edad/Sexo mal entrado")
            FormatName = "INVALID"
            Exit Function
        End If
        sName = sName.Insert(sName.IndexOf(" "), ",")
        arrName = Split(sName, ",")
        'sName = Trim(UCase(arrName(0)))

        If UBound(arrName) <> 2 Then
            FormatName = "INVALID"
            Exit Function
        End If

        'valido edad y sexo
        sSex = ""
        sEdad = ""
        'verifico edad y sexo
        If InStr(1, UCase(sName), "/E") > 0 Then
            'pusieron edad
            sEdad = Split(UCase(sName), "/E")(1)
            If InStr(1, sEdad, "/") > 0 Then sEdad = Split(sEdad, "/")(0)
            If Not IsNumeric(sEdad) Then
                MsgBox("Edad incorrecta")
                FormatName = "INVALID"
                Exit Function
            End If
        End If

        If InStr(1, UCase(sName), "/S") > 0 Then
            'pusieron sexo
            sSex = Split(UCase(sName), "/S")(1)
            If InStr(1, sSex, "/") > 0 Then sSex = Split(sSex, "/")(0)
            If Not (UCase(sSex) = "M" Or UCase(sSex) = "F") Then
                MsgBox("Sexo incorrecto solo (M/F)")
                FormatName = "INVALID"
                Exit Function
            End If
        End If



        '1er apellido
        sLName1 = arrName(0).Trim.ToUpper

        '2do apellido
        'sLName2 = Trim(UCase(Left(Trim(arrName(1)), 1))) & Trim(LCase(MID(Trim(arrName(1)), 2)))
        sLName2 = arrName(1).Trim

        'Nombre
        sFName = Trim(arrName(2))
        FormatName = sLName1 & " " & sLName2 & ", " & sFName
    End Function

    'UPGRADE_WARNING: Application will terminate when Sub Main() finishes. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="E08DDC71-66BA-424F-A612-80AF11498FF8"'
    Public Sub Main()
        Call Init()
        frmLogin.ShowDialog()

        If frmLogin.LoginSucceeded And Not Config.FirstExecution Then
            frmLogin.Close()
            frmMain.Show()
        Else
            frmLogin.Close()
        End If
    End Sub


    Function GetBatName(ByRef ClavID As Object) As String
        Dim Cn As Connection
        Dim Rs As Recordset

        Cn = New Connection
        Rs = New Recordset

        OpenConnection(Cn, Config.ConnectionString)

        'UPGRADE_WARNING: Couldn't resolve default property of object ClavID. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Rs.Open("Select cl_plugin from Claves where cl_id = " & ClavID, Cn, 3, 3)

        If Rs.RecordCount = 1 Then
            GetBatName = Rs.Fields("cl_plugin").Value
        Else
            GetBatName = ""
        End If

        Rs.Close()
        Cn.Close()
    End Function

    Function GetClaveName(ByRef ClavID As Object) As String

        Dim Cn As Connection
        Dim Rs As Recordset

        Cn = New Connection
        Rs = New Recordset

        OpenConnection(Cn, Config.ConnectionString)

        'UPGRADE_WARNING: Couldn't resolve default property of object ClavID. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Rs.Open("Select cl_type from Claves where cl_id = " & ClavID, Cn, 3, 3)

        If Rs.RecordCount = 1 Then
            GetClaveName = Rs.Fields("cl_type").Value
        Else
            GetClaveName = ""
        End If

        Rs.Close()
        Cn.Close()
    End Function


    Function GetPercentile(ByVal iGrado As Short, ByVal sSexo As String, ByVal lValue As Double, ByVal iMateria As Short) As Double
        Dim SQL As String
        Dim Rs As New Recordset
        Dim Cn As New Connection
        Dim sField As String = Nothing

        OpenConnection(Cn, Config.ConnectionString)

        Select Case iMateria
            Case 1
                sField = "VERB"
            Case 2
                sField = "NUME"
            Case 3
                sField = "ABST"
            Case 4
                sField = "CLER"
            Case 5
                sField = "MECA"
            Case 6
                sField = "ESPA"
        End Select

        SQL = "Select * from Pep_Normas " & " Where Pepn_Grado =" & iGrado & " AND Pepn_Sexo = '" & sSexo & "' AND Pepn_" & sField & "_from <= " & lValue & " AND Pepn_" & sField & "_to >= " & lValue

        Rs.Open(SQL, Cn, CursorTypeEnum.adOpenStatic, LockTypeEnum.adLockReadOnly)
        If Not Rs.EOF Then
            GetPercentile = GetValue(Rs.Fields("pepn_percentil"), 0)
        Else
            MsgBox("Error in PEP norms. Check Sex in Students", MsgBoxStyle.Critical, "Pep norms")
        End If

        Rs.Close()
        Cn.Close()
        Return Nothing
    End Function

    Function StartDoc(ByRef DocName As String) As Integer
        Dim Scr_hDC As Integer
        Scr_hDC = GetDesktopWindow()
        StartDoc = ShellExecute(Scr_hDC, "Open", DocName, "", "C:\", 3)
    End Function
    '--
    Sub CreateFile(ByRef TargetFile As String, ByRef StringToAppend As Object)
        Dim iFile As Short

        iFile = FreeFile()
        FileOpen(iFile, TargetFile, OpenMode.Output)
        PrintLine(iFile, StringToAppend)
        FileClose(iFile)
    End Sub


    Function C2RecCount(ByVal RepID As Integer, ByRef sType As String) As Integer
        'Esta funcion determina si existe un ingles con destreza en el reporte
        'para entonces poder imprimir el reporte de ingles de las destrezas
        Dim Cn As New Connection
        Dim Rs As New Recordset
        Dim sQuery As String = Nothing

        Select Case sType
            Case "REN"
                sQuery = "Select resg_id from Resultados where resg_rep_id = " & RepID & " and resg_ren >0"
            Case "LES"
                sQuery = "Select resg_id from Resultados where resg_rep_id = " & RepID & " and resg_les >0"
            Case "NV"
                sQuery = "Select resg_id from Resultados where resg_rep_id = " & RepID & " and resg_nv >0"
            Case "MAT"
                sQuery = "Select resg_id from Resultados where resg_rep_id = " & RepID & " and resg_mat >0"
        End Select

        OpenConnection(Cn, Config.ConnectionString)

        Rs.Open(sQuery, Cn, CursorTypeEnum.adOpenStatic, LockTypeEnum.adLockReadOnly)

        C2RecCount = Rs.RecordCount
        Rs.Close()
        Cn.Close()

    End Function

    Function DirExists(ByVal sDir As String) As Boolean
        Dim bRet As Boolean
        Dim sFile As String
        Try
            If Right(sDir, 1) <> "\" And Trim(sDir) <> "" Then sDir = sDir & "\"

            'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
            sFile = Dir(sDir, FileAttribute.Directory)
            If sFile <> "" Then
                bRet = True
            Else
                bRet = False
            End If
            DirExists = bRet
            Exit Function
        Catch ex As Exception
            bRet = False
        End Try
    End Function


    Function FileExists(ByVal FileName As String) As Boolean
        '===========================================
        'Checks if a File Exists
        'Returns True if it exists, returns false if
        'it does not exist or if there was an error
        '===========================================
        Dim FirstFileHndl As Integer
        On Error Resume Next
        FirstFileHndl = FindFirstFile(FileName, Win32FindData)
        If FirstFileHndl <> INVALID_HANDLE_VALUE And FirstFileHndl <> ERROR_NO_MORE_FILES Then
            FileExists = True
        Else
            FileExists = False
        End If
    End Function

    Function GetPrice(ByRef schId As Double) As Double
        'Dim Cn As New Connection
        'Dim Rs As New Recordset
        'Dim sQuery As String
        'Dim Ret As Double

        ''************************<<QUERY>>*************************************************
        'sQuery = "SELECT sc_price from Schools where sc_id = " & SchID
        ''************************<<QUERY>>*************************************************

        'OpenConnection(Cn, Config.ConnectionString)

        'Rs.Open(sQuery, Cn, CursorTypeEnum.adOpenStatic, LockTypeEnum.adLockReadOnly)

        'If Rs.RecordCount = 1 Then            
        '    Ret = GetValue(Rs.Fields("sc_price"), 0)
        'Else
        '    Ret = 0
        'End If

        'Rs.Close()
        'Cn.Close()

        'GetPrice = Ret

        Dim ret As Double = 0
        Dim sql As String = "SELECT sc_price from Schools where sc_id = " & schId
        Dim i As Integer = 0
        Dim val As Object = GlobalResources.ExecuteScalar(sql)
        If Not val Is Nothing Then
            ret = CType(val, Double)
        End If
        Return ret
    End Function


    Sub CopyListView(ByRef lvFrom As ListView, ByRef lvTo As ListView)
        Dim s As Integer
        Dim i As Integer
        Dim Item As ListViewItem
        lvTo.Items.Clear()

        For i = 1 To lvFrom.Items.Count
            'UPGRADE_WARNING: Lower bound of collection lvFrom.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
            Item = lvTo.Items.Add(lvFrom.Items.Item(i).Text)
            'UPGRADE_WARNING: Lower bound of collection lvFrom.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
            For s = 1 To lvFrom.Items.Item(1).SubItems.Count
                'UPGRADE_WARNING: Lower bound of collection lvFrom.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                'UPGRADE_WARNING: Lower bound of collection lvFrom.ListItems().ListSubItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                'UPGRADE_WARNING: Lower bound of collection Item.ListSubItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                Item.SubItems.Item(s).Text = lvFrom.Items.Item(1).SubItems.Item(s).Text
                'UPGRADE_WARNING: Couldn't resolve default property of object s. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Lower bound of collection lvFrom.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                'UPGRADE_WARNING: Lower bound of collection lvFrom.ListItems().ListSubItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                'UPGRADE_WARNING: Lower bound of collection Item.ListSubItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                Item.SubItems.Item(s).Tag = lvFrom.Items.Item(1).SubItems.Item(s).Tag
            Next s
        Next i
    End Sub

    'Called By: frmAccountingView.Toolbar_ButtonClick()
    Sub CreateNomina()
        '=================================================
        '---------------OLD SUB NOT USED------------------
        '=================================================
        Dim Cn As New Connection
        Dim RsData As New Recordset
        Dim RsExaminer As New Recordset

        Dim RsNG As New Recordset
        Dim RsN As New Recordset
        Dim RsND As New Recordset

        Dim Cm As New Command
        Dim sQuery As String
        Dim NG_ID As Integer
        Dim N_ID As Integer
        'Dim ND_ID As Integer
        Dim iExaminer As Integer
        Dim ExaminerID As Integer
        Dim ExaminerName As String
        Dim iData As Integer
        Dim SubTotalGross As Double
        Dim SubTotalNet As Double
        Dim SubTotalRetained As Double
        Dim TotalGross As Double
        Dim TotalNet As Double
        Dim TotalRetained As Double
        Dim Retencion As Double


        OpenConnection(Cn, Config.ConnectionString)


        '//// Busco todos los records de los jobs
        sQuery = "SELECT SCHOOLS.SC_SCH_NAME, SCHOOLS.SC_Cost,Jobs.* FROM Jobs LEFT OUTER JOIN SCHOOLS ON Jobs.J_SCH = SCHOOLS.SC_ID Where Jobs.J_Paid =0"
        RsData.Open(sQuery, Cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockPessimistic)

        If RsData.EOF Then
            RsData.Close()
            Cn.Close()
            Exit Sub
        End If

        '///Creao record General de la nomina
        RsNG.Open("Select * From Nomina_General Where NG_ID=-1", Cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockPessimistic)
        RsNG.AddNew()
        RsNG.Update()
        NG_ID = RsNG.Fields("NG_ID").Value



        '////Busco los records de los examinadores
        sQuery = "Select * From Consultants"
        RsExaminer.Open(sQuery, Cn, CursorTypeEnum.adOpenStatic, LockTypeEnum.adLockReadOnly)

        '////NOMINA
        sQuery = "Select * From Nomina Where N_ID=-1"
        RsN.Open(sQuery, Cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockPessimistic)

        '////NOMINA_DETAILS
        sQuery = "Select * From Nomina_Detail Where ND_ID=-1"
        RsND.Open(sQuery, Cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockPessimistic)




        '///Calculo la nomina para cada examinador

        For iExaminer = 1 To RsExaminer.RecordCount
            SubTotalGross = 0
            SubTotalNet = 0
            SubTotalRetained = 0
            Retencion = GetValue(RsExaminer.Fields("CON_Retention"), 0)
            ExaminerID = RsExaminer.Fields("CON_ID").Value
            ExaminerName = Trim(GetValue(RsExaminer.Fields("CON_NAME")) & " " & GetValue(RsExaminer.Fields("Con_LName1")) & " " & GetValue(RsExaminer.Fields("Con_LName2")))

            RsN.AddNew()
            RsN.Fields("N_Name").Value = ExaminerName
            RsN.Fields("N_NG_ID").Value = NG_ID
            RsN.Update()
            N_ID = RsN.Fields("N_ID").Value

            RsData.MoveFirst()

            For iData = 1 To RsData.RecordCount
                'UPGRADE_WARNING: Couldn't resolve default property of object GetValue(RsData!J_CONS2, 0). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                If RsData.Fields("J_CONS").Value = ExaminerID Or GetValue(RsData.Fields("J_CONS2"), 0) = ExaminerID Then
                    RsND.AddNew()
                    RsND.Fields("ND_N_ID").Value = N_ID
                    RsND.Fields("ND_SCH_NAME").Value = RsData.Fields("sc_sch_name").Value
                    RsND.Fields("ND_J_ID").Value = RsData.Fields("j_id").Value
                    RsND.Fields("ND_Pay").Value = GetValue(RsData.Fields("SC_COST"), 0)
                    RsND.Update()
                    SubTotalGross = SubTotalGross + GetValue(RsData.Fields("SC_COST"), 0)
                End If
                RsData.MoveNext()
            Next iData
            SubTotalRetained = SubTotalGross * Retencion
            SubTotalNet = SubTotalGross - SubTotalRetained

            RsN.Fields("N_Total_Gross").Value = SubTotalGross
            RsN.Fields("N_Total_Net").Value = SubTotalNet
            RsN.Fields("N_Total_Retained").Value = SubTotalRetained
            RsN.Update()
            RsExaminer.MoveNext()
            'Acumulo los valores globales
            TotalGross = TotalGross + SubTotalGross
            TotalRetained = TotalRetained + SubTotalRetained
            TotalNet = TotalNet + SubTotalNet

        Next iExaminer

        RsNG.Fields("NG_Total").Value = TotalNet
        RsNG.Fields("NG_Total_Gross").Value = TotalGross
        RsNG.Fields("NG_Total_Ret").Value = TotalRetained
        'RsNG!NG_Total_Paid=
        RsNG.Update()


        'Marcamos los Jobs como Pagados
        RsData.MoveFirst()
        While Not RsData.EOF
            RsData.Fields("j_paid").Value = 1
            RsData.MoveNext()
        End While

        RsData.Close()
        RsNG.Close()
        RsN.Close()
        RsND.Close()

        Cn.Close()

    End Sub

    'Called By: frmEditSchool_Load()
    Sub FillLangCbox(ByRef Cbox As ComboBox)

        Cbox.Items.Clear()
        Cbox.Items.Add("")
        Cbox.Items.Add("Spanish")
        Cbox.Items.Add("English")

        SetItemData(Cbox, 0, -1)
        SetItemData(Cbox, 1, enumLanguages.Spanih)
        SetItemData(Cbox, 2, enumLanguages.English)


        Cbox.SelectedIndex = 0
    End Sub
    'Called By: frmEditSchool_Load()
    Sub FillPotentialCbox(ByRef Cbox As ComboBox)

        Cbox.Items.Clear()
        Cbox.Items.Add("")
        Cbox.Items.Add("NV-LES")
        Cbox.Items.Add("NV-REN")

        SetItemData(Cbox, 0, -1)
        SetItemData(Cbox, 1, 1) 'NVLES
        SetItemData(Cbox, 2, 2) 'NVREN
        Cbox.SelectedIndex = 0
    End Sub
    ''' <returns></returns>
    ''' <remarks>
    '''          Called By: LA_Declarations.CreateReport()
    ''' </remarks>
    Function GetNextFacID() As Integer
        Dim sQuery As String
        Dim Cn As New Connection
        Dim RsFac As New Recordset
        Dim Ret As Integer

        LA_Declarations.OpenConnection(Cn, Config.ConnectionString)

        sQuery = "Select top 1 f_fac_id from Factura order by f_fac_id desc"
        RsFac.Open(sQuery, Cn, CursorTypeEnum.adOpenStatic, LockTypeEnum.adLockReadOnly)

        If RsFac.RecordCount = 1 Then
            Ret = RsFac.Fields("f_fac_id").Value + 1
        Else
            Ret = 1
        End If
        RsFac.Close()
        Cn.Close()

        GetNextFacID = Ret

    End Function

    Function GetUserType(ByRef UserType As enumSecurityLevel) As String

        Select Case UserType
            Case 0
                GetUserType = "Data Entry"
            Case 1
                GetUserType = "Consultant"
            Case 2
                GetUserType = "Accounting"
            Case 3
                GetUserType = "Administrator"
            Case 4
                GetUserType = "Inactive"
            Case Else
                GetUserType = "Unknown"
        End Select
        Return GetUserType
    End Function
    ''TODO: commented out since frmReport has issues
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="ReportID"></param>
    ''' <remarks>
    '''           Called By: frmPrintReport.cmdContinue_Click()
    ''' </remarks>
    Sub PreviewReport(ByRef ReportID As Integer)
        Dim Cn As New ADODB.Connection
        Dim Rs As New ADODB.Recordset
        Dim RsInd As New ADODB.Recordset
        Dim rsKinder As New ADODB.Recordset

        Dim Destrezas As Boolean
        Dim Indiv As Boolean
        Dim Invoice As Boolean
        Dim isDial As Boolean
        Dim isIndReg As Boolean
        Dim isKinder As Boolean
        Dim isPEP As Boolean
        Dim isPRE1 As Boolean
        Dim isPre1G As Boolean
        Dim MID_Renamed As Boolean
        Dim PrintRegular As Boolean
        Dim SchID As Integer

        ' CP - seems at some point this form was moved... 
        Dim rptDesLes As New Forms.ReportForms.frmReport
        Dim rptDesLes1 As New Forms.ReportForms.frmReport
        Dim rptDesMat As New Forms.ReportForms.frmReport
        Dim rptDesMat1 As New Forms.ReportForms.frmReport
        Dim rptDesRen As New Forms.ReportForms.frmReport
        Dim rptDesRen1 As New Forms.ReportForms.frmReport
        Dim rptDialReg As New Forms.ReportForms.frmReport
        Dim rptFac As New Forms.ReportForms.frmReport
        Dim rptFac2 As New Forms.ReportForms.frmReport
        Dim rptGeneral As New Forms.ReportForms.frmReport
        Dim rptIndiv As New Forms.ReportForms.frmReport
        Dim rptIndiv0 As New Forms.ReportForms.frmReport
        Dim rptIndiv0_OT As New Forms.ReportForms.frmReport
        Dim rptIndivDIAL As New Forms.ReportForms.frmReport
        Dim rptIndivPEP As New Forms.ReportForms.frmReport
        Dim rptIndivPRE1G As New Forms.ReportForms.frmReport
        Dim rptIndivPRE1G_OT As New Forms.ReportForms.frmReport
        Dim rptLista As New Forms.ReportForms.frmReport
        Dim rptOffice As New Forms.ReportForms.frmReport
        Dim rptPepGrupal As New Forms.ReportForms.frmReport
        Dim rptRegular0 As New Forms.ReportForms.frmReport
        Dim rptRegularPRE1G As New Forms.ReportForms.frmReport

        LA_Declarations.OpenConnection(Cn, Config.ConnectionString)
        'OpenConnection(Cn, Config.ConnectionStringAdo)

        Rs.Open("Select * From Reports Where Rep_ID = " & ReportID.ToString.Trim, Cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)

        If Not Rs.EOF Then
            SchID = Rs.Fields("rep_sch_id").Value
            'If Rs!rep_sem = 1 Then
            '    rsKinder.Open "select * from Resultados where resg_rep_id = " & ReportID & " and resg_grado <= 1", Cn, adOpenStatic, adLockReadOnly
            'Else
            '    rsKinder.Open "select * from Resultados where resg_rep_id = " & ReportID & " and resg_grado = 0", Cn, adOpenStatic, adLockReadOnly
            'End If
            rsKinder.Open("select * from Resultados where resg_rep_id = " & ReportID.ToString.Trim & " and resg_AID = 51", Cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
            isKinder = rsKinder.RecordCount > 0
            rsKinder.Close()

            'verifico si hay que imprimir el PRE1-G
            rsKinder.Open("select * from Resultados where resg_rep_id = " & ReportID.ToString.Trim & " and (resg_AID =69 or resg_LES=69 or resg_NV=69)", Cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
            isPre1G = rsKinder.RecordCount > 0
            rsKinder.Close()

            If bTITULO1 Then
                rsKinder.Open("select * from Resultados where resg_rep_id = " & ReportID.ToString.Trim & " and (resg_LES =87 or resg_MAT=89 or resg_REN=88)", Cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
                isPre1G = rsKinder.RecordCount > 0
                rsKinder.Close()
            End If

            rsKinder.Open("select * from Resultados where resg_rep_id = " & ReportID.ToString.Trim & " and ((resg_AID >=88 AND resg_AID<=90 ) OR (resg_AID=110))", Cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
            isDial = rsKinder.RecordCount > 0
            rsKinder.Close()

            'verifico si hay que imprimir el PRE-1
            'ya no SE USA ESTA AREA
            '    rsKinder.Open "select * from Resultados where resg_rep_id = " & ReportID & " and resg_LES =68", Cn, adOpenStatic, adLockReadOnly
            '    isPRE1 = rsKinder.RecordCount > 0
            '    rsKinder.Close

            'verifico si hay que imprimir REG Y INDIVIDUAL NORMAL
            'rsKinder.Open "select * from Resultados where resg_rep_id = " & ReportID & " AND  resg_LES <> 68 AND ( (resg_LES > 0) OR (resg_MAT > 0) OR (resg_NV > 0) OR (resg_REN > 0))", Cn, adOpenStatic, adLockReadOnly
            rsKinder.Open("select * from Resultados where resg_rep_id = " & ReportID.ToString.Trim & " AND ( (resg_LES > 0) OR (resg_MAT > 0) OR (resg_NV > 0) OR (resg_REN > 0))", Cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
            isIndReg = rsKinder.RecordCount > 0
            rsKinder.Close()

            'If bTITULO1 And isPre1G Then isIndReg = False

            Indiv = LA_Declarations.GetValue(Rs.Fields("rep_indiv"), False)
            Destrezas = LA_Declarations.GetValue(Rs.Fields("rep_destrezas"), False)
            Invoice = LA_Declarations.GetValue(Rs.Fields("rep_factura"), False)
            PrintRegular = LA_Declarations.GetValue(Rs.Fields("rep_regular"), False)
            MID_Renamed = LA_Declarations.GetValue(Rs.Fields("rep_mid"), False)
            isPEP = LA_Declarations.GetValue(Rs.Fields("rep_pepv"), False)

            ''/////PRINT REPORT

            '//PEP INDIVIDUAL
            If Indiv And (Rs.Fields("rep_type").Value = enumReportTypes.Regular) And isPEP Then
                rptIndivPEP.ReportID = ReportID
                rptIndivPEP.ReportFile = Config.ReportsPath & "PEP_Individual.rpt"
                rptIndivPEP.Show()
            End If

            '//PEP REGULAR (grupal)
            If (Rs.Fields("rep_type").Value = enumReportTypes.Regular) And (PrintRegular) And isPEP Then
                rptPepGrupal.ReportID = ReportID
                rptPepGrupal.ReportFile = Config.ReportsPath & "Pep_Grupal.rpt"
                rptPepGrupal.Show()
            End If

            '//INDIVIDUAL
            If Indiv And Not (Rs.Fields("rep_type").Value = enumReportTypes.OfficeTesting) And Not isPEP Then
                If isKinder Then
                    rptIndiv0.ReportID = ReportID
                    If bTITULO1 Then
                        rptIndiv0.ReportFile = Config.ReportsPath & "TITULO1_rptIndividual0.rpt"
                    Else
                        rptIndiv0.ReportFile = Config.ReportsPath & "rptIndividual0.rpt"
                    End If
                    rptIndiv0.Show()
                End If

                If isPre1G Then
                    rptIndivPRE1G.ReportID = ReportID
                    If bTITULO1 Then
                        rptIndivPRE1G.ReportFile = Config.ReportsPath & "TITULO1_IndividualPRE1G.rpt"
                    Else
                        rptIndivPRE1G.ReportFile = Config.ReportsPath & "rptIndividualPRE1G.rpt"
                    End If
                    rptIndivPRE1G.Show()
                End If

                If isIndReg Then
                    rptIndiv.ReportID = ReportID
                    'rptIndiv.ReportFile = Config.ReportsPath & "Individual.rpt"
                    If bTITULO1 Then
                        rptIndiv.ReportFile = Config.ReportsPath & "titulo1_Individual.rpt"
                    Else
                        rptIndiv.ReportFile = Config.ReportsPath & "Individual.rpt"
                    End If
                    rptIndiv.Show()
                End If

                If isDial Then
                    rptIndivDIAL.ReportID = ReportID
                    If bTITULO1 Then
                        rptIndivDIAL.ReportFile = Config.ReportsPath & "titulo1_Individual.rpt"
                    Else
                        rptIndivDIAL.ReportFile = Config.ReportsPath & "rptIndividual_DIAL4.rpt"
                    End If
                    rptIndivDIAL.Show()
                End If
            End If

            '//DESTREZAS
            If Destrezas Then
                If C2RecCount(ReportID, "LES") > 0 And frmPrintReport.chkLES.CheckState = 1 Then
                    rptDesLes.ReportID = ReportID
                    If bTITULO1 Then
                        rptDesLes.ReportFile = Config.ReportsPath & "TITULO1_DestrezasLES.rpt"
                    Else
                        rptDesLes.ReportFile = Config.ReportsPath & "DestrezasLES.rpt"
                    End If
                    rptDesLes.Show()
                End If

                If bTITULO1 And isPre1G And frmPrintReport.chkLES.CheckState = 1 Then
                    rptDesLes1.ReportID = ReportID
                    rptDesLes1.ReportFile = Config.ReportsPath & "TITULO1_DestrezasLESPRE1.rpt"
                    rptDesLes1.Show()
                End If

                If C2RecCount(ReportID, "REN") > 0 And frmPrintReport.chkREN.CheckState = 1 Then
                    rptDesRen.ReportID = ReportID
                    If bTITULO1 Then
                        rptDesRen.ReportFile = Config.ReportsPath & "TITULO1_DestrezasREN.rpt"
                    Else
                        rptDesRen.ReportFile = Config.ReportsPath & "DestrezasREN.rpt"
                    End If
                    rptDesRen.Show()
                End If

                If bTITULO1 And isPre1G And frmPrintReport.chkREN.CheckState = 1 Then
                    rptDesRen1.ReportID = ReportID
                    rptDesRen1.ReportFile = Config.ReportsPath & "TITULO1_DestrezasRENPRE1.rpt"
                    rptDesRen1.Show()
                End If

                If C2RecCount(ReportID, "MAT") > 0 And frmPrintReport.chkMAT.CheckState = 1 Then
                    rptDesMat.ReportID = ReportID
                    If bTITULO1 Then
                        rptDesMat.ReportFile = Config.ReportsPath & "TITULO1_DestrezasMAT.rpt"
                    Else
                        rptDesMat.ReportFile = Config.ReportsPath & "DestrezasMAT20.rpt"
                    End If
                    rptDesMat.Show()
                End If

                If bTITULO1 And isPre1G And frmPrintReport.chkMAT.CheckState = 1 Then
                    rptDesMat1.ReportID = ReportID
                    rptDesMat1.ReportFile = Config.ReportsPath & "TITULO1_DestrezasMATPRE1.rpt"
                    rptDesMat1.Show()
                End If
            End If

            '//REGULAR
            If (Rs.Fields("rep_type").Value = enumReportTypes.Regular Or Rs.Fields("rep_type").Value = enumReportTypes.AcomodoRazonable Or Rs.Fields("rep_type").Value = enumReportTypes.Entrance) And (PrintRegular Or MID_Renamed) And Not isPEP Then
                If isKinder And PrintRegular Then
                    rptRegular0.ReportID = ReportID
                    If bTITULO1 Then
                        rptRegular0.ReportFile = Config.ReportsPath & "Titulo1_Regular0.rpt"
                    Else
                        rptRegular0.ReportFile = Config.ReportsPath & "Regular0.rpt"
                    End If
                    rptRegular0.Show()
                End If
                '        ElseIf isPRE1 And PrintRegular Then
                '            Dim rptRegularPRE1 As New frmReport
                '            rptRegularPRE1.ReportID = ReportID
                '            rptRegularPRE1.ReportFile = Config.ReportsPath & "RegularPRE1.rpt"
                '            rptRegularPRE1.Show
                If isPre1G And PrintRegular Then
                    rptRegularPRE1G.ReportID = ReportID
                    rptRegularPRE1G.ReportFile = Config.ReportsPath & "RegularPRE1GNew.rpt"
                    rptRegularPRE1G.Show()
                End If

                If PrintRegular And isIndReg Then
                    rptGeneral.ReportID = ReportID
                    rptGeneral.ReportFile = Config.ReportsPath & "RegularNew.rpt"
                    rptGeneral.Show()
                End If

                If PrintRegular And isDial Then
                    rptDialReg.ReportID = ReportID
                    rptDialReg.ReportFile = Config.ReportsPath & "rptRegular_DIAL4.rpt"
                    rptDialReg.Show()
                End If
            End If

            '//OFFICE TESTING
            If Rs.Fields("rep_type").Value = enumReportTypes.OfficeTesting Then
                If isKinder Then
                    rptIndiv0_OT.ReportID = ReportID
                    rptIndiv0_OT.ReportFile = Config.ReportsPath & "rptIndividual0_OT.rpt"
                    rptIndiv0_OT.Show()
                End If
                If isPre1G Then
                    rptIndivPRE1G_OT.ReportID = ReportID
                    rptIndivPRE1G_OT.ReportFile = Config.ReportsPath & "rptIndividual0_PRE1G_OT.rpt"
                    rptIndivPRE1G_OT.Show()
                End If
                rptOffice.ReportID = ReportID
                rptOffice.ReportFile = Config.ReportsPath & "Individual_OT.rpt"
                rptOffice.Show()
            End If

            '//FACTURA
            If Not (Rs.Fields("rep_type").Value = enumReportTypes.OfficeTesting) And Invoice Then
                'load factura form to update acomodo razonable prices
                frmFactura.lFactID = ReportID
                frmFactura.ShowDialog()
                rptFac.ReportID = ReportID
                If bTITULO1 Then
                    rptFac.ReportFile = Config.ReportsPath & "TITULO1_Factura.rpt"
                Else
                    rptFac.ReportFile = Config.ReportsPath & "Factura.rpt"
                End If
                rptFac.Show()
            End If

            '   //TECNICO
            If frmPrintReport.chkTecnico.CheckState = 1 Then
                rptFac2.ReportID = ReportID
                If bTITULO1 Then
                    rptFac2.ReportFile = Config.ReportsPath & "titulo1_tecnico.rpt"
                Else
                    rptFac2.ReportFile = Config.ReportsPath & "tecnico.rpt"
                End If
                rptFac2.Show()
            End If

            '   //LISTA EST
            If frmPrintReport.chkLista.CheckState = 1 Then
                If bTITULO1 Then
                    rptLista.ReportID = SchID
                    rptLista.ReportFile = Config.ReportsPath & "TITULO1_ListaEstudiantes.rpt"
                    rptLista.Show()
                End If
            End If
        Else
            MsgBox("Report was not found.", MsgBoxStyle.Critical)
        End If
        Rs.Close()
        Cn.Close()
    End Sub

    ''' <param name="ReportID"></param>
    ''' <remarks>
    '''           Called By: frmPrintReport.cmdContinue_Click()
    ''' </remarks>
    Sub PrintReport(ByRef ReportID As Integer)
        On Error GoTo Print_Report_Err
        Dim Cn As New Connection
        Dim Rs As New Recordset
        Dim RsInd As New Recordset
        Dim rsKinder As New Recordset
        Dim rsResg As New Recordset

        Dim CrxApp As New Application  'ERRORS HERE
        Dim CrxRpt As Report

        Dim Destrezas As Boolean
        Dim iCopy As Integer
        Dim iCtrGrade As Short
        Dim Indiv As Boolean
        Dim Invoice As Boolean
        Dim isDial As Boolean
        Dim isIndReg As Boolean
        Dim isKinder As Boolean
        Dim isPEP As Boolean
        Dim isPRE1 As Boolean
        Dim isPre1G As Boolean
        Dim isPrinting As Boolean
        Dim MID_Renamed As Boolean
        Dim PrintRegular As Boolean
        Dim PrintREN As Boolean
        Dim rev As Boolean
        Dim ReportFile As Object

        LA_Declarations.OpenConnection(Cn, Config.ConnectionString)
        Rs.Open("Select * From Reports Where Rep_ID = " & ReportID.ToString.Trim, Cn, CursorTypeEnum.adOpenStatic, LockTypeEnum.adLockReadOnly)

        If Not Rs.EOF Then
            'If Rs!rep_sem = 1 Then
            '    rsKinder.Open "select * from Resultados where resg_rep_id = " & ReportID & " and resg_grado <= 1", Cn, adOpenStatic, adLockReadOnly
            'Else
            '    rsKinder.Open "select * from Resultados where resg_rep_id = " & ReportID & " and resg_grado = 0", Cn, adOpenStatic, adLockReadOnly
            'End If
            rsKinder.Open("select * from Resultados where resg_rep_id = " & ReportID.ToString.Trim & " and resg_AID = 51", Cn, CursorTypeEnum.adOpenStatic, LockTypeEnum.adLockReadOnly)
            isKinder = rsKinder.RecordCount > 0
            rsKinder.Close()

            'verifico si hay que imprimir el PRE-1
            '    rsKinder.Open "select * from Resultados where resg_rep_id = " & ReportID & " and resg_LES =68", Cn, adOpenStatic, adLockReadOnly
            '    isPRE1 = rsKinder.RecordCount > 0
            '    rsKinder.Close

            'verifico si hay que imprimir el PRE1-G
            rsKinder.Open("select * from Resultados where resg_rep_id = " & ReportID.ToString.Trim & " and resg_AID = 69", Cn, CursorTypeEnum.adOpenStatic, LockTypeEnum.adLockReadOnly)
            isPre1G = rsKinder.RecordCount > 0
            rsKinder.Close()

            If bTITULO1 Then
                rsKinder.Open("select * from Resultados where resg_rep_id = " & ReportID.ToString.Trim & " and (resg_LES =87 or resg_MAT=89 or resg_REN=88)", Cn, CursorTypeEnum.adOpenStatic, LockTypeEnum.adLockReadOnly)
                'UPGRADE_WARNING: Couldn't resolve default property of object isPre1G. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                isPre1G = rsKinder.RecordCount > 0
                rsKinder.Close()
            End If

            'verifico si hay que imprimir REG Y INDIVIDUAL NORMAL
            rsKinder.Open("select * from Resultados where resg_rep_id = " & ReportID.ToString.Trim & " AND  ((resg_LES > 0) OR (resg_MAT > 0) OR (resg_NV > 0) OR (resg_REN > 0))", Cn, CursorTypeEnum.adOpenStatic, LockTypeEnum.adLockReadOnly)
            isIndReg = rsKinder.RecordCount > 0
            rsKinder.Close()

            rsKinder.Open("select * from Resultados where resg_rep_id = " & ReportID.ToString.Trim & " and ((resg_AID >=88 AND resg_AID<=90 ) OR (resg_AID=110))", Cn, CursorTypeEnum.adOpenStatic, LockTypeEnum.adLockReadOnly)
            isDial = rsKinder.RecordCount > 0
            rsKinder.Close()

            'If bTITULO1 And isPre1G Then isIndReg = False

            Indiv = GetValue(Rs.Fields("rep_indiv"), False)
            Destrezas = GetValue(Rs.Fields("rep_destrezas"), False)
            Invoice = GetValue(Rs.Fields("rep_factura"), False)
            PrintRegular = GetValue(Rs.Fields("rep_regular"), False)
            MID_Renamed = GetValue(Rs.Fields("rep_mid"), False)
            isPEP = GetValue(Rs.Fields("rep_pepv"), False)
            frmMain.CDPrint.ShowDialog()
            PrintREN = (C2RecCount(ReportID, "REN") > 0)

            For iCopy = 1 To 1
                ''/////PRINT REPORT
                If iCopy = 2 Then
                    ReportFile = Config.ReportsPath & "Separator.rpt"
                    CrxRpt = CrxApp.OpenReport(ReportFile)
                    CrxRpt.PrintOut(False, 1, False)
                    CrxRpt = Nothing
                End If

                '//PEP INDIVIDUAL
                If Indiv And (Rs.Fields("rep_type").Value = enumReportTypes.Regular) And isPEP Then
                    ReportFile = Config.ReportsPath & "Pep_Individual.rpt"
                    CrxRpt = CrxApp.OpenReport(ReportFile)
                    CrxRpt.ParameterFields(1).AddCurrentValue((ReportID))
                    CrxRpt.PrintOut(False, 1, False)
                    CrxRpt = Nothing
                End If

                '//PEP REGULAR
                If (Rs.Fields("rep_type").Value = enumReportTypes.Regular) And (PrintRegular) And isPEP Then
                    ReportFile = Config.ReportsPath & "PEP_Grupal.rpt"
                    CrxRpt = CrxApp.OpenReport(ReportFile)
                    CrxRpt.ParameterFields(1).AddCurrentValue((ReportID))
                    CrxRpt.PrintOut(False, 1, False)
                    CrxRpt = Nothing
                End If

                '//REGULAR
                If (Rs.Fields("rep_type").Value = enumReportTypes.Regular Or Rs.Fields("rep_type").Value = enumReportTypes.AcomodoRazonable Or Rs.Fields("rep_type").Value = enumReportTypes.Entrance) And (PrintRegular Or MID_Renamed) And Not isPEP Then
                    If isKinder And PrintRegular Then
                        If bTITULO1 Then
                            ReportFile = Config.ReportsPath & "Titulo1_Regular0.rpt"
                        Else
                            ReportFile = Config.ReportsPath & "Regular0.rpt"
                        End If
                        CrxRpt = CrxApp.OpenReport(ReportFile)
                        CrxRpt.ParameterFields(1).AddCurrentValue((ReportID))
                        CrxRpt.PrintOut(False, 1, False)
                        CrxRpt = Nothing

                    End If
                    '            ElseIf isPRE1 And PrintRegular Then
                    '                ReportFile = Config.ReportsPath & "RegularPRE1.rpt"
                    '                Set CrxRpt = CrxApp.OpenReport(ReportFile)
                    '                CrxRpt.ParameterFields(1).AddCurrentValue (ReportID)
                    '                CrxRpt.PrintOut False, 1, False
                    '                Set CrxRpt = Nothing
                    If isPre1G And PrintRegular Then
                        If bTITULO1 Then
                            ReportFile = Config.ReportsPath & "TITULO1_RegularPRE1G.rpt"
                        Else
                            ReportFile = Config.ReportsPath & "RegularPRE1GNew.rpt"
                        End If
                        CrxRpt = CrxApp.OpenReport(ReportFile)
                        CrxRpt.ParameterFields(1).AddCurrentValue((ReportID))
                        CrxRpt.PrintOut(False, 1, False)
                        CrxRpt = Nothing
                    End If
                    If PrintRegular And isIndReg = True Then
                        ReportFile = Config.ReportsPath & "Regular.rpt"
                        CrxRpt = CrxApp.OpenReport(ReportFile)
                        CrxRpt.ParameterFields(1).AddCurrentValue((ReportID))
                        CrxRpt.PrintOut(False, 1, False)
                        CrxRpt = Nothing
                    End If
                End If

                '//DESTREZAS
                If Destrezas Then
                    If C2RecCount(ReportID, "LES") > 0 And frmPrintReport.chkLES.CheckState = 1 Then
                        If bTITULO1 Then
                            ReportFile = Config.ReportsPath & "TITULO1_DestrezasLES.rpt"
                        Else
                            ReportFile = Config.ReportsPath & "DestrezasLES.rpt"
                        End If
                        CrxRpt = CrxApp.OpenReport(ReportFile)
                        CrxRpt.ParameterFields(1).AddCurrentValue((ReportID))
                        CrxRpt.PrintOut(False, 1, False)
                        CrxRpt = Nothing
                    End If
                    If bTITULO1 And isPre1G And frmPrintReport.chkLES.CheckState = 1 Then
                        ReportFile = Config.ReportsPath & "TITULO1_DestrezasLESPRE1.rpt"
                        CrxRpt = CrxApp.OpenReport(ReportFile)
                        CrxRpt.ParameterFields(1).AddCurrentValue((ReportID))
                        CrxRpt.PrintOut(False, 1, False)
                        CrxRpt = Nothing
                    End If
                    If PrintREN And frmPrintReport.chkREN.CheckState = 1 Then
                        If bTITULO1 Then
                            ReportFile = Config.ReportsPath & "TITULO1_DestrezasREN.rpt"
                        Else
                            ReportFile = Config.ReportsPath & "DestrezasREN.rpt"
                        End If
                        CrxRpt = CrxApp.OpenReport(ReportFile)
                        CrxRpt.ParameterFields(1).AddCurrentValue((ReportID))
                        CrxRpt.PrintOut(False, 1, False)
                        CrxRpt = Nothing
                    End If
                    If bTITULO1 And isPre1G And frmPrintReport.chkREN.CheckState = 1 Then
                        ReportFile = Config.ReportsPath & "TITULO1_DestrezasRENPRE1.rpt"
                        CrxRpt = CrxApp.OpenReport(ReportFile)
                        CrxRpt.ParameterFields(1).AddCurrentValue((ReportID))
                        CrxRpt.PrintOut(False, 1, False)
                        CrxRpt = Nothing
                    End If
                    If C2RecCount(ReportID, "MAT") > 0 And frmPrintReport.chkMAT.CheckState = 1 Then
                        If bTITULO1 Then
                            ReportFile = Config.ReportsPath & "TITULO1_DestrezasMAT.rpt"
                        Else
                            ReportFile = Config.ReportsPath & "DestrezasMAT.rpt"
                        End If
                        CrxRpt = CrxApp.OpenReport(ReportFile)
                        CrxRpt.ParameterFields(1).AddCurrentValue((ReportID))
                        CrxRpt.PrintOut(False, 1, False)
                        CrxRpt = Nothing
                    End If
                    If bTITULO1 And isPre1G And frmPrintReport.chkMAT.CheckState = 1 Then
                        ReportFile = Config.ReportsPath & "TITULO1_DestrezasMATPRE1.rpt"
                        CrxRpt = CrxApp.OpenReport(ReportFile)
                        CrxRpt.ParameterFields(1).AddCurrentValue((ReportID))
                        CrxRpt.PrintOut(False, 1, False)
                        CrxRpt = Nothing
                    End If
                End If

                '//INDIVIDUAL
                If Indiv And Not (Rs.Fields("rep_type").Value = enumReportTypes.OfficeTesting) And Not isPEP Then
                    If isKinder Then
                        If bTITULO1 Then
                            ReportFile = Config.ReportsPath & "TITULO1_rptIndividual0.rpt"
                        Else
                            ReportFile = Config.ReportsPath & "rptIndividual0.rpt"
                        End If
                        CrxRpt = CrxApp.OpenReport(ReportFile)
                        CrxRpt.ParameterFields(1).AddCurrentValue((ReportID))
                        CrxRpt.PrintOut(False, 1, False)
                        CrxRpt = Nothing
                    End If
                    '            ElseIf isPRE1 Then
                    '                ReportFile = Config.ReportsPath & "rptIndividualPRE1.rpt"
                    '                Set CrxRpt = CrxApp.OpenReport(ReportFile)
                    '                CrxRpt.ParameterFields(1).AddCurrentValue (ReportID)
                    '                CrxRpt.PrintOut False, 1, False
                    '                Set CrxRpt = Nothing
                    If isPre1G Then
                        ReportFile = Config.ReportsPath & "rptIndividualPRE1G.rpt"
                        CrxRpt = CrxApp.OpenReport(ReportFile)
                        CrxRpt.ParameterFields(1).AddCurrentValue((ReportID))
                        CrxRpt.PrintOut(False, 1, False)
                        CrxRpt = Nothing
                    End If
                    If isIndReg = True Then
                        If bTITULO1 Then
                            ReportFile = Config.ReportsPath & "TITULO1_Individual.rpt"
                        Else
                            ReportFile = Config.ReportsPath & "Individual.rpt"
                        End If
                        CrxRpt = CrxApp.OpenReport(ReportFile)
                        CrxRpt.ParameterFields(1).AddCurrentValue((ReportID))
                        CrxRpt.PrintOut(False, 1, False)
                        CrxRpt = Nothing
                    End If

                    If isDial = True Then
                        If bTITULO1 Then
                            ReportFile = Config.ReportsPath & "TITULO1_Individual.rpt"
                        Else
                            ReportFile = Config.ReportsPath & "rptIndividual_DIAL.rpt"
                        End If
                        CrxRpt = CrxApp.OpenReport(ReportFile)
                        CrxRpt.ParameterFields(1).AddCurrentValue((ReportID))
                        CrxRpt.PrintOut(False, 1, False)
                        CrxRpt = Nothing
                    End If


                    '            If rev Then spage = 2901 Else spage = 1
                    '            If rev Then epage = 3000 Else epage = 100
                    '            isPrinting = True
                    '            While ((rev And spage >= 1) Or (Not rev And epage < 3000)) And isPrinting
                    '                CrxRpt.PrintOut False, 1, False, spage, epage
                    '                If rev Then spage = spage - 100 Else spage = epage + 1
                    '                If rev Then epage = epage - 100 Else epage = epage + 100
                    '            Wend
                    '            Set CrxRpt = Nothing

                    'Hacer Loop por cada grado hasta 12 y verifico que
                    'exista data para ese grado y lo mando a imprimir
                    '            ReportFile = Config.ReportsPath & "Individual_1.rpt"
                    '            For iCtrGrade = 12 To 1 Step -1
                    '                'Verifico en Resultados si hay data para este grado
                    '                sql = "SELECT resg_grado FROM Resultados WHERE resg_rep_id = " & ReportID & " AND resg_grado = " & iCtrGrade
                    '                rsResg.Open sql, Cn, 3, 3
                    '
                    '                If rsResg.RecordCount > 0 Then
                    '                    rsResg.Close
                    '                    Set CrxRpt = CrxApp.OpenReport(ReportFile)
                    '                    CrxRpt.ParameterFields(1).AddCurrentValue (ReportID)
                    '                    CrxRpt.ParameterFields(2).AddCurrentValue (iCtrGrade)
                    '                    spage = 1
                    '                    epage = 20
                    '                    For xx = 1 To 30
                    '                            CrxRpt.PrintOut False, 1, False, spage, endpage
                    '                            spage = epage + 1
                    '                            epage = epage + 20
                    '                    Next xx
                    '                    Set CrxRpt = Nothing
                    '                Else
                    '                    rsResg.Close
                    '                End If
                    '            Next iCtrGrade
                End If

                '//OFFICE TESTING
                If Rs.Fields("rep_type").Value = enumReportTypes.OfficeTesting Then
                    If isKinder Then
                        ReportFile = Config.ReportsPath & "rptIndividual0_ot.rpt"
                        CrxRpt = CrxApp.OpenReport(ReportFile)
                        CrxRpt.ParameterFields(1).AddCurrentValue((ReportID))
                        CrxRpt.PrintOut(False, 1, False)
                        CrxRpt = Nothing
                    End If
                    ReportFile = Config.ReportsPath & "Individual_OT.rpt"
                    CrxRpt = CrxApp.OpenReport(ReportFile)
                    CrxRpt.ParameterFields(1).AddCurrentValue((ReportID))
                    CrxRpt.PrintOut(False, 1, False)
                    CrxRpt = Nothing
                End If
            Next iCopy

            '//FACTURA
            If Not (Rs.Fields("rep_type").Value = enumReportTypes.OfficeTesting) And Invoice Then
                If bTITULO1 Then
                    ReportFile = Config.ReportsPath & "titulo1_Factura.rpt"
                Else
                    ReportFile = Config.ReportsPath & "Factura.rpt"
                End If
                CrxRpt = CrxApp.OpenReport(ReportFile)
                CrxRpt.ParameterFields(1).AddCurrentValue((ReportID))
                CrxRpt.PrintOut(False, 1, False)
                CrxRpt = Nothing
            End If
        Else
            MsgBox("Report was not found.", MsgBoxStyle.Critical)
        End If

Print_Report_Exit:
        Rs.Close()
        Cn.Close()
        Exit Sub

Print_Report_Err:
        If Err.Number = 32755 Then
            'Le dio Cancel al ShowPrinter
            Resume Print_Report_Exit
        ElseIf Err.Number = -2147189421 Or Err.Number = -2147191159 Then
            'Error imprimiendo un range de pagina
            isPrinting = False
            Resume Next
        Else
            MsgBox(Err.Number & "-" & Err.Description)
            Resume Print_Report_Exit
        End If
    End Sub

    'Called By: frmAdjustment.Activated()
    'Called By: frmPreJob.LoadData()
    Sub SelectItemWithID(ByRef Cbox As ComboBox, ByRef ID As Integer)
        For i As Integer = 0 To Cbox.Items.Count - 1
            If GetItemData(Cbox, i) = ID Then
                Cbox.SelectedIndex = i
                Exit For
            End If
        Next i
    End Sub
    ''' <summary>
    ''' Checks whether the item is in list or not
    ''' </summary>
    ''' <param name="Cbox"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function ItemIsInList(ByRef Cbox As ComboBox) As Boolean
        Dim Item As String = Cbox.Text
        ItemIsInList = False
        For i As Integer = 0 To Cbox.Items.Count - 1
            If UCase(Item) = UCase(GetItemString(Cbox, i)) Then
                ItemIsInList = True
                Exit For
            End If
        Next i
    End Function



    Function ConvApr(ByVal Score As Single, ByVal Mean As Single) As Single
        ConvApr = 110
    End Function

    Function ConvPot(ByVal Score As Single, ByVal Mean As Single) As Single
        ConvPot = 110
    End Function

    'UPGRADE_NOTE: MID was upgraded to MID_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
    ''' <param name="RepType"></param>
    ''' <param name="Sch_ID"></param>
    ''' <param name="RepYear"></param>
    ''' <param name="Sem"></param>
    ''' <param name="Indiv"></param>
    ''' <param name="MID_Renamed"></param>
    ''' <param name="Destrezas"></param>
    ''' <param name="Comp"></param>
    ''' <param name="Invoice"></param>
    ''' <param name="Regular"></param>
    ''' <param name="FromGrade"></param>
    ''' <param name="ToGrade"></param>
    ''' <param name="AcomodoRazonable"></param>
    ''' <param name="Reposition"></param>
    ''' <remarks>
    '''           'Called By: frmCreateReport.CreateRegular()
    ''' </remarks>
    Sub CreateReport(ByVal RepType As Short, ByVal Sch_ID As Integer, ByVal RepYear As Short,
                     ByVal Sem As Short, ByVal Indiv As Boolean, ByVal MID_Renamed As Boolean,
                     ByVal Destrezas As Boolean, ByVal Comp As Boolean, ByVal Invoice As Boolean,
                     ByVal Regular As Boolean, ByVal FromGrade As Short, ByVal ToGrade As Short,
                     ByVal AcomodoRazonable As Short, ByVal Reposition As Short)

        Dim fac_id As Integer
        Dim Cn As New Connection
        Dim Rs As New Recordset
        Dim Rep_ID As Integer
        Dim ServDate As Date
        Dim iGrade As Double
        Dim F_ID As Integer 'Invoice (Factura) ID



        LA_Declarations.OpenConnection(Cn, Config.ConnectionString)
        Rs.CursorLocation = CursorLocationEnum.adUseClient

        Rs.Open("Select * From Reports where rep_id =-1", Cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockOptimistic)

        Rs.AddNew()
        Rs.Fields("rep_type").Value = RepType
        If RepType <> enumReportTypes.OfficeTesting Then
            Rs.Fields("rep_sch_id").Value = Sch_ID
        Else
            Rs.Fields("rep_sch_id").Value = 0
        End If
        Rs.Fields("Rep_Year").Value = RepYear
        Rs.Fields("Rep_Sem").Value = Sem
        Rs.Fields("rep_indiv").Value = Indiv
        Rs.Fields("rep_mid").Value = MID_Renamed
        Rs.Fields("rep_regular").Value = Regular
        Rs.Fields("rep_destrezas").Value = Destrezas
        Rs.Fields("rep_factura").Value = Invoice
        Rs.Fields("rep_comp").Value = Comp
        Rs.Fields("rep_FromGrade").Value = FromGrade
        Rs.Fields("rep_ToGrade").Value = ToGrade
        Rs.Fields("Rep_AcomRazonable").Value = AcomodoRazonable
        Rs.Fields("rep_reposicion").Value = Reposition
        Rs.Update()
        Rep_ID = Rs.Fields("Rep_ID").Value
        Rs.Close()

        ' get max id 
        ' Rs = Cn.execute("select MAX(Rep_ID) from Reports") 
        'Rep_ID = Rs[0]
        'Creo el Record de Factura
        F_ID = 0
        If RepType <> enumReportTypes.OfficeTesting Then
            Rs.Open("Select * From Factura where f_id =-1", Cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockOptimistic)

            fac_id = LA_Declarations.GetNextFacID()
            Rs.AddNew()
            Rs.Fields("f_date").Value = Now
            Rs.Fields("f_sch").Value = Sch_ID
            Rs.Fields("f_repid").Value = Rep_ID
            Rs.Fields("f_fac_id").Value = fac_id
            Rs.Update()

            F_ID = Rs.Fields("F_ID").Value
        End If
        '--
        'Fac_Total = 0
        For iGrade = FromGrade To ToGrade
            LA_Declarations.CreateResultados(RepType, Sch_ID, RepYear, Sem, Rep_ID, iGrade, F_ID, Fac_Total, ServDate, AcomodoRazonable)
            'Call SetStanines(iGrade, CDbl(Rep_ID), Cn)
            'Stanines Start
            Stanines.SetStanines(iGrade, Rep_ID, Cn)
            'MessageBox.Show(Fac_Total & vbCrLf & iGrade)
        Next iGrade
        ServDate = CDate(InputBox("Enter the Service Date in the following format: '00/00/0000'", "Service Date", Date.Now.ToShortDateString))
        'Update the ServDate to the report
        Cn.Execute("Update Reports Set Rep_Serv_Date ='" & ServDate & "' Where Rep_ID = " & Rep_ID)

        'Editar el total de la factura

        Dim RsFdC As New Recordset
        RsFdC.Open("SELECT fd_Total FROM Factura_Detail WHERE fd_f_id =" & F_ID, Cn)
        Dim total As Decimal
        While Not RsFdC.EOF
            total += Decimal.Parse(RsFdC("fd_total").Value)
            RsFdC.MoveNext()
        End While
        If RepType <> enumReportTypes.OfficeTesting Then
            'Rs.Fields("f_total").Value = Fac_Total
            Rs.Fields("f_total").Value = total
            Rs.Update()
            Rs.Close()
        End If
        '--
        Cn.Close()

        If frmCreateReport.chk_preview.CheckState Then
            'Call PreviewReport(Rep_ID)
        Else
            'Call PrintReport(Rep_ID) by tika
        End If

    End Sub
    Function ToDate(ByRef sDate As String) As String
        If IsNumeric(sDate) Then sDate = Format(sDate, "00/00/0000")
        sDate = Format(sDate, "mm/dd/yyyy")

        If IsDate(sDate) Then
            ToDate = sDate
        Else
            ToDate = ""
        End If
    End Function
    ''' <param name="RepType"></param>
    ''' <param name="Sch"></param>
    ''' <param name="RepYear"></param>
    ''' <param name="Sem"></param>
    ''' <param name="AcomodoRazonable"></param>
    ''' <param name="pep"></param>
    ''' <returns></returns>
    ''' <remarks>
    '''          Called By: frmCreateReport.CreateRegular()
    ''' </remarks>
    Function JobsNotCompleted(ByVal RepType As Short, ByVal Sch As Integer, ByVal RepYear As Short, ByVal Sem As Short, ByVal AcomodoRazonable As Short, ByVal pep As Short) As Boolean
        Dim Rs As New Recordset
        Dim Cn As New Connection
        Dim sQuery As String

        If RepType <> enumReportTypes.OfficeTesting Then
            sQuery = "Select * From Jobs Where J_Type = " & RepType.ToString.Trim
            sQuery &= " AND J_SCH =" & Sch.ToString.Trim
            sQuery &= " AND Year(J_DATE) = " & RepYear.ToString.Trim
            sQuery &= " AND J_Status <> 4 " 'Status <> 4  = NOT COMPLETED
            sQuery &= " AND J_Sem = " & Sem.ToString.Trim
            sQuery &= " AND J_Printed = 0 "
            sQuery &= " AND J_AcomRAzonable = " & AcomodoRazonable.ToString.Trim
            sQuery &= " AND J_PEPV = " & pep.ToString.Trim
        Else
            sQuery = "Select * From Jobs Where J_Type = " & RepType.ToString.Trim
            sQuery &= " AND Year(J_DATE) = " & RepYear.ToString.Trim
            sQuery &= " AND J_Status <> 4 " 'Status <> 4  = NOT COMPLETED
            sQuery &= " AND J_Sem = " & Sem.ToString.Trim
            sQuery &= " AND J_Printed = 0 "
            sQuery &= " AND J_AcomRazonable = " & AcomodoRazonable.ToString.Trim
            sQuery &= " AND J_PEPV = " & pep.ToString.Trim
        End If

        LA_Declarations.OpenConnection(Cn, Config.ConnectionString)

        Rs.Open(sQuery, Cn, CursorTypeEnum.adOpenStatic, LockTypeEnum.adLockReadOnly)
        If Rs.RecordCount > 0 Then
            JobsNotCompleted = True
        Else
            JobsNotCompleted = False
        End If

        Rs.Close()
        Cn.Close()

    End Function

    Function ReportExist(ByVal RepType As Short, ByVal Sch_ID As Integer, ByVal RepYear As Short, ByVal Sem As Short, ByVal AcomodoRazonable As Short, ByVal pep As Short) As Integer
        Dim Cn As New Connection
        Dim Rs As New Recordset

        OpenConnection(Cn, Config.ConnectionString)

        Rs.Open("Select * From Reports where Rep_Type =" & RepType & " AND " & " Rep_SCH_ID =" & Sch_ID & " AND YEAR(Rep_Date)=" & RepYear & " AND  Rep_Sem =" & Sem & " AND  Rep_AcomRazonable = " & AcomodoRazonable & " AND  Rep_PepV = " & pep, Cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockPessimistic)

        If Not Rs.EOF Then ReportExist = Rs.Fields("Rep_ID").Value

        Rs.Close()
        Cn.Close()
        Return Nothing
    End Function

    'UPGRADE_NOTE: MID was upgraded to MID_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
    Sub CreatePepReport(ByVal RepType As Short, ByVal Sch_ID As Integer, ByVal RepYear As Short, ByVal Sem As Short, ByVal Indiv As Boolean, ByVal MID_Renamed As Boolean, ByVal Destrezas As Boolean, ByVal Comp As Boolean, ByVal Invoice As Boolean, ByVal Regular As Boolean, ByVal FromGrade As Short, ByVal ToGrade As Short, ByVal AcomodoRazonable As Short)
        Dim fac_id As Integer

        Dim Cn As New Connection
        Dim Rs As New Recordset
        Dim Rep_ID As Integer
        Dim ServDate As Date
        Dim iGrade As Double
        Dim F_ID As Integer
        Dim Fac_Total As Double

        LA_Declarations.OpenConnection(Cn, Config.ConnectionString)

        Rs.Open("Select * From Reports where rep_id =-1", Cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockPessimistic)

        Rs.AddNew()
        Rs.Fields("rep_type").Value = RepType
        If RepType <> enumReportTypes.OfficeTesting Then
            Rs.Fields("rep_sch_id").Value = Sch_ID
        End If
        Rs.Fields("Rep_Year").Value = RepYear
        Rs.Fields("Rep_Sem").Value = Sem
        Rs.Fields("rep_indiv").Value = Indiv
        Rs.Fields("rep_mid").Value = MID_Renamed
        Rs.Fields("rep_regular").Value = Regular
        Rs.Fields("rep_destrezas").Value = Destrezas
        Rs.Fields("rep_factura").Value = Invoice
        Rs.Fields("rep_comp").Value = Comp
        Rs.Fields("rep_FromGrade").Value = FromGrade
        Rs.Fields("rep_ToGrade").Value = ToGrade
        Rs.Fields("Rep_AcomRazonable").Value = AcomodoRazonable
        Rs.Fields("rep_pepv").Value = 1
        Rs.Update()
        Rep_ID = Rs.Fields("Rep_ID").Value

        'Creo el Record de Factura
        Rs.Close()
        Rs.Open("Select * From Factura where f_id =-1", Cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockPessimistic)

        fac_id = GetNextFacID()
        Rs.AddNew()
        Rs.Fields("f_date").Value = Now
        Rs.Fields("f_sch").Value = Sch_ID
        Rs.Fields("f_repid").Value = Rep_ID
        Rs.Fields("f_fac_id").Value = fac_id
        Rs.Update()
        F_ID = Rs.Fields("F_ID").Value
        '--
        'Fac_Total = 0
        For iGrade = FromGrade To ToGrade
            LA_Declarations.CreatePepResultados(RepType, Sch_ID, RepYear, Sem, Rep_ID, iGrade, F_ID, Fac_Total, ServDate, AcomodoRazonable)
            'Call SetPercentiles(iGrade, CDbl(Rep_ID), Cn)
            MessageBox.Show(Fac_Total)
        Next iGrade

        'Update the ServDate to the report
        Cn.Execute("Update Reports Set Rep_Serv_Date ='" & ServDate.ToString.Trim & "' Where Rep_ID = " & Rep_ID.ToString.Trim)

        'Editar el total de la factura
        'Edit the total bill
        Rs.Fields("f_total").Value = Fac_Total
        Rs.Update()
        '--

        Rs.Close()
        Cn.Close()

        If frmCreateReport.chk_preview.CheckState Then
            'Call PreviewReport(Rep_ID)
        Else
            'Call PrintReport(Rep_ID) by tika
        End If

    End Sub
    Sub CreatePepResultados(ByVal RepType As Short, ByVal Sch As Integer, ByVal RepYear As Short, ByVal Sem As Short, ByVal Rep_ID As Integer, ByVal iGrade As Short, ByRef F_ID As Integer, ByRef Fac_Total As Double, ByRef Serv_Date As Date, ByVal AcomodoRazonable As Short)
        Dim RsJobs As New Recordset
        Dim RsRes As New Recordset
        Dim RsFD As New Recordset
        Dim Cn As New Connection
        Dim sQuery As String
        Dim Res_ID As Integer

        If RepType <> enumReportTypes.OfficeTesting Then
            sQuery = "Select * From Jobs Where J_Type =" & RepType.ToString.Trim
            sQuery &= " AND J_SCH =" & Sch.ToString.Trim
            sQuery &= " AND Year(J_DATE) =" & RepYear.ToString.Trim
            sQuery &= " AND J_Status = 4 " 'Status 4  = COMPLETED
            sQuery &= " AND J_Sem =" & Sem.ToString.Trim
            sQuery &= " AND J_Grade = " & iGrade.ToString.Trim
            sQuery &= " AND J_USER = '" & LoggedUser.UserID.Trim & "'"
            sQuery &= " AND J_AcomRazonable = " & AcomodoRazonable.ToString.Trim
            sQuery &= " AND IsNull(Jobs.J_PEPV,0) = 52 "
        Else
            sQuery = "Select * From Jobs Where J_Type =" & RepType.ToString.Trim
            sQuery &= " AND Year(J_DATE) =" & RepYear.ToString.Trim
            sQuery &= " AND J_Status = 4 " 'Status 4  = COMPLETED
            sQuery &= " AND J_Sem =" & Sem.ToString.Trim
            sQuery &= " AND J_Grade = " & iGrade.ToString.Trim
            sQuery &= " AND J_USER = '" & LoggedUser.UserID.Trim & "'"
            sQuery &= " AND J_AcomRazonable = " & AcomodoRazonable.ToString.Trim
            sQuery &= " AND IsNull(Jobs.J_PEPV,0) = 52 "
        End If

        OpenConnection(Cn, Config.ConnectionString)

        RsJobs.Open(sQuery, Cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockPessimistic)
        RsRes.Open("Select * From Resultados Where resg_id = -1", Cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockPessimistic)
        RsFD.Open("Select * From Factura_Detail Where fd_id = -1", Cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockPessimistic)

        If Not RsJobs.EOF Then Serv_Date = RsJobs.Fields("J_Serv_Date").Value

        While Not RsJobs.EOF
            RsRes.AddNew()
            RsRes.Fields("reg_sc_id").Value = Sch
            RsRes.Fields("reg_j_ID").Value = RsJobs.Fields("j_id").Value
            RsRes.Fields("reg_serv_date").Value = RsJobs.Fields("J_Serv_Date").Value
            RsRes.Fields("resg_rep_id").Value = Rep_ID
            RsRes.Fields("resg_total_est").Value = RsJobs.Fields("J_TOTAL_EST").Value
            RsRes.Fields("resg_grado").Value = RsJobs.Fields("J_GRADE").Value
            RsRes.Fields("resg_section").Value = RsJobs.Fields("J_SEC").Value
            RsRes.Fields("resg_les").Value = RsJobs.Fields("J_LES").Value
            RsRes.Fields("resg_NV").Value = RsJobs.Fields("J_NV").Value
            RsRes.Fields("resg_REN").Value = RsJobs.Fields("J_REN").Value
            RsRes.Fields("resg_mat").Value = RsJobs.Fields("J_MAT").Value
            RsRes.Fields("resg_AID").Value = RsJobs.Fields("j_AID").Value
            RsRes.Fields("resg_PEPV").Value = RsJobs.Fields("j_pepv").Value
            RsRes.Fields("resg_cons").Value = RsJobs.Fields("J_CONS").Value
            RsRes.Fields("resg_toll1").Value = RsJobs.Fields("j_toll1").Value
            RsRes.Fields("resg_cons2").Value = RsJobs.Fields("J_CONS2").Value
            RsRes.Fields("resg_toll2").Value = RsJobs.Fields("j_toll2").Value
            RsRes.Fields("resg_cons3").Value = RsJobs.Fields("J_CONS3").Value
            RsRes.Fields("resg_Price").Value = RsJobs.Fields("J_price").Value
            RsRes.Update()
            Res_ID = RsRes.Fields("resg_id").Value
            Call CreatePepResEst(RsJobs.Fields("j_id").Value, RsRes.Fields("resg_grado").Value, Res_ID, Cn)

            'Create Factura_Detail record
            RsFD.AddNew()
            RsFD.Fields("fd_f_id").Value = F_ID
            RsFD.Fields("fd_serv_date").Value = RsJobs.Fields("J_Serv_Date").Value
            RsFD.Fields("fd_grado").Value = RsJobs.Fields("J_GRADE").Value
            RsFD.Fields("fd_sec").Value = RsJobs.Fields("J_SEC").Value
            RsFD.Fields("fd_tot_student").Value = RsJobs.Fields("J_TOTAL_EST").Value
            RsFD.Fields("fd_price").Value = RsJobs.Fields("J_price").Value
            RsFD.Fields("fd_total").Value = RsJobs.Fields("J_price").Value * RsJobs.Fields("J_TOTAL_EST").Value
            Fac_Total = Fac_Total + RsJobs.Fields("J_price").Value * RsJobs.Fields("J_TOTAL_EST").Value
            RsFD.Update()
            '--

            RsJobs.Fields("J_Printed").Value = True
            RsJobs.Update()
            RsJobs.MoveNext()

        End While
        'hacer update a report con el service date

        RsJobs.Close()
        RsRes.Close()
        Cn.Close()


    End Sub

    Sub CreatePepResEst(ByRef iJobID As Integer, ByVal iGrade As Short, ByRef Res_ID As Integer, ByRef Cn As Connection)
        Dim p As Object
        Dim Rs As New Recordset
        Dim RsEst As New Recordset
        Dim lValue As Object


        Rs.Open("Select * From Answers Where A_J_ID = " & iJobID, Cn, CursorTypeEnum.adOpenStatic, LockTypeEnum.adLockReadOnly)
        RsEst.Open("Select * from ResEst Where rese_id = -1", Cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockPessimistic)

        While Not Rs.EOF
            RsEst.AddNew()
            RsEst.Fields("resg_id").Value = Res_ID
            RsEst.Fields("rese_nombre").Value = Rs.Fields("A_NOMBRE").Value
            RsEst.Fields("rese_sexo").Value = Rs.Fields("A_sexo").Value
            RsEst.Fields("rese_PEPV1").Value = Rs.Fields("A_PEPV1_TOTAL").Value
            RsEst.Fields("rese_PEPV2").Value = Rs.Fields("A_PEPV2_TOTAL").Value
            RsEst.Fields("rese_PEPV3").Value = Rs.Fields("A_PEPV3_TOTAL").Value
            RsEst.Fields("rese_PEPV4").Value = Rs.Fields("A_PEPV4_TOTAL").Value
            RsEst.Fields("rese_PEPV5").Value = Rs.Fields("A_PEPV5_TOTAL").Value
            RsEst.Fields("rese_PEPV6").Value = Rs.Fields("A_PEPV6_TOTAL").Value

            RsEst.Fields("rese_Grupo1").Value = Rs.Fields("A_PEPV_Grupo1").Value
            RsEst.Fields("rese_Grupo2").Value = Rs.Fields("A_PEPV_Grupo2").Value
            RsEst.Fields("rese_Grupo3").Value = Rs.Fields("A_PEPV_Grupo3").Value
            RsEst.Fields("rese_Interes1").Value = Rs.Fields("A_PEPV_Interes1").Value
            RsEst.Fields("rese_Interes2").Value = Rs.Fields("A_PEPV_Interes2").Value
            RsEst.Fields("rese_Interes3").Value = Rs.Fields("A_PEPV_Interes3").Value


            For i As Integer = 1 To 6
                'UPGRADE_WARNING: Couldn't resolve default property of object lValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                lValue = GetValue(Rs.Fields("A_PEPV" & i & "_TOTAL"))
                'UPGRADE_WARNING: Couldn't resolve default property of object lValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                If lValue <> "" Then
                    'p = GetPercentile(iGrade, GetValue(Rs!A_sexo), Round((CDbl(lValue) * 100) + 0.0000005, 0), I)
                    'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object lValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object p. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    p = GetPercentile(iGrade, GetValue(Rs.Fields("A_sexo")), CDbl(lValue), i)
                    'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object p. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    RsEst.Fields("rese_PEPV" & i & "_pctila").Value = p
                End If
            Next i

            RsEst.Update()
            Rs.MoveNext()
        End While

        RsEst.Close()
        Rs.Close()
    End Sub

    Function DeleteReport(ByRef Rep_ID As Integer) As Boolean
        Dim Cn As New Connection
        Dim Rs As New Recordset
        Dim Cm As New Command
        Dim sQuery As String

        DeleteReport = False

        OpenConnection(Cn, Config.ConnectionString)

        Rs.Open("Select * from Factura where f_status = 'C' and f_RepID = " & Rep_ID.ToString.Trim, Cn)
        If Not Rs.EOF Then
            Rs.Close()
            Cn.Close()
            Exit Function
        End If
        Rs.Close()

        Cm.ActiveConnection = Cn

        Rs.Open("Select * From Resultados where resg_rep_id=" & Rep_ID.ToString.Trim, Cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockPessimistic)
        While Not Rs.EOF
            Cm.CommandText = "Delete From ResEst Where resg_id =" & Rs.Fields("resg_id").Value.ToString.Trim
            Cm.Execute()

            If sQuery = "" Then
                sQuery = " J_ID = " & Rs.Fields("reg_j_ID").Value.ToString.Trim
            Else
                sQuery &= " OR J_ID = " & Rs.Fields("reg_j_ID").Value.ToString.Trim
            End If

            Rs.Delete(AffectEnum.adAffectCurrent)
            Rs.MoveNext()
        End While

        '//Los jobs asociados al reportes son reseteados
        If sQuery <> "" Then
            sQuery = "Update Jobs Set J_Printed = 0 Where " & sQuery
            Cm.CommandText = sQuery
            Cm.Execute()
        Else
            'Puede ser un delete de un reporte experimental de ingles
            'que dentro de jobs hay un campo que tiene el ID del reporte
            sQuery = "Update Jobs Set J_Printed = 0 where j_rep_id = " & Rep_ID.ToString.Trim
            Cm.CommandText = sQuery
            Cm.Execute()
        End If

        Cm.CommandText = "Delete From Reports Where rep_id =" & Rep_ID.ToString.Trim
        Cm.Execute()

        Rs.Close()

        'Borrar Factura asociada a este reporte
        Rs.Open("Select * from Factura where f_RepID = " & Rep_ID.ToString.Trim, Cn)
        While Not Rs.EOF
            Cm.CommandText = "Delete From Factura_Detail Where fd_f_id =" & Rs.Fields("f_id").Value.ToString.Trim
            Cm.Execute()
            Rs.MoveNext()
        End While

        Cm.CommandText = "Delete From Factura Where f_repid =" & Rep_ID.ToString.Trim
        Cm.Execute()
        '--
        DeleteReport = True

        Rs.Close()
        Cn.Close()

    End Function

    Sub CreateResEst(ByRef iJobID As Integer, ByRef Res_ID As Integer, ByRef Cn As Connection)
        Dim iCounter1 As Integer
        Dim Rs As New Recordset
        Dim RsEst As New Recordset


        Rs.Open("Select * From Answers Where A_J_ID = " & iJobID, Cn, CursorTypeEnum.adOpenStatic, LockTypeEnum.adLockReadOnly)
        RsEst.Open("Select * from ResEst Where rese_id = -1", Cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockPessimistic)

        While Not Rs.EOF
            Try
                RsEst.AddNew()
                RsEst.Fields("resg_id").Value = Res_ID
                RsEst.Fields("rese_nombre").Value = Rs.Fields("A_NOMBRE").Value
                For iCounter1 = 1 To 20
                    'If Rs.Fields("A_L" & i.ToString & "_TOTAL").Value <> "" Then RsEst.Fields("rese_L" & i.ToString).Value = Rs.Fields("A_L" & i.ToString & "_TOTAL").Value
                    If Not Rs.Fields("A_L" & iCounter1.ToString & "_TOTAL").Value Is Nothing Then
                        RsEst.Fields("rese_L" & iCounter1.ToString).Value = Rs.Fields("A_L" & iCounter1.ToString & "_TOTAL").Value
                    End If
                    If Not Rs.Fields("A_R" & iCounter1.ToString & "_TOTAL").Value Is Nothing Then
                        RsEst.Fields("rese_R" & iCounter1.ToString).Value = Rs.Fields("A_R" & iCounter1.ToString & "_TOTAL").Value
                    End If
                    If Not Rs.Fields("A_N" & iCounter1.ToString & "_TOTAL").Value Is Nothing Then
                        RsEst.Fields("rese_N" & iCounter1.ToString).Value = Rs.Fields("A_N" & iCounter1.ToString & "_TOTAL").Value
                    End If
                    If Not Rs.Fields("A_M" & iCounter1.ToString & "_TOTAL").Value Is Nothing Then
                        RsEst.Fields("rese_M" & iCounter1.ToString).Value = Rs.Fields("A_M" & iCounter1.ToString & "_TOTAL").Value
                    End If
                    If Not Rs.Fields("A_AIDR" & iCounter1.ToString & "_TOTAL").Value Is Nothing Then
                        RsEst.Fields("rese_A" & iCounter1.ToString).Value = Rs.Fields("A_AIDR" & iCounter1.ToString & "_TOTAL").Value
                    End If
                Next iCounter1
                If Not Rs.Fields("A_LES_TOTAL").Value Is Nothing Then
                    RsEst.Fields("rese_L").Value = Rs.Fields("A_LES_TOTAL").Value
                End If
                If Not Rs.Fields("A_REN_TOTAL").Value Is Nothing Then
                    RsEst.Fields("rese_R").Value = Rs.Fields("A_REN_TOTAL").Value
                End If
                If Not Rs.Fields("A_NV_TOTAL").Value Is Nothing Then
                    RsEst.Fields("rese_N").Value = Rs.Fields("A_NV_TOTAL").Value
                End If
                If Not Rs.Fields("A_MAT_TOTAL").Value Is Nothing Then
                    RsEst.Fields("rese_M").Value = Rs.Fields("A_MAT_TOTAL").Value
                End If
                If Not Rs.Fields("A_AIDR_TOTAL").Value Is Nothing Then
                    RsEst.Fields("rese_A").Value = Rs.Fields("A_AIDR_TOTAL").Value
                End If
                If Not Rs.Fields("A_school").Value Is Nothing Then
                    RsEst.Fields("rese_school").Value = Rs.Fields("A_school").Value
                End If
                If Not Rs.Fields("A_edad").Value Is Nothing Then
                    RsEst.Fields("rese_edad").Value = Rs.Fields("A_edad").Value
                End If
                'RsEst.Fields("rese_N").Value = Rs.Fields("A_NV_TOTAL").Value
                'RsEst.Fields("rese_M").Value = Rs.Fields("A_MAT_TOTAL").Value
                'RsEst.Fields("rese_A").Value = Rs.Fields("A_AIDR_TOTAL").Value
                'RsEst.Fields("rese_school").Value = Rs.Fields("A_school").Value
                'RsEst.Fields("rese_edad").Value = Rs.Fields("A_edad").Value

                RsEst.Update()
                Rs.MoveNext()
            Catch ex As Exception
                MessageBox.Show("test" + ex.Message)
            End Try
        End While

        RsEst.Close()
        Rs.Close()

    End Sub
    ''' <param name="RepType"></param>
    ''' <param name="Sch"></param>
    ''' <param name="RepYear"></param>
    ''' <param name="Sem"></param>
    ''' <param name="Rep_ID"></param>
    ''' <param name="iGrade"></param>
    ''' <param name="F_ID"></param>
    ''' <param name="Fac_Total"></param>
    ''' <param name="Serv_Date"></param>
    ''' <param name="AcomodoRazonable"></param>
    ''' <remarks>
    '''          Called By: LA_Declarations.CreateReport()
    ''' </remarks>
    Sub CreateResultados(ByVal RepType As Short, ByVal Sch As Integer, ByVal RepYear As Short, ByVal Sem As Short, ByVal Rep_ID As Integer, ByVal iGrade As Short, ByVal F_ID As Integer, ByVal Fac_Total As Double, ByVal Serv_Date As Date, ByVal AcomodoRazonable As Short)
        Dim RsJobs As New ADODB.Recordset
        Dim RsRes As New ADODB.Recordset
        Dim RsFD As New ADODB.Recordset
        Dim Cn As New Connection
        Dim sQuery As String
        Dim Res_ID As Integer

        If RepType <> enumReportTypes.OfficeTesting Then

            'This query returns an empty recordset.
            'Upon execution without J_Sem through J_AcomRazonable,
            'This query DOES return records, but the constraints are 
            'mixed in the DB and cause the above mentioned empty set.

            sQuery = "Select * From Jobs Where J_Type = " & RepType.ToString.Trim
            sQuery &= " AND J_SCH = " & Sch.ToString.Trim
            sQuery &= " AND Year(J_DATE) = " & RepYear.ToString.Trim
            sQuery &= " AND J_Status = 4 " 'Status 4  = COMPLETED
            sQuery &= " AND J_Sem = " & Sem.ToString.Trim
            sQuery &= " AND J_Printed = 0 "
            sQuery &= " AND J_Grade = " & iGrade.ToString.Trim
            sQuery &= " AND J_USER = '" & LoggedUser.UserID.Trim & "'"
            sQuery &= " AND J_AcomRazonable = " & AcomodoRazonable.ToString.Trim
            sQuery &= " AND IsNull(Jobs.J_PEPV,0) <> 52 "
        Else
            sQuery = "Select * From Jobs Where J_Type =" & RepType.ToString.Trim
            sQuery &= " AND Year(J_DATE) =" & RepYear.ToString.Trim
            sQuery &= " AND J_Status = 4 " 'Status 4  = COMPLETED
            sQuery &= " AND J_Sem =" & Sem.ToString.Trim
            sQuery &= " AND J_Printed = 0 "
            sQuery &= " AND J_Grade = " & iGrade.ToString.Trim
            sQuery &= " AND J_USER = '" & LoggedUser.UserID.Trim.Trim & "'"
            sQuery &= " AND J_AcomRazonable = " & AcomodoRazonable.ToString.Trim
            sQuery &= " AND IsNull(Jobs.J_PEPV,0) <> 52 "
        End If
        LA_Declarations.OpenConnection(Cn, Config.ConnectionString)
        ' this has been done due to get newly added record pk id
        RsRes.CursorLocation = CursorLocationEnum.adUseClient

        RsJobs.Open(sQuery, Cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockPessimistic)
        RsRes.Open("Select * From Resultados Where resg_id = -1", Cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockOptimistic)
        RsFD.Open("Select * From Factura_Detail Where fd_id = -1", Cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockPessimistic)

        If Not RsJobs.EOF Then
            Serv_Date = RsJobs.Fields("J_Serv_Date").Value
        End If

        While Not RsJobs.EOF
            RsRes.AddNew()
            RsRes.Fields("reg_sc_id").Value = Sch
            RsRes.Fields("reg_j_ID").Value = RsJobs.Fields("j_id").Value
            RsRes.Fields("reg_serv_date").Value = RsJobs.Fields("J_Serv_Date").Value
            RsRes.Fields("resg_rep_id").Value = Rep_ID
            RsRes.Fields("resg_total_est").Value = RsJobs.Fields("J_TOTAL_EST").Value
            RsRes.Fields("resg_grado").Value = RsJobs.Fields("J_GRADE").Value
            RsRes.Fields("resg_section").Value = RsJobs.Fields("J_SEC").Value
            RsRes.Fields("resg_les").Value = RsJobs.Fields("J_LES").Value
            RsRes.Fields("resg_NV").Value = RsJobs.Fields("J_NV").Value
            RsRes.Fields("resg_REN").Value = RsJobs.Fields("J_REN").Value
            RsRes.Fields("resg_mat").Value = RsJobs.Fields("J_MAT").Value
            RsRes.Fields("resg_AID").Value = RsJobs.Fields("j_AID").Value
            RsRes.Fields("resg_cons").Value = RsJobs.Fields("J_CONS").Value
            RsRes.Fields("resg_toll1").Value = RsJobs.Fields("j_toll1").Value
            RsRes.Fields("resg_cons2").Value = RsJobs.Fields("J_CONS2").Value
            RsRes.Fields("resg_toll2").Value = RsJobs.Fields("j_toll2").Value
            RsRes.Fields("resg_cons3").Value = RsJobs.Fields("J_CONS3").Value
            RsRes.Fields("resg_Price").Value = RsJobs.Fields("J_price").Value
            RsRes.Update()
            Res_ID = RsRes.Fields("resg_id").Value

            Call CreateResEst(CInt(RsJobs.Fields("j_id").Value), Res_ID, Cn)
            'on error resume next 
            'Create Factura_Detail record
            If F_ID > 0 Then
                RsFD.AddNew()
                RsFD.Fields("fd_f_id").Value = F_ID
                RsFD.Fields("fd_serv_date").Value = RsJobs.Fields("J_Serv_Date").Value
                RsFD.Fields("fd_grado").Value = RsJobs.Fields("J_GRADE").Value
                RsFD.Fields("fd_sec").Value = RsJobs.Fields("J_SEC").Value
                RsFD.Fields("fd_tot_student").Value = RsJobs.Fields("J_TOTAL_EST").Value
                RsFD.Fields("fd_price").Value = RsJobs.Fields("J_price").Value
                RsFD.Fields("fd_total").Value = RsJobs.Fields("J_price").Value * RsJobs.Fields("J_TOTAL_EST").Value
                Fac_Total = Fac_Total + RsJobs.Fields("J_price").Value * RsJobs.Fields("J_TOTAL_EST").Value
                RsFD.Update()
            End If

            RsJobs.Fields("J_Printed").Value = True
            RsJobs.Update()
            RsJobs.MoveNext()
        End While
        'hacer update a report con el service date

        RsJobs.Close()
        RsRes.Close()
        Cn.Close()


    End Sub

    Sub FillBatteryCbox(ByRef Cbox As ComboBox)
        Dim Cn As Connection
        Dim Rs As Recordset

        Cn = New Connection
        Rs = New Recordset

        OpenConnection(Cn, Config.ConnectionString)

        Rs.Open("Select DISTINCT(DEF_BAT) From DEFAULTS order by DEF_BAT", Cn, CursorTypeEnum.adOpenForwardOnly)
        Cbox.Items.Clear()
        'Cbox.Items.Add("")
        While Not Rs.EOF
            Cbox.Items.Add(Rs.Fields("DEF_BAT").Value)
            Rs.MoveNext()
        End While
        Rs.Close()

        Cn.Close()
        Cbox.SelectedIndex = 0
    End Sub
    ''' <summary>
    ''' Fill Consultant Combo Box
    ''' </summary>
    ''' <param name="Cbox"></param>
    ''' <param name="ConsultantType"></param>
    ''' <remarks></remarks>
    Sub FillConsultantCBox(ByRef Cbox As ComboBox, ByVal loadFromStorage As Boolean, Optional ByVal ConsultantType As enumConsultantType = enumConsultantType.ctExaminer)
        'Dim Cn As Connection
        'Dim Rs As Recordset
        'Dim n As String
        'Dim l1 As String
        'Dim l2 As String
        Dim Con_Type As New FixedLengthString(1)

        If ConsultantType = enumConsultantType.ctConsultant Then
            Con_Type.Value = "C"
        Else
            Con_Type.Value = "E"
        End If
        'Cbox.Items.Clear()
        'Cbox.Items.Add("")

        'Cn = New Connection
        'Rs = New Recordset

        'OpenConnection(Cn, Config.ConnectionString)

        'Rs.Open("Select CON_ID,CON_NAME,CON_LNAME1,CON_LNAME2 From CONSULTANTS Where CON_TYPE ='" & Con_Type.Value & "' Order By CON_NAME ", Cn)

        'While Not Rs.EOF
        '    n = GetValue(Rs.Fields("CON_NAME"))
        '    l1 = GetValue(Rs.Fields("Con_LName1"))
        '    l2 = GetValue(Rs.Fields("Con_LName2"))

        '    Cbox.Items.Add(Trim(Trim(n) & " " & Trim(l1) & " " & Trim(l2)))
        '    SetItemData(Cbox, Cbox.Items.Count - 1, Rs.Fields("CON_ID").Value)
        '    Rs.MoveNext()
        'End While     

        'Rs.Close()
        'Cn.Close()
        Dim sql As String = "Select CON_ID,CON_NAME + ' ' + CON_LNAME1 + ' ' + CON_LNAME2 name From CONSULTANTS Where CON_TYPE ='" & Con_Type.Value & "' Order By CON_NAME "

        Dim dt As DataTable
        If loadFromStorage And Not GlobalResources.Consultants Is Nothing And GlobalResources.Consultants.Rows.Count() > 0 Then
            dt = GlobalResources.Consultants
        Else
            dt = GlobalResources.ExecuteDataTable(sql, True)
            GlobalResources.Consultants = dt
        End If

        Dim i As Integer = 0
        If (dt.Rows.Count > 0) Then
            'For i = 0 To dt.Rows.Count - 1
            '    Cbox.Items.Add(Trim(dt.Rows(i)("name").ToString()))
            '    SetItemData(Cbox, Cbox.Items.Count - 1, dt.Rows(i)("CON_ID").ToString())
            'Next
            Cbox.ValueMember = "CON_ID"
            Cbox.DisplayMember = "name"
            Cbox.DataSource = dt
        End If
        Cbox.SelectedIndex = 0
    End Sub

    'Called By: frmEditJob_Load()
    'Called By: frmEditSchool_Load()
    'Called By: frmPreJob_Load()
    Sub FillConsultantCBox(ByRef Cbox As ComboBox, Optional ByVal ConsultantType As enumConsultantType = enumConsultantType.ctExaminer)
        FillConsultantCBox(Cbox, False)
    End Sub
    ''' <summary>
    ''' Get Grade Name by nmber
    ''' </summary>
    ''' <param name="iGrade"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ''' 
    'Called By: frmPreJob.LoadData()
    ''' <param name="iGrade"></param>
    ''' <returns>
    '''           Grade Name
    ''' </returns>
    ''' <remarks>
    '''            Called By: frmCreateReport.FillJobsPending()
    ''' </remarks>
    Function GetGradeName(ByVal iGrade As Short) As String
        Select Case iGrade
            Case 0 : GetGradeName = "Kindergarten"
            Case 1 : GetGradeName = "First"
            Case 2 : GetGradeName = "Second"
            Case 3 : GetGradeName = "Third"
            Case 4 : GetGradeName = "Fourth"
            Case 5 : GetGradeName = "Fifth"
            Case 6 : GetGradeName = "Sixth"
            Case 7 : GetGradeName = "Seventh"
            Case 8 : GetGradeName = "Eighth"
            Case 9 : GetGradeName = "Ninth"
            Case 10 : GetGradeName = "Tenth"
            Case 11 : GetGradeName = "Eleventh"
            Case 12 : GetGradeName = "Twelfth"
            Case 13 : GetGradeName = "PRE-Kinder"
            Case 14 : GetGradeName = "PRE-PRE-K"
            Case 15 : GetGradeName = "MAT PPK"
            Case 16 : GetGradeName = "MAT PPK2"
            Case Else : GetGradeName = ""
        End Select
    End Function
    ''' <summary>
    ''' Get Grade by Number
    ''' </summary>
    ''' <param name="iGrade"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function GetGradeNo(ByVal iGrade As Short) As String
        Select Case iGrade
            Case 0 : GetGradeNo = "K"
            Case 13 : GetGradeNo = "PK"
            Case 14 : GetGradeNo = "PPK"
            Case 15 : GetGradeNo = "MAT"
            Case 16 : GetGradeNo = "MAT2"
            Case Else : GetGradeNo = CStr(iGrade)
        End Select
    End Function
    ''' <param name="iSemester"></param>
    ''' <returns></returns>
    ''' <remarks>
    '''          Called By: frmReportView.Fill2()
    '''          Called By: LA_Declarations.FillSemesterBox()
    ''' </remarks>
    Function GetSemester(ByVal iSemester As Short) As String
        Select Case iSemester
            Case 1 : GetSemester = "First Semester(Aug-Dec)"
            Case 2 : GetSemester = "Second Semester(Jan-May)"
            Case Else : GetSemester = ""
        End Select
    End Function

    ''' <param name="ReportType"></param>
    ''' <returns>
    '''          Report Type as String
    ''' </returns>
    ''' <remarks>
    '''          Called By: frmReportView.Fill2()
    ''' </remarks>
    Function GetReportType(ByVal ReportType As Short) As String
        Select Case ReportType
            Case enumReportTypes.OfficeTesting
                GetReportType = "Office Testing"
            Case enumReportTypes.Entrance
                GetReportType = "Entrance"
            Case enumReportTypes.Regular
                GetReportType = "Regular"
            Case enumReportTypes.AcomodoRazonable
                GetReportType = "Acomodo Razonable"
            Case Else
                GetReportType = String.Empty
        End Select
    End Function
    'Called By: frmAdjustment.Activated()
    'Called By: frmEditJob.SetExam()
    'Called By: frmPreJob.LVDetails_Click()
    Sub SetValueToCBox(ByRef Cbox As ComboBox, ByRef sValue As String)

        '  For i = 0 To Cbox.Items.Count - 1
        ' If Cbox.FindStringExact(sValue.Trim) Then
        'Cbox.SelectedIndex = Cbox.FindStringExact(sValue.Trim)
        ' End If
        ' Next

        Cbox.SelectedIndex = Cbox.FindStringExact(sValue.Trim)

    End Sub

    'Called By: frmEditJob_Load()
    'Called By: frmNewJob_Load()
    'Called By: frmPreJob_Load()
    Sub FillGradeCbox(ByRef Cbox As ComboBox)
        Cbox.Items.Clear()
        Cbox.Items.Add("")
        SetItemData(Cbox, 0, -1)
        For i As Integer = 0 To 16
            Cbox.Items.Add(GetGradeName(i))
            SetItemData(Cbox, i + 1, i)
        Next i
        Cbox.SelectedIndex = 0
    End Sub

    Function getDefExam(ByRef iGrade As Short, ByRef iSemester As Short) As String
        Dim Cn As Connection
        Dim Rs As Recordset

        Cn = New Connection
        Rs = New Recordset

        OpenConnection(Cn, Config.ConnectionString)

        Rs.Open("SELECT * FROM Defaults WHERE DEF_Grade =" & iGrade & " AND DEF_Sem =" & iSemester, Cn, 3, 3)
        If Not Rs.EOF Then
            Return Rs.Fields("DEF_BAT").Value
        End If

        Rs.Close()
        Cn.Close()
        Return Nothing
    End Function
    'Called By: frmNewJob.SetExam()
    'Called By: frmPreJob.SetExam()
    Sub GetDefaultsValues(ByVal DefBat As Short, ByRef iSemester As Short, ByRef LES As String, ByRef REN As String, ByRef MAT As String, ByRef NV As String, ByRef sPluginName As String, Optional ByRef def_id As Integer = 0, Optional ByRef sSource As String = "")
        DefBat = DefBat - 1
        Dim Cn As Connection
        Dim Rs As Recordset

        Cn = New Connection
        Rs = New Recordset

        OpenConnection(Cn, Config.ConnectionString)


        If def_id > 0 Then
            Rs.Open("Select * from Defaults Where DEF_ID = " & def_id, Cn, 3, 3)
        Else
            Rs.Open("Select * from Defaults Where DEF_GRADE = " & DefBat & " AND DEF_Sem = " & iSemester & " ORDER BY DEF_ID", Cn, 3, 3)
        End If

        If Not Rs.EOF Then

            If Rs.RecordCount > 1 Then

                If def_id = 0 Then
                    If sSource = "prejob" Then
                        frmPreJob.cboBattery.Items.Clear()
                        While Not Rs.EOF
                            frmPreJob.cboBattery.Items.Add(Rs.Fields("Def_PLUGIN").Value & "|___________|" & Rs.Fields("def_id").Value)
                            'frmPreJob.cboBattery.Items.Add(Rs.Fields("Def_PLUGIN").Value.ToString)
                            Rs.MoveNext()
                        End While
                    End If
                    If sSource = "editjob" Then
                        frmEditJob.cboBattery.Items.Clear()
                        While Not Rs.EOF
                            frmEditJob.cboBattery.Items.Add(Rs.Fields("Def_PLUGIN").Value & "|___________|" & Rs.Fields("def_id").Value)
                            'frmEditJob.cboBattery.Items.Add(Rs.Fields("Def_PLUGIN").Value.ToString)
                            Rs.MoveNext()
                        End While
                    End If
                    If sSource = "officetesting" Then
                        frmAddOfficeStudent.cboBattery.Items.Clear()
                        While Not Rs.EOF
                            frmAddOfficeStudent.cboBattery.Items.Add(Rs.Fields("Def_PLUGIN").Value & "|___________|" & Rs.Fields("def_id").Value)
                            'frmAddOfficeStudent.cboBattery.Items.Add(Rs.Fields("Def_PLUGIN").Value.ToString)
                            Rs.MoveNext()
                        End While
                    End If
                End If
                Rs.MoveFirst()
                NV = ""
                LES = ""
                REN = ""
                MAT = ""
                sPluginName = ""
            Else
                If def_id = 0 Then
                    If sSource = "prejob" Then
                        frmPreJob.cboBattery.Items.Clear()
                        frmPreJob.cboBattery.Items.Add(Rs.Fields("Def_PLUGIN").Value & "|__________|" & Rs.Fields("def_id").Value)
                        'frmPreJob.cboBattery.Items.Add(Rs.Fields("Def_PLUGIN").Value.ToString)
                        frmPreJob.cboBattery.SelectedIndex = 0
                    End If

                    If sSource = "editjob" Then
                        frmEditJob.cboBattery.Items.Clear()
                        frmEditJob.cboBattery.Items.Add(Rs.Fields("Def_PLUGIN").Value & "|__________|" & Rs.Fields("def_id").Value)
                        'frmEditJob.cboBattery.Items.Add(Rs.Fields("Def_PLUGIN").Value.ToString)
                        frmEditJob.cboBattery.SelectedIndex = 0
                    End If
                    If sSource = "officetesting" Then
                        frmAddOfficeStudent.cboBattery.Items.Clear()
                        frmAddOfficeStudent.cboBattery.Items.Add(Rs.Fields("Def_PLUGIN").Value & "|__________|" & Rs.Fields("def_id").Value)
                        'frmAddOfficeStudent.cboBattery.Items.Add(Rs.Fields("Def_PLUGIN").Value.ToString)
                        frmAddOfficeStudent.cboBattery.SelectedIndex = 0
                    End If
                End If

                If IsDBNull(Rs.Fields("DEF_CAT").Value) Then
                    NV = ""
                Else
                    NV = Rs.Fields("DEF_CAT").Value
                End If

                If IsDBNull(Rs.Fields("DEF_les").Value) Then
                    LES = ""
                Else
                    LES = Rs.Fields("DEF_les").Value
                End If

                If IsDBNull(Rs.Fields("DEF_ren").Value) Then
                    REN = ""
                Else
                    REN = Rs.Fields("DEF_ren").Value
                End If

                If IsDBNull(Rs.Fields("DEF_mat").Value) Then
                    MAT = ""
                Else
                    MAT = Rs.Fields("DEF_mat").Value
                End If

                sPluginName = Rs.Fields("Def_PLUGIN").Value
            End If
        Else
            MAT = ""
            NV = ""
            REN = ""
            LES = ""
            sPluginName = ""
        End If


        Rs.Close()
        Cn.Close()

    End Sub
    Function GetPluginName(ByVal Grade As Short, ByVal iSemester As Short) As String
        Dim sPluginName As String
        Dim Cn As Connection
        Dim Rs As Recordset

        Cn = New Connection
        Rs = New Recordset

        OpenConnection(Cn, Config.ConnectionString)

        Rs.Open("Select * from Defaults Where DEF_GRADE = " & Grade & " AND DEF_Sem = " & iSemester, Cn, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly)
        If Not Rs.EOF Then
            sPluginName = GetValue(Rs.Fields("Def_PLUGIN"))
        Else
            sPluginName = ""
        End If
        Rs.Close()
        Cn.Close()
        GetPluginName = sPluginName
    End Function
    'Called By: frmEditJob.LoadData()
    'Called By: frmNewJob_Load()
    'Called By: frmNewJob.chkPEP_CheckStateChanged()
    'Called By: frmPreJob_Load()
    Sub FillLESCbox(ByRef Cbox As ComboBox, Optional ByVal ShowAID As Boolean = True, Optional ByVal ShowPEP As Boolean = False)

        'Cbox.Items.Clear()
        'Cbox.Items.Add("")
        'Cbox.Items.Add("AID")

        Dim sQuery As String = "Select CL_ID,CL_Type From Claves where Active =1 and CL_Category = 'L' "
        If ShowAID Then
            sQuery &= " or cl_category = 'A' "
        End If
        If ShowPEP Then
            sQuery &= " OR CL_CATEGORY = 'P' "
        End If
        sQuery &= " order by cl_type ASC"

        'Dim Cn As Connection
        'Dim Rs As Recordset

        'Cn = New Connection
        'Rs = New Recordset

        'OpenConnection(Cn, Config.ConnectionString)

        'Rs.Open(sQuery, Cn, CursorTypeEnum.adOpenStatic, LockTypeEnum.adLockReadOnly)

        'While Not Rs.EOF
        '    Cbox.Items.Add(Rs.Fields("cl_type").Value)
        '    SetItemData(Cbox, Cbox.Items.Count - 1, Rs.Fields("CL_ID").Value)
        '    Rs.MoveNext()
        'End While

        'Rs.Close()
        'Cn.Close()

        Dim dt As DataTable = GlobalResources.ExecuteDataTable(sQuery, True)
        Dim i As Integer = 0
        If (dt.Rows.Count > 0) Then
            'For i = 0 To dt.Rows.Count - 1
            '    Cbox.Items.Add(Trim(dt.Rows(i)("cl_type").ToString()))
            '    SetItemData(Cbox, Cbox.Items.Count - 1, dt.Rows(i)("CL_ID").ToString())
            'Next

            Cbox.ValueMember = "CL_ID"
            Cbox.DisplayMember = "cl_type"
            Cbox.DataSource = dt
        End If
        Cbox.SelectedIndex = 0

    End Sub
    'Called By: frmEditJob.LoadData()
    'Called By: frmNewJob_Load()
    'Called By: frmNewJob.chkPEP_CheckStateChanged()
    'Called By: frmPreJob_Load()
    Sub FillRENCbox(ByRef Cbox As ComboBox, Optional ByVal ShowAID As Boolean = True, Optional ByVal ShowPEP As Boolean = False)
        'Cbox.Items.Clear()
        'Cbox.Items.Add("")
        'Cbox.Items.Add("AID")
        Dim sQuery As String = "Select CL_ID,CL_Type From Claves where Active =1 and CL_Category = 'R' "
        If ShowAID Then
            sQuery &= " or cl_category = 'A' "
        End If
        If ShowPEP Then
            sQuery &= " OR CL_CATEGORY = 'P' "
        End If
        sQuery &= " order by cl_type ASC"

        'Dim Cn As Connection
        'Dim Rs As Recordset

        'Cn = New Connection
        'Rs = New Recordset

        'OpenConnection(Cn, Config.ConnectionString)

        'Rs.Open(sQuery, Cn, CursorTypeEnum.adOpenStatic, LockTypeEnum.adLockReadOnly)

        'While Not Rs.EOF
        '    Cbox.Items.Add(Rs.Fields("cl_type").Value)
        '    SetItemData(Cbox, Cbox.Items.Count - 1, Rs.Fields("CL_ID").Value)
        '    Rs.MoveNext()
        'End While
        'Cbox.SelectedIndex = 0
        'Rs.Close()
        'Cn.Close()

        Dim dt As DataTable = GlobalResources.ExecuteDataTable(sQuery, True)
        Dim i As Integer = 0
        If (dt.Rows.Count > 0) Then
            'For i = 0 To dt.Rows.Count - 1
            '    Cbox.Items.Add(Trim(dt.Rows(i)("cl_type").ToString()))
            '    SetItemData(Cbox, Cbox.Items.Count - 1, dt.Rows(i)("CL_ID").ToString())
            'Next
            Cbox.ValueMember = "CL_ID"
            Cbox.DisplayMember = "cl_type"
            Cbox.DataSource = dt
        End If
        Cbox.SelectedIndex = 0
    End Sub
    'Called By: frmEditJob.LoadData()
    'Called By: frmNewJob_Load()
    'Called By: frmNewJob.chkPEP_CheckStateChanged()
    'Called By: frmPreJob_Load()
    Sub FillMATCbox(ByRef Cbox As ComboBox, Optional ByVal ShowAID As Boolean = True, Optional ByVal ShowPEP As Boolean = False)
        'Cbox.Items.Clear()
        'Cbox.Items.Add("")
        'Cbox.Items.Add("AID")

        Dim sQuery As String = "Select CL_ID,CL_Type From Claves where Active =1 and CL_Category = 'M' "
        If ShowAID Then
            sQuery &= " or cl_category = 'A' "
        End If
        If ShowPEP Then
            sQuery &= " OR CL_CATEGORY = 'P' "
        End If
        sQuery &= " order by cl_type ASC"

        'Dim Cn As Connection
        'Dim Rs As Recordset

        'Cn = New Connection
        'Rs = New Recordset

        'OpenConnection(Cn, Config.ConnectionString)

        'Rs.Open(sQuery, Cn, CursorTypeEnum.adOpenStatic, LockTypeEnum.adLockReadOnly)

        'While Not Rs.EOF
        '    Cbox.Items.Add(Rs.Fields("cl_type").Value)
        '    SetItemData(Cbox, Cbox.Items.Count - 1, Rs.Fields("CL_ID").Value)
        '    Rs.MoveNext()
        'End While

        'Rs.Close()
        'Cn.Close()

        Dim dt As DataTable = GlobalResources.ExecuteDataTable(sQuery, True)
        Dim i As Integer = 0
        If (dt.Rows.Count > 0) Then
            'For i = 0 To dt.Rows.Count - 1
            '    Cbox.Items.Add(Trim(dt.Rows(i)("cl_type").ToString()))
            '    SetItemData(Cbox, Cbox.Items.Count - 1, dt.Rows(i)("CL_ID").ToString())
            'Next
            Cbox.ValueMember = "CL_ID"
            Cbox.DisplayMember = "cl_type"
            Cbox.DataSource = dt
        End If
        Cbox.SelectedIndex = 0
    End Sub
    'Called By: frmEditJob.LoadData()
    'Called By: frmNewJob_Load()
    'Called By: frmNewJob.chkPEP_CheckStateChanged()
    'Called By: frmPreJob_Load()
    Sub FillNVCbox(ByRef Cbox As ComboBox, Optional ByVal ShowAID As Boolean = True, Optional ByVal ShowPEP As Boolean = False)
        Dim sQuery As String
        'Cbox.Items.Clear()
        'Cbox.Items.Add("")
        'Cbox.Items.Add("AID")

        sQuery = "Select CL_ID,CL_Type From Claves where Active =1 and CL_Category = 'N' "
        If ShowAID Then sQuery = sQuery & " or cl_category = 'A' "
        If ShowPEP Then sQuery = sQuery & " OR CL_CATEGORY = 'P' "
        sQuery = sQuery & " order by cl_type ASC"

        'Dim Cn As Connection
        'Dim Rs As Recordset

        'Cn = New Connection
        'Rs = New Recordset

        'OpenConnection(Cn, Config.ConnectionString)

        'Rs.Open(sQuery, Cn, CursorTypeEnum.adOpenStatic, LockTypeEnum.adLockReadOnly)

        'While Not Rs.EOF
        '    Cbox.Items.Add(Rs.Fields("cl_type").Value)
        '    SetItemData(Cbox, Cbox.Items.Count - 1, Rs.Fields("CL_ID").Value)
        '    Rs.MoveNext()
        'End While

        'Rs.Close()
        'Cn.Close()

        Dim dt As DataTable = GlobalResources.ExecuteDataTable(sQuery, True)
        Dim i As Integer = 0
        If (dt.Rows.Count > 0) Then
            'For i = 0 To dt.Rows.Count - 1
            '    Cbox.Items.Add(Trim(dt.Rows(i)("cl_type").ToString()))
            '    SetItemData(Cbox, Cbox.Items.Count - 1, dt.Rows(i)("CL_ID").ToString())
            'Next
            Cbox.ValueMember = "CL_ID"
            Cbox.DisplayMember = "cl_type"
            Cbox.DataSource = dt
        End If
        Cbox.SelectedIndex = 0
    End Sub
    'Called By: frmAdjustment.cboSchools_MouseClick()
    'Called By: frmEditJob_Load()
    'Called By: frmNewJob_Load()
    'Called By: frmPreJob_Load()

    ''' <param name="Cbox"></param>
    ''' <remarks>
    '''          Called By: frmCreateReport.Load()
    ''' </remarks>
    Sub FillSchoolCbox(ByRef Cbox As ComboBox)

        'Cbox.Items.Clear()
        'Cbox.Items.Add("")

        'Dim Cn As Connection
        'Dim Rs As Recordset

        'Cn = New Connection
        'Rs = New Recordset

        'OpenConnection(Cn, Config.ConnectionString)

        ''fill the school combobox
        'Rs.Open("Select * From SChools Order By SC_SCH_Name", Cn, CursorTypeEnum.adOpenForwardOnly)
        'While Not Rs.EOF
        '    Cbox.Items.Add(GetValue(Rs.Fields("sc_sch_name")) & " (" & GetValue(Rs.Fields("sc_city")) & ")")
        '    SetItemData(Cbox, Cbox.Items.Count - 1, Rs.Fields("sc_id").Value)
        '    Rs.MoveNext()
        'End While
        'Rs.Close()
        'Cn.Close()
        'Cbox.SelectedIndex = 0

        Dim sQuery As String = "Select sc_id, sc_sch_name + ' (' + sc_city +')' sch_name From SChools Order By SC_SCH_Name"
        Dim dt As DataTable = GlobalResources.ExecuteDataTable(sQuery, True)
        Dim iCounter1 As Integer = 0
        Dim scid As String
        Dim scname As String
        Cbox.Items.Clear()
        Try
            If dt.Rows.Count > 0 Then
                'For i = 0 To dt.Rows.Count - 1
                'Cbox.Items.Add((dt.Rows(i)("sc_sch_name").ToString()) & " (" & (dt.Rows(i)("sc_city").ToString()) & ")")
                'SetItemData(Cbox, Cbox.Items.Count - 1, dt.Rows(i)("sc_id").ToString())
                'scid = dt.Rows(i)("sc_id").ToString
                'scname = dt.Rows(i)("sc_sch_name").ToString
                'sccty = "(" + dt.Rows(i)("sc_city").ToString + ")"
                'Cbox.Items.Add((dt.Rows(i)("sc_id").ToString) & " - " & (dt.Rows(i)("sc_sch_name").ToString) & " (" & (dt.Rows(i)("sc_city").ToString) & ")")
                'Next
                For iCounter1 = 1 To dt.Rows.Count - 1
                    scid = dt.Rows(iCounter1)("sc_id").ToString
                    If scid = String.Empty Then
                        scid = "0"
                    End If
                    scid = String.Format("{0:000}", Val(scid))
                    scname = dt.Rows(iCounter1)("sch_name").ToString
                    If scname = String.Empty Then
                        scname = "----------"
                    End If
                    Cbox.Items.Add(scid & " - " & scname)
                    'Cbox.Items.Add(scid + " - " + scname)
                    'Cbox.ValueMember = "sc_id"
                    'Cbox.DisplayMember = "sch_name"
                    'Cbox.DataSource = dt
                Next
                Cbox.SelectedIndex = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'Cbox.SelectedIndex = 5
    End Sub

    'Called By: frmPreJob_Load()
    ''' <param name="Cbox"></param>
    ''' <remarks>
    '''          Called By: frmCreateReport_Load()
    ''' </remarks>
    Sub FillSemesterCbox(ByRef Cbox As ComboBox)
        Cbox.Items.Clear()
        Dim iCounter1 As Integer
        For iCounter1 = 0 To 2
            Cbox.Items.Add(LA_Declarations.GetSemester(iCounter1))
        Next iCounter1
    End Sub

    ''' <param name="Text"></param>
    ''' <param name="Delim"></param>
    ''' <param name="Occur"></param>
    ''' <returns></returns>
    ''' <remarks>
    '''           Called By: LA_Declarations.GetINIValue()
    ''' </remarks>
    Function INIField(ByVal Text As String, ByVal Delim As String, ByVal Occur As Integer) As String
        Dim Start As Integer
        Dim Pos1 As Integer
        Dim Pos2 As Integer

        Start = 1
        Pos1 = 1 - Len(Delim)
        Do While Occur > 1
            Pos1 = InStr(Start, Text, Delim)
            If Pos1 < 1 Then
                Exit Do
            End If
            Start = Pos1 + 1
            Occur -= 1
        Loop

        Pos2 = InStr(Pos1 + Len(Delim), Text, Delim)
        If Pos1 < 1 And Occur <> 1 Then
            INIField = String.Empty
        ElseIf Pos2 = 0 Then
            INIField = Mid(Text, Pos1 + Len(Delim), 32767)
        Else
            INIField = Mid(Text, Pos1 + Len(Delim), Pos2 - Pos1 - Len(Delim))
        End If
    End Function

    'UPGRADE_NOTE: format was upgraded to format_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
    Function IsInFormat(ByRef s As String, ByVal format_Renamed As String) As Boolean
        Dim rValue As Boolean
        Dim tmpS As String
        Dim tmpFormat As String
        Dim i As Short
        Dim SChar As String
        Dim FChar As String

        rValue = True

        tmpS = StrReverse(s)
        tmpFormat = StrReverse(format_Renamed)

        If Len(tmpS) = Len(tmpFormat) Then
            While rValue = True And i < Len(tmpS)
                i = i + 1
                FChar = Mid(tmpFormat, i, 1)
                SChar = Mid(tmpS, i, 1)
                Select Case SChar
                    Case "#"
                        If FChar < "0" Or FChar > "9" Then rValue = False
                    Case "@"
                        If Not ((FChar >= "a" And FChar <= "z") Or (FChar >= "A" And FChar <= "Z")) Then rValue = False
                    Case Else
                        If SChar <> FChar Then rValue = False
                End Select
            End While
        Else
            rValue = False
        End If


        IsInFormat = rValue
    End Function

    Sub ChangeJobStatus(ByRef iJobID As Integer, Optional ByRef iStatus As Short = -1, Optional ByRef iProcessStatus As Short = -1, Optional ByRef sDescription As String = "")
        Dim Cn As Connection
        Dim Rs As Recordset

        Cn = New Connection
        Rs = New Recordset

        OpenConnection(Cn, Config.ConnectionString)

        Rs.Open("Select * From Jobs Where J_ID = " & iJobID, Cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockPessimistic)
        If Not Rs.EOF Then
            If iStatus <> -1 Then Rs.Fields("J_Status").Value = iStatus
            If iProcessStatus <> -1 Then Rs.Fields("J_Process_Status").Value = iProcessStatus
            'UPGRADE_NOTE: IsMissing() was changed to IsNothing(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8AE1CB93-37AB-439A-A4FF-BE3B6760BB23"'
            If Not IsNothing(sDescription) Then Rs.Fields("J_DESCRIPTION").Value = sDescription
            Rs.Update()
        End If

        Rs.Close()
        Cn.Close()

    End Sub

    Sub DeleteJob(ByRef JobID As Integer)
        Dim Cn As Connection
        Dim Cm As Command

        Cn = New Connection
        Cm = New Command

        OpenConnection(Cn, Config.ConnectionString)

        Cm.ActiveConnection = Cn

        Cm.CommandText = "DELETE FROM Jobs WHERE J_ID =" & JobID
        Cm.Execute()

        Cm.CommandText = "DELETE FROM Answers WHERE A_J_ID =" & JobID
        Cm.CommandTimeout = 900
        Cm.Execute()

        Cm.CommandText = "DELETE FROM LOGS WHERE L_J_ID =" & JobID
        Cm.CommandTimeout = 900
        Cm.Execute()

        Cn.Close()

    End Sub
    'Called By: frmJobsView.ClearJobToolStripMenuItem_Click
    'Called By: frmJobsView.cmdNext_Click()
    Sub FillJobsView2()
        Dim totpending As String
        Dim Cn As Connection
        Dim Rs As Recordset
        Dim CurrentItem As ListViewItem
        Dim sQuery As String = String.Empty
        On Error GoTo Errores
        'Cn = New Connection
        'Rs = New Recordset

        'OpenConnection(Cn, Config.ConnectionString)

        With Forms.MasterForms.frmJobsView.lvJobs.Items

            If Jobs_WhereStatement = "" Then
                sQuery = " WHERE J_Printed = 0 AND J_Serv_Date >= " & DateAdd(DateInterval.Month, -2, Today) & " AND J_USER = '" & LoggedUser.UserID & "'"
            Else
                sQuery = Jobs_WhereStatement & " AND J_Printed =0 AND J_Serv_Date >= " & DateAdd(DateInterval.Month, -2, Today) & " AND J_USER = '" & LoggedUser.UserID & "'"
            End If

            'Rs.Open("Select Jobs.*,Schools.SC_SCH_NAME From Jobs left outer join SCHOOLS ON Jobs.J_SCH = SCHOOLS.SC_ID " & sQuery & " ORDER BY J_SCH, J_GRADE,J_SEC", Cn)

            Dim sql As String = "Select Jobs.*,Schools.SC_SCH_NAME From Jobs left outer join SCHOOLS ON Jobs.J_SCH = SCHOOLS.SC_ID " & sQuery & " ORDER BY J_SCH, J_GRADE,J_SEC"
            Dim dt As DataTable = GlobalResources.ExecuteDataTable(sql)

            For i As Integer = 0 To dt.Rows.Count - 1
                totpending = dt.Rows(i)("j_total_est_pend").ToString()

                'On Error Resume Next
                CurrentItem = .Item("J" & dt.Rows(i)("j_id").ToString())
                If Not (CurrentItem Is Nothing) Then 'Edit Existing item
                    If Not IsDBNull(dt.Rows(i)("sc_sch_name").ToString()) And _
                        CurrentItem.SubItems(1).Text <> dt.Rows(i)("sc_sch_name").ToString() And _
                        CurrentItem.SubItems.Count > 1 Then
                        If dt.Rows(i)("j_type") <> 0 Then
                            CurrentItem.SubItems(1).Text = dt.Rows(i)("sc_sch_name").ToString()
                        Else
                            CurrentItem.SubItems(1).Text = ""
                        End If
                    End If

                    If Not IsDBNull(dt.Rows(i)("J_GRADE").ToString()) And CurrentItem.SubItems(2).Text <> dt.Rows(i)("J_GRADE").ToString() And CurrentItem.SubItems.Count > 2 Then
                        CurrentItem.SubItems(2).Text = dt.Rows(i)("J_GRADE").ToString()
                    End If

                    If Not IsDBNull(dt.Rows(i)("J_SEC").ToString()) And CurrentItem.SubItems(3).Text <> dt.Rows(i)("J_SEC").ToString() And CurrentItem.SubItems.Count > 3 Then
                        CurrentItem.SubItems(3).Text = dt.Rows(i)("J_SEC").ToString()
                    End If

                    If Not IsDBNull(dt.Rows(i)("J_SEM").ToString()) And CurrentItem.SubItems(4).Text <> dt.Rows(i)("J_SEM").ToString() And CurrentItem.SubItems.Count > 4 Then
                        CurrentItem.SubItems(4).Text = dt.Rows(i)("J_SEM").ToString()
                    End If

                    If Not IsDBNull(dt.Rows(i)("J_DATE").ToString()) And CurrentItem.SubItems(5).Text <> dt.Rows(i)("J_DATE").ToString() And CurrentItem.SubItems.Count > 5 Then
                        CurrentItem.SubItems(5).Text = dt.Rows(i)("J_DATE").ToString()
                    End If

                    If Not IsDBNull(dt.Rows(i)("J_Status").ToString()) And CurrentItem.SubItems(6).Text <> GetJobStatusDesc(dt.Rows(i)("J_Status").ToString()) Then
                        CurrentItem.SubItems(6).Text = GetJobStatusDesc(dt.Rows(i)("J_Status").ToString())
                    End If

                    If Not IsDBNull(dt.Rows(i)("J_Process_Status").ToString()) And CurrentItem.SubItems(7).Text <> GetJobProcStatusDesc(dt.Rows(i)("J_Process_Status").ToString()) Then
                        CurrentItem.SubItems(7).Text = GetJobProcStatusDesc(dt.Rows(i)("J_Process_Status").ToString())
                    End If

                    If Not IsDBNull(dt.Rows(i)("J_DESCRIPTION").ToString()) And CurrentItem.SubItems(8).Text <> dt.Rows(i)("J_DESCRIPTION").ToString() And CurrentItem.SubItems.Count > 8 Then
                        CurrentItem.SubItems(8).Text = dt.Rows(i)("J_DESCRIPTION").ToString()
                    End If

                    Call SetJobIcon(CurrentItem, dt.Rows(i)("J_Status").ToString(), dt.Rows(i)("J_Process_Status").ToString())

                    If CurrentItem.SubItems.Count > 9 Then
                        CurrentItem.SubItems(9).Text = dt.Rows(i)("j_total_est_pend").ToString()
                    End If
                Else 'Insert new Item
                    CurrentItem = Forms.MasterForms.frmJobsView.lvJobs.Items.Add("J" & dt.Rows(i)("j_id").ToString(), "", "")
                    If dt.Rows(i)("j_type").ToString <> 0 Then
                        CurrentItem.SubItems.Insert(1, New ListViewItem.ListViewSubItem(Nothing, dt.Rows(i)("sc_sch_name").ToString()))
                    Else
                        CurrentItem.SubItems.Insert(1, New ListViewItem.ListViewSubItem(Nothing, ""))
                    End If
                    CurrentItem.SubItems.Insert(2, New ListViewItem.ListViewSubItem(Nothing, dt.Rows(i)("J_GRADE").ToString()))
                    CurrentItem.SubItems.Insert(3, New ListViewItem.ListViewSubItem(Nothing, dt.Rows(i)("J_SEC").ToString()))
                    CurrentItem.SubItems.Insert(4, New ListViewItem.ListViewSubItem(Nothing, dt.Rows(i)("J_SEM").ToString()))
                    CurrentItem.SubItems.Insert(5, New ListViewItem.ListViewSubItem(Nothing, dt.Rows(i)("J_DATE").ToString()))
                    CurrentItem.SubItems.Insert(6, New ListViewItem.ListViewSubItem(Nothing, GetJobStatusDesc(dt.Rows(i)("J_Status").ToString())))
                    CurrentItem.SubItems.Item(6).Tag = dt.Rows(i)("J_Status").ToString()
                    CurrentItem.SubItems.Insert(7, New ListViewItem.ListViewSubItem(Nothing, GetJobProcStatusDesc(dt.Rows(i)("J_Process_Status").ToString())))
                    CurrentItem.SubItems.Insert(8, New ListViewItem.ListViewSubItem(Nothing, dt.Rows(i)("J_DESCRIPTION").ToString()))
                    Call SetJobIcon(CurrentItem, dt.Rows(i)("J_Status").ToString(), dt.Rows(i)("J_Process_Status").ToString())
                    CurrentItem.SubItems.Insert(9, New ListViewItem.ListViewSubItem(Nothing, dt.Rows(i)("j_total_est_pend").ToString()))
                End If
                'Se marca el item con "1" en la propiedad de Tag para saber que este record
                'ya fue chequeado por lo tanto existe en la base de datos

                'if the item is marked "1" in the porperties  tag if it exists in the database.
                '
                CurrentItem.Tag = "1"
                'Rs.MoveNext()
            Next
            'Verifico el listado de items buscando los items que no han sido chequeados para removerlose
            'del listados

            'Verify the items that were not set and eliminate them from the report.
        End With

        Dim j As Short
        j = 0
        While j <= Forms.MasterForms.frmJobsView.lvJobs.Items.Count - 1
            CurrentItem = Forms.MasterForms.frmJobsView.lvJobs.Items.Item(j)
            If CurrentItem.Tag = "1" Then
                CurrentItem.Tag = ""
                j = j + 1
            Else
                Call Forms.MasterForms.frmJobsView.lvJobs.Items.RemoveAt(CurrentItem.Index)
            End If
        End While

        'Rs.Close()

        'Cn.Close()
        Exit Sub
Errores:
        MsgBox(Err.Description, MsgBoxStyle.Critical)
    End Sub

    Sub DeleteNomina(ByRef NominaID As Integer)
        Dim Cn As New Connection
        Dim Rs As New Recordset
        Dim Cm As New Command

        OpenConnection(Cn, Config.ConnectionString)

        Rs.Open("Select * From Nomina Where N_NG_ID =" & NominaID, Cn, CursorTypeEnum.adOpenStatic, LockTypeEnum.adLockReadOnly)
        Cm.ActiveConnection = Cn

        While Not Rs.EOF
            Cm.CommandText = "DELETE FROM NOMINA_DETAIL WHERE ND_N_ID =" & Rs.Fields("N_ID").Value
            Cm.Execute()
            Rs.MoveNext()
        End While

        Cm.CommandText = "DELETE FROM NOMINA WHERE N_NG_ID = " & NominaID
        Cm.Execute()

        Cm.CommandText = "DELETE FROM NOMINA_GENERAL WHERE NG_ID = " & NominaID
        Cm.Execute()

        Rs.Close()
        Cn.Close()


    End Sub

    Function GetAnswer(ByVal sAnswers As String, ByRef iSection As Object, ByRef iAnswerNum As Object, ByRef bError As Boolean) As String
        On Error GoTo Errores

        Dim Ans() As String
        Dim Sec() As String
        Dim tmp As String

        bError = False

        Sec = Split(sAnswers, "|")
        'UPGRADE_WARNING: Couldn't resolve default property of object iSection. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Sec(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        tmp = Sec(iSection - 1)
        Ans = Split(tmp, "-")

        'UPGRADE_WARNING: Couldn't resolve default property of object iAnswerNum. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        GetAnswer = Ans(iAnswerNum - 1)

        Exit Function
Errores:
        bError = True


    End Function

    'Called By: frmAccountingView.Fill()  19 call
    'Called By: frmnomina.GetTemplateDataintoform()
    'Called By: LA_Declarations.CreateNomina()


    ''' <summary>
    ''' </summary>
    ''' <param name="s"></param>
    ''' <param name="OnNullValue"></param>
    ''' <returns></returns>
    ''' <remarks>
    '''           Called By: frmReportView.Fill2()
    '''           Called By: frmCreateReport.FillJobsPending()
    '''           Called By: Stanines.GetStanines()
    '''           Called By: frmPrintReport.LoadData() [2 Calls]
    '''           Called By: LA_Declarations.PreviewReport()
    '''           Called By: LA_Declarations.PrintReport()
    ''' </remarks>
    Function GetValue(ByRef s As Object, Optional ByRef OnNullValue As Object = "") As String
        Try
            If IsDBNull(s) Then
                Return OnNullValue
            Else
                If TypeOf (s) Is Field Then
                    Dim x = CType(s, Field)
                    Return x.Value.ToString()
                Else
                    Return s.ToString()
                End If
            End If
        Catch ex As Exception
            Throw New Exception()
        End Try
    End Function

    Function SetAnswer(ByVal sAnswers As Object, ByVal iSection As Object, ByVal iAnswerNum As Object, ByRef NewAnswer As String, ByRef bError As Boolean) As String
        On Error GoTo Errores
        Dim Ans() As String
        Dim Sec() As String
        Dim tmp As String

        bError = False

        Sec = Split(sAnswers, "|")
        tmp = Sec(iSection - 1)
        Ans = Split(tmp, "-")

        Ans(iAnswerNum - 1) = NewAnswer
        tmp = Join(Ans, "-")
        'UPGRADE_WARNING: Couldn't resolve default property of object iSection. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Sec(iSection - 1) = tmp
        SetAnswer = Join(Sec, "|")

        Exit Function
Errores:
        bError = True
    End Function


    ''' <returns>
    '''           Returns the system path
    ''' </returns>
    ''' <remarks>
    '''           Called By: LA_Declarations.GetSystemSettings()
    ''' </remarks>
    Function GetAppPath() As String
        Dim sPath As String = My.Application.Info.DirectoryPath
        If sPath.Length >= 3 Then
            sPath &= "\"
        End If
        GetAppPath = sPath
    End Function

    ''' <param name="Key"></param>
    ''' <returns>
    '''            intTemp
    ''' </returns>
    ''' <remarks>
    '''            Called By: frmReportView.Toolbar1_ButtonClick()
    ''' </remarks>
    Function GetIDFromKey(ByRef Key As String) As Integer
        Dim intTemp As Integer = Val(Right(Key, Key.Length - 1))
        GetIDFromKey = intTemp
    End Function
    'Called By: frmJobsView.ViewEditStudentToolStripMenuItem_Click()
    'Called By: frmNewJob.cmdNext_Click()
    Function GetNamesForJobAIDR(ByRef iJobID As Integer) As Boolean
        frmDataEntry.iJobID = iJobID
        frmDataEntry.ShowDialog()
        GetNamesForJobAIDR = frmDataEntry.bCancel
        frmDataEntry.Close()
    End Function


    Function GetNextJobForProcess(ByVal Scan As Boolean, ByVal JobID As Integer, ByRef iJobStatus As Integer, ByRef sPlugin As String, ByRef bDoLES1 As Boolean, ByRef bDoREN1 As Boolean, ByRef bDoMAT1 As Boolean, ByRef bDoNV1 As Boolean, ByRef sPlugin2 As String, ByRef bDoLES2 As Boolean, ByRef bDoREN2 As Boolean, ByRef bDoMAT2 As Boolean, ByRef bDoNV2 As Boolean) As Boolean
        Dim Cn As Connection
        Dim Rs As Recordset
        'Dim BatName As String
        'Dim PluginName As String
        'Dim PluginName2 As String
        Cn = New Connection
        Rs = New Recordset

        OpenConnection(Cn, Config.ConnectionString)

        Rs.Open("Select J_ID,J_PLUGIN,J_Status,J_LES,J_REN,J_MAT,J_NV,J_AID From Jobs Where J_ID=" & JobID, Cn)
        If Not Rs.EOF Then

            bDoLES1 = False
            bDoMAT1 = False
            bDoREN1 = False
            bDoNV1 = False

            If Rs.Fields("J_LES").Value > 0 Then bDoLES1 = True
            If Rs.Fields("J_MAT").Value > 0 Then bDoMAT1 = True
            If Rs.Fields("J_REN").Value > 0 Then bDoREN1 = True
            If Rs.Fields("J_NV").Value > 0 Then bDoNV1 = True

            'Revisar LES
            'BatName = GetBatName(Rs!J_LES)
            'If BatName <> "" Then
            '    PluginName = BatName
            '    bDoLES1 = True
            '    bDoLES2 = False
            'Else
            '    bDoLES1 = False
            '    bDoLES2 = False
            'End If

            'Revisar REN
            'BatName = GetBatName(Rs!J_REN)
            'If BatName <> "" Then
            '    If PluginName = "" Then
            '        PluginName = BatName
            '        bDoREN1 = True
            '        bDoREN2 = False
            '        Else
            '            If PluginName = BatName Then
            '                bDoREN1 = True
            '            Else
            '                PluginName2 = BatName
            '                bDoREN1 = False
            '                bDoREN2 = True
            '            End If
            '        End If
            '    Else
            '        bDoREN1 = False
            '        bDoREN2 = False
            '    End If
            '
            '    'Revisar MAT
            '    BatName = GetBatName(Rs!J_MAT)
            '    If BatName <> "" Then
            '        If PluginName = "" Then
            '            PluginName = BatName
            '            bDoMAT1 = True
            '            bDoMAT2 = False
            '        Else
            '            If PluginName = BatName Then
            '                bDoMAT1 = True
            '            Else
            '                PluginName2 = BatName
            '                bDoMAT1 = False
            '                bDoMAT2 = True
            '            End If
            '        End If
            '    Else
            '        bDoMAT1 = False
            '        bDoMAT2 = False
            '    End If
            '
            '    'Revisar NV
            '    BatName = GetBatName(Rs!J_NV)
            '    If BatName <> "" Then
            '        If PluginName = "" Then
            '            PluginName = BatName
            '            bDoNV1 = True
            '            bDoNV2 = False
            '        Else
            '            If PluginName = BatName Then
            '                bDoNV1 = True
            '            Else
            '                PluginName2 = BatName
            '                bDoNV1 = False
            '                bDoNV2 = True
            '            End If
            '        End If
            '    Else
            '        bDoNV1 = False
            '        bDoNV2 = False
            '    End If
            '
            '    'Revisar AID
            '    BatName = GetBatName(Rs!J_AID)
            '    If BatName <> "" Then
            '        PluginName = BatName
            '        PluginName2 = ""
            '    End If

            'sPlugin = PluginName
            'sPlugin2 = PluginName2
            sPlugin = Rs.Fields("j_plugin").Value

            iJobStatus = Rs.Fields("J_Status").Value

            GetNextJobForProcess = True
        Else
            GetNextJobForProcess = False
        End If

        Rs.Close()
        Cn.Close()

    End Function

    Sub GetSubSections(ByVal Clave As String, ByRef C1 As String, ByRef C2 As String, ByRef C3 As String)
        Dim tmp() As String
        Dim CC As Short
        C1 = ""
        C2 = ""
        C3 = ""
        tmp = Split(Clave, "|")
        CC = UBound(tmp, 1) + 1
        C1 = tmp(0)
        If CC > 1 Then C2 = tmp(1)
        If CC > 2 Then C3 = tmp(2)
    End Sub

    Sub SetJobIcon(ByRef ListItem As ListViewItem, ByVal Status As Short, ByRef ProcStatus As Short)
        Select Case Status
            Case 0
                ListItem.ImageIndex = 3
            Case 4
                ListItem.ImageIndex = 8
            Case Else
                'Do nothing. 
        End Select

        '0
        '2 scanned
        'If Status = 4 Then
        '    'UPGRADE_ISSUE: MSComctlLib.ListItem property ListItem.Icon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        '    ListItem.Icon = 9
        '    'UPGRADE_ISSUE: MSComctlLib.ListItem property ListItem.SmallIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        '    ListItem.SmallIcon = 9
        'ElseIf ProcStatus = 1 Then  ' warning
        '    'UPGRADE_ISSUE: MSComctlLib.ListItem property ListItem.Icon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        '    ListItem.Icon = 5
        '    'UPGRADE_ISSUE: MSComctlLib.ListItem property ListItem.SmallIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        '    ListItem.SmallIcon = 5
        'Else
        '    'UPGRADE_ISSUE: MSComctlLib.ListItem property ListItem.Icon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        '    ListItem.Icon = 1
        '    'UPGRADE_ISSUE: MSComctlLib.ListItem property ListItem.SmallIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        '    ListItem.SmallIcon = 1
        'End If

    End Sub
    ''' <summary>
    ''' Open Database Connection
    ''' NOTE: THIS WILL BE DEPRECIATED IN FAVOR OF STRAIGHT SQL
    ''' </summary>
    ''' <param name="Cn"></param>
    ''' <param name="CS"></param>
    ''' <remarks>
    '''           Called By: frmReportView.Fill2()
    '''           Called By: frmCreateReport.FillJobsPending()
    '''           Called By: LA_Declarations.JobsNotCompleted()
    '''           Called By: LA_Declarations.CreateReport()
    '''           Called By: LA_Declarations.GetNextFacID()
    '''           Called By: LA_Declarations.CreateResultados()
    '''           Called By: Statnines.GetPotFormula()
    '''           Called By: frmPrintReport.LoadData()
    '''           Called By: frmPrintReport.cmdContinue()
    '''           Called By: LA_Declarations.PreviewReport()
    ''' </remarks>
    Sub OpenConnection(ByRef Cn As Connection, ByRef CS As String)
        'Dim yy As Object
        'On Error GoTo OC_Err
        'Dim iCtr As Short = 1
        Try
            Cn.ConnectionTimeout = iMaxConn
            Cn.CommandTimeout = iMaxConn
            Cn.Open(CS)
        Catch ex As Exception
            MessageBox.Show(ex.Message + "\n" + ex.InnerException.Message + "\n" + ex.StackTrace)
        End Try

        'Exit Sub

        'OC_Err:
        '        If iCtr <= 50 Then
        '            iCtr = iCtr + 1
        '            FileOpen(1, My.Application.Info.DirectoryPath & "\err_" & Format(Now, "YYMMDDHHNNSS") & ".txt", OpenMode.Output)
        '            PrintLine(1, "Cn Error." & Err.Number & "." & Err.Description & ".CN=" & CS)
        '            FileClose(1)
        '            If iCtr >= 30 Then
        '                For yy = 1 To 1999
        '                    System.Windows.Forms.Application.DoEvents()
        '                    'Debug.Print "waiting conn" & iCtr
        '                Next
        '            End If
        '            Resume
        '        Else
        '            If MsgBox("No puede conectarse a la base de datos. Desea intentarlo nuevamente?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "LearnAid") = MsgBoxResult.Yes Then
        '                Resume
        '            Else
        '                Resume Next
        '            End If
        '        End If
    End Sub
End Module