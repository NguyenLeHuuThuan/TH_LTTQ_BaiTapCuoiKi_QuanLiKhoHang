Imports System.Data.SqlClient

Module Database
    Public connectionString As String = "Data Source=DESKTOP-M4V955C\MSSQLSERVER04;Initial Catalog=QuanLyKhoHang;Integrated Security=True"
    Public conn As New SqlConnection(connectionString)
End Module
