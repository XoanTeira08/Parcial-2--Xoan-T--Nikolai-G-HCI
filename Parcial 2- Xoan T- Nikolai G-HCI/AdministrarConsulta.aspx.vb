Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class Editar_consulta
    Inherits System.Web.UI.Page

    Dim con As New SqlConnection("Data Source=LAPTOP-JTB4JJF4;Initial Catalog=Parcial 2- HCI;Integrated Security=True")
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If SesionIniciada = False Then
            Response.Redirect("Login.aspx")
        End If
    End Sub

    Protected Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim dataV As New DataView
        Dim datatable As New DataTable
        Dim consulta As String
        If TextBox1.Text = "" Then
            Label2.Text = "Por favor ingrese datos validos en los campos"
        Else
            consulta = "Select * FROM Consulta Where IDConsulta='" & TextBox1.Text & "'"

            Dim command As New SqlDataAdapter(consulta, con)

            command.Fill(datatable)

            GridView1.DataSource = datatable
            GridView1.DataBind()
        End If



    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim consulta As String
        Dim control As Integer

        con.Open()

        If TextBox1.Text = "" Or DropDownList1.SelectedIndex = 0 Or DropDownList2.SelectedIndex = 0 Then
            Label6.Text = "Por favor ingrese datos validos en los campos"
        Else
            consulta = "Delete * FROM Consulta Where IDConsulta='" & TextBox1.Text & "'"
            Dim comando As New SqlCommand(consulta, con)

            control = comando.ExecuteNonQuery()
            If control > 0 Then

                Label6.Text = "Consulta eliminada"
            Else
                Label6.Text = "ERROR"
            End If

        End If
    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim consulta, consulta2 As String
        Dim control As Integer

        con.Open()
        If TextBox1.Text = "" Or DropDownList1.SelectedIndex = 0 Or DropDownList2.SelectedIndex = 0 Or TextBox3.Text = "" Then
            Label6.Text = "Por favor ingrese datos validos en los campos"
        Else
            consulta = "Update Consulta Set TipoSoporte='" & DropDownList1.Text & "', Estado='" & DropDownList2.Text & "', Observacion='" & TextBox2.Text & "', Costo='" & TextBox3.Text & "' WHERE IDConsulta='" & TextBox1.Text & "'"
            Dim comando As New SqlCommand(consulta, con)

            control = comando.ExecuteNonQuery()
            If control > 0 Then
                TextBox2.Text = ""
                TextBox3.Text = ""
                DropDownList1.SelectedIndex = 0
                DropDownList2.SelectedIndex = 0
                Label6.Text = "Consulta actualizada"
                Dim dataV As New DataView
                Dim datatable As New DataTable

                consulta2 = "Select * FROM Consulta Where IDConsulta='" & TextBox1.Text & "'"

                Dim command As New SqlDataAdapter(consulta2, con)

                command.Fill(datatable)

                GridView1.DataSource = datatable
                GridView1.DataBind()

            Else
                Label6.Text = "ERROR"
            End If
        End If
    End Sub

    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox1.Text = "" Then
            Label6.Text = "Por favor ingrese datos validos en los campos"
        Else
            Response.ClearContent()
            Response.AddHeader("Content-disposition", "attachment; filename=Consulta.xls")
            Response.ContentType = "application/vnd.msexcel"
            Dim swriter As New StringWriter()
            Dim htmlwriter As New HtmlTextWriter(swriter)
            GridView1.RenderControl(htmlwriter)
            Response.Write(swriter.ToString())
            Response.End()
        End If


    End Sub
    Public Overloads Overrides Sub VerifyRenderingInServerForm(ByVal c As Control)

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SesionIniciada = False
        Response.Redirect("Login.aspx")
    End Sub
End Class