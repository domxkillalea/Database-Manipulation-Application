<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.gpbSearch = New System.Windows.Forms.GroupBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.cmbColumn = New System.Windows.Forms.ComboBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lblCombo = New System.Windows.Forms.Label()
        Me.lblKeyword = New System.Windows.Forms.Label()
        Me.DGVData = New System.Windows.Forms.DataGridView()
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.gpbLogIn = New System.Windows.Forms.GroupBox()
        Me.btnLogIn = New System.Windows.Forms.Button()
        Me.txtServer = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblServer = New System.Windows.Forms.Label()
        Me.gpbSearch.SuspendLayout()
        CType(Me.DGVData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbLogIn.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpbSearch
        '
        Me.gpbSearch.Controls.Add(Me.lblOutput)
        Me.gpbSearch.Controls.Add(Me.cmbColumn)
        Me.gpbSearch.Controls.Add(Me.txtSearch)
        Me.gpbSearch.Controls.Add(Me.btnSearch)
        Me.gpbSearch.Controls.Add(Me.lblCombo)
        Me.gpbSearch.Controls.Add(Me.lblKeyword)
        Me.gpbSearch.Location = New System.Drawing.Point(13, 13)
        Me.gpbSearch.Name = "gpbSearch"
        Me.gpbSearch.Size = New System.Drawing.Size(259, 163)
        Me.gpbSearch.TabIndex = 0
        Me.gpbSearch.TabStop = False
        Me.gpbSearch.Text = "Search"
        '
        'lblOutput
        '
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput.Location = New System.Drawing.Point(6, 100)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(247, 60)
        Me.lblOutput.TabIndex = 5
        Me.lblOutput.Text = "No connection. Please log in to a server."
        '
        'cmbColumn
        '
        Me.cmbColumn.FormattingEnabled = True
        Me.cmbColumn.Location = New System.Drawing.Point(58, 43)
        Me.cmbColumn.Name = "cmbColumn"
        Me.cmbColumn.Size = New System.Drawing.Size(121, 21)
        Me.cmbColumn.TabIndex = 1
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(58, 17)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(121, 20)
        Me.txtSearch.TabIndex = 0
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(58, 70)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'lblCombo
        '
        Me.lblCombo.AutoSize = True
        Me.lblCombo.Location = New System.Drawing.Point(6, 46)
        Me.lblCombo.Name = "lblCombo"
        Me.lblCombo.Size = New System.Drawing.Size(42, 13)
        Me.lblCombo.TabIndex = 1
        Me.lblCombo.Text = "Column"
        '
        'lblKeyword
        '
        Me.lblKeyword.AutoSize = True
        Me.lblKeyword.Location = New System.Drawing.Point(6, 20)
        Me.lblKeyword.Name = "lblKeyword"
        Me.lblKeyword.Size = New System.Drawing.Size(48, 13)
        Me.lblKeyword.TabIndex = 0
        Me.lblKeyword.Text = "Keyword"
        '
        'DGVData
        '
        Me.DGVData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVData.Location = New System.Drawing.Point(13, 182)
        Me.DGVData.Name = "DGVData"
        Me.DGVData.Size = New System.Drawing.Size(858, 374)
        Me.DGVData.TabIndex = 6
        '
        'btnCommit
        '
        Me.btnCommit.Location = New System.Drawing.Point(715, 562)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(75, 23)
        Me.btnCommit.TabIndex = 7
        Me.btnCommit.Text = "Commit"
        Me.btnCommit.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(796, 562)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'gpbLogIn
        '
        Me.gpbLogIn.Controls.Add(Me.btnLogIn)
        Me.gpbLogIn.Controls.Add(Me.txtServer)
        Me.gpbLogIn.Controls.Add(Me.txtPass)
        Me.gpbLogIn.Controls.Add(Me.txtUser)
        Me.gpbLogIn.Controls.Add(Me.lblPass)
        Me.gpbLogIn.Controls.Add(Me.lblUser)
        Me.gpbLogIn.Controls.Add(Me.lblServer)
        Me.gpbLogIn.Location = New System.Drawing.Point(681, 13)
        Me.gpbLogIn.Name = "gpbLogIn"
        Me.gpbLogIn.Size = New System.Drawing.Size(190, 160)
        Me.gpbLogIn.TabIndex = 9
        Me.gpbLogIn.TabStop = False
        Me.gpbLogIn.Text = "Log In"
        '
        'btnLogIn
        '
        Me.btnLogIn.Location = New System.Drawing.Point(67, 131)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Size = New System.Drawing.Size(75, 23)
        Me.btnLogIn.TabIndex = 8
        Me.btnLogIn.Text = "Log In"
        Me.btnLogIn.UseVisualStyleBackColor = True
        '
        'txtServer
        '
        Me.txtServer.Location = New System.Drawing.Point(67, 17)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(100, 20)
        Me.txtServer.TabIndex = 5
        '
        'txtPass
        '
        Me.txtPass.HideSelection = False
        Me.txtPass.Location = New System.Drawing.Point(67, 69)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(100, 20)
        Me.txtPass.TabIndex = 7
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(67, 43)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(100, 20)
        Me.txtUser.TabIndex = 6
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Location = New System.Drawing.Point(6, 72)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(53, 13)
        Me.lblPass.TabIndex = 2
        Me.lblPass.Text = "Password"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(6, 46)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(55, 13)
        Me.lblUser.TabIndex = 1
        Me.lblUser.Text = "Username"
        '
        'lblServer
        '
        Me.lblServer.AutoSize = True
        Me.lblServer.Location = New System.Drawing.Point(6, 20)
        Me.lblServer.Name = "lblServer"
        Me.lblServer.Size = New System.Drawing.Size(38, 13)
        Me.lblServer.TabIndex = 0
        Me.lblServer.Text = "Server"
        '
        'Form1
        '
        Me.AcceptButton = Me.btnSearch
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(883, 597)
        Me.Controls.Add(Me.gpbLogIn)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnCommit)
        Me.Controls.Add(Me.DGVData)
        Me.Controls.Add(Me.gpbSearch)
        Me.Name = "Form1"
        Me.Text = "Customer Management"
        Me.gpbSearch.ResumeLayout(False)
        Me.gpbSearch.PerformLayout()
        CType(Me.DGVData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbLogIn.ResumeLayout(False)
        Me.gpbLogIn.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gpbSearch As GroupBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents lblCombo As Label
    Friend WithEvents lblKeyword As Label
    Friend WithEvents cmbColumn As ComboBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents DGVData As DataGridView
    Friend WithEvents btnCommit As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents lblOutput As Label
    Friend WithEvents gpbLogIn As GroupBox
    Friend WithEvents btnLogIn As Button
    Friend WithEvents txtServer As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents lblPass As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents lblServer As Label
End Class
