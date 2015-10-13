<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogInOutForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.backToMainMenuBtn = New System.Windows.Forms.Button()
        Me.logInGB = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.viewProjectsBtn = New System.Windows.Forms.Button()
        Me.logInEmployeePasswordTB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.logInEmployeeNumberTB = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.logInBtn = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.employeesProjectsDGV = New System.Windows.Forms.DataGridView()
        Me.formLogOutBtn = New System.Windows.Forms.Button()
        Me.formLogInBtn = New System.Windows.Forms.Button()
        Me.logOutGB = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.logOutBtn = New System.Windows.Forms.Button()
        Me.logoutEmployeePasswordTB = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.logoutEmployeeNumberTB = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.projectIDCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.projectCodeCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.projectNameCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.projectManagerCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.projectStartCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.projectEndCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.projectClientCodeCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.logInGB.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.employeesProjectsDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.logOutGB.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(265, 29)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Logging Management"
        '
        'backToMainMenuBtn
        '
        Me.backToMainMenuBtn.BackColor = System.Drawing.SystemColors.Control
        Me.backToMainMenuBtn.BackgroundImage = Global.PBDITSoftEngCaseStudy.My.Resources.Resources.list
        Me.backToMainMenuBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.backToMainMenuBtn.Location = New System.Drawing.Point(543, 11)
        Me.backToMainMenuBtn.Name = "backToMainMenuBtn"
        Me.backToMainMenuBtn.Size = New System.Drawing.Size(29, 27)
        Me.backToMainMenuBtn.TabIndex = 29
        Me.backToMainMenuBtn.UseVisualStyleBackColor = False
        '
        'logInGB
        '
        Me.logInGB.Controls.Add(Me.GroupBox1)
        Me.logInGB.Controls.Add(Me.logInBtn)
        Me.logInGB.Controls.Add(Me.GroupBox2)
        Me.logInGB.Location = New System.Drawing.Point(12, 42)
        Me.logInGB.Name = "logInGB"
        Me.logInGB.Size = New System.Drawing.Size(560, 388)
        Me.logInGB.TabIndex = 30
        Me.logInGB.TabStop = False
        Me.logInGB.Text = "Log In"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.viewProjectsBtn)
        Me.GroupBox1.Controls.Add(Me.logInEmployeePasswordTB)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.logInEmployeeNumberTB)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(545, 118)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Employee Details"
        '
        'viewProjectsBtn
        '
        Me.viewProjectsBtn.Location = New System.Drawing.Point(447, 88)
        Me.viewProjectsBtn.Name = "viewProjectsBtn"
        Me.viewProjectsBtn.Size = New System.Drawing.Size(92, 23)
        Me.viewProjectsBtn.TabIndex = 9
        Me.viewProjectsBtn.Text = "View Projects"
        Me.viewProjectsBtn.UseVisualStyleBackColor = True
        '
        'logInEmployeePasswordTB
        '
        Me.logInEmployeePasswordTB.Location = New System.Drawing.Point(111, 51)
        Me.logInEmployeePasswordTB.Name = "logInEmployeePasswordTB"
        Me.logInEmployeePasswordTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.logInEmployeePasswordTB.Size = New System.Drawing.Size(428, 20)
        Me.logInEmployeePasswordTB.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Password: "
        '
        'logInEmployeeNumberTB
        '
        Me.logInEmployeeNumberTB.Location = New System.Drawing.Point(111, 17)
        Me.logInEmployeeNumberTB.Name = "logInEmployeeNumberTB"
        Me.logInEmployeeNumberTB.Size = New System.Drawing.Size(428, 20)
        Me.logInEmployeeNumberTB.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Employee Number: "
        '
        'logInBtn
        '
        Me.logInBtn.Location = New System.Drawing.Point(462, 359)
        Me.logInBtn.Name = "logInBtn"
        Me.logInBtn.Size = New System.Drawing.Size(92, 23)
        Me.logInBtn.TabIndex = 6
        Me.logInBtn.Text = "Log In"
        Me.logInBtn.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.employeesProjectsDGV)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 143)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(545, 210)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        '
        'employeesProjectsDGV
        '
        Me.employeesProjectsDGV.AllowUserToAddRows = False
        Me.employeesProjectsDGV.AllowUserToDeleteRows = False
        Me.employeesProjectsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.employeesProjectsDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.projectIDCol, Me.projectCodeCol, Me.projectNameCol, Me.projectManagerCol, Me.projectStartCol, Me.projectEndCol, Me.projectClientCodeCol})
        Me.employeesProjectsDGV.Location = New System.Drawing.Point(9, 19)
        Me.employeesProjectsDGV.Name = "employeesProjectsDGV"
        Me.employeesProjectsDGV.ReadOnly = True
        Me.employeesProjectsDGV.RowHeadersVisible = False
        Me.employeesProjectsDGV.Size = New System.Drawing.Size(530, 185)
        Me.employeesProjectsDGV.TabIndex = 0
        '
        'formLogOutBtn
        '
        Me.formLogOutBtn.Location = New System.Drawing.Point(445, 13)
        Me.formLogOutBtn.Name = "formLogOutBtn"
        Me.formLogOutBtn.Size = New System.Drawing.Size(92, 23)
        Me.formLogOutBtn.TabIndex = 30
        Me.formLogOutBtn.Text = "Log Out"
        Me.formLogOutBtn.UseVisualStyleBackColor = True
        '
        'formLogInBtn
        '
        Me.formLogInBtn.Location = New System.Drawing.Point(347, 13)
        Me.formLogInBtn.Name = "formLogInBtn"
        Me.formLogInBtn.Size = New System.Drawing.Size(92, 23)
        Me.formLogInBtn.TabIndex = 29
        Me.formLogInBtn.Text = "Log In"
        Me.formLogInBtn.UseVisualStyleBackColor = True
        '
        'logOutGB
        '
        Me.logOutGB.Controls.Add(Me.GroupBox3)
        Me.logOutGB.Location = New System.Drawing.Point(12, 42)
        Me.logOutGB.Name = "logOutGB"
        Me.logOutGB.Size = New System.Drawing.Size(560, 388)
        Me.logOutGB.TabIndex = 31
        Me.logOutGB.TabStop = False
        Me.logOutGB.Text = "Log Out"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.logOutBtn)
        Me.GroupBox3.Controls.Add(Me.logoutEmployeePasswordTB)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.logoutEmployeeNumberTB)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(545, 118)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Employee Details"
        '
        'logOutBtn
        '
        Me.logOutBtn.Location = New System.Drawing.Point(447, 88)
        Me.logOutBtn.Name = "logOutBtn"
        Me.logOutBtn.Size = New System.Drawing.Size(92, 23)
        Me.logOutBtn.TabIndex = 14
        Me.logOutBtn.Text = "Log Out"
        Me.logOutBtn.UseVisualStyleBackColor = True
        '
        'logoutEmployeePasswordTB
        '
        Me.logoutEmployeePasswordTB.Location = New System.Drawing.Point(111, 51)
        Me.logoutEmployeePasswordTB.Name = "logoutEmployeePasswordTB"
        Me.logoutEmployeePasswordTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.logoutEmployeePasswordTB.Size = New System.Drawing.Size(428, 20)
        Me.logoutEmployeePasswordTB.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Password: "
        '
        'logoutEmployeeNumberTB
        '
        Me.logoutEmployeeNumberTB.Location = New System.Drawing.Point(111, 17)
        Me.logoutEmployeeNumberTB.Name = "logoutEmployeeNumberTB"
        Me.logoutEmployeeNumberTB.Size = New System.Drawing.Size(428, 20)
        Me.logoutEmployeeNumberTB.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Employee Number: "
        '
        'projectIDCol
        '
        Me.projectIDCol.HeaderText = "ID"
        Me.projectIDCol.Name = "projectIDCol"
        Me.projectIDCol.ReadOnly = True
        Me.projectIDCol.Visible = False
        '
        'projectCodeCol
        '
        Me.projectCodeCol.HeaderText = "Project Code"
        Me.projectCodeCol.Name = "projectCodeCol"
        Me.projectCodeCol.ReadOnly = True
        Me.projectCodeCol.Width = 120
        '
        'projectNameCol
        '
        Me.projectNameCol.HeaderText = "Project Name"
        Me.projectNameCol.Name = "projectNameCol"
        Me.projectNameCol.ReadOnly = True
        Me.projectNameCol.Width = 120
        '
        'projectManagerCol
        '
        Me.projectManagerCol.HeaderText = "Project Manager"
        Me.projectManagerCol.Name = "projectManagerCol"
        Me.projectManagerCol.ReadOnly = True
        Me.projectManagerCol.Width = 130
        '
        'projectStartCol
        '
        Me.projectStartCol.HeaderText = "Start Date"
        Me.projectStartCol.Name = "projectStartCol"
        Me.projectStartCol.ReadOnly = True
        Me.projectStartCol.Width = 120
        '
        'projectEndCol
        '
        Me.projectEndCol.HeaderText = "End Date"
        Me.projectEndCol.Name = "projectEndCol"
        Me.projectEndCol.ReadOnly = True
        Me.projectEndCol.Width = 120
        '
        'projectClientCodeCol
        '
        Me.projectClientCodeCol.HeaderText = "Client Code"
        Me.projectClientCodeCol.Name = "projectClientCodeCol"
        Me.projectClientCodeCol.ReadOnly = True
        Me.projectClientCodeCol.Width = 120
        '
        'LogInOutForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 442)
        Me.Controls.Add(Me.formLogOutBtn)
        Me.Controls.Add(Me.formLogInBtn)
        Me.Controls.Add(Me.backToMainMenuBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.logInGB)
        Me.Controls.Add(Me.logOutGB)
        Me.Name = "LogInOutForm"
        Me.Text = "Log In/Out"
        Me.logInGB.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.employeesProjectsDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.logOutGB.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents backToMainMenuBtn As System.Windows.Forms.Button
    Friend WithEvents logInGB As System.Windows.Forms.GroupBox
    Friend WithEvents formLogOutBtn As System.Windows.Forms.Button
    Friend WithEvents formLogInBtn As System.Windows.Forms.Button
    Friend WithEvents logOutGB As System.Windows.Forms.GroupBox
    Friend WithEvents logInBtn As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents employeesProjectsDGV As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents viewProjectsBtn As System.Windows.Forms.Button
    Friend WithEvents logInEmployeePasswordTB As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents logInEmployeeNumberTB As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents logOutBtn As System.Windows.Forms.Button
    Friend WithEvents logoutEmployeePasswordTB As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents logoutEmployeeNumberTB As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents projectIDCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents projectCodeCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents projectNameCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents projectManagerCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents projectStartCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents projectEndCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents projectClientCodeCol As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
