Imports System.Data.OleDb

Public Class Client
    Public Property id As Integer
    Public Property code As String
    Public Property name As String
    Public Property address As String
    Public Property city As String
    Public Property contactPerson As String
    Public Property contactNumber As String

    Public Sub New(ByVal _id As Integer)
        Dim table As String = "clients"
        Dim fields As String = "[id], [client_code], [client_name], [address], [city], [contact_person], [contact_number]"
        Dim condition As String = "[id]=" & _id

        Dim recordReader As OleDbDataReader = selectQuery(table, fields, condition)

        While recordReader.Read() = True
            Me.id = _id
            Me.code = recordReader.Item("client_code")
            Me.name = recordReader.Item("client_name")
            Me.address = recordReader.Item("address")
            Me.city = recordReader.Item("city")
            Me.contactPerson = recordReader.Item("contact_person")
            Me.contactNumber = recordReader.Item("contact_number")
        End While

        recordReader.Close()
    End Sub

    Public Shared Function all() As Hashtable()
        all = getClients("1")
    End Function

    Public Shared Function search(ByVal _condition As String) As Hashtable()
        search = getClients(_condition)
    End Function

    Public Shared Function exists(ByVal _clientCode) As Boolean
        Dim recordReader As OleDbDataReader

        Dim table As String = "clients"
        Dim fields As String = "[id]"
        Dim condition As String = "[client_code]='" & _clientCode & "'"

        recordReader = selectQuery(table, fields, condition)

        If recordReader.HasRows Then
            exists = True
        Else
            exists = False
        End If
    End Function

    Public Shared Function addClient(ByVal _clientCode As String, ByVal _clientName As String, ByVal _address As String, ByVal _city As String, ByVal _contactPerson As String, ByVal _contactNumber As String) As String
        Dim table As String = "clients"
        Dim fields As String = "[client_code], [client_name], [address], [city], [contact_person], [contact_number]"
        Dim values As String = "'" & _clientCode & "', '" & _clientName & "', '" & _address & "', '" & _city & "', '" & _contactPerson & "', '" & _contactNumber & "'"

        If addQuery(table, fields, values) Then
            addClient = "Client ADDED: " & _clientCode
        Else
            addClient = "Error Adding Client"
        End If
    End Function

    Public Function updateClient(ByVal _clientCode As String, ByVal _clientName As String, ByVal _address As String, ByVal _city As String, ByVal _contactPerson As String, ByVal _contactNumber As String) As String
        Dim table As String = "clients"
        Dim fields As String() = {"client_code", "client_name", "address", "city", "contact_person", "contact_number"}
        Dim values As String() = {"'" & _clientCode & "'", "'" & _clientName & "'", "'" & _address & "'", "'" & _city & "'", "'" & _contactPerson & "'", "'" & _contactNumber & "'"}
        Dim condition As String = "id=" & Me.id

        If updateQuery(table, fields, values, condition) Then
            updateClient = "Client UPDATED: " & Me.code
        Else
            updateClient = "Error Updating Client"
        End If
    End Function

    Public Function deleteClient() As String
        Dim table As String = "clients"
        Dim condition As String = "[id]=" & Me.id

        If deleteQuery(table, condition) Then
            deleteClient = "Client DELETED: " & Me.code

            table = "projects"
            condition = "[client_code]='" & Me.code & "'"

            deleteQuery(table, condition)
        Else
            deleteClient = "Error Deleting Client"
        End If
    End Function

    ' private methods
    Private Shared Function getClients(ByVal _condition As String)
        Dim table As String = "clients"
        Dim fields As String = "[id], [client_code], [client_name], [address], [city], [contact_person], [contact_number]"

        Dim recordReader As OleDbDataReader = selectQuery(table, fields, _condition)

        Dim record As Hashtable
        Dim records As List(Of Hashtable) = New List(Of Hashtable)

        While recordReader.Read() = True
            record = New Hashtable

            record.Add("id", recordReader.Item("id"))
            record.Add("client_code", recordReader.Item("client_code"))
            record.Add("client_name", recordReader.Item("client_name"))
            record.Add("address", recordReader.Item("address"))
            record.Add("city", recordReader.Item("city"))
            record.Add("contact_person", recordReader.Item("contact_person"))
            record.Add("contact_number", recordReader.Item("contact_number"))

            records.Add(record)
        End While

        getClients = records.ToArray

        recordReader.Close()
    End Function
End Class
