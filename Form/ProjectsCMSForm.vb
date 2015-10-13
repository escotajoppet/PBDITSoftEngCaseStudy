Public Class ProjectsCMSForm
    Dim projectClientCode As String
    Dim selectedId As String
    Dim rowIndex As Integer

    Private Sub ProjectsCMSForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim temp As String = InputBox("Set Client CODE", "Client Code", " ")

        If temp = " " Then
            MsgBox("Error: please enter a client code to continue", MsgBoxStyle.Exclamation)
            ProjectsCMSForm_Load(sender, e)
        ElseIf temp = "" Then
            Me.Close()
        Else
            If Client.exists(temp) Then
                projectClientCode = temp
                viewProjectsPage()
            Else
                MsgBox("Error: Client Code does not exist", MsgBoxStyle.Critical)
                ProjectsCMSForm_Load(sender, e)
            End If
        End If
    End Sub

    Private Sub backToMainMenuBtn_Click(sender As Object, e As EventArgs) Handles backToMainMenuBtn.Click
        Me.Close()
    End Sub

    Private Sub ProjectsCMSForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        MainMenuForm.Show()
    End Sub

    Private Sub cancelAddEditBtn_Click(sender As Object, e As EventArgs) Handles cancelAddEditBtn.Click
        viewProjectsPage()
    End Sub

    Private Sub crudViewEmployeesBtn_Click(sender As Object, e As EventArgs)
        viewProjectsPage()
    End Sub

    Private Sub viewProjectsPage()
        clientCodeLbl.Text = projectClientCode

        populateProjectsDataGridView(projectsDGV, Project.findByClient(projectClientCode), "projects")
        projectFormGB.Hide()
        viewProjectsGB.Show()
        crudAddProjectBtn.Enabled = True
        rowIndex = -1
    End Sub

    Private Sub addEditProjectPage(ByVal action As String)
        projectFormGB.Show()
        viewProjectsGB.Hide()

        If action = "add" Then
            crudAddProjectBtn.Enabled = False
        Else
            crudAddProjectBtn.Enabled = True
        End If
    End Sub

    Private Sub projectsDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles projectsDGV.CellClick
        rowIndex = e.RowIndex

        If rowIndex > -1 Then
            selectedId = projectsDGV.Item("projectIDCol", rowIndex).Value
        End If
    End Sub

    Private Sub crudAddProjectBtn_Click(sender As Object, e As EventArgs) Handles crudAddProjectBtn.Click
        addEditProjectBtn.Text = "Add Project"
        projectFormGB.Text = "Add Project"

        projectCodeTB.Text = ""
        projectNameTB.Text = ""
        projectManagerTB.Text = ""
        projectStartDTP.ResetText()
        projectEndDTP.ResetText()

        addEditProjectPage("add")
    End Sub

    Private Sub projectEditBtn_Click(sender As Object, e As EventArgs) Handles projectEditBtn.Click
        If rowIndex > -1 Then
            projectCodeTB.Text = projectsDGV.Item("projectCodeCol", rowIndex).Value
            projectNameTB.Text = projectsDGV.Item("projectNameCol", rowIndex).Value
            projectManagerTB.Text = projectsDGV.Item("projectManagerCol", rowIndex).Value
            projectStartDTP.Value = DateTime.Parse(projectsDGV.Item("projectStartCol", rowIndex).Value)
            projectEndDTP.Value = DateTime.Parse(projectsDGV.Item("projectEndCol", rowIndex).Value)

            projectFormGB.Text = "Edit Project"
            addEditProjectBtn.Text = "Update Project"

            addEditProjectPage("edit")
        Else
            MsgBox("Please select a record to update", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub projectDeleteBtn_Click(sender As Object, e As EventArgs) Handles projectDeleteBtn.Click
        If rowIndex > -1 Then
            Dim toDelete As String = projectsDGV.Item("projectCodeCol", rowIndex).Value

            Dim project As Project = New Project(selectedId)

            Dim message As String = project.deleteProject()

            If message.ToLower.Contains("error") Then
                MsgBox(message, MsgBoxStyle.Critical)
            Else
                rowIndex = rIndex(projectsDGV, rowIndex)
                viewProjectsPage()

                MsgBox(message, MsgBoxStyle.Information)
            End If
        Else
            MsgBox("Please select a record to delete", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub addEditProjectBtn_Click(sender As Object, e As EventArgs) Handles addEditProjectBtn.Click
        If validateInputs() = "passed" Then
            Dim action As String
            Dim message As String

            Dim projCode As String = projectCodeTB.Text
            Dim projName As String = projectNameTB.Text
            Dim projManager As String = projectManagerTB.Text
            Dim projSDate As String = projectStartDTP.Value.ToString("MMMM dd, yyyy")
            Dim projEDate As String = projectEndDTP.Value.ToString("MMMM dd, yyyy")

            If addEditProjectBtn.Text = "Add Project" Then
                action = "ADDED"
                message = Project.addProject(projCode, projName, projManager, projSDate, projEDate, projectClientCode)
            Else
                action = "UPDATED"
                Dim project As Project = New Project(selectedId)
                message = project.updateProject(projCode, projName, projManager, projSDate, projEDate)
            End If

            If message.ToLower.Contains("error") Then
                MsgBox(message, MsgBoxStyle.Critical)
            Else
                MsgBox(message, MsgBoxStyle.Information)
                viewProjectsPage()
            End If
        Else
            MsgBox(validateInputs(), MsgBoxStyle.Critical)
        End If
    End Sub

    Private Function validateInputs() As String
        Dim errors As String = ""

        If projectCodeTB.Text.Trim = "" Then
            errors &= "Project Code is blank" & vbCrLf
        End If

        If projectNameTB.Text.Trim = "" Then
            errors &= "Project Name is blank" & vbCrLf
        End If

        If projectManagerTB.Text.Trim = "" Then
            errors &= "Project Manager is blank" & vbCrLf
        End If

        If Date.Parse(projectStartDTP.Value) >= Date.Parse(projectEndDTP.Value) Then
            errors &= "Project End date should be greater than the Project Starting date"
        End If

        If errors = "" Then
            errors = "passed"
        End If

        validateInputs = errors
    End Function
End Class