Imports System.Data.SqlClient

Public Class Db_con

    Dim Conexion As New SqlConnection(My.Settings.cadena)


    Conexion.Open()


End Class
