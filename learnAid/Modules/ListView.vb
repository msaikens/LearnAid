Option Strict Off
Option Explicit On
Module mListView

    ' ===========================================================================
    ' Filename: mListView
    ' Author:   Juan Carlos - Aranay Interactive Systems
    ' Date:     08-01-2002
    '
    ' Requires:
    '
    ' Description:
    ' Declares to support advanced ListView features.
    '

    Public Const CLR_NONE As Integer = &HFFFFFFFF

    Public Const LVM_FIRST As Integer = &H1000 '// ListView messages
    Public Const LVM_SETBKCOLOR As Decimal = (LVM_FIRST + 1)
    Public Const LVM_GETHEADER As Decimal = (LVM_FIRST + 31)
    Public Const LVM_SETTEXTBKCOLOR As Decimal = (LVM_FIRST + 38)
    Public Const LVM_SETICONSPACING As Decimal = (LVM_FIRST + 53)


    Public Const LVM_SETHOVERTIME As Decimal = (LVM_FIRST + 71)
    Public Const LVM_GETHOVERTIME As Decimal = (LVM_FIRST + 72)

    Public Const LVM_GETEXTENDEDLISTVIEWSTYLE As Decimal = (LVM_FIRST + 55)
    Public Const LVM_SETEXTENDEDLISTVIEWSTYLE As Decimal = (LVM_FIRST + 54) '// optional wParam == mask

    Public Const LVS_EX_GRIDLINES As Integer = &H1
    Public Const LVS_EX_SUBITEMIMAGES As Integer = &H2
    Public Const LVS_EX_CHECKBOXES As Integer = &H4
    Public Const LVS_EX_TRACKSELECT As Integer = &H8
    Public Const LVS_EX_HEADERDRAGDROP As Integer = &H10
    Public Const LVS_EX_FULLROWSELECT As Integer = &H20 '// applies to report mode only
    Public Const LVS_EX_ONECLICKACTIVATE As Integer = &H40
    Public Const LVS_EX_TWOCLICKACTIVATE As Integer = &H80
    '#if (_WIN32_IE >= =&H0400)
    Public Const LVS_EX_FLATSB As Integer = &H100
    Public Const LVS_EX_REGIONAL As Integer = &H200
    Public Const LVS_EX_INFOTIP As Integer = &H400 '// listview does InfoTips for you
    Public Const LVS_EX_UNDERLINEHOT As Integer = &H800
    Public Const LVS_EX_UNDERLINECOLD As Integer = &H1000
    Public Const LVS_EX_MULTIWORKAREAS As Integer = &H2000
    '#endif

    ' Bitmaps in list views!
    Structure LVBKIMAGE
        Dim ulFlags As Integer
        Dim hbm As Integer
        Dim pszImage As String
        Dim cchImageMax As Integer
        Dim xOffsetPercent As Integer
        Dim yOffsetPercent As Integer
    End Structure

    ' 4.71:
    Public Const LVBKIF_SOURCE_NONE As Integer = &H0
    Public Const LVBKIF_SOURCE_HBITMAP As Integer = &H1 ' Not supported
    Public Const LVBKIF_SOURCE_URL As Integer = &H2
    Public Const LVBKIF_SOURCE_MASK As Integer = &H3
    Public Const LVBKIF_STYLE_NORMAL As Integer = &H0
    Public Const LVBKIF_STYLE_TILE As Integer = &H10
    Public Const LVBKIF_STYLE_MASK As Integer = &H10

    Public Const LVM_SETBKIMAGEA As Decimal = (LVM_FIRST + 68)
    Public Const LVM_GETBKIMAGEA As Decimal = (LVM_FIRST + 69)
    Public Const LVM_SETBKIMAGE As Integer = LVM_SETBKIMAGEA
    Public Const LVM_GETBKIMAGE As Integer = LVM_GETBKIMAGEA

    ' Manipulating ListView Columns
    Structure LVCOLUMN
        Dim mask As Integer
        Dim fmt As Integer
        Dim cx As Integer
        Dim pszText As String
        Dim cchTextMax As Integer
        Dim iSubItem As Integer
        '#if (_WIN32_IE >= 0x0300)
        Dim iImage As Integer
        Dim iOrder As Integer
        '#End If
    End Structure

    ' LVCOLUMN mask values:
    Public Const LVCF_FMT As Integer = &H1
    Public Const LVCF_WIDTH As Integer = &H2
    Public Const LVCF_TEXT As Integer = &H4
    Public Const LVCF_SUBITEM As Integer = &H8
    '#if (_WIN32_IE >= =&H0300)
    Public Const LVCF_IMAGE As Integer = &H10
    Public Const LVCF_ORDER As Integer = &H20
    '#End If

    ' LVCOLUMN fmt values:
    Public Const LVCFMT_LEFT As Integer = &H0
    Public Const LVCFMT_RIGHT As Integer = &H1
    Public Const LVCFMT_CENTER As Integer = &H2
    Public Const LVCFMT_JUSTIFYMASK As Integer = &H3
    '#if (_WIN32_IE >= =&H0300)
    Public Const LVCFMT_IMAGE As Integer = &H800
    Public Const LVCFMT_BITMAP_ON_RIGHT As Integer = &H1000
    Public Const LVCFMT_COL_HAS_IMAGES As Integer = &H8000
    '#End If

    Public Const LVM_GETCOLUMNA As Decimal = (LVM_FIRST + 25)
    Public Const LVM_GETCOLUMN As Integer = LVM_GETCOLUMNA
    Public Const LVM_SETCOLUMNA As Decimal = (LVM_FIRST + 26)
    Public Const LVM_SETCOLUMN As Integer = LVM_SETCOLUMNA

    Public Const LVM_GETCOLUMNORDERARRAY As Decimal = (LVM_FIRST + 59)
    Public Const LVM_SETCOLUMNORDERARRAY As Decimal = (LVM_FIRST + 58)

    ' Manipulating ListView items:
    Structure LVITEM
        Dim mask As Integer
        Dim iItem As Integer
        Dim iSubItem As Integer
        Dim state As Integer
        Dim stateMask As Integer
        Dim pszText As String
        Dim cchTextMax As Integer
        Dim iImage As Integer
        Dim lParam As Integer
        '#if (_WIN32_IE >= 0x0300)
        Dim iIndent As Integer
        '#End If
    End Structure

    ' LVITEM mask values:
    Public Const LVIF_TEXT As Integer = &H1
    Public Const LVIF_IMAGE As Integer = &H2
    Public Const LVIF_PARAM As Integer = &H4
    Public Const LVIF_STATE As Integer = &H8
    '#if (_WIN32_IE >= =&H0300)
    Public Const LVIF_INDENT As Integer = &H10
    Public Const LVIF_NORECOMPUTE As Integer = &H800
    '#End If

    Public Const LVM_GETITEMA As Decimal = (LVM_FIRST + 5)
    Public Const LVM_GETITEM As Integer = LVM_GETITEMA
    Public Const LVM_SETITEMA As Decimal = (LVM_FIRST + 6)
    Public Const LVM_SETITEM As Integer = LVM_SETITEMA

    ' Check boxes:
    Public Const LVM_GETITEMSTATE As Decimal = (LVM_FIRST + 44)
    Public Const LVM_SETITEMSTATE As Decimal = (LVM_FIRST + 43)

    Public Const LVIS_FOCUSED As Integer = &H1
    Public Const LVIS_SELECTED As Integer = &H2
    Public Const LVIS_CUT As Integer = &H4
    Public Const LVIS_DROPHILITED As Integer = &H8
    Public Const LVIS_ACTIVATING As Integer = &H20

    Public Const LVIS_OVERLAYMASK As Integer = &HF00
    Public Const LVIS_STATEIMAGEMASK As Integer = &HF000

    ' Finding:
    Public Structure POINT
        Dim X As Integer
        Dim y As Integer
    End Structure

    Public Structure LVFINDINFO
        Dim flags As Integer
        Dim psz As String
        Dim lParam As Integer
        Dim pt As POINT
        Dim vkDirection As Integer
    End Structure

    Private Const LVFI_PARAM As Short = 1
    Public Const LVFI_STRING As Integer = &H2
    Public Const LVFI_PARTIAL As Integer = &H8
    Public Const LVFI_WRAP As Integer = &H20
    Public Const LVFI_NEARESTXY As Integer = &H40

    Private Const LVM_FINDITEM As Decimal = LVM_FIRST + 13
    Private Const LVM_GETITEMTEXT As Decimal = LVM_FIRST + 45
    Public Const LVM_SORTITEMS As Decimal = LVM_FIRST + 48

    Public Const LVM_GETNEXTITEM As Decimal = (LVM_FIRST + 12)

    Public Const LVNI_ALL As Integer = &H0
    Public Const LVNI_FOCUSED As Integer = &H1
    Public Const LVNI_SELECTED As Integer = &H2
    Public Const LVNI_CUT As Integer = &H4
    Public Const LVNI_DROPHILITED As Integer = &H8

    Public Const LVNI_ABOVE As Integer = &H100
    Public Const LVNI_BELOW As Integer = &H200
    Public Const LVNI_TOLEFT As Integer = &H400
    Public Const LVNI_TORIGHT As Integer = &H800

    ' Header control styles
    Public Const HDS_HOTTRACK As Integer = &H4 ' v 4.70
    Public Const HDS_BUTTONS As Integer = &H2

    ' Message functions:
    Declare Function SendMessageByString Lib "user32" Alias "SendMessageA" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As String) As Integer
    Declare Function SendMessageByLong Lib "user32" Alias "SendMessageA" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FAE78A8D-8978-4FD4-8208-5B7324A8F795"'
    'Declare Function SendMessage Lib "user32"  Alias "SendMessageA"(ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByRef lParam As Any) As Integer
    Declare Function PostMessage Lib "user32" Alias "PostMessageA" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer

    Declare Function GetWindow Lib "user32" (ByVal hwnd As Integer, ByVal wCmd As Integer) As Integer
    Public Const GW_CHILD As Short = 5
    Public Const GW_HWNDFIRST As Short = 0
    Public Const GW_HWNDLAST As Short = 1
    Public Const GW_HWNDNEXT As Short = 2
    Public Const GW_HWNDPREV As Short = 3
    Public Const GW_MAX As Short = 5
    Public Const GW_OWNER As Short = 4

    Declare Function ShowWindow Lib "user32" (ByVal hwnd As Integer, ByVal nCmdShow As Integer) As Integer
    ' Show window styles
    Public Const SW_SHOWNORMAL As Short = 1
    Public Const SW_ERASE As Integer = &H4
    Public Const SW_HIDE As Short = 0
    Public Const SW_INVALIDATE As Integer = &H2
    Public Const SW_MAX As Short = 10
    Public Const SW_MAXIMIZE As Short = 3
    Public Const SW_MINIMIZE As Short = 6
    Public Const SW_NORMAL As Short = 1
    Public Const SW_OTHERUNZOOM As Short = 4
    Public Const SW_OTHERZOOM As Short = 2
    Public Const SW_PARENTCLOSING As Short = 1
    Public Const SW_RESTORE As Short = 9
    Public Const SW_PARENTOPENING As Short = 3
    Public Const SW_SHOW As Short = 5
    Public Const SW_SCROLLCHILDREN As Integer = &H1
    Public Const SW_SHOWDEFAULT As Short = 10
    Public Const SW_SHOWMAXIMIZED As Short = 3
    Public Const SW_SHOWMINIMIZED As Short = 2
    Public Const SW_SHOWMINNOACTIVE As Short = 7
    Public Const SW_SHOWNA As Short = 8
    Public Const SW_SHOWNOACTIVATE As Short = 4
    Declare Function SetParent Lib "user32" (ByVal hWndChild As Integer, ByVal hWndNewParent As Integer) As Integer
    Declare Function GetParent Lib "user32" (ByVal hwnd As Integer) As Integer

    ' Window style bit functions:
    Public Declare Function SetWindowLong Lib "user32" Alias "SetWindowLongA" (ByVal hwnd As Integer, ByVal nIndex As Integer, ByVal dwNewLong As Integer) As Integer
    Public Declare Function GetWindowLong Lib "user32" Alias "GetWindowLongA" (ByVal hwnd As Integer, ByVal nIndex As Integer) As Integer
    ' Window Long indexes:
    Public Const GWL_EXSTYLE As Short = (-20)
    Public Const GWL_HINSTANCE As Short = (-6)
    Public Const GWL_HWNDPARENT As Short = (-8)
    Public Const GWL_ID As Short = (-12)
    Public Const GWL_STYLE As Short = (-16)
    Public Const GWL_USERDATA As Short = (-21)
    Public Const GWL_WNDPROC As Short = (-4)

    Declare Function SetWindowPos Lib "user32" (ByVal hwnd As Integer, ByVal hWndInsertAfter As Integer, ByVal X As Integer, ByVal y As Integer, ByVal cx As Integer, ByVal cY As Integer, ByVal wFlags As Integer) As Integer
    Public Const SWP_FRAMECHANGED As Integer = &H20 '  The frame changed: send WM_NCCALCSIZE
    Public Const SWP_HIDEWINDOW As Integer = &H80
    Public Const SWP_NOACTIVATE As Integer = &H10
    Public Const SWP_NOCOPYBITS As Integer = &H100
    Public Const SWP_NOMOVE As Integer = &H2
    Public Const SWP_NOOWNERZORDER As Integer = &H200 '  Don't do owner Z ordering
    Public Const SWP_NOREDRAW As Integer = &H8
    Public Const SWP_NOREPOSITION As Integer = SWP_NOOWNERZORDER
    Public Const SWP_NOSIZE As Integer = &H1
    Public Const SWP_NOZORDER As Integer = &H4
    Public Const SWP_SHOWWINDOW As Integer = &H40
    Public Const SWP_DRAWFRAME As Integer = SWP_FRAMECHANGED
    Public Const HWND_NOTOPMOST As Short = -2

    Public Declare Function CoInitialize Lib "OLE32.DLL" (ByVal pvReserved As Integer) As Integer
    Public Declare Sub CoUninitialize Lib "OLE32.DLL" ()
    Public Const NOERROR As Integer = &H0
    Public Const S_OK As Integer = &H0
    Public Const S_FALSE As Integer = &H1

    Declare Function GetDC Lib "user32" (ByVal hwnd As Integer) As Integer
    Declare Function ReleaseDC Lib "user32" (ByVal hwnd As Integer, ByVal hdc As Integer) As Integer
    Declare Function SetBkMode Lib "gdi32" (ByVal hdc As Integer, ByVal nBkMode As Integer) As Integer
    Declare Function SetBkColor Lib "gdi32" (ByVal hdc As Integer, ByVal crColor As Integer) As Integer
    Public Const TRANSPARENT As Short = 1

    Public m_iSortCol As Integer
    'Public m_eSortOrder As ComctlLib.ListSortOrderConstants
    Public Enum ELVSortTypes
        elvstText
        elvstInteger
        elvstFloat
        elvstDate
    End Enum
    Public m_eSortType As ELVSortTypes

    'Called By: frmPreJob_Load()
    Sub SetFlatScrollBars(ByRef lv As System.Windows.Forms.ListView, Optional ByVal Flat As Object = True)
        'Dim lP As Integer
        Dim lStyle As Integer
        Dim lS As Integer

        ' Set Extended List View Styles supported by COMCTL32.DLL v4.71 or
        ' higher (IE4 version or above):
        lStyle = SendMessageByLong(lv.Handle.ToInt32, LVM_GETEXTENDEDLISTVIEWSTYLE, 0, 0)

        lS = LVS_EX_FLATSB
        If (Not Flat) Then
            lStyle = lStyle And Not lS
        Else
            lStyle = lStyle Or lS

        End If

        SendMessageByLong(lv.Handle.ToInt32, LVM_SETEXTENDEDLISTVIEWSTYLE, 0, lStyle)

    End Sub


    Public Function LVWSortCompare(ByVal lParam1 As Integer, ByVal lParam2 As Integer, ByVal hwnd As Integer) As Integer
        Dim m_eSortOrder As Object = Nothing
        Dim lI1, lI2 As Integer
        Dim v2 As Object = Nothing
        Dim v1 As Object = Nothing
        Dim vt As Object = Nothing

        'UPGRADE_WARNING: Couldn't resolve default property of object GetListViewIndexForlParam(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        lI1 = GetListViewIndexForlParam(hwnd, lParam1)
        'UPGRADE_WARNING: Couldn't resolve default property of object GetListViewIndexForlParam(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        lI2 = GetListViewIndexForlParam(hwnd, lParam2)

        'Compare the items
        'Return -ve if lI1<lI2,
        '       0 if lI1 = lI2
        '       +ve if lI1 > lI2
        On Error Resume Next
        Select Case m_eSortType
            Case ELVSortTypes.elvstInteger
                'UPGRADE_WARNING: Couldn't resolve default property of object v1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                v1 = CInt(GetListViewItem(hwnd, lI1))
                'UPGRADE_WARNING: Couldn't resolve default property of object v2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                v2 = CInt(GetListViewItem(hwnd, lI2))
            Case ELVSortTypes.elvstFloat
                'UPGRADE_WARNING: Couldn't resolve default property of object v1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                v1 = CDbl(GetListViewItem(hwnd, lI1))
                'UPGRADE_WARNING: Couldn't resolve default property of object v2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                v2 = CDbl(GetListViewItem(hwnd, lI2))
            Case ELVSortTypes.elvstDate
                'UPGRADE_WARNING: Couldn't resolve default property of object v1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                v1 = CDate(GetListViewItem(hwnd, lI1))
                'UPGRADE_WARNING: Couldn't resolve default property of object v2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                v2 = CDate(GetListViewItem(hwnd, lI2))
            Case ELVSortTypes.elvstText
                'UPGRADE_WARNING: Couldn't resolve default property of object v1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                v1 = GetListViewItem(hwnd, lI1)
                'UPGRADE_WARNING: Couldn't resolve default property of object v2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                v2 = GetListViewItem(hwnd, lI2)
        End Select

        If (m_eSortOrder = System.Windows.Forms.SortOrder.Descending) Then
            'UPGRADE_WARNING: Couldn't resolve default property of object v2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object vt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            vt = v2
            'UPGRADE_WARNING: Couldn't resolve default property of object v1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object v2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            v2 = v1
            'UPGRADE_WARNING: Couldn't resolve default property of object vt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object v1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            v1 = vt
        End If
        'UPGRADE_WARNING: Couldn't resolve default property of object v2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object v1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If (v1 < v2) Then
            LVWSortCompare = -1
            'UPGRADE_WARNING: Couldn't resolve default property of object v2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object v1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        ElseIf (v1 = v2) Then
            LVWSortCompare = 0
        Else
            LVWSortCompare = 1
        End If

    End Function
    Private Function GetListViewIndexForlParam(ByVal hwnd As Integer, ByVal lParam As Integer) As Object
        Dim tLV As LVFINDINFO
        'Dim lIndex As Integer

        ' Convert the input parameter to an index in the list view
        tLV.flags = LVFI_PARAM
        tLV.lParam = lParam
        'UPGRADE_WARNING: Couldn't resolve default property of object tLV. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'GetListViewIndexForlParam = SendMessageByString(hwnd, LVM_FINDITEM, -1, tLV)
        MessageBox.Show("This function is not used. Please not the steps you took to get to this message and notify a developer", "Unexpected Error", MessageBoxButtons.OK)
        Return Nothing
    End Function
    Private Function GetListViewItem(ByVal hwnd As Integer, ByVal lIndex As Integer) As String
        Dim tLV As LVITEM
        Dim lLength As Integer

        tLV.mask = LVIF_TEXT
        tLV.iSubItem = m_iSortCol - 1
        tLV.pszText = New String(Chr(0), 32)
        tLV.cchTextMax = 32
        'UPGRADE_WARNING: Couldn't resolve default property of object tLV. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'lLength = SendMessage(hwnd, LVM_GETITEMTEXT, lIndex, tLV)
        If lLength > 0 Then
            Return Left(tLV.pszText, lLength)
        End If
        MessageBox.Show("Returning nothing. Something went wrong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return Nothing
    End Function


    Sub SetListViewFlatHeader(ByRef lv As System.Windows.Forms.ListView, ByVal Flat As Boolean)
        Dim lS As Integer
        Dim lhWnd As Integer

        ' Set the Buttons mode of the ListView's header control:
        lhWnd = SendMessageByLong(lv.Handle.ToInt32, LVM_GETHEADER, 0, 0)
        If (lhWnd <> 0) Then
            lS = GetWindowLong(lhWnd, GWL_STYLE)
            If (Flat) Then
                lS = lS And Not HDS_BUTTONS
            Else
                lS = lS Or HDS_BUTTONS
            End If
            SetWindowLong(lhWnd, GWL_STYLE, lS)
        End If

    End Sub
End Module