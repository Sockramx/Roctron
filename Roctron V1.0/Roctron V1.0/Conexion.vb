Imports System.Data.SqlClient

Public Class Conexion
    Public cn As SqlConnection
    Public da As SqlDataAdapter
    Public cm As SqlCommand
    Public cb As SqlCommandBuilder
    Public ds As Data.DataSet
    Public Sub conecta(ByVal sql As String, ByVal tabla As String)
        Try
            cn = New SqlConnection("Server = .; DataBase = Roctron2; Integrated Security = True")
            cm = New SqlCommand(sql, cn)
            da = New SqlDataAdapter(cm)
            cb = New SqlCommandBuilder(da)
            ds = New Data.DataSet
            cn.Open()
            da.Fill(ds, tabla)
            cn.Close()
            cn.Dispose()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
