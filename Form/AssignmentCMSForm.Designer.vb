<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AssignmentCMSForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.employeesDGV = New System.Windows.Forms.DataGridView()
        Me.employeeIDCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employeeNumberCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employeeLastNameCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employeeFirstNameCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employeeMiddleNameCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employeeBirthdateCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employeeRatePerHourCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employeeTypeCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.unassignBtn = New System.Windows.Forms.Button()
        Me.existingProjectsDGV = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.assignBtn = New System.Windows.Forms.Button()
        Me.availableProjectsDGV = New System.Windows.Forms.DataGridView()
        Me.backToMainMenuBtn = New System.Windows.Forms.Button()
        Me.existingProjectsIDCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.existingProjectsCodeCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.existingProjectsNameCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.existingProjectsManagerCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.existingProjectsStartCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.existingProjectsEndCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.existingProjectsClientCodeCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.availableProjectsIDCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.availableProjectsCodeCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.availableProjectsNameCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.availableProjectsManagerCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.availableProjectsStartCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.availableProjectsEndCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.availableProjectsClientCodeCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.employeesDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.existingProjectsDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.availableProjectsDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(305, 29)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Assignment Management"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.employeesDGV)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(560, 179)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Employees"
        '
        'employeesDGV
        '
        Me.employeesDGV.AllowUserToAddRows = False
        Me.employeesDGV.AllowUserToDeleteRows = False
        Me.employeesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.employeesDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.employeeIDCol, Me.employeeNumberCol, Me.employeeLastNameCol, Me.employeeFirstNameCol, Me.employeeMiddleNameCol, Me.employeeBirthdateCol, Me.employeeRatePerHourCol, Me.employeeTypeCol})
        Me.employeesDGV.Location = New System.Drawing.Point(6, 19)
        Me.employeesDGV.Name = "employeesDGV"
        Me.employeesDGV.ReadOnly = True
        Me.employeesDGV.RowHeadersVisible = False
        Me.employeesDGV.Size = New System.Drawing.Size(548, 149)
        Me.employeesDGV.TabIndex = 0
        '
        'employeeIDCol
        '
        Me.employeeIDCol.HeaderText = "ID"
        Me.employeeIDCol.Name = "employeeIDCol"
        Me.employeeIDCol.ReadOnly = True
        Me.employeeIDCol.Visible = False
        '
        'employeeNumberCol
        '
        Me.employeeNumberCol.HeaderText = "Employee Number"
        Me.employeeNumberCol.Name = "employeeNumberCol"
        Me.employeeNumberCol.ReadOnly = True
        Me.employeeNumberCol.Width = 120
        '
        'employeeLastNameCol
        '
        Me.employeeLastNameCol.HeaderText = "Last Name"
        Me.employeeLastNameCol.Name = "employeeLastNameCol"
        Me.employeeLastNameCol.ReadOnly = True
        '
        'employeeFirstNameCol
        '
        Me.employeeFirstNameCol.HeaderText = "First Name"
        Me.employeeFirstNameCol.Name = "employeeFirstNameCol"
        Me.employeeFirstNameCol.ReadOnly = True
        '
        'employeeMiddleNameCol
        '
        Me.employeeMiddleNameCol.HeaderText = "Middle Name"
        Me.employeeMiddleNameCol.Name = "employeeMiddleNameCol"
        Me.employeeMiddleNameCol.ReadOnly = True
        '
        'employeeBirthdateCol
        '
        Me.employeeBirthdateCol.HeaderText = "Birthdate"
        Me.employeeBirthdateCol.Name = "employeeBirthdateCol"
        Me.employeeBirthdateCol.ReadOnly = True
        '
        'employeeRatePerHourCol
        '
        Me.employeeRatePerHourCol.HeaderText = "Rate/Hr"
        Me.employeeRatePerHourCol.Name = "employeeRatePerHourCol"
        Me.employeeRatePerHourCol.ReadOnly = True
        '
        'employeeTypeCol
        '
        Me.employeeTypeCol.HeaderText = "Type"
        Me.employeeTypeCol.Name = "employeeTypeCol"
        Me.employeeTypeCol.ReadOnly = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.unassignBtn)
        Me.GroupBox2.Controls.Add(Me.existingProjectsDGV)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 231)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(275, 199)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Existing Projects"
        '
        'unassignBtn
        '
        Me.unassignBtn.Location = New System.Drawing.Point(142, 171)
        Me.unassignBtn.Name = "unassignBtn"
        Me.unassignBtn.Size = New System.Drawing.Size(127, 23)
        Me.unassignBtn.TabIndex = 1
        Me.unassignBtn.Text = "Unassign to Project"
        Me.unassignBtn.UseVisualStyleBackColor = True
        '
        'existingProjectsDGV
        '
        Me.existingProjectsDGV.AllowUserToAddRows = False
        Me.existingProjectsDGV.AllowUserToDeleteRows = False
        Me.existingProjectsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.existingProjectsDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.existingProjectsIDCol, Me.existingProjectsCodeCol, Me.existingProjectsNameCol, Me.existingProjectsManagerCol, Me.existingProjectsStartCol, Me.existingProjectsEndCol, Me.existingProjectsClientCodeCol})
        Me.existingProjectsDGV.Location = New System.Drawing.Point(6, 19)
        Me.existingProjectsDGV.Name = "existingProjectsDGV"
        Me.existingProjectsDGV.ReadOnly = True
        Me.existingProjectsDGV.RowHeadersVisible = False
        Me.existingProjectsDGV.Size = New System.Drawing.Size(263, 149)
        Me.existingProjectsDGV.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.assignBtn)
        Me.GroupBox3.Controls.Add(Me.availableProjectsDGV)
        Me.GroupBox3.Location = New System.Drawing.Point(297, 231)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(275, 199)
        Me.GroupBox3.TabIndex = 31
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Available Projects"
        '
        'assignBtn
        '
        Me.assignBtn.Location = New System.Drawing.Point(142, 171)
        Me.assignBtn.Name = "assignBtn"
        Me.assignBtn.Size = New System.Drawing.Size(127, 23)
        Me.assignBtn.TabIndex = 2
        Me.assignBtn.Text = "Assign to Project"
        Me.assignBtn.UseVisualStyleBackColor = True
        '
        'availableProjectsDGV
        '
        Me.availableProjectsDGV.AllowUserToAddRows = False
        Me.availableProjectsDGV.AllowUserToDeleteRows = False
        Me.availableProjectsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.availableProjectsDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.availableProjectsIDCol, Me.availableProjectsCodeCol, Me.availableProjectsNameCol, Me.availableProjectsManagerCol, Me.availableProjectsStartCol, Me.availableProjectsEndCol, Me.availableProjectsClientCodeCol})
        Me.availableProjectsDGV.Location = New System.Drawing.Point(6, 19)
        Me.availableProjectsDGV.Name = "availableProjectsDGV"
        Me.availableProjectsDGV.ReadOnly = True
        Me.availableProjectsDGV.RowHeadersVisible = False
        Me.availableProjectsDGV.Size = New System.Drawing.Size(263, 149)
        Me.availableProjectsDGV.TabIndex = 0
        '
        'backToMainMenuBtn
        '
        Me.backToMainMenuBtn.BackColor = System.Drawing.SystemColors.Control
        Me.backToMainMenuBtn.BackgroundImage = Global.PBDITSoftEngCaseStudy.My.Resources.Resources.list
        Me.backToMainMenuBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.backToMainMenuBtn.Location = New System.Drawing.Point(543, 15)
        Me.backToMainMenuBtn.Name = "backToMainMenuBtn"
        Me.backToMainMenuBtn.Size = New System.Drawing.Size(29, 27)
        Me.backToMainMenuBtn.TabIndex = 27
        Me.backToMainMenuBtn.UseVisualStyleBackColor = False
        '
        'existingProjectsIDCol
        '
        Me.existingProjectsIDCol.HeaderText = "ID"
        Me.existingProjectsIDCol.Name = "existingProjectsIDCol"
        Me.existingProjectsIDCol.ReadOnly = True
        Me.existingProjectsIDCol.Visible = False
        '
        'existingProjectsCodeCol
        '
        Me.existingProjectsCodeCol.HeaderText = "Project Code"
        Me.existingProjectsCodeCol.Name = "existingProjectsCodeCol"
        Me.existingProjectsCodeCol.ReadOnly = True
        Me.existingProjectsCodeCol.Width = 120
        '
        'existingProjectsNameCol
        '
        Me.existingProjectsNameCol.HeaderText = "Project Name"
        Me.existingProjectsNameCol.Name = "existingProjectsNameCol"
        Me.existingProjectsNameCol.ReadOnly = True
        Me.existingProjectsNameCol.Width = 120
        '
        'existingProjectsManagerCol
        '
        Me.existingProjectsManagerCol.HeaderText = "Project Manager"
        Me.existingProjectsManagerCol.Name = "existingProjectsManagerCol"
        Me.existingProjectsManagerCol.ReadOnly = True
        Me.existingProjectsManagerCol.Width = 130
        '
        'existingProjectsStartCol
        '
        Me.existingProjectsStartCol.HeaderText = "Start Date"
        Me.existingProjectsStartCol.Name = "existingProjectsStartCol"
        Me.existingProjectsStartCol.ReadOnly = True
        Me.existingProjectsStartCol.Width = 120
        '
        'existingProjectsEndCol
        '
        Me.existingProjectsEndCol.HeaderText = "End Date"
        Me.existingProjectsEndCol.Name = "existingProjectsEndCol"
        Me.existingProjectsEndCol.ReadOnly = True
        Me.existingProjectsEndCol.Width = 120
        '
        'existingProjectsClientCodeCol
        '
        Me.existingProjectsClientCodeCol.HeaderText = "Client Code"
        Me.existingProjectsClientCodeCol.Name = "existingProjectsClientCodeCol"
        Me.existingProjectsClientCodeCol.ReadOnly = True
        Me.existingProjectsClientCodeCol.Width = 120
        '
        'availableProjectsIDCol
        '
        Me.availableProjectsIDCol.HeaderText = "ID"
        Me.availableProjectsIDCol.Name = "availableProjectsIDCol"
        Me.availableProjectsIDCol.ReadOnly = True
        Me.availableProjectsIDCol.Visible = False
        '
        'availableProjectsCodeCol
        '
        Me.availableProjectsCodeCol.HeaderText = "Project Code"
        Me.availableProjectsCodeCol.Name = "availableProjectsCodeCol"
        Me.availableProjectsCodeCol.ReadOnly = True
        Me.availableProjectsCodeCol.Width = 120
        '
        'availableProjectsNameCol
        '
        Me.availableProjectsNameCol.HeaderText = "Project Name"
        Me.availableProjectsNameCol.Name = "availableProjectsNameCol"
        Me.availableProjectsNameCol.ReadOnly = True
        Me.availableProjectsNameCol.Width = 120
        '
        'availableProjectsManagerCol
        '
        Me.availableProjectsManagerCol.HeaderText = "Project Manager"
        Me.availableProjectsManagerCol.Name = "availableProjectsManagerCol"
        Me.availableProjectsManagerCol.ReadOnly = True
        Me.availableProjectsManagerCol.Width = 130
        '
        'availableProjectsStartCol
        '
        Me.availableProjectsStartCol.HeaderText = "Start Date"
        Me.availableProjectsStartCol.Name = "availableProjectsStartCol"
        Me.availableProjectsStartCol.ReadOnly = True
        Me.availableProjectsStartCol.Width = 120
        '
        'availableProjectsEndCol
        '
        Me.availableProjectsEndCol.HeaderText = "End Date"
        Me.availableProjectsEndCol.Name = "availableProjectsEndCol"
        Me.availableProjectsEndCol.ReadOnly = True
        Me.availableProjectsEndCol.Width = 120
        '
        'availableProjectsClientCodeCol
        '
        Me.availableProjectsClientCodeCol.HeaderText = "Client Code"
        Me.availableProjectsClientCodeCol.Name = "availableProjectsClientCodeCol"
        Me.availableProjectsClientCodeCol.ReadOnly = True
        Me.availableProjectsClientCodeCol.Width = 120
        '
        'AssignmentCMSForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 442)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.backToMainMenuBtn)
        Me.Name = "AssignmentCMSForm"
        Me.Text = "Assign Employee To Project"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.employeesDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.existingProjectsDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.availableProjectsDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents backToMainMenuBtn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents employeesDGV As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents existingProjectsDGV As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents availableProjectsDGV As System.Windows.Forms.DataGridView
    Friend WithEvents unassignBtn As System.Windows.Forms.Button
    Friend WithEvents assignBtn As System.Windows.Forms.Button
    Friend WithEvents employeeIDCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents employeeNumberCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents employeeLastNameCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents employeeFirstNameCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents employeeMiddleNameCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents employeeBirthdateCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents employeeRatePerHourCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents employeeTypeCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents existingProjectsIDCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents existingProjectsCodeCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents existingProjectsNameCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents existingProjectsManagerCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents existingProjectsStartCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents existingProjectsEndCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents existingProjectsClientCodeCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents availableProjectsIDCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents availableProjectsCodeCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents availableProjectsNameCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents availableProjectsManagerCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents availableProjectsStartCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents availableProjectsEndCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents availableProjectsClientCodeCol As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
