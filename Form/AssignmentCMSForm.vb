Public Class AssignmentCMSForm
    Dim empSelectedId As String
    Dim empRowIndex As Integer

    Dim ePSelectedId As String
    Dim ePRowIndex As Integer

    Dim aPSelectedId As String
    Dim aPRowIndex As Integer

    Private Sub AssignmentCMSForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populateEmployeesDataGridView(employeesDGV, Employee.all)

        empRowIndex = -1
    End Sub

    Private Sub backToMainMenuBtn_Click(sender As Object, e As EventArgs) Handles backToMainMenuBtn.Click
        Me.Close()
    End Sub

    Private Sub AssignmentCMSForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        MainMenuForm.Show()
    End Sub

    Private Sub employeesDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles employeesDGV.CellClick
        empRowIndex = e.RowIndex

        If empRowIndex > -1 Then
            empSelectedId = employeesDGV.Item("employeeIDCol", empRowIndex).Value
            populateExistingProjects()
            populateAvailableProjects()
        End If
    End Sub

    Private Sub populateExistingProjects()
        Dim employee As Employee = New Employee(empSelectedId)

        populateProjectsDataGridView(existingProjectsDGV, employee.existingProjects(), "existingProjects")

        ePRowIndex = -1
    End Sub

    Private Sub existingProjectsDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles existingProjectsDGV.CellClick
        ePRowIndex = e.RowIndex

        If ePRowIndex > -1 Then
            ePSelectedId = existingProjectsDGV.Item("existingProjectsIDCol", ePRowIndex).Value
        End If
    End Sub

    Private Sub populateAvailableProjects()
        Dim employee As Employee = New Employee(empSelectedId)
        populateProjectsDataGridView(availableProjectsDGV, employee.availableProjects(), "availableProjects")

        aPRowIndex = -1
    End Sub

    Private Sub availableProjectsDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles availableProjectsDGV.CellClick
        aPRowIndex = e.RowIndex

        If aPRowIndex > -1 Then
            aPSelectedId = availableProjectsDGV.Item("availableProjectsIDCol", aPRowIndex).Value
        End If
    End Sub

    Private Sub assignBtn_Click(sender As Object, e As EventArgs) Handles assignBtn.Click
        Dim employee As Employee = New Employee(empSelectedId)

        If aPSelectedId = "" Then
            MsgBox("Please select a project to assign", MsgBoxStyle.Critical)
        Else
            result(employee.assignTo(aPSelectedId), "a")
        End If
    End Sub

    Private Sub unassignBtn_Click(sender As Object, e As EventArgs) Handles unassignBtn.Click
        Dim employee As Employee = New Employee(empSelectedId)

        If ePSelectedId = "" Then
            MsgBox("Please select a project to unassign", MsgBoxStyle.Critical)
        Else
            result(employee.unassignTo(ePSelectedId), "u")
        End If
    End Sub

    Private Sub result(ByVal _message As String, ByVal _sender As String)
        If _message.ToLower.Contains("error") Then
            MsgBox(_message, MsgBoxStyle.Critical)
        Else
            populateAvailableProjects()
            populateExistingProjects()

            If _sender = "u" Then
                aPRowIndex = rIndex(availableProjectsDGV, aPRowIndex)
            Else
                ePRowIndex = rIndex(existingProjectsDGV, ePRowIndex)
            End If

            MsgBox(_message, MsgBoxStyle.Information)
        End If

        ePSelectedId = ""
        aPSelectedId = ""
    End Sub
End Class