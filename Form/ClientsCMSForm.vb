Imports PBDITSoftEngCaseStudy.DatabaseConnection
Imports PBDITSoftEngCaseStudy.Client

Public Class ClientsCMSForm
    Dim selectedId As String
    Dim rowIndex As Integer

    Private Sub backToMainMenuBtn_Click(sender As Object, e As EventArgs) Handles backToMainMenuBtn.Click
        Me.Close()
    End Sub

    Private Sub ClientsCMSForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        MainMenuForm.Show()
    End Sub

    Private Sub ClientsCMSForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rowIndex = -1

        If Client.all.Length < 1 Then
            editClientBtn.Enabled = False
            deleteClientBtn.Enabled = False
        End If

        viewClientsPage()
    End Sub

    Private Sub cancelAddEditBtn_Click(sender As Object, e As EventArgs) Handles cancelAddEditBtn.Click
        viewClientsPage()
    End Sub

    Private Sub viewClientsPage()
        populateClientsDataGridView(clientsDGV, Client.all)
        viewClientsGB.Show()
        formClientGB.Hide()
        crudAddClientBtn.Enabled = True
        rowIndex = -1
    End Sub

    Private Sub addEditClientPage(ByVal action As String)
        viewClientsGB.Hide()
        formClientGB.Show()

        If action = "add" Then
            crudAddClientBtn.Enabled = False
        Else
            crudAddClientBtn.Enabled = True
        End If
    End Sub

    Private Sub clientsDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles clientsDGV.CellClick
        rowIndex = e.RowIndex

        If rowIndex > -1 Then
            selectedId = clientsDGV.Item("clientIDCol", e.RowIndex).Value
        End If
    End Sub

    Private Sub crudAddClientBtn_Click(sender As Object, e As EventArgs) Handles crudAddClientBtn.Click
        addEditClientBtn.Text = "Add Client"
        formClientGB.Text = "Add Client"

        clientCodeTB.Text = ""
        clientNameTB.Text = ""
        clientAddressTB.Text = ""
        clientCityTB.Text = ""
        clientContactPersonTB.Text = ""
        clientContactNumberTB.Text = ""

        addEditClientPage("add")
    End Sub

    Private Sub editClientBtn_Click(sender As Object, e As EventArgs) Handles editClientBtn.Click
        If rowIndex > -1 Then
            clientCodeTB.Text = clientsDGV.Item("clientCodeCol", rowIndex).Value
            clientNameTB.Text = clientsDGV.Item("clientNameCol", rowIndex).Value
            clientAddressTB.Text = clientsDGV.Item("clientAddressCol", rowIndex).Value
            clientCityTB.Text = clientsDGV.Item("clientCityCol", rowIndex).Value
            clientContactPersonTB.Text = clientsDGV.Item("clientContactPersonCol", rowIndex).Value
            clientContactNumberTB.Text = clientsDGV.Item("clientContactNumberCol", rowIndex).Value

            formClientGB.Text = "Edit Client"
            addEditClientBtn.Text = "Update Client"

            addEditClientPage("edit")
        Else
            MsgBox("Please select a record to update", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub deleteClientBtn_Click(sender As Object, e As EventArgs) Handles deleteClientBtn.Click
        If rowIndex > -1 Then
            Dim toDelete As String = clientsDGV.Item("clientCodeCol", rowIndex).Value

            Dim client As Client = New Client(selectedId)

            Dim message As String = client.deleteClient()

            If message.ToLower.Contains("error") Then
                MsgBox(message, MsgBoxStyle.Critical)
            Else
                rowIndex = rIndex(clientsDGV, rowIndex)
                viewClientsPage()

                MsgBox(message, MsgBoxStyle.Information)
            End If
        Else
            MsgBox("Please select a Client to delete", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub addEditClientBtn_Click(sender As Object, e As EventArgs) Handles addEditClientBtn.Click
        If validateInputs() = "passed" Then
            Dim action As String
            Dim message As String

            Dim cCode As String = clientCodeTB.Text
            Dim cName As String = clientNameTB.Text
            Dim cAddress As String = clientAddressTB.Text
            Dim cCity As String = clientCityTB.Text
            Dim cCP As String = clientContactPersonTB.Text
            Dim cCN As String = clientContactNumberTB.Text

            If addEditClientBtn.Text = "Add Client" Then
                action = "ADDED"
                message = Client.addClient(cCode, cName, cAddress, cCity, cCP, cCN)
            Else
                action = "UPDATED"
                Dim client As Client = New Client(selectedId)

                message = client.updateClient(cCode, cName, cAddress, cCity, cCP, cCN)
            End If

            If message.ToLower.Contains("error") Then
                MsgBox(message, MsgBoxStyle.Critical)
            Else
                MsgBox(message, MsgBoxStyle.Information)
                viewClientsPage()
            End If
        Else
            MsgBox(validateInputs(), MsgBoxStyle.Critical)
        End If
    End Sub

    Private Function validateInputs() As String
        Dim errors As String = ""

        If clientCodeTB.Text.Trim = "" Then
            errors &= "Client Code is blank" & vbCrLf
        End If

        If clientNameTB.Text.Trim = "" Then
            errors &= "Client Name is blank" & vbCrLf
        End If

        If clientAddressTB.Text.Trim = "" Then
            errors &= "Please provide a client address" & vbCrLf
        End If

        If clientContactPersonTB.Text.Trim = "" Then
            errors &= "Please provide a contact person" & vbCrLf
        End If

        If clientContactNumberTB.Text.Trim = "" Then
            errors &= "Please provide a contact number" & vbCrLf
        End If

        If errors = "" Then
            errors = "passed"
        End If

        validateInputs = errors
    End Function
End Class