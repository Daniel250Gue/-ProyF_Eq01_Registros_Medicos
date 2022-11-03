Imports System.Data.SqlClient

Public Class Listar_Hospitales


    'ASI CREAMOS METODOS PARA SER USADOS EN LA CAPA PRESENTACION A CADA METODO SE APERTURA LA BASE Y SE DEBE CERRAR AL FINAL
    Public Shared Function NOMBREDELMETODO() As DataTable

        Dim Conexion As New SqlConnection(My.Settings.cadena)
        Conexion.Open()

        Using Da As New SqlDataAdapter("NOMBRE DEL PROCEDIMIENTO", Conexion)

            Using NOMBRE_VARIABLE As New DataTable
                Da.Fill(NOMBRE_VARIABLE)


                Return NOMBRE_VARIABLE

            End Using
        End Using
        Conexion.Close()

    End Function
End Class
