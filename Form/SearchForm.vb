Public Class SearchForm
    Private Sub SearchForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        searchCB.SelectedIndex = 0
        populateByCB()
    End Sub

    Private Sub SearchForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        MainMenuForm.Show()
    End Sub

    Private Sub backToMainMenuBtn_Click(sender As Object, e As EventArgs) Handles backToMainMenuBtn.Click
        Me.Close()
    End Sub

    Private Sub searchCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles searchCB.SelectedIndexChanged
        populateByCB()
        search()
    End Sub

    Private Sub byCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles byCB.SelectedIndexChanged
        search()
    End Sub

    Private Sub search()
        populateSearchResultsDGVColumn()
        populateSearchResultsDGVRow()
    End Sub

    Private Sub populateByCB()
        byCB.Items.Clear()

        Dim cbItems As String() = {}

        Select Case searchCB.SelectedItem.ToString
            Case "Employees"
                cbItems = {"Employee Number", "Last Name", "First Name", "Birthdate", "Employee Type"}
            Case "Clients"
                cbItems = {"City", "Client Code", "Client Name"}
            Case "Projects"
                cbItems = {"Project Code", "Project Name", "Manager", "Client Code"}
        End Select

        For i As Integer = 0 To cbItems.Length - 1
            byCB.Items.Add(cbItems(i))
        Next

        byCB.SelectedIndex = 0
    End Sub

    Private Sub searchTB_KeyUp(sender As Object, e As KeyEventArgs) Handles searchTB.KeyUp
        populateSearchResultsDGVRow()
    End Sub

    Private Sub populateSearchResultsDGVColumn()
        populateDataGridViewColumns(searchResultsDGV, searchCB.SelectedItem.ToString)
    End Sub

    Private Sub populateSearchResultsDGVRow()
        Dim keyword As String = searchTB.Text
        Dim field As String = byCB.SelectedItem.ToString
        Dim condition As String

        If keyword.Length > 2 Then
            condition = "[" & field.Replace(" ", "_").ToLower & "] LIKE '%" & keyword & "%'"
        Else
            condition = "1"
        End If

        Select Case searchCB.SelectedItem.ToString
            Case "Employees"
                populateEmployeesDataGridView(searchResultsDGV, Employee.search(condition))
            Case "Clients"
                populateClientsDataGridView(searchResultsDGV, Client.search(condition))
            Case "Projects"
                populateProjectsDataGridView(searchResultsDGV, Project.search(condition), "projects")
        End Select
    End Sub
End Class