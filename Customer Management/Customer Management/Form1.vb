Public Class Form1


    Public keyArray As New ArrayList
    Public mySQLControl As New SQLController
    Private myDate As Date = Now

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Populate the arraylist that will be connected to the combobox
        keyArray.Add("ProgramNumber")
        keyArray.Add("Name")
        keyArray.Add("DescriptionKey")

        'Assigns the arraylist as the primary source of strings for combobox "cmbColumn"
        cmbColumn.DataSource = keyArray

        Me.btnSearch.Enabled = False


    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Dim mySearch As String
        If mySQLControl.TestConnection = True Then

            'Clears the output label
            lblOutput.Text = ""

            'Handles uppercase
            If cmbColumn.Text = "ProgramNumber" Then
                mySearch = txtSearch.Text.ToUpper()
            Else
                mySearch = txtSearch.Text
            End If
            mySearch = mySQLControl.checkNull(mySearch)

            'If no keywords entered into search textbox, return all rows from database
            mySQLControl.Query(mySearch, cmbColumn.Text)

            'Shows the SQL query in the label
            lblOutput.Text = mySQLControl.QueryString

            DGVData.DataSource = mySQLControl.myDataSet.Tables(0)
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Dim mySearch As String

        'Changes will not be committed, and the table will update
        If cmbColumn.Text = "ProgramNumber" Then
            mySearch = txtSearch.Text.ToUpper()
        Else
            mySearch = txtSearch.Text
        End If
        mySearch = mySQLControl.checkNull(mySearch)

        If mySQLControl.TestConnection = True Then
            lblOutput.Text = "0 records were updated."
            mySQLControl.Query(mySearch, cmbColumn.Text)
            DGVData.DataSource = mySQLControl.myDataSet.Tables(0)
        End If

    End Sub

    Private Sub btnCommit_Click(sender As Object, e As EventArgs) Handles btnCommit.Click

        'Handles the altering of data
        If mySQLControl.TestConnection = True Then
            If checkKey() = True Then
                checkProgramKey()

                Dim m As Integer
                m = MsgBox("Data will be permanently altered. This cannot be undone." & vbNewLine & "Are you sure you would like to proceed?", vbYesNoCancel)
                If m = vbYes Then
                    Try
                        mySQLControl.commitChange()
                        lblOutput.Text = "Changes successfully committed."
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                ElseIf m = vbNo Then
                    'Code from the cancel button if user declines changes
                    lblOutput.Text = "0 records were updated."
                    mySQLControl.Query(cmbColumn.Text, txtSearch.Text)
                    DGVData.DataSource = mySQLControl.myDataSet.Tables(0)
                Else
                    lblOutput.Text = lblOutput.Text & vbNewLine & "User declined. Changes have not been applied."
                    'Messagebox will close and changes will appear on the DataGridView, but will not be committed
                End If
            End If
        End If

    End Sub

    Private Sub DGVData_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVData.CellValueChanged

        'Sets input data to uppercase for column Program Number and Category Key
        If e.ColumnIndex = 1 Then
            DGVData.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = DGVData.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString().ToUpper()
        End If
        If e.ColumnIndex = 3 Then
            DGVData.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = DGVData.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString().ToUpper()
        End If




        'Changes the date in Last Updated column
        DGVData.CurrentRow.Cells("LastUpdated").Value = myDate

    End Sub

    Private Function checkKey() As Boolean

        'Warn the user if no key exists for a column
        Dim TF As Boolean = True
        If DGVData.CurrentRow.Cells("Key").Value Is Nothing Then
            MsgBox("Key is missing!")
            TF = False
        End If
        Return TF

    End Function


    Private Sub checkProgramKey()

        'Data validation to enforce database relationships
        Dim dataString As String
        Dim catString As String
        Try
            dataString = DGVData.CurrentRow.Cells("CategoryKey").Value.ToString
            catString = mySQLControl.categoryAssign(dataString)
            DGVData.CurrentRow.Cells("CategoryName").Value = catString
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub



    Private Sub DGVData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVData.CellContentClick, DGVData.CellClick

        'Sets the rules to limiting cell input - same char length as datatype in the database
        CType(Me.DGVData.Columns(0), DataGridViewTextBoxColumn).MaxInputLength = 5 'Key
        CType(Me.DGVData.Columns(1), DataGridViewTextBoxColumn).MaxInputLength = 10 'Program Number
        CType(Me.DGVData.Columns(2), DataGridViewTextBoxColumn).MaxInputLength = 255 'Name
        CType(Me.DGVData.Columns(3), DataGridViewTextBoxColumn).MaxInputLength = 5 'Category Key
        CType(Me.DGVData.Columns(4), DataGridViewTextBoxColumn).MaxInputLength = 255 'Category Name
        CType(Me.DGVData.Columns(5), DataGridViewTextBoxColumn).MaxInputLength = 50 'Client
        CType(Me.DGVData.Columns(6), DataGridViewTextBoxColumn).MaxInputLength = 20 'Version
        CType(Me.DGVData.Columns(7), DataGridViewTextBoxColumn).MaxInputLength = 50 'Menu Main Number
        CType(Me.DGVData.Columns(8), DataGridViewTextBoxColumn).MaxInputLength = 255 'Main Menu Name
        CType(Me.DGVData.Columns(9), DataGridViewTextBoxColumn).MaxInputLength = 255 'Description Key
        CType(Me.DGVData.Columns(13), DataGridViewTextBoxColumn).MaxInputLength = 20 'Chain To
        CType(Me.DGVData.Columns(14), DataGridViewTextBoxColumn).MaxInputLength = 20 'Chain From
        CType(Me.DGVData.Columns(17), DataGridViewTextBoxColumn).MaxInputLength = 50 'Menu Key

    End Sub

    Private Sub DGVData_UserAddedRow(sender As Object, e As DataGridViewRowEventArgs) Handles DGVData.UserAddedRow

        'When new row is added, it will automatically have a created date
        DGVData.CurrentRow.Cells("RecordCreated").Value = myDate

    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click

        Dim connString As String
        Dim servString As String
        Dim userString As String
        Dim pasString As String
        Dim dbString As String = "Database=Customer_Records;" 'Database name

        'Begin by clearing the query search, then connect using manually entered values. If database is named differently, change in the line above
        txtSearch.Clear()
        servString = txtServer.Text & ";"
        userString = "User=" & txtUser.Text & ";"
        pasString = "Pwd=" & txtPass.Text & ";"

        'This is the command that the sqlConnection object executes. Timeout prevents infinite searching if wrong database name or server
        connString = "server=" & servString & dbString & userString & pasString & "Connect Timeout=3"
        mySQLControl.LogIn(connString)

        If mySQLControl.TestConnection = True Then
            lblOutput.Text = "Connection Established!"
            'Enable the search button and grey out the log in button
            Me.btnSearch.Enabled = True
            Me.btnLogIn.Enabled = False
        Else
            lblOutput.Text = "Connection Failed! Check user log-in data."
        End If

        mySQLControl.Query(mySQLControl.checkNull(txtSearch.Text), cmbColumn.Text)
        Try
            DGVData.DataSource = mySQLControl.myDataSet.Tables(0)
        Catch ex As Exception
            'Catch errors all at once instead of one-by-one
            MessageBox.Show("Error: Check that Server, Username, and Password are correct!", "Log in failed", MessageBoxButtons.OK)
        End Try


    End Sub
End Class
