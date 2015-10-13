Imports System.Data.OleDb

Public Class Project
    Public Property id As Integer
    Public Property code As String
    Public Property name As String
    Public Property manager As String
    Public Property startDate As String
    Public Property endDate As String
    Public Property clientCode As String

    Public Sub New(ByVal _id As Integer)
        Dim table As String = "projects"
        Dim fields As String = "[project_code], [project_name], [manager], [start_date], [end_date], [client_code]"
        Dim condition As String = "[id]=" & _id

        Dim recordReader As OleDbDataReader = selectQuery(table, fields, condition)

        While recordReader.Read() = True
            Me.id = _id
            Me.code = recordReader.Item("project_code")
            Me.name = recordReader.Item("project_name")
            Me.manager = recordReader.Item("manager")
            Me.startDate = recordReader.Item("start_date")
            Me.endDate = recordReader.Item("end_date")
            Me.clientCode = recordReader.Item("client_code")
        End While

        recordReader.Close()
    End Sub

    Public Shared Function findByClient(ByVal _clientCode As String) As Hashtable()
        findByClient = getProjects("[client_code]='" & _clientCode & "'")
    End Function

    Public Shared Function all() As Hashtable()
        all = getProjects("1")
    End Function

    Public Shared Function search(ByVal _condition As String) As Hashtable()
        search = getProjects(_condition)
    End Function

    Public Shared Function addProject(ByVal _projectCode As String, ByVal _projectName As String, ByVal _manager As String, ByVal _startDate As String, ByVal _endDate As String, ByVal _clientCode As String) As String
        Dim table As String = "projects"
        Dim fields As String = "[project_code], [project_name], [manager], [start_date], [end_date], [client_code]"
        Dim values As String = "'" & _projectCode & "', '" & _projectName & "', '" & _manager & "', '" & _startDate & "', '" & _endDate & "', '" & _clientCode & "'"

        If addQuery(table, fields, values) Then
            addProject = "Project ADDED: " & _projectCode
        Else
            addProject = "Error Adding Project"
        End If
    End Function

    Public Function updateProject(ByVal _projectCode As String, ByVal _projectName As String, ByVal _manager As String, ByVal _startDate As String, ByVal _endDate As String) As String
        Dim table As String = "projects"
        Dim fields As String() = {"project_code", "project_name", "manager", "start_date", "end_date"}
        Dim values As String() = {"'" & _projectCode & "'", "'" & _projectName & "'", "'" & _manager & "'", "'" & _startDate & "'", "'" & _endDate & "'"}
        Dim condition As String = "id=" & Me.id

        If updateQuery(table, fields, values, condition) Then
            updateProject = "Project UPDATED: " & Me.code
        Else
            updateProject = "Error Updating Project"
        End If
    End Function

    Public Function deleteProject() As String
        Dim table As String = "projects"
        Dim condition As String = "id=" & Me.id

        If deleteQuery(table, condition) Then
            deleteProject = "Project DELETED: " & Me.code
        Else
            deleteProject = "Error Deleting Project"
        End If
    End Function

    Public Function employees() As Hashtable()
        Dim employee_ids As String() = getEmployeeIds()

        If employee_ids.ToArray.Length > 0 Then
            Dim condition = "[id] IN (" & Join(employee_ids.ToArray, ", ") & ")"
            employees = Employee.search(condition)
        Else
            employees = {}
        End If
    End Function

    Public Function getEmployeeIds() As String()
        Dim table As String = "employees_projects"
        Dim fields As String = "[employee_id]"
        Dim condition As String = "[project_id]=" & Me.id

        Dim recordReader As OleDbDataReader = selectQuery(table, fields, condition)

        Dim employee_ids As List(Of String) = New List(Of String)

        While recordReader.Read() = True
            employee_ids.Add(recordReader.Item("employee_id"))
        End While

        getEmployeeIds = employee_ids.ToArray
    End Function

    ' private methods

    Private Shared Function getProjects(ByVal _condition As String) As Hashtable()
        Dim table As String = "projects"
        Dim fields As String = "[id], [project_code], [project_name], [manager], [start_date], [end_date], [client_code]"

        Dim recordReader As OleDbDataReader = selectQuery(table, fields, _condition)

        Dim record As Hashtable
        Dim records As List(Of Hashtable) = New List(Of Hashtable)

        While recordReader.Read() = True
            record = New Hashtable

            record.Add("id", recordReader.Item("id"))
            record.Add("project_code", recordReader.Item("project_code"))
            record.Add("project_name", recordReader.Item("project_name"))
            record.Add("manager", recordReader.Item("manager"))
            record.Add("start_date", recordReader.Item("start_date"))
            record.Add("end_date", recordReader.Item("end_date"))
            record.Add("client_code", recordReader.Item("client_code"))

            records.Add(record)
        End While

        getProjects = records.ToArray

        recordReader.Close()
    End Function
End Class
