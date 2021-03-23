Imports System
Imports System.Data
Imports System.Data.OleDb
Public Class DB_Methods
    Private conFlag As Boolean = False
    Private con As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\employeeDB.mdb")
    Public Sub fnShow(sender As Form1)
        'sender.dvgEmployee.Refresh() 'NOT CORRECT, SHOULD PROLLY DO A SELECT * TO REFRESH
        connectionCheck()
    End Sub

    Public Sub fnDelete(userID As String)

    End Sub

    Public Sub fnInsert(userID As String, userName As String, userSalary As String, userAddress As String)

    End Sub

    Public Sub connectionCheck()
        If (conFlag = False) Then
            con.Open()
            conFlag = True
        End If
        Try
            If con.State = ConnectionState.Open Then
                MsgBox("Connected")
            Else
                Throw New Exception("Database Connection failed")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class
