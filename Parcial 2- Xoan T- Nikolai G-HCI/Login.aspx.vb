Imports System.Data.SqlClient
Public Class Login
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim dataR, dataR2 As SqlDataReader
        Dim consulta, consulta2 As String
        Dim con As New SqlConnection("Data Source=LAPTOP-JTB4JJF4;Initial Catalog=Parcial 2- HCI;Integrated Security=True")
        con.Open()
        IniciarSesion.usuario = txtUsuario.Text
        If txtUsuario.Text = "" Or txtContra.Text = "" Then
            lblMensaje.Text = "Por favor ingrese datos validos en los espacios correspondietes"
        Else
            consulta = "Select * From Clientes where Usuario='" & txtUsuario.Text & "' And Contra='" & txtContra.Text & "'"
            consulta2 = "Select * From Admin where Usuario='" & txtUsuario.Text & "' And Contra='" & txtContra.Text & "'"
            Dim comando As New SqlCommand(consulta, con)
            Dim comando2 As New SqlCommand(consulta2, con)
            dataR = comando.ExecuteReader
            If dataR.Read() Then
                SesionIniciada = True
                Response.Redirect("ConsultasCliente.aspx")

            Else
                dataR.Close()
                dataR2 = comando2.ExecuteReader()
                If dataR2.Read() Then
                    SesionIniciada = True
                    Response.Redirect("VerConsultaAdmin.aspx")
                Else
                    dataR2.Close()
                    lblMensaje.Text = "Usuario o contraseña no validos"
                End If
            End If
        End If

    End Sub
End Class