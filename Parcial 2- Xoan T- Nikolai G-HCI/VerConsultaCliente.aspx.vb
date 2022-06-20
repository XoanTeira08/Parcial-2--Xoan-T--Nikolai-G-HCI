Imports System.Data.SqlClient
Public Class VerConsultaCliente
    Inherits System.Web.UI.Page
    Dim con As New SqlConnection("Data Source=LAPTOP-JTB4JJF4;Initial Catalog=Parcial 2- HCI;Integrated Security=True")
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If SesionIniciada = False Then
            Response.Redirect("Login.aspx")
        End If
        con.Open()

        Dim dataV As New DataView
        Dim datatable As New DataTable
        Dim consulta As String

        consulta = "Select IDConsulta,Fecha,Asunto, Urgencia, Descripcion,Estado FROM Consulta Where Cliente='" & IniciarSesion.usuario & "'"

        Dim command As New SqlDataAdapter(consulta, con)
        command.Fill(datatable)
        GridView1.DataSource = datatable
        GridView1.DataBind()
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SesionIniciada = False
        Response.Redirect("Login.aspx")
    End Sub
End Class