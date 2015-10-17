Public Class EmployeesCMSForm
    Dim selectedId As String
    Dim rowIndex As Integer

    Private Sub backToMainMenuBtn_Click(sender As Object, e As EventArgs) Handles backToMainMenuBtn.Click
        Me.Close()
    End Sub

    Private Sub EmployeesCMSForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        MainMenuForm.Show()
    End Sub

    Private Sub EmployeesCMSForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rowIndex = -1

        If Employee.all.Length < 1 Then
            editEmployeeBtn.Enabled = False
            deleteEmployeeBtn.Enabled = False
        End If

        viewEmployeesPage()
    End Sub

    Private Sub cancelAddEditBtn_Click(sender As Object, e As EventArgs) Handles cancelAddEditBtn.Click
        viewEmployeesPage()
    End Sub

    Private Sub viewEmployeesPage()
        populateEmployeesDataGridView(employeesDGV, Employee.all)
        employeeFormGB.Hide()
        viewEmployeesGB.Show()
        crudAddEmployeeBtn.Enabled = True

        rowIndex = -1
    End Sub

    Private Sub addEditEmployeePage(ByVal action As String)
        viewEmployeesGB.Hide()
        employeeFormGB.Show()

        If action = "add" Then
            crudAddEmployeeBtn.Enabled = False
        Else
            crudAddEmployeeBtn.Enabled = True
        End If
    End Sub

    Private Sub employeesDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles employeesDGV.CellClick
        rowIndex = e.RowIndex

        If rowIndex > -1 Then
            selectedId = employeesDGV.Item("employeeIDCol", e.RowIndex).Value
        End If
    End Sub

    Private Sub crudAddEmployeeBtn_Click(sender As Object, e As EventArgs) Handles crudAddEmployeeBtn.Click
        employeeAddEditBtn.Text = "Add Employee"
        employeeFormGB.Text = "Add Employee"

        employeeNoTB.Text = ""
        employeeLastNameTB.Text = ""
        employeeFirstNameTB.Text = ""
        employeeMiddleNameTB.Text = ""
        employeeBirthdateDTP.ResetText()
        employeeRatePerHourTB.Text = ""
        employeeTypeCB.ResetText()
        employeePasswordTB.Text = ""

        addEditEmployeePage("add")
    End Sub

    Private Sub editEmployeeBtn_Click(sender As Object, e As EventArgs) Handles editEmployeeBtn.Click
        If rowIndex > -1 Then
            employeeFormGB.Text = "Edit Employee"
            employeeAddEditBtn.Text = "Update Employee"

            employeeNoTB.Text = employeesDGV.Item("employeeNumberCol", rowIndex).Value
            employeeLastNameTB.Text = employeesDGV.Item("employeeLastNameCol", rowIndex).Value
            employeeFirstNameTB.Text = employeesDGV.Item("employeeFirstNameCol", rowIndex).Value
            employeeMiddleNameTB.Text = employeesDGV.Item("employeeMiddleNameCol", rowIndex).Value
            employeeBirthdateDTP.Value = DateTime.Parse(employeesDGV.Item("employeeBirthdateCol", rowIndex).Value)
            employeeRatePerHourTB.Text = employeesDGV.Item("employeeRatePerHourCol", rowIndex).Value
            employeeTypeCB.SelectedItem = employeesDGV.Item("employeeTypeCol", rowIndex).Value.ToString

            addEditEmployeePage("edit")
        Else
            MsgBox("Please select a record to update", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub deleteEmployeeBtn_Click(sender As Object, e As EventArgs) Handles deleteEmployeeBtn.Click
        If rowIndex > -1 Then
            Dim toDelete As String = employeesDGV.Item("employeeNumberCol", rowIndex).Value

            Dim employee As Employee = New Employee(selectedId)

            Dim message As String = employee.deleteEmployee()

            If message.ToLower.Contains("error") Then
                MsgBox(message, MsgBoxStyle.Critical)
            Else
                rowIndex = rIndex(employeesDGV, rowIndex)
                viewEmployeesPage()

                MsgBox(message, MsgBoxStyle.Information)
            End If
        Else
            MsgBox("Please select a Employee to delete", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub employeeAddEditBtn_Click(sender As Object, e As EventArgs) Handles employeeAddEditBtn.Click
        If validateInputs() = "passed" Then
            Dim action As String
            Dim message As String

            Dim empNo As Integer = Integer.Parse(employeeNoTB.Text)
            Dim empLN As String = employeeLastNameTB.Text
            Dim empFN As String = employeeFirstNameTB.Text
            Dim empMN As String = employeeMiddleNameTB.Text
            Dim empBD As String = employeeBirthdateDTP.Value.ToString("MMMM dd, yyyy")
            Dim empRPH As Decimal = Decimal.Parse(employeeRatePerHourTB.Text)
            Dim emdType As String = employeeTypeCB.SelectedItem.ToString
            Dim empPW As String = employeePasswordTB.Text

            If employeeAddEditBtn.Text = "Add Employee" Then
                action = "ADDED"
                message = Employee.addEmployee(empNo, empLN, empFN, empMN, empBD, empRPH, emdType, empPW)
            Else
                action = "UPDATED"
                Dim employee As Employee = New Employee(selectedId)
                message = employee.updateEmployee(empNo, empLN, empFN, empMN, empBD, empRPH, emdType, empPW)
            End If

            If message.ToLower.Contains("error") Then
                MsgBox(message, MsgBoxStyle.Critical)
            Else
                MsgBox(message, MsgBoxStyle.Information)
                employeePasswordTB.Text = ""
                viewEmployeesPage()
            End If
        Else
            MsgBox(validateInputs(), MsgBoxStyle.Critical)
        End If
    End Sub

    Private Function validateInputs() As String
        Dim errors As String = ""

        If employeeNoTB.Text.Trim = "" Then
            errors &= "Employee Number is blank" & vbCrLf
        Else
            If Not (IsNumeric(employeeNoTB.Text.Trim)) Then
                errors &= "Employee number data type is invalid. Should be Numeric" & vbCrLf
            End If
        End If

        If employeeLastNameTB.Text.Trim = "" Then
            errors &= "Last Name is blank" & vbCrLf
        End If

        If employeeFirstNameTB.Text.Trim = "" Then
            errors &= "First Name is blank" & vbCrLf
        End If

        If employeeRatePerHourTB.Text.Trim = "" Then
            errors &= "Rate per Hour is blank" & vbCrLf
        Else
            If Not (IsNumeric(employeeRatePerHourTB.Text.Trim)) Then
                errors &= "Rate per Hour data type is invalid. Should be Numeric" & vbCrLf
            End If
        End If

        If employeeTypeCB.SelectedIndex = -1 Then
            errors &= "Please select an Employee Type"
        End If

        If errors = "" Then
            errors = "passed"
        End If

        validateInputs = errors
    End Function
End Class