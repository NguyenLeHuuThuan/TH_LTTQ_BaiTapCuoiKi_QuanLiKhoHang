Imports System.Data.SqlClient

Module Database
    Public connectionString As String = "Data Source=NGUYENPHUONG;Initial Catalog=QLKH;Integrated Security=True"
    Public conn As New SqlConnection(connectionString)
End Module
