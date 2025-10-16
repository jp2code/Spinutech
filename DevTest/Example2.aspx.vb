Public Class Example2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            lblResult.Text = ""
            txtValue.Focus()
        End If
        lblResult.Text = "Exercise 2 has not been started yet."
    End Sub

    Protected Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        lblResult.Text = "Exercise 2 has not been started yet."
    End Sub
End Class