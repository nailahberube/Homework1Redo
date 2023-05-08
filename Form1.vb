Public Class frmNumbers
    Private Sub frmNumbers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblFrench.Visible = False
    End Sub

    Private Sub btnOne_Click(sender As Object, e As EventArgs) Handles btnOne.Click
        lblFrench.Visible = True
        lblFrench.Text = "Un"
    End Sub

    Private Sub btnTwo_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
        lblFrench.Visible = True
        lblFrench.Text = "Deux"
    End Sub

    Private Sub btnThree_Click(sender As Object, e As EventArgs) Handles btnThree.Click
        lblFrench.Visible = True
        lblFrench.Text = "Trois"
    End Sub

    Private Sub btnFour_Click(sender As Object, e As EventArgs) Handles btnFour.Click
        lblFrench.Visible = True
        lblFrench.Text = "Quatre"
    End Sub

    Private Sub btnFive_Click(sender As Object, e As EventArgs) Handles btnFive.Click
        lblFrench.Visible = True
        lblFrench.Text = "Cinq"
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
