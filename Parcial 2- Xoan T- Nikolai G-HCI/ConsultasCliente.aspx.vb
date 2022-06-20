Imports System.Data.SqlClient
Public Class ConsultasCliente
    Inherits System.Web.UI.Page
    Public Property Usuario As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If SesionIniciada = False Then
            Response.Redirect("Login.aspx")
        End If
    End Sub

    Protected Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim control As Integer
        Dim consulta, fechaString, estado As String
        Dim fecha As Date = Date.Now

        fechaString = Format(fecha, "yyyyMMdd hh:mm:ss")
        estado = "No visto"

        Dim con As New SqlConnection("Data Source=LAPTOP-JTB4JJF4;Initial Catalog=Parcial 2- HCI;Integrated Security=True")
        con.Open()

        If TextBox1.Text = "" Or DropDownList1.SelectedIndex = 0 Or TextBox2.Text = "" Then
            Label4.Text = "Por favor ingrese datos validos en los campos"
        Else
            consulta = "Insert into Consulta( Fecha ,Asunto, Urgencia,Descripcion, Estado, Cliente) Values('" & fechaString & "','" & TextBox1.Text & "','" & DropDownList1.Text & "','" & TextBox2.Text & "','" & estado & "','" & IniciarSesion.usuario & "')"
            Dim comando As New SqlCommand(consulta, con)
            control = comando.ExecuteNonQuery()
            If control > 0 Then
                TextBox1.Text = ""
                TextBox2.Text = ""
                DropDownList1.SelectedIndex = 0
                Label4.Text = "Consulta realizada con exito"
            Else
                Label4.Text = "ERROR"
            End If
        End If


    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SesionIniciada = False
        Response.Redirect("Login.aspx")
    End Sub
End Class