Imports System.Security.Cryptography
Imports System.Text

Module Tools
    Public Function rIndex(ByVal _dgv As DataGridView, ByVal _i As Integer) As Integer
        If _dgv.Rows.Count > 1 Then
            If _i = 0 Then
                rIndex = 0
            Else
                rIndex -= 1
            End If
        Else
            rIndex = -1
        End If
    End Function

    Public Function generateHash(ByVal _str As String) As String
        Dim md5Obj As MD5 = MD5.Create()
        Dim byteObj As Byte() = md5Obj.ComputeHash(Encoding.Default.GetBytes(_str))
        Dim builder As New StringBuilder()

        For i As Integer = 0 To byteObj.Length - 1
            builder.Append(byteObj(i).ToString("x2"))
        Next

        generateHash = builder.ToString
    End Function

    Public Function timePast345PM() As Boolean
        Dim now As Integer = Date.Now.Hour

        If now >= 8 And now <= 15 Then
            If now = 15 Then
                If Date.Now.Minute > 45 Then
                    timePast345PM = True
                Else
                    timePast345PM = False
                End If
            Else
                timePast345PM = False
            End If
        Else
            timePast345PM = True
        End If
    End Function

    Public Sub populateDataGridViewColumns(ByVal dgv As DataGridView, ByVal entity As String)
        dgv.Columns.Clear()

        Dim columnNames As String() = {}
        Dim headerNames As String() = {}

        Select Case entity
            Case "Employees"
                columnNames = {"employeeIDCol", "employeeNumberCol", "employeeLastNameCol", "employeeFirstNameCol", "employeeMiddleNameCol", "employeeBirthdateCol", "employeeRatePerHourCol", "employeeTypeCol"}
                headerNames = {"ID", "Employee Number", "Last Name", "First Name", "Middle Name", "Birthdate", "Rate/Hour", "Type"}
            Case "Clients"
                columnNames = {"clientIDCol", "clientCodeCol", "clientNameCol", "clientAddressCol", "clientCityCol", "clientContactPersonCol", "clientContactNumberCol"}
                headerNames = {"ID", "Client Code", "Client Name", "Address", "City", "Contact Person", "Contact Number"}
            Case "Projects"
                columnNames = {"projectIDCol", "projectCodeCol", "projectNameCol", "projectManagerCol", "projectStartCol", "projectEndCol", "projectClientCodeCol"}
                headerNames = {"ID", "Project Code", "Project Name", "Project Manager", "Start Date", "End Date", "Client Code"}
        End Select

        Dim col As DataGridViewTextBoxColumn

        For i As Integer = 0 To columnNames.Length - 1
            col = New DataGridViewTextBoxColumn

            col.Name = columnNames(i)
            col.HeaderText = headerNames(i)
            col.MinimumWidth = 120

            If i = 0 Then
                col.Visible = False
            End If

            dgv.Columns.Add(col)
        Next
    End Sub

    Public Sub populateEmployeesDataGridView(ByVal _dgv As DataGridView, ByVal _employees As Hashtable())
        Dim columns As String() = {"employeeIDCol", "employeeNumberCol", "employeeLastNameCol", "employeeFirstNameCol", "employeeMiddleNameCol", "employeeBirthdateCol", "employeeRatePerHourCol", "employeeTypeCol"}
        Dim items As String() = {"id", "employee_number", "last_name", "first_name", "middle_name", "birthdate", "rate_per_hour", "type"}

        populateDGV(_dgv, columns, items, _employees)
    End Sub

    Public Sub populateClientsDataGridView(ByVal _dgv As DataGridView, ByVal _clients As Hashtable())
        Dim columns As String() = {"clientIDCol", "clientCodeCol", "clientNameCol", "clientAddressCol", "clientCityCol", "clientContactPersonCol", "clientContactNumberCol"}
        Dim items As String() = {"id", "client_code", "client_name", "address", "city", "contact_person", "contact_number"}

        populateDGV(_dgv, columns, items, _clients)
    End Sub

    Public Sub populateProjectsDataGridView(ByVal _dgv As DataGridView, ByVal _projects As Hashtable(), ByVal _type As String)
        Dim columns As String() = {}
        Dim items As String() = {"id", "project_code", "project_name", "manager", "start_date", "end_date", "client_code"}

        Select Case _type
            Case "projects"
                columns = {"projectIDCol", "projectCodeCol", "projectNameCol", "projectManagerCol", "projectStartCol", "projectEndCol", "projectClientCodeCol"}
            Case "existingProjects"
                columns = {"existingProjectsIDCol", "existingProjectsCodeCol", "existingProjectsNameCol", "existingProjectsManagerCol", "existingProjectsStartCol", "existingProjectsEndCol", "existingProjectsClientCodeCol"}
            Case "availableProjects"
                columns = {"availableProjectsIDCol", "availableProjectsCodeCol", "availableProjectsNameCol", "availableProjectsManagerCol", "availableProjectsStartCol", "availableProjectsEndCol", "availableProjectsClientCodeCol"}
        End Select

        populateDGV(_dgv, columns, items, _projects)
    End Sub

    Private Sub populateDGV(ByVal _dgv As DataGridView, ByVal _columns As String(), ByVal _items As String(), ByVal _records As Hashtable())
        Dim index As Integer = 0

        _dgv.Rows.Clear()
        _dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        For Each record In _records
            index = _dgv.Rows.Add

            For i As Integer = 0 To _columns.Length - 1
                _dgv.Item(_columns(i), index).Value = record.Item(_items(i))
            Next
        Next

        If _dgv.Rows.Count > 0 Then
            _dgv.CurrentCell.Selected = False
        End If
    End Sub
End Module