Imports System.Data.OleDb

Public Class Employee
    Public Property id As Integer
    Public Property employeeNumber As Integer
    Public Property lastName As String
    Public Property firstName As String
    Public Property middleName As String
    Public Property birthdate As String
    Public Property ratePerHour As Decimal
    Public Property type As String
    Public Property password As String

    Public Sub New(ByVal _id As Integer)
        Dim table As String = "employees"
        Dim fields As String = "[id], [employee_number], [last_name], [first_name], [middle_name], [birthdate], [rate_per_hour], [employee_type], [password]"
        Dim condition As String = "[id]=" & _id

        Dim recordReader As OleDbDataReader = selectQuery(table, fields, condition)

        While recordReader.Read() = True
            Me.id = _id
            Me.employeeNumber = recordReader.Item("employee_number")
            Me.lastName = recordReader.Item("last_name")
            Me.firstName = recordReader.Item("first_name")
            Me.middleName = recordReader.Item("middle_name")
            Me.birthdate = recordReader.Item("birthdate")
            Me.ratePerHour = Decimal.Parse(recordReader.Item("rate_per_hour"))
            Me.type = recordReader.Item("employee_type")
        End While

        recordReader.Close()
    End Sub

    Public Shared Function all() As Hashtable()
        all = getEmployees("1")
    End Function

    Public Shared Function search(ByVal _condition As String) As Hashtable()
        search = getEmployees(_condition)
    End Function

    Public Shared Function getId(ByVal _employeeNumber As Integer) As Integer
        Dim table As String = "employees"
        Dim fields As String = "[id]"
        Dim condition As String = "[employee_number]=" & _employeeNumber

        Dim recordReader As OleDbDataReader = selectQuery(table, fields, condition)

        getId = 0

        While recordReader.Read = True
            getId = Integer.Parse(recordReader.Item("id"))
        End While
    End Function

    Public Function existingProjects() As Hashtable()
        Dim project_ids As String() = projects()
        Dim condition As String = "[id] IN (" & Join(project_ids.ToArray, ", ") & ")"

        existingProjects = someonesProjects(condition, project_ids, False)
    End Function

    Public Function availableProjects() As Hashtable()
        Dim project_ids As String() = projects()
        Dim condition As String = "[id] NOT IN (" & Join(project_ids.ToArray, ", ") & ")"

        availableProjects = someonesProjects(condition, project_ids, True)
    End Function

    Public Function clientsProjects(ByVal _clientCode As String) As Hashtable()
        Dim project_ids As String() = projects()
        Dim condition As String = "[id] IN (" & Join(project_ids.ToArray, ", ") & ") AND [client_code]='" & _clientCode & "'"

        clientsProjects = someonesProjects(condition, project_ids, False)
    End Function

    Public Function assignTo(ByVal _projectId As Integer) As String
        If conflict(_projectId) Then
            assignTo = "Error Assigning Employee: Selected project will conflict to one of your existing projects"
        Else
            Dim table As String = "employees_projects"
            Dim fields As String = "[employee_id], [project_id]"
            Dim values As String = Me.id & ", " & _projectId

            Dim project As Project = New Project(_projectId)

            If addQuery(table, fields, values) Then
                assignTo = Me.employeeNumber & " is now in the project " & project.code
            Else
                assignTo = "Error Assigning Employee"
            End If
        End If
    End Function

    Public Function unassignTo(ByVal _projectId As Integer) As String
        Dim table As String = "employees_projects"
        Dim condition As String = "[employee_id]=" & Me.id & " AND [project_id]=" & _projectId.ToString

        Dim project As Project = New Project(_projectId)

        If deleteQuery(table, condition) Then
            unassignTo = Me.employeeNumber & " is now out of the project " & project.code
        Else
            unassignTo = "Error Unassigning Employee"
        End If
    End Function

    Public Function authenticated(ByVal _employeeNumber As Integer, ByVal _password As String) As String
        Dim recordReader As OleDbDataReader

        Dim table As String = "employees"
        Dim fields As String = "[id]"
        Dim condition As String = "[employee_number]=" & _employeeNumber.ToString & " AND [password]='" & _password & "'"

        recordReader = selectQuery(table, fields, condition)

        If recordReader.HasRows Then
            Me.password = _password
            authenticated = ""
        Else
            authenticated = "Error Authentication: Employee Number and Password do not match"
        End If

        recordReader.Close()
    End Function

    Public Function logIn(ByVal _selectedProjectId As Integer) As String
        Dim log As Hashtable = lastLog()

        If log.Item("action") = "OUT" Or log.Item("action") = "" Then
            Dim recordReader As OleDbDataReader

            Dim table As String = "projects"
            Dim fields As String = "[project_code], [project_name]"
            Dim condition As String = "[id]=" & _selectedProjectId

            Dim projectCode As String = ""
            Dim projectName As String = ""

            recordReader = selectQuery(table, fields, condition)

            While recordReader.Read() = True
                projectCode = recordReader.Item("project_code")
                projectName = recordReader.Item("project_name")
            End While

            table = "logs"
            fields = "[employee_number], [action], [project_code], [project_name], [log_date], [log_time]"
            Dim values As String = Me.employeeNumber & ", 'IN', '" & projectCode & "', '" & projectName & "', '" & Date.Now.ToString("MMMM dd, yyyy") & "', '" & Date.Now.ToString("hh:mm:ss tt") & "'"

            If addQuery(table, fields, values) Then
                logIn = Me.employeeNumber & " successfully logged into project " & projectName
            Else
                logIn = "Error Logging In"
            End If
        Else
            logIn = "You are currently logged into project " & log.Item("project") & vbCrLf & "You must log out first"
        End If
    End Function

    Public Function logOut() As String
        Dim log As Hashtable = lastLog()

        If log.Item("action") = "IN" Then
            Dim table As String = "logs"
            Dim fields As String = "[employee_number], [action], [project_code], [project_name] [log_date], [log_time]"
            Dim values As String = Me.employeeNumber & ", 'OUT', '" & log.Item("project_code") & "', '" & log.Item("project_name") & "', '" & Date.Now.ToString("MMMM dd, yyyy") & "', '" & Date.Now.ToString("hh:mm:ss tt") & "'"

            If addQuery(table, fields, values) Then
                logOut = Me.employeeNumber & " successfully logged out of project " & log.Item("project")
            Else
                logOut = "Error Logging Out"
            End If
        Else
            logOut = "You are not logged in yet" & vbCrLf & "You must log in first"
        End If
    End Function

    Public Function getLogs(ByVal _projectCode As String) As Hashtable()
        Dim recordReader As OleDbDataReader

        Dim table = "logs"
        Dim fields = "[id], [employee_number], [action], [project_code], [project_name], [log_date], [log_time]"
        Dim condition = "[employee_number]=" & Me.employeeNumber & " AND [project_code]='" & _projectCode & "'"

        recordReader = selectQuery(table, fields, condition)

        Dim record As Hashtable
        Dim records As List(Of Hashtable) = New List(Of Hashtable)

        While recordReader.Read() = True
            record = New Hashtable

            record.Add("id", recordReader.Item("id"))
            record.Add("employee_number", recordReader.Item("employee_number"))
            record.Add("action", recordReader.Item("action"))
            record.Add("project_code", recordReader.Item("project_code"))
            record.Add("project_name", recordReader.Item("project_name"))
            record.Add("log_date", recordReader.Item("log_date"))
            record.Add("log_time", recordReader.Item("log_time"))

            records.Add(record)
        End While

        getLogs = records.ToArray

        recordReader.Close()
    End Function

    Public Shared Function addEmployee(ByVal _employeeNumber As Integer, ByVal _lastName As String, ByVal _firstName As String, ByVal _middleName As String, ByVal _birthdate As String, ByVal _ratePerHour As Decimal, _type As String, ByVal _password As String) As String
        Dim table As String = "employees"
        Dim fields As String = "[employee_number], [last_name], [first_name], [middle_name], [birthdate], [rate_per_hour], [employee_type], [password]"
        Dim values As String = _employeeNumber & ", '" & _lastName & "', '" & _firstName & "', '" & _middleName & "', '" & _birthdate & "', " & _ratePerHour & ", '" & _type & "', '" & generateHash(_password) & "'"

        If addQuery(table, fields, values) Then
            addEmployee = "Employee ADDED: " & _employeeNumber
        Else
            addEmployee = "Error Adding Employee"
        End If
    End Function

    Public Function updateEmployee(ByVal _employeeNumber As Integer, ByVal _lastName As String, ByVal _firstName As String, ByVal _middleName As String, ByVal _birthdate As String, ByVal _ratePerHour As Decimal, _type As String, ByVal _password As String) As String
        Dim table As String = "employees"
        Dim fields As List(Of String) = {"employee_number", "last_name", "first_name", "middle_name", "birthdate", "rate_per_hour", "employee_type"}.ToList()
        Dim values As List(Of String) = {_employeeNumber.ToString, "'" & _lastName & "'", "'" & _firstName & "'", "'" & _middleName & "'", "'" & _birthdate & "'", _ratePerHour.ToString, "'" & _type & "'"}.ToList()
        Dim condition As String = "[id]=" & Me.id

        If _password <> "" Then
            fields.Add("password")
            values.Add("'" & generateHash(_password) & "'")
        End If

        If updateQuery(table, fields.ToArray, values.ToArray, condition) Then
            updateEmployee = "Employee UPDATED: " & Me.employeeNumber
        Else
            updateEmployee = "Error Updating Employee"
        End If
    End Function

    Public Function deleteEmployee() As String
        Dim table As String = "employees"
        Dim condition As String = "[id]=" & Me.id

        If deleteQuery(table, condition) Then
            deleteEmployee = " Employee DELETED: " & Me.employeeNumber

            table = "employees_projects"
            condition = "[employee_id]=" & Me.id

            deleteQuery(table, condition)
        Else
            deleteEmployee = "Error Deleting Employee"
        End If
    End Function

    ' private methods
    Public Shared Function getEmployees(ByVal _condition As String) As Hashtable()
        Dim table As String = "employees"
        Dim fields As String = "[id], [employee_number], [last_name], [first_name], [middle_name], [birthdate], [rate_per_hour], [employee_type]"

        Dim recordReader As OleDbDataReader = selectQuery(table, fields, _condition)

        Dim record As Hashtable
        Dim records As List(Of Hashtable) = New List(Of Hashtable)

        While recordReader.Read() = True
            record = New Hashtable

            record.Add("id", recordReader.Item("id"))
            record.Add("employee_number", recordReader.Item("employee_number"))
            record.Add("last_name", recordReader.Item("last_name"))
            record.Add("first_name", recordReader.Item("first_name"))
            record.Add("middle_name", recordReader.Item("middle_name"))
            record.Add("birthdate", recordReader.Item("birthdate"))
            record.Add("rate_per_hour", recordReader.Item("rate_per_hour"))
            record.Add("type", recordReader.Item("employee_type"))

            records.Add(record)
        End While

        getEmployees = records.ToArray

        recordReader.Close()
    End Function

    Private Function projects() As String()
        Dim table As String = "employees_projects"
        Dim fields As String = "[project_id]"
        Dim condition As String = "[employee_id]=" & Me.id

        Dim recordReader As OleDbDataReader = selectQuery(table, fields, condition)

        Dim project_ids As List(Of String) = New List(Of String)

        While recordReader.Read() = True
            project_ids.Add(recordReader.Item("project_id"))
        End While

        projects = project_ids.ToArray

        recordReader.Close()
    End Function

    Private Function someonesProjects(ByVal _condition As String, ByVal _project_ids As String(), ByVal _all As Boolean) As Hashtable()
        If _project_ids.Length > 0 Then
            someonesProjects = Project.search(_condition)
        Else
            If _all Then
                someonesProjects = Project.all()
            Else
                someonesProjects = {}
            End If
        End If
    End Function

    Private Function conflict(ByVal _projectId As Integer) As Boolean
        conflict = False

        Dim project As Project = New Project(_projectId)

        Dim projectSDate As Date = Date.Parse(project.startDate)
        Dim projectEDate As Date = Date.Parse(project.endDate)

        Dim project_ids As String() = projects()

        If project_ids.Length > 0 Then
            Dim table As String = "projects"
            Dim fields As String = "[start_date], [end_date]"
            Dim condition As String = "[id] IN (" & Join(project_ids, ", ") & ")"

            Dim recordReader As OleDbDataReader = selectQuery(table, fields, condition)

            Dim projectsSDates As List(Of Date) = New List(Of Date)
            Dim projectsEDates As List(Of Date) = New List(Of Date)

            While recordReader.Read() = True
                projectsSDates.Add(Date.Parse(recordReader.Item("start_date")))
                projectsEDates.Add(Date.Parse(recordReader.Item("end_date")))
            End While

            For i As Integer = 0 To projectsSDates.ToArray.Length - 1
                If (projectSDate <= projectsEDates(i) And projectSDate >= projectsSDates(i)) Or (projectEDate <= projectsEDates(i) And projectEDate >= projectsSDates(i)) Then
                    conflict = True
                End If
            Next

            recordReader.Close()
        End If
    End Function

    Private Function lastLog() As Hashtable
        Dim recordReader As OleDbDataReader
        Dim logs As List(Of Hashtable) = New List(Of Hashtable)
        Dim log As Hashtable

        Dim table As String = "logs"
        Dim fields As String = "[employee_number], [action], [project_name]"
        Dim condition As String = "[employee_number]=" & Me.employeeNumber

        recordReader = selectQuery(table, fields, condition)

        While recordReader.Read() = True
            log = New Hashtable
            log.Add("action", recordReader.Item("action"))
            log.Add("project", recordReader.Item("project_name"))
            log.Add("project_code", recordReader.Item("project_code"))

            logs.Add(log)
        End While

        Dim tmp As Hashtable() = logs.ToArray()

        If tmp.Length > 0 Then
            lastLog = tmp(tmp.Length - 1)
        Else
            log = New Hashtable
            log.Add("action", "")
            log.Add("project", "")
            log.Add("project_code", "")

            logs.Add(log)

            lastLog = logs.ToArray()(0)
        End If

        recordReader.Close()
    End Function
End Class
