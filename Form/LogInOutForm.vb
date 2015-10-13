Public Class LogInOutForm
    Dim selectedId As String
    Dim rowIndex As Integer

    Dim employeeId As Integer

    Private Sub LogInOutForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If timePast345PM() Then
            activateLogoutGB()
            formLogInBtn.Enabled = False
            MsgBox("Can't log in anymore. The time has past 3:45 PM", MsgBoxStyle.Information)
        Else
            activateLoginGB()
        End If
    End Sub

    Private Sub LogInOutForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        MainMenuForm.Show()
    End Sub

    Private Sub backToMainMenuBtn_Click(sender As Object, e As EventArgs) Handles backToMainMenuBtn.Click
        Me.Close()
    End Sub

    Private Sub formLogInBtn_Click(sender As Object, e As EventArgs) Handles formLogInBtn.Click
        activateLoginGB()
    End Sub

    Private Sub formLogOutBtn_Click(sender As Object, e As EventArgs) Handles formLogOutBtn.Click
        activateLogoutGB()
    End Sub

    Private Sub activateLoginGB()
        logOutGB.SendToBack()
        logInGB.BringToFront()
        formLogInBtn.Enabled = False
        formLogOutBtn.Enabled = True
    End Sub

    Private Sub activateLogoutGB()
        logInGB.SendToBack()
        logOutGB.BringToFront()
        formLogInBtn.Enabled = True
        formLogOutBtn.Enabled = False
    End Sub

    Private Sub resetFields()
        logInEmployeeNumberTB.Clear()
        logInEmployeePasswordTB.Clear()
        logoutEmployeeNumberTB.Clear()
        logoutEmployeePasswordTB.Clear()
        employeesProjectsDGV.Rows.Clear()

        selectedId = ""
        rowIndex = -1
        employeeId = 0
    End Sub

    Private Sub viewProjectsBtn_Click(sender As Object, e As EventArgs) Handles viewProjectsBtn.Click
        If validateLoginInputs() = "passed" Then
            Dim employeeNumber As Integer = Integer.Parse(logInEmployeeNumberTB.Text)
            employeeId = Employee.getId(employeeNumber)

            Dim message As String

            If employeeId > 0 Then
                Dim employee As Employee = New Employee(employeeId)

                message = employee.authenticated(employeeNumber, generateHash(logInEmployeePasswordTB.Text))

                If message = "" Then
                    Dim existingProjects As Hashtable() = employee.existingProjects()

                    If existingProjects.Length > 0 Then
                        populateProjectsDataGridView(employeesProjectsDGV, existingProjects, "projects")
                    Else
                        MsgBox("The Employee does not have eny projects yet", MsgBoxStyle.Information)
                    End If
                Else
                    MsgBox(message, MsgBoxStyle.Critical)
                End If
            Else
                MsgBox("Error: Employee Number does not exist", MsgBoxStyle.Critical)
            End If
        Else
            MsgBox(validateLoginInputs(), MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub employeesProjectsDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles employeesProjectsDGV.CellClick
        rowIndex = e.RowIndex

        If rowIndex > -1 Then
            selectedId = employeesProjectsDGV.Item("projectIDCol", rowIndex).Value
        End If
    End Sub

    Private Sub logInBtn_Click(sender As Object, e As EventArgs) Handles logInBtn.Click
        If rowIndex > -1 Then
            Dim employeeNumber As Integer = Integer.Parse(logInEmployeeNumberTB.Text)
            Dim employee As Employee = New Employee(employeeId)

            Dim message As String = employee.authenticated(employeeNumber, generateHash(logInEmployeePasswordTB.Text))

            If message = "" Then
                message = employee.logIn(selectedId)
                If message.ToLower.Contains("error") Then
                    MsgBox(message, MsgBoxStyle.Critical)
                Else
                    resetFields()

                    MsgBox(message, MsgBoxStyle.Information)
                End If
            Else
                MsgBox(message, MsgBoxStyle.Critical)
            End If
        Else
            MsgBox("Please select a Project before loggin in", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Function validateLoginInputs() As String
        Dim errors As String = ""

        If logInEmployeeNumberTB.Text = "" Then
            errors &= "Provide an employee number to log in" & vbCrLf
        Else
            If Not IsNumeric(logInEmployeeNumberTB.Text) Then
                errors &= "Employee number should be numeric" & vbCrLf
            End If
        End If

        If logInEmployeePasswordTB.Text = "" Then
            errors &= "Provide a password to log in" & vbCrLf
        End If

        If errors = "" Then
            errors = "passed"
        End If

        validateLoginInputs = errors
    End Function

    Private Sub logOutBtn_Click(sender As Object, e As EventArgs) Handles logOutBtn.Click
        If validateLogoutInputs() = "passed" Then
            Dim employeeNumber As Integer = Integer.Parse(logoutEmployeeNumberTB.Text)
            employeeId = Employee.getId(employeeNumber)

            If employeeId > 0 Then
                Dim employee As Employee = New Employee(employeeId)

                Dim message As String = employee.authenticated(employeeNumber, generateHash(logoutEmployeePasswordTB.Text))

                If message = "" Then
                    message = employee.logOut()
                    If message.ToLower.Contains("error") Then
                        MsgBox(message, MsgBoxStyle.Critical)
                    Else
                        resetFields()

                        MsgBox(message, MsgBoxStyle.Information)
                    End If
                Else
                    MsgBox(message, MsgBoxStyle.Critical)
                End If
            Else
                MsgBox("Error: Employee Number does not exist", MsgBoxStyle.Critical)
            End If
        Else
            MsgBox(validateLogoutInputs(), MsgBoxStyle.Critical)
        End If
    End Sub

    Private Function validateLogoutInputs() As String
        Dim errors As String = ""

        If logoutEmployeeNumberTB.Text = "" Then
            errors &= "Provide an employee number to log out" & vbCrLf
        Else
            If Not IsNumeric(logoutEmployeeNumberTB.Text) Then
                errors &= "Employee number should be numeric" & vbCrLf
            End If
        End If

        If logoutEmployeePasswordTB.Text = "" Then
            errors &= "Provide a password to log out" & vbCrLf
        End If

        If errors = "" Then
            errors = "passed"
        End If

        validateLogoutInputs = errors
    End Function
End Class