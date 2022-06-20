Imports System.Data.SqlClient
Public Class VerConsultaAdmin
    Inherits System.Web.UI.Page
    Dim con As New SqlConnection("Data Source=LAPTOP-JTB4JJF4;Initial Catalog=Parcial 2- HCI;Integrated Security=True")
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'CONTROL DE INICIO DE SESION'
        If SesionIniciada = False Then
            Response.Redirect("Login.aspx")
        End If

        'GRID VIEWS'
        Dim dataV, dataV2, dataV3, dataV4 As New DataView
        Dim datatable, datatable2, datatable3, datatable4 As New DataTable
        Dim consulta, consulta2, consulta3, consulta4 As String

        consulta = "Select * FROM Consulta Where Urgencia='" & "Emergencia" & "'"
        consulta2 = "Select * FROM Consulta Where Urgencia='" & "Muy Urgente" & "'"
        consulta3 = "Select * FROM Consulta Where Urgencia='" & "Urgente" & "'"
        consulta4 = "Select * FROM Consulta Where Urgencia='" & "Normal" & "'"

        Dim command As New SqlDataAdapter(consulta, con)
        Dim command2 As New SqlDataAdapter(consulta2, con)
        Dim command3 As New SqlDataAdapter(consulta3, con)
        Dim command4 As New SqlDataAdapter(consulta4, con)

        command.Fill(datatable)
        command2.Fill(datatable2)
        command3.Fill(datatable3)
        command4.Fill(datatable4)

        GridView1.DataSource = datatable
        GridView2.DataSource = datatable2
        GridView3.DataSource = datatable3
        GridView4.DataSource = datatable4

        GridView1.DataBind()
        GridView2.DataBind()
        GridView3.DataBind()
        GridView4.DataBind()

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SesionIniciada = False
        Response.Redirect("Login.aspx")
    End Sub
End Class