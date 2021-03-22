Public Class Form1
    Private db As New DB_Methods
    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        db.fnShow(Me)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        db.fnDelete(txtDeleteID.Text)
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        db.fnInsert(txtID.Text, txtName.Text, txtSalary.Text, txtAddress.Text)
    End Sub
End Class
