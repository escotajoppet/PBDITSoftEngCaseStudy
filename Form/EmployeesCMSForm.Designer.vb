<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeesCMSForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.viewEmployeesGB = New System.Windows.Forms.GroupBox()
        Me.deleteEmployeeBtn = New System.Windows.Forms.Button()
        Me.editEmployeeBtn = New System.Windows.Forms.Button()
        Me.employeesDGV = New System.Windows.Forms.DataGridView()
        Me.employeeIDCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employeeNumberCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employeeLastNameCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employeeFirstNameCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employeeMiddleNameCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employeeBirthdateCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employeeRatePerHourCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employeeTypeCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.crudAddEmployeeBtn = New System.Windows.Forms.Button()
        Me.cancelAddEditBtn = New System.Windows.Forms.Button()
        Me.employeeFormGB = New System.Windows.Forms.GroupBox()
        Me.employeeBirthdateDTP = New System.Windows.Forms.DateTimePicker()
        Me.employeeRatePerHourTB = New System.Windows.Forms.TextBox()
        Me.employeeMiddleNameTB = New System.Windows.Forms.TextBox()
        Me.employeeFirstNameTB = New System.Windows.Forms.TextBox()
        Me.employeeNoTB = New System.Windows.Forms.TextBox()
        Me.employeeLastNameTB = New System.Windows.Forms.TextBox()
        Me.employeeTypeCB = New System.Windows.Forms.ComboBox()
        Me.employeeNoLbl = New System.Windows.Forms.Label()
        Me.employeeAddEditBtn = New System.Windows.Forms.Button()
        Me.employeeFirstNameLbl = New System.Windows.Forms.Label()
        Me.employeeLastNameLbl = New System.Windows.Forms.Label()
        Me.employeeMiddleNameLbl = New System.Windows.Forms.Label()
        Me.employeeBirthdateLbl = New System.Windows.Forms.Label()
        Me.employeeRatePerHourLbl = New System.Windows.Forms.Label()
        Me.employeeTypeLbl = New System.Windows.Forms.Label()
        Me.backToMainMenuBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.employeePasswordTB = New System.Windows.Forms.TextBox()
        Me.viewEmployeesGB.SuspendLayout()
        CType(Me.employeesDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.employeeFormGB.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(300, 29)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Employees Management"
        '
        'viewEmployeesGB
        '
        Me.viewEmployeesGB.Controls.Add(Me.deleteEmployeeBtn)
        Me.viewEmployeesGB.Controls.Add(Me.editEmployeeBtn)
        Me.viewEmployeesGB.Controls.Add(Me.employeesDGV)
        Me.viewEmployeesGB.Controls.Add(Me.crudAddEmployeeBtn)
        Me.viewEmployeesGB.Location = New System.Drawing.Point(14, 43)
        Me.viewEmployeesGB.Name = "viewEmployeesGB"
        Me.viewEmployeesGB.Size = New System.Drawing.Size(556, 389)
        Me.viewEmployeesGB.TabIndex = 19
        Me.viewEmployeesGB.TabStop = False
        Me.viewEmployeesGB.Text = "Employees List"
        '
        'deleteEmployeeBtn
        '
        Me.deleteEmployeeBtn.BackColor = System.Drawing.SystemColors.Control
        Me.deleteEmployeeBtn.BackgroundImage = Global.PBDITSoftEngCaseStudy.My.Resources.Resources.remove
        Me.deleteEmployeeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.deleteEmployeeBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteEmployeeBtn.Location = New System.Drawing.Point(518, 9)
        Me.deleteEmployeeBtn.Name = "deleteEmployeeBtn"
        Me.deleteEmployeeBtn.Size = New System.Drawing.Size(29, 27)
        Me.deleteEmployeeBtn.TabIndex = 24
        Me.deleteEmployeeBtn.UseVisualStyleBackColor = False
        '
        'editEmployeeBtn
        '
        Me.editEmployeeBtn.BackColor = System.Drawing.SystemColors.Control
        Me.editEmployeeBtn.BackgroundImage = Global.PBDITSoftEngCaseStudy.My.Resources.Resources.edit
        Me.editEmployeeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.editEmployeeBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editEmployeeBtn.Location = New System.Drawing.Point(483, 9)
        Me.editEmployeeBtn.Name = "editEmployeeBtn"
        Me.editEmployeeBtn.Size = New System.Drawing.Size(29, 27)
        Me.editEmployeeBtn.TabIndex = 23
        Me.editEmployeeBtn.UseVisualStyleBackColor = False
        '
        'employeesDGV
        '
        Me.employeesDGV.AllowUserToAddRows = False
        Me.employeesDGV.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.employeesDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.employeesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.employeesDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.employeeIDCol, Me.employeeNumberCol, Me.employeeLastNameCol, Me.employeeFirstNameCol, Me.employeeMiddleNameCol, Me.employeeBirthdateCol, Me.employeeRatePerHourCol, Me.employeeTypeCol})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.employeesDGV.DefaultCellStyle = DataGridViewCellStyle2
        Me.employeesDGV.Location = New System.Drawing.Point(9, 39)
        Me.employeesDGV.Name = "employeesDGV"
        Me.employeesDGV.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.employeesDGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.employeesDGV.RowHeadersVisible = False
        Me.employeesDGV.Size = New System.Drawing.Size(538, 343)
        Me.employeesDGV.TabIndex = 22
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
        'crudAddEmployeeBtn
        '
        Me.crudAddEmployeeBtn.BackColor = System.Drawing.SystemColors.Control
        Me.crudAddEmployeeBtn.BackgroundImage = Global.PBDITSoftEngCaseStudy.My.Resources.Resources.add
        Me.crudAddEmployeeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.crudAddEmployeeBtn.Location = New System.Drawing.Point(448, 9)
        Me.crudAddEmployeeBtn.Name = "crudAddEmployeeBtn"
        Me.crudAddEmployeeBtn.Size = New System.Drawing.Size(29, 27)
        Me.crudAddEmployeeBtn.TabIndex = 25
        Me.crudAddEmployeeBtn.UseVisualStyleBackColor = False
        '
        'cancelAddEditBtn
        '
        Me.cancelAddEditBtn.BackColor = System.Drawing.SystemColors.Control
        Me.cancelAddEditBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cancelAddEditBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelAddEditBtn.Location = New System.Drawing.Point(446, 359)
        Me.cancelAddEditBtn.Name = "cancelAddEditBtn"
        Me.cancelAddEditBtn.Size = New System.Drawing.Size(101, 23)
        Me.cancelAddEditBtn.TabIndex = 16
        Me.cancelAddEditBtn.Text = "Cancel"
        Me.cancelAddEditBtn.UseVisualStyleBackColor = False
        '
        'employeeFormGB
        '
        Me.employeeFormGB.Controls.Add(Me.employeePasswordTB)
        Me.employeeFormGB.Controls.Add(Me.Label1)
        Me.employeeFormGB.Controls.Add(Me.cancelAddEditBtn)
        Me.employeeFormGB.Controls.Add(Me.employeeBirthdateDTP)
        Me.employeeFormGB.Controls.Add(Me.employeeRatePerHourTB)
        Me.employeeFormGB.Controls.Add(Me.employeeMiddleNameTB)
        Me.employeeFormGB.Controls.Add(Me.employeeFirstNameTB)
        Me.employeeFormGB.Controls.Add(Me.employeeNoTB)
        Me.employeeFormGB.Controls.Add(Me.employeeLastNameTB)
        Me.employeeFormGB.Controls.Add(Me.employeeTypeCB)
        Me.employeeFormGB.Controls.Add(Me.employeeNoLbl)
        Me.employeeFormGB.Controls.Add(Me.employeeAddEditBtn)
        Me.employeeFormGB.Controls.Add(Me.employeeFirstNameLbl)
        Me.employeeFormGB.Controls.Add(Me.employeeLastNameLbl)
        Me.employeeFormGB.Controls.Add(Me.employeeMiddleNameLbl)
        Me.employeeFormGB.Controls.Add(Me.employeeBirthdateLbl)
        Me.employeeFormGB.Controls.Add(Me.employeeRatePerHourLbl)
        Me.employeeFormGB.Controls.Add(Me.employeeTypeLbl)
        Me.employeeFormGB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeFormGB.Location = New System.Drawing.Point(14, 43)
        Me.employeeFormGB.Name = "employeeFormGB"
        Me.employeeFormGB.Size = New System.Drawing.Size(556, 389)
        Me.employeeFormGB.TabIndex = 26
        Me.employeeFormGB.TabStop = False
        Me.employeeFormGB.Visible = False
        '
        'employeeBirthdateDTP
        '
        Me.employeeBirthdateDTP.Location = New System.Drawing.Point(96, 194)
        Me.employeeBirthdateDTP.Name = "employeeBirthdateDTP"
        Me.employeeBirthdateDTP.Size = New System.Drawing.Size(451, 20)
        Me.employeeBirthdateDTP.TabIndex = 12
        '
        'employeeRatePerHourTB
        '
        Me.employeeRatePerHourTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeRatePerHourTB.Location = New System.Drawing.Point(96, 238)
        Me.employeeRatePerHourTB.Name = "employeeRatePerHourTB"
        Me.employeeRatePerHourTB.Size = New System.Drawing.Size(451, 20)
        Me.employeeRatePerHourTB.TabIndex = 13
        '
        'employeeMiddleNameTB
        '
        Me.employeeMiddleNameTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeMiddleNameTB.Location = New System.Drawing.Point(96, 150)
        Me.employeeMiddleNameTB.Name = "employeeMiddleNameTB"
        Me.employeeMiddleNameTB.Size = New System.Drawing.Size(451, 20)
        Me.employeeMiddleNameTB.TabIndex = 11
        '
        'employeeFirstNameTB
        '
        Me.employeeFirstNameTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeFirstNameTB.Location = New System.Drawing.Point(96, 106)
        Me.employeeFirstNameTB.Name = "employeeFirstNameTB"
        Me.employeeFirstNameTB.Size = New System.Drawing.Size(451, 20)
        Me.employeeFirstNameTB.TabIndex = 10
        '
        'employeeNoTB
        '
        Me.employeeNoTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeNoTB.Location = New System.Drawing.Point(96, 18)
        Me.employeeNoTB.Name = "employeeNoTB"
        Me.employeeNoTB.Size = New System.Drawing.Size(451, 20)
        Me.employeeNoTB.TabIndex = 8
        '
        'employeeLastNameTB
        '
        Me.employeeLastNameTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeLastNameTB.Location = New System.Drawing.Point(96, 62)
        Me.employeeLastNameTB.Name = "employeeLastNameTB"
        Me.employeeLastNameTB.Size = New System.Drawing.Size(451, 20)
        Me.employeeLastNameTB.TabIndex = 9
        '
        'employeeTypeCB
        '
        Me.employeeTypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.employeeTypeCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeTypeCB.FormattingEnabled = True
        Me.employeeTypeCB.Items.AddRange(New Object() {"Rank and File", "Project Manager"})
        Me.employeeTypeCB.Location = New System.Drawing.Point(96, 282)
        Me.employeeTypeCB.Name = "employeeTypeCB"
        Me.employeeTypeCB.Size = New System.Drawing.Size(451, 21)
        Me.employeeTypeCB.TabIndex = 14
        '
        'employeeNoLbl
        '
        Me.employeeNoLbl.AutoSize = True
        Me.employeeNoLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeNoLbl.Location = New System.Drawing.Point(6, 22)
        Me.employeeNoLbl.Name = "employeeNoLbl"
        Me.employeeNoLbl.Size = New System.Drawing.Size(74, 13)
        Me.employeeNoLbl.TabIndex = 1
        Me.employeeNoLbl.Text = "Employee no.:"
        '
        'employeeAddEditBtn
        '
        Me.employeeAddEditBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeAddEditBtn.Location = New System.Drawing.Point(339, 359)
        Me.employeeAddEditBtn.Name = "employeeAddEditBtn"
        Me.employeeAddEditBtn.Size = New System.Drawing.Size(101, 23)
        Me.employeeAddEditBtn.TabIndex = 15
        Me.employeeAddEditBtn.UseVisualStyleBackColor = True
        '
        'employeeFirstNameLbl
        '
        Me.employeeFirstNameLbl.AutoSize = True
        Me.employeeFirstNameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeFirstNameLbl.Location = New System.Drawing.Point(6, 110)
        Me.employeeFirstNameLbl.Name = "employeeFirstNameLbl"
        Me.employeeFirstNameLbl.Size = New System.Drawing.Size(60, 13)
        Me.employeeFirstNameLbl.TabIndex = 3
        Me.employeeFirstNameLbl.Text = "First Name:"
        '
        'employeeLastNameLbl
        '
        Me.employeeLastNameLbl.AutoSize = True
        Me.employeeLastNameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeLastNameLbl.Location = New System.Drawing.Point(6, 66)
        Me.employeeLastNameLbl.Name = "employeeLastNameLbl"
        Me.employeeLastNameLbl.Size = New System.Drawing.Size(61, 13)
        Me.employeeLastNameLbl.TabIndex = 2
        Me.employeeLastNameLbl.Text = "Last Name:"
        '
        'employeeMiddleNameLbl
        '
        Me.employeeMiddleNameLbl.AutoSize = True
        Me.employeeMiddleNameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeMiddleNameLbl.Location = New System.Drawing.Point(6, 154)
        Me.employeeMiddleNameLbl.Name = "employeeMiddleNameLbl"
        Me.employeeMiddleNameLbl.Size = New System.Drawing.Size(72, 13)
        Me.employeeMiddleNameLbl.TabIndex = 4
        Me.employeeMiddleNameLbl.Text = "Middle Name:"
        '
        'employeeBirthdateLbl
        '
        Me.employeeBirthdateLbl.AutoSize = True
        Me.employeeBirthdateLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeBirthdateLbl.Location = New System.Drawing.Point(6, 198)
        Me.employeeBirthdateLbl.Name = "employeeBirthdateLbl"
        Me.employeeBirthdateLbl.Size = New System.Drawing.Size(52, 13)
        Me.employeeBirthdateLbl.TabIndex = 5
        Me.employeeBirthdateLbl.Text = "Birthdate:"
        '
        'employeeRatePerHourLbl
        '
        Me.employeeRatePerHourLbl.AutoSize = True
        Me.employeeRatePerHourLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeRatePerHourLbl.Location = New System.Drawing.Point(6, 242)
        Me.employeeRatePerHourLbl.Name = "employeeRatePerHourLbl"
        Me.employeeRatePerHourLbl.Size = New System.Drawing.Size(77, 13)
        Me.employeeRatePerHourLbl.TabIndex = 6
        Me.employeeRatePerHourLbl.Text = "Rate per Hour:"
        '
        'employeeTypeLbl
        '
        Me.employeeTypeLbl.AutoSize = True
        Me.employeeTypeLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeTypeLbl.Location = New System.Drawing.Point(6, 286)
        Me.employeeTypeLbl.Name = "employeeTypeLbl"
        Me.employeeTypeLbl.Size = New System.Drawing.Size(83, 13)
        Me.employeeTypeLbl.TabIndex = 7
        Me.employeeTypeLbl.Text = "Employee Type:"
        '
        'backToMainMenuBtn
        '
        Me.backToMainMenuBtn.BackColor = System.Drawing.SystemColors.Control
        Me.backToMainMenuBtn.BackgroundImage = Global.PBDITSoftEngCaseStudy.My.Resources.Resources.list
        Me.backToMainMenuBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.backToMainMenuBtn.Location = New System.Drawing.Point(541, 11)
        Me.backToMainMenuBtn.Name = "backToMainMenuBtn"
        Me.backToMainMenuBtn.Size = New System.Drawing.Size(29, 27)
        Me.backToMainMenuBtn.TabIndex = 26
        Me.backToMainMenuBtn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 331)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Password:"
        '
        'employeePasswordTB
        '
        Me.employeePasswordTB.Location = New System.Drawing.Point(96, 327)
        Me.employeePasswordTB.Name = "employeePasswordTB"
        Me.employeePasswordTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.employeePasswordTB.Size = New System.Drawing.Size(451, 20)
        Me.employeePasswordTB.TabIndex = 18
        '
        'EmployeesCMSForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 442)
        Me.Controls.Add(Me.backToMainMenuBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.employeeFormGB)
        Me.Controls.Add(Me.viewEmployeesGB)
        Me.Name = "EmployeesCMSForm"
        Me.Text = "Employees CMS"
        Me.viewEmployeesGB.ResumeLayout(False)
        CType(Me.employeesDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.employeeFormGB.ResumeLayout(False)
        Me.employeeFormGB.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents viewEmployeesGB As System.Windows.Forms.GroupBox
    Friend WithEvents cancelAddEditBtn As System.Windows.Forms.Button
    Friend WithEvents deleteEmployeeBtn As System.Windows.Forms.Button
    Friend WithEvents editEmployeeBtn As System.Windows.Forms.Button
    Friend WithEvents employeesDGV As System.Windows.Forms.DataGridView
    Friend WithEvents employeeIDCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents employeeNumberCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents employeeLastNameCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents employeeFirstNameCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents employeeMiddleNameCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents employeeBirthdateCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents employeeRatePerHourCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents employeeTypeCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents crudAddEmployeeBtn As System.Windows.Forms.Button
    Friend WithEvents employeeFormGB As System.Windows.Forms.GroupBox
    Friend WithEvents employeeBirthdateDTP As System.Windows.Forms.DateTimePicker
    Friend WithEvents employeeRatePerHourTB As System.Windows.Forms.TextBox
    Friend WithEvents employeeMiddleNameTB As System.Windows.Forms.TextBox
    Friend WithEvents employeeFirstNameTB As System.Windows.Forms.TextBox
    Friend WithEvents employeeNoTB As System.Windows.Forms.TextBox
    Friend WithEvents employeeLastNameTB As System.Windows.Forms.TextBox
    Friend WithEvents employeeTypeCB As System.Windows.Forms.ComboBox
    Friend WithEvents employeeNoLbl As System.Windows.Forms.Label
    Friend WithEvents employeeAddEditBtn As System.Windows.Forms.Button
    Friend WithEvents employeeFirstNameLbl As System.Windows.Forms.Label
    Friend WithEvents employeeLastNameLbl As System.Windows.Forms.Label
    Friend WithEvents employeeMiddleNameLbl As System.Windows.Forms.Label
    Friend WithEvents employeeBirthdateLbl As System.Windows.Forms.Label
    Friend WithEvents employeeRatePerHourLbl As System.Windows.Forms.Label
    Friend WithEvents employeeTypeLbl As System.Windows.Forms.Label
    Friend WithEvents backToMainMenuBtn As System.Windows.Forms.Button
    Friend WithEvents employeePasswordTB As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
