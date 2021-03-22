Public Class DB_Methods
    Public Sub fnShow(sender As Form1)
        sender.dvgEmployee.Refresh() 'NOT CORRECT, SHOULD PROLLY DO A SELECT * TO REFRESH
    End Sub

    Public Sub fnDelete(userID As String)

    End Sub

    Public Sub fnInsert(userID As String, userName As String, userSalary As String, userAddress As String)

    End Sub

End Class
