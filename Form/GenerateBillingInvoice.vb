Imports System.IO

Public Class GenerateBillingInvoice
    Private eRowIndex As Integer
    Private eSelectedId As Integer

    Private cRowIndex As Integer
    Private cSelectedId As Integer = 0

    Private pRowIndex As Integer
    Private pSelectedId As Integer = 0
    Private pSelectedCode As String

    Private Sub GenerateBillingInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        step1()

        If Employee.all.Length < 1 Then
            step1NextBtn.Enabled = False
        End If
    End Sub

    Private Sub GenerateBillingInvoice_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        MainMenuForm.Show()
    End Sub

    Private Sub backToMainMenuBtn_Click(sender As Object, e As EventArgs) Handles backToMainMenuBtn.Click
        Me.Close()
    End Sub

    Private Sub step1()
        populateEmployeesDataGridView(employeesDGV, Employee.all)
        step1GB.BringToFront()
        step2GB.SendToBack()
        step3GB.SendToBack()

        eRowIndex = -1
        eSelectedId = 0
    End Sub

    Private Sub step2()
        populateClientsDataGridView(clientsDGV, Client.all)
        projectsDGV.Rows.Clear()
        step1GB.SendToBack()
        step2GB.BringToFront()
        step3GB.SendToBack()

        cRowIndex = -1
        cSelectedId = 0

        pRowIndex = -1
        pSelectedId = 0
    End Sub

    Private Sub step3()
        step1GB.SendToBack()
        step2GB.SendToBack()
        step3GB.BringToFront()
    End Sub

    Private Sub employeesDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles employeesDGV.CellClick
        eRowIndex = e.RowIndex

        If eRowIndex > -1 Then
            eSelectedId = employeesDGV.Item("employeeIDCol", e.RowIndex).Value
        End If
    End Sub

    Private Sub step1NextBtn_Click(sender As Object, e As EventArgs) Handles step1NextBtn.Click
        If eRowIndex > -1 Then
            step2()
        Else
            MsgBox("Please select an employee to continue", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub clientsDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles clientsDGV.CellClick
        cRowIndex = e.RowIndex

        If cRowIndex > -1 Then
            cSelectedId = clientsDGV.Item("clientIDCol", cRowIndex).Value
            Dim cSelectedCode As String = clientsDGV.Item("clientCodeCol", cRowIndex).Value

            Dim employee As Employee = New Employee(eSelectedId)
            populateProjectsDataGridView(projectsDGV, employee.clientsProjects(cSelectedCode), "projects")

            pRowIndex = -1
        End If
    End Sub

    Private Sub projectsDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles projectsDGV.CellClick
        pRowIndex = e.RowIndex

        If pRowIndex > -1 Then
            pSelectedId = projectsDGV.Item("projectIDCol", pRowIndex).Value
            pSelectedCode = projectsDGV.Item("projectCodeCol", pRowIndex).Value
        End If
    End Sub

    Private Sub step2NextBtn_Click(sender As Object, e As EventArgs) Handles step2NextBtn.Click
        If pRowIndex > -1 And cRowIndex > -1 Then
            step3()
            populateLabels(computeBill())
        Else
            MsgBox("Please select a client and a project to continue", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub step2BackBtn_Click(sender As Object, e As EventArgs) Handles step2BackBtn.Click
        step1()
    End Sub

    Private Function computeBill() As Decimal()
        Dim timeLogs As List(Of Decimal) = New List(Of Decimal)
        Dim rphLogs As List(Of Decimal) = New List(Of Decimal)

        Dim employee As Employee = New Employee(eSelectedId)
        Dim logs As Hashtable() = employee.getLogs(pSelectedCode)

        Dim logIns As List(Of Date) = New List(Of Date)
        Dim logOuts As List(Of Date) = New List(Of Date)

        Dim totalHoursBilled As Decimal = 0
        Dim totalHours As Decimal = 0

        For Each log In logs
            Dim day As String = Date.Parse(log.Item("log_date")).DayOfWeek.ToString.ToLower
            Dim rph As Decimal = Decimal.Parse(employee.ratePerHour)

            If log.Item("action") = "IN" Then
                logIns.Add(Date.Parse(log.Item("log_time")))
            Else
                If day = "saturday" Or day = "sunday" Then
                    rph *= 0.3
                End If

                rphLogs.Add(rph)

                logOuts.Add(Date.Parse(log.Item("log_time")))
            End If
        Next

        If logOuts.ToArray.Length() > 0 Then
            For i As Integer = 0 To logOuts.ToArray.Length() - 1
                Dim hourPerDay As Decimal = Decimal.Round(Decimal.Parse(((logOuts(i).TimeOfDay.TotalHours - logIns(i).TimeOfDay.TotalHours) - 0.3)), 2)

                If hourPerDay < 0 Then
                    hourPerDay = 0
                End If

                timeLogs.Add(hourPerDay)
            Next
        End If

        If timeLogs.ToArray.Length > 0 Then
            For i As Integer = 0 To timeLogs.ToArray.Length() - 1
                totalHoursBilled += timeLogs(i) * rphLogs(i)
                totalHours += timeLogs(i)
            Next
        End If

        computeBill = {totalHours, totalHoursBilled}
    End Function

    Private Sub resetLabels()
        billingDateLbl.Text = "Billing Date"

        clientCodeLbl.Text = "Client Code"
        clientNameLbl.Text = "Client Name"
        clientAddressLbl.Text = "Client Address"

        projectCodeLbl.Text = "Project Code"
        projectManagerLbl.Text = "Project Manager"
        projectNameLbl.Text = "Project Name"

        employeeNumberLbl.Text = "Employee number"
        employeeNameLbl.Text = "Name"
        employeeRatePerHourLbl.Text = "Rate"

        totalHoursBilledLbl.Text = "TOTAL HOURS BILLED"
        totalHoursLbl.Text = "TOTAL NO. HOURS "

        dueDateLbl.Text = "Due Date"
    End Sub

    Public Sub populateLabels(ByVal _totals As Decimal())
        billingDateLbl.Text = Date.Now.ToString("MMMM dd, yyyy")

        Dim client As Client = New Client(cSelectedId)

        clientCodeLbl.Text &= ": " & client.code
        clientNameLbl.Text &= ": " & client.name
        clientAddressLbl.Text &= ": " & client.address

        Dim project As Project = New Project(pSelectedId)

        projectCodeLbl.Text &= ": " & pSelectedCode
        projectManagerLbl.Text &= ": " & project.manager
        projectNameLbl.Text &= ": " & project.name

        Dim employee As Employee = New Employee(eSelectedId)

        employeeNumberLbl.Text = employee.employeeNumber
        employeeNameLbl.Text = employee.lastName & ", " & employee.firstName & " " & employee.middleName
        employeeRatePerHourLbl.Text = "Php " & employee.ratePerHour & "/Hour"

        totalHoursBilledLbl.Text &= ": " & _totals(0).ToString & " Hours"
        totalHoursLbl.Text &= ": " & "Php " & _totals(1).ToString

        dueDateLbl.Text &= ": " & project.endDate
    End Sub

    Private Sub step3BackBtn_Click(sender As Object, e As EventArgs) Handles step3BackBtn.Click
        step2()
        resetLabels()
    End Sub

    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        Dim dateNow As Date = Date.Now
        Dim saveFileDialog As New SaveFileDialog()

        saveFileDialog.Filter = "Text Documents (*.txt)|*.txt|All files (*.*)|*.*"
        saveFileDialog.FilterIndex = 1
        saveFileDialog.RestoreDirectory = True
        saveFileDialog.Title = "Save Billing Invoice File As"

        Dim employee As Employee = New Employee(eSelectedId)

        Dim fileName As String = employee.employeeNumber & "_"
        fileName &= dateNow.ToString("yyyymmdd") & "_"
        fileName &= dateNow.ToString("HHmmss") & "_"
        fileName &= "INVOICE.txt"

        saveFileDialog.FileName = fileName

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim sw As StreamWriter = New StreamWriter(saveFileDialog.OpenFile())

            If (sw IsNot Nothing) Then
                sw.WriteLine("{0, 50}", "ABC COMPANY")
                sw.WriteLine()
                sw.WriteLine("{0, 53}", "Billing Invoice")
                sw.WriteLine()
                sw.WriteLine(clientCodeLbl.Text & "{0, 50}", billingDateLbl.Text)
                sw.WriteLine(clientNameLbl.Text)
                sw.WriteLine(clientAddressLbl.Text)
                sw.WriteLine()
                sw.WriteLine("{0, 53}", "Billing Details")
                sw.WriteLine()
                sw.WriteLine(projectCodeLbl.Text & "{0, 40}", projectNameLbl.Text)
                sw.WriteLine(projectManagerLbl.Text)
                sw.WriteLine()
                sw.WriteLine(employeeNumberLbl.Text & "{0, 40} {1, 40}", employeeNameLbl.Text, employeeRatePerHourLbl.Text)
                sw.WriteLine()
                sw.WriteLine(totalHoursBilledLbl.Text)
                sw.WriteLine(totalHoursLbl.Text)
                sw.WriteLine(dueDateLbl.Text)
                sw.Close()
            End If
        End If
    End Sub
End Class