Public Class MainMenuForm

    Private Sub employeesCMSBtn_Click(sender As Object, e As EventArgs) Handles employeesCMSBtn.Click
        Me.Hide()
        EmployeesCMSForm.Show()
    End Sub

    Private Sub clientsCMSBtn_Click(sender As Object, e As EventArgs) Handles clientsCMSBtn.Click
        Me.Hide()
        ClientsCMSForm.Show()
    End Sub

    Private Sub projectsCMStBtn_Click(sender As Object, e As EventArgs) Handles projectsCMStBtn.Click
        Me.Hide()
        ProjectsCMSForm.Show()
    End Sub

    Private Sub assignEmployeeBtn_Click(sender As Object, e As EventArgs) Handles assignEmployeeBtn.Click
        Me.Hide()
        AssignmentCMSForm.Show()
    End Sub

    Private Sub logInOutBtn_Click(sender As Object, e As EventArgs) Handles logInOutBtn.Click
        Me.Hide()
        LogInOutForm.Show()
    End Sub

    Private Sub searchBtn_Click(sender As Object, e As EventArgs) Handles searchBtn.Click
        Me.Hide()
        SearchForm.Show()
    End Sub

    Private Sub generateBillingInvoiceBtn_Click(sender As Object, e As EventArgs) Handles generateBillingInvoiceBtn.Click
        Me.Hide()
        GenerateBillingInvoice.Show()
    End Sub

    Private Sub MainMenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' for testing purposes only :)
    End Sub
End Class












