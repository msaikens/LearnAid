Imports System.Data.SqlClient

Namespace BLL
    Public Class GlobalResources

#Region "Property"
        Private Shared _connectionString As String









        Private Shared _consultants As DataTable = New DataTable()
        Private Shared _schools As DataTable = New DataTable()

        Public Shared Property Consultants() As DataTable
            Get
                Return _consultants
            End Get
            Set(ByVal value As DataTable)
                _consultants = value
            End Set
        End Property
        Public Shared Property Schools() As DataTable
            Get
                Return _schools
            End Get
            Set(ByVal value As DataTable)
                _schools = value
            End Set
        End Property

        Public Shared Property ConnectionString() As String
            Get
                Return _connectionString
            End Get
            Set(ByVal value As String)
                _connectionString = value
            End Set
        End Property

        Public Shared Property DbConnection() As SqlConnection
            Get
                Return _dbConnection
            End Get
            Set(ByVal value As SqlConnection)
                _dbConnection = value
            End Set
        End Property

#End Region

#Region "Methods"
        Public Shared Function GetConnectionStringAdo(ByRef userId As String, ByRef password As String, ByRef databaseName As String, ByRef dataSource As String, ByRef blankPassword As Boolean) As String
            If blankPassword = True Then
                Return "Provider=SQLNCLI11;Server=SERVER3\LEARNAID;Database=LA;User ID=sa;DataCompatibility=80;"
                'Return "Integrated Security=True;User ID = " & userId & ";Initial Catalog = " & databaseName & ";Data Source = " & dataSource
            ElseIf blankPassword = True Then
                Return "Provider=SQLOLEDB.1;Persist Security Info=False;User ID= " & userId & ";Initial Catalog=" & databaseName &
                    ";Data Source = " & dataSource & ";Use Procedure for Prepare=1;Auto Translate=True;Packet Size=4096;Workstation ID=PROGRAMMING-LA;Initial File Name="";Use Encryption for Data=False;Tag with column collation when possible=False;MARS Connection=False;DataTypeCompatability=0;Trust Server Certificate=False;Application Intent=READWRITE;"
            Else
                'Return "Provider=SQLOLEDB.1;Data Source=SERVER3\LEARNAID;Initial Catalog=LA;User ID=sa"
                Return "Provider=SQLNCLI11;Server=SERVER3\LEARNAID;Database=LA;User ID=sa;DataCompatibility=80;"
            End If
        End Function

        Public Shared Sub OpenConnection()
            Try
                'ConnectionString = GetConnectionStringAdo(Config.DbUserID, Config.DbPassword, Config.DatabaseName, Config.DataSource, Config.DbBlankPWD)
                'ConnectionString = GetConnectionString(Config.DbUserID, Config.DbPassword, Config.DatabaseName, Config.DataSource, Config.DbBlankPWD)
                'ConnectionString = "Server=SERVER3\LEARNAID;Database=LA;User ID=sa" 

                ' CP 2015.03.30 - not sure why this is trying to open a SQL connection when the entire application has ADO connections... 
                '                   but seems it is used in a few places... 
                DbConnection = New SqlConnection("Server=SERVER3\LEARNAID;Database=LA;User ID=sa") ' --> UGH, sorry for the hard-coding.

                DbConnection.Open()
            Catch ex As Exception
                MessageBox.Show(ex.InnerException.ToString())
            End Try
        End Sub

        Private Shared Function IsDbConnectionOpen(dbConnection As SqlConnection) As Boolean
            Try
                If dbConnection.State = ConnectionState.Open Then
                    Return True
                Else
                    OpenConnection()
                End If
            Catch ex As Exception

            End Try

            Return False
        End Function
        Public Shared Function ExecuteDataTable(sQuery As String) As DataTable
            Return ExecuteDataTable(sQuery, False)
        End Function
        Public Shared Function ExecuteDataTable(sQuery As String, insertBlankRow As Boolean) As DataTable
            Dim dt = New DataTable
            If (IsDbConnectionOpen(DbConnection)) Then
                Dim da As SqlDataAdapter
                Try
                    da = New SqlDataAdapter(sQuery, DbConnection)
                    dt.BeginLoadData()
                    da.Fill(dt)
                    dt.EndLoadData()
                    If (insertBlankRow) Then
                        Dim dr As DataRow = dt.NewRow()
                        dt.Rows.InsertAt(dr, 0)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Database Error!!!!")
                Finally
                    'da.Dispose()
                End Try
            End If
            Return dt
        End Function


        Public Shared Function ExecuteNonQuery(sQuery As String) As Integer
            Dim ret As Integer
            If IsDbConnectionOpen(DbConnection) Then
                Dim cmd As SqlCommand = New SqlCommand(sQuery, DbConnection)
                Try
                    ret = cmd.ExecuteNonQuery()
                Catch ex As Exception

                End Try
            End If
            Return ret
        End Function
        Public Shared Function ExecuteScalar(sQuery As String) As Object
            Dim ret As Object
            If IsDbConnectionOpen(DbConnection) Then
                Dim cmd As SqlCommand = New SqlCommand(sQuery, DbConnection)
                Try
                    ret = cmd.ExecuteScalar()
                Catch ex As Exception

                End Try
            End If
            Return ret
        End Function

#End Region

    End Class
End Namespace