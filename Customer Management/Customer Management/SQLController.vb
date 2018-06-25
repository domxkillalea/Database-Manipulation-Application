Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class SQLController
    'Class to handle communication between SQL server and this program


    'Create SQL reference objects, chage the server and credentials as necessary, i.e swap "trusted_connection=true" to "user=sa;password=password". VH45DE is server name (my pc)
    'Private myConn As New SqlConnection With {.ConnectionString = "Server=" & Environment.MachineName & ";Database=Customer_Records;Trusted_Connection=True"}
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private myDA As SqlDataAdapter
    Private myCmdBuilder As SqlCommandBuilder
    Public myDataSet As DataSet
    Public QueryString As String

    Public Sub LogIn(ByVal connString As String)

        'Establish a connection based on the inputs (user, password, server name)
        myConn = New SqlConnection With {.ConnectionString = connString}

    End Sub

    Public Function TestConnection() As Boolean

        'Ensures the given user info is correct
        Try
            myConn.Open()
            myConn.Close()
            Return True
        Catch ex As Exception

            Return False
        End Try

    End Function

    Public Function ReadDatabase()

        'Use the connection object to open a connection to the database
        myConn.Open()
        Dim R As SqlDataReader = myCmd.ExecuteReader

        While R.Read
            Return R.ToString
        End While

        myConn.Close()

    End Function

    Public Function checkNull(ByVal myKey As String) As String

        'Ensures the correct query is created

        If myKey = "" Then
            'Return all if no parameter is entered
            myKey = "*"

            ''Alternative below is to return nothing
            'lblOuput.Text = lblOuput.Text & vbNewLine & "No keywords have been entered."

        End If

        Return myKey

    End Function

    Public Sub Query(ByVal Search As String, Column As String)

        'Create the query using the input strings
        Dim qstring As String
        Dim queryArray As ArrayList
        queryArray = stringSplitter(Search)

        If Search = "*" Then
            qstring = "SELECT * FROM Program"
        Else

            qstring = "SELECT * FROM Program WHERE " & Column & " like '%" & queryArray(0) & "%'"

            'This part handles multiple keywords to create an OR query
            Dim count As Int32 = queryArray.Count
            Dim int As Int32 = 1

            'Loop, index starts at 1, arraylist starts at 0
            Do Until int = count
                qstring = qstring & " OR " & Column & " like '%" & queryArray(int) & "%'"
                int = int + 1
            Loop

        End If


        QueryString = qstring
        Try
            myConn.Open()

            myCmd = New SqlCommand(qstring, myConn)
            myDA = New SqlDataAdapter(myCmd)
            myDataSet = New DataSet
            myDA.Fill(myDataSet)
            myConn.Close()
        Catch ex As Exception
            If myConn.State = ConnectionState.Open Then
                myConn.Close()
            End If
        End Try

    End Sub

    Public Function stringSplitter(ByVal qSearch As String) As ArrayList

        'When multiple words are entered into the textbox, this will create an array to refer to each word
        Dim chr As Char = " "c
        Dim splitStrings() As String = qSearch.Split(chr)
        Dim OutArray As New ArrayList

        For Each splitstring In splitStrings
            OutArray.Add(splitstring)
        Next

        Return OutArray

    End Function

    Public Sub commitChange()

        'Handles the changes in the database
        Dim myLine As String = "SELECT UCASE(Name) AS Program FROM Program"
        myCmdBuilder = New SqlCommandBuilder(myDA)
        myDA.Update(myDataSet)
        myCmd = New SqlCommand(myLine, myConn)

    End Sub

    Public Function categoryAssign(ByVal keyCode As String) As String

        'Returns the category name based on its key
        Dim category As String

        If keyCode = "CP" Then
            category = "Chain Program"
        ElseIf keyCode = "CU" Then
            category = "Custom Client"
        ElseIf keyCode = "LP" Then
            category = "Letter Program"
        ElseIf keyCode = "MP" Then
            category = "Main Program"
        ElseIf keyCode = "PP" Then
            category = "Purge Program"
        ElseIf keyCode = "RP" Then
            category = "Report Program"
        ElseIf keyCode = "SU" Then
            category = "Support Utility"
        ElseIf keyCode = "UU" Then
            category = "User Utility"
        End If

        Return category

    End Function
End Class
