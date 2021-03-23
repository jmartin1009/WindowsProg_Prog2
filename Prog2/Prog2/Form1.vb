Public Class Form1
    Private db As New DB_Methods
    'Handles user clicking the show button
    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        db.fnShow(Me)
    End Sub
    'Handles user clicking the delete button
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        db.fnDelete(txtDeleteID.Text, Me)
    End Sub
    'Handles user clicking the insert button
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        db.fnInsert(txtID.Text, txtName.Text, Convert.ToInt32(txtSalary.Text), txtAddress.Text, Me)
    End Sub
End Class
