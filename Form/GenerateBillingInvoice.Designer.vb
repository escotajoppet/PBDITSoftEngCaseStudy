<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GenerateBillingInvoice
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.backToMainMenuBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.step2GB = New System.Windows.Forms.GroupBox()
        Me.step2BackBtn = New System.Windows.Forms.Button()
        Me.step2NextBtn = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.projectsDGV = New System.Windows.Forms.DataGridView()
        Me.projectIDCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.projectCodeCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.projectNameCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.projectManagerCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.projectStartCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.projectEndCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.projectClientCodeCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.clientsDGV = New System.Windows.Forms.DataGridView()
        Me.clientIDCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clientCodeCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clientNameCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clientAddressCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clientCityCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clientContactPersonCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clientContactNumberCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.step1GB = New System.Windows.Forms.GroupBox()
        Me.step1NextBtn = New System.Windows.Forms.Button()
        Me.employeesDGV = New System.Windows.Forms.DataGridView()
        Me.employeeIDCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employeeNumberCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employeeLastNameCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employeeFirstNameCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employeeMiddleNameCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employeeBirthdateCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employeeRatePerHourCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employeeTypeCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.step3GB = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.projectNameLbl = New System.Windows.Forms.Label()
        Me.dueDateLbl = New System.Windows.Forms.Label()
        Me.totalHoursLbl = New System.Windows.Forms.Label()
        Me.totalHoursBilledLbl = New System.Windows.Forms.Label()
        Me.employeeRatePerHourLbl = New System.Windows.Forms.Label()
        Me.employeeNameLbl = New System.Windows.Forms.Label()
        Me.projectManagerLbl = New System.Windows.Forms.Label()
        Me.employeeNumberLbl = New System.Windows.Forms.Label()
        Me.projectCodeLbl = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.billingDateLbl = New System.Windows.Forms.Label()
        Me.clientAddressLbl = New System.Windows.Forms.Label()
        Me.clientNameLbl = New System.Windows.Forms.Label()
        Me.clientCodeLbl = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.step3BackBtn = New System.Windows.Forms.Button()
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.step2GB.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.projectsDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.clientsDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.step1GB.SuspendLayout()
        CType(Me.employeesDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.step3GB.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'backToMainMenuBtn
        '
        Me.backToMainMenuBtn.BackColor = System.Drawing.SystemColors.Control
        Me.backToMainMenuBtn.BackgroundImage = Global.PBDITSoftEngCaseStudy.My.Resources.Resources.list
        Me.backToMainMenuBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.backToMainMenuBtn.Location = New System.Drawing.Point(542, 13)
        Me.backToMainMenuBtn.Name = "backToMainMenuBtn"
        Me.backToMainMenuBtn.Size = New System.Drawing.Size(29, 27)
        Me.backToMainMenuBtn.TabIndex = 32
        Me.backToMainMenuBtn.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(244, 29)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Billing Management"
        '
        'step2GB
        '
        Me.step2GB.Controls.Add(Me.step2BackBtn)
        Me.step2GB.Controls.Add(Me.step2NextBtn)
        Me.step2GB.Controls.Add(Me.GroupBox3)
        Me.step2GB.Controls.Add(Me.GroupBox2)
        Me.step2GB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.step2GB.Location = New System.Drawing.Point(18, 46)
        Me.step2GB.Name = "step2GB"
        Me.step2GB.Size = New System.Drawing.Size(553, 386)
        Me.step2GB.TabIndex = 31
        Me.step2GB.TabStop = False
        Me.step2GB.Text = "Step 2: Select Client and Project"
        '
        'step2BackBtn
        '
        Me.step2BackBtn.Location = New System.Drawing.Point(343, 357)
        Me.step2BackBtn.Name = "step2BackBtn"
        Me.step2BackBtn.Size = New System.Drawing.Size(99, 23)
        Me.step2BackBtn.TabIndex = 4
        Me.step2BackBtn.Text = "Back"
        Me.step2BackBtn.UseVisualStyleBackColor = True
        '
        'step2NextBtn
        '
        Me.step2NextBtn.Location = New System.Drawing.Point(448, 357)
        Me.step2NextBtn.Name = "step2NextBtn"
        Me.step2NextBtn.Size = New System.Drawing.Size(99, 23)
        Me.step2NextBtn.TabIndex = 3
        Me.step2NextBtn.Text = "Next"
        Me.step2NextBtn.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.projectsDGV)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 190)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(541, 164)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Project(s)"
        '
        'projectsDGV
        '
        Me.projectsDGV.AllowUserToAddRows = False
        Me.projectsDGV.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.projectsDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.projectsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.projectsDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.projectIDCol, Me.projectCodeCol, Me.projectNameCol, Me.projectManagerCol, Me.projectStartCol, Me.projectEndCol, Me.projectClientCodeCol})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.projectsDGV.DefaultCellStyle = DataGridViewCellStyle2
        Me.projectsDGV.Location = New System.Drawing.Point(6, 19)
        Me.projectsDGV.Name = "projectsDGV"
        Me.projectsDGV.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.projectsDGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.projectsDGV.RowHeadersVisible = False
        Me.projectsDGV.Size = New System.Drawing.Size(529, 139)
        Me.projectsDGV.TabIndex = 1
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
        Me.projectManagerCol.HeaderText = "Manager"
        Me.projectManagerCol.Name = "projectManagerCol"
        Me.projectManagerCol.ReadOnly = True
        Me.projectManagerCol.Width = 120
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
        Me.projectClientCodeCol.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.clientsDGV)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(541, 164)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Client(s)"
        '
        'clientsDGV
        '
        Me.clientsDGV.AllowUserToAddRows = False
        Me.clientsDGV.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clientsDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.clientsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.clientsDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clientIDCol, Me.clientCodeCol, Me.clientNameCol, Me.clientAddressCol, Me.clientCityCol, Me.clientContactPersonCol, Me.clientContactNumberCol})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clientsDGV.DefaultCellStyle = DataGridViewCellStyle5
        Me.clientsDGV.Location = New System.Drawing.Point(6, 19)
        Me.clientsDGV.Name = "clientsDGV"
        Me.clientsDGV.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clientsDGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.clientsDGV.RowHeadersVisible = False
        Me.clientsDGV.Size = New System.Drawing.Size(529, 139)
        Me.clientsDGV.TabIndex = 0
        '
        'clientIDCol
        '
        Me.clientIDCol.HeaderText = "ID"
        Me.clientIDCol.Name = "clientIDCol"
        Me.clientIDCol.ReadOnly = True
        Me.clientIDCol.Visible = False
        '
        'clientCodeCol
        '
        Me.clientCodeCol.HeaderText = "Client Code"
        Me.clientCodeCol.Name = "clientCodeCol"
        Me.clientCodeCol.ReadOnly = True
        Me.clientCodeCol.Width = 120
        '
        'clientNameCol
        '
        Me.clientNameCol.HeaderText = "Client Name"
        Me.clientNameCol.Name = "clientNameCol"
        Me.clientNameCol.ReadOnly = True
        Me.clientNameCol.Width = 120
        '
        'clientAddressCol
        '
        Me.clientAddressCol.HeaderText = "Address"
        Me.clientAddressCol.Name = "clientAddressCol"
        Me.clientAddressCol.ReadOnly = True
        Me.clientAddressCol.Width = 120
        '
        'clientCityCol
        '
        Me.clientCityCol.HeaderText = "City"
        Me.clientCityCol.Name = "clientCityCol"
        Me.clientCityCol.ReadOnly = True
        Me.clientCityCol.Width = 120
        '
        'clientContactPersonCol
        '
        Me.clientContactPersonCol.HeaderText = "Contact Person"
        Me.clientContactPersonCol.Name = "clientContactPersonCol"
        Me.clientContactPersonCol.ReadOnly = True
        Me.clientContactPersonCol.Width = 120
        '
        'clientContactNumberCol
        '
        Me.clientContactNumberCol.HeaderText = "Contact Number"
        Me.clientContactNumberCol.Name = "clientContactNumberCol"
        Me.clientContactNumberCol.ReadOnly = True
        Me.clientContactNumberCol.Width = 120
        '
        'step1GB
        '
        Me.step1GB.Controls.Add(Me.step1NextBtn)
        Me.step1GB.Controls.Add(Me.employeesDGV)
        Me.step1GB.Location = New System.Drawing.Point(18, 46)
        Me.step1GB.Name = "step1GB"
        Me.step1GB.Size = New System.Drawing.Size(553, 386)
        Me.step1GB.TabIndex = 33
        Me.step1GB.TabStop = False
        Me.step1GB.Text = "Step 1: Select Employee"
        '
        'step1NextBtn
        '
        Me.step1NextBtn.Location = New System.Drawing.Point(448, 357)
        Me.step1NextBtn.Name = "step1NextBtn"
        Me.step1NextBtn.Size = New System.Drawing.Size(99, 23)
        Me.step1NextBtn.TabIndex = 1
        Me.step1NextBtn.Text = "Next"
        Me.step1NextBtn.UseVisualStyleBackColor = True
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
        Me.employeesDGV.Size = New System.Drawing.Size(541, 332)
        Me.employeesDGV.TabIndex = 0
        '
        'employeeIDCol
        '
        Me.employeeIDCol.HeaderText = "ID"
        Me.employeeIDCol.Name = "employeeIDCol"
        Me.employeeIDCol.ReadOnly = True
        Me.employeeIDCol.Visible = False
        Me.employeeIDCol.Width = 120
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
        Me.employeeLastNameCol.Width = 120
        '
        'employeeFirstNameCol
        '
        Me.employeeFirstNameCol.HeaderText = "First Name"
        Me.employeeFirstNameCol.Name = "employeeFirstNameCol"
        Me.employeeFirstNameCol.ReadOnly = True
        Me.employeeFirstNameCol.Width = 120
        '
        'employeeMiddleNameCol
        '
        Me.employeeMiddleNameCol.HeaderText = "Middle Name"
        Me.employeeMiddleNameCol.Name = "employeeMiddleNameCol"
        Me.employeeMiddleNameCol.ReadOnly = True
        Me.employeeMiddleNameCol.Width = 120
        '
        'employeeBirthdateCol
        '
        Me.employeeBirthdateCol.HeaderText = "Birthdate"
        Me.employeeBirthdateCol.Name = "employeeBirthdateCol"
        Me.employeeBirthdateCol.ReadOnly = True
        Me.employeeBirthdateCol.Width = 120
        '
        'employeeRatePerHourCol
        '
        Me.employeeRatePerHourCol.HeaderText = "Rate/Hour"
        Me.employeeRatePerHourCol.Name = "employeeRatePerHourCol"
        Me.employeeRatePerHourCol.ReadOnly = True
        Me.employeeRatePerHourCol.Width = 120
        '
        'employeeTypeCol
        '
        Me.employeeTypeCol.HeaderText = "Type"
        Me.employeeTypeCol.Name = "employeeTypeCol"
        Me.employeeTypeCol.ReadOnly = True
        Me.employeeTypeCol.Width = 120
        '
        'step3GB
        '
        Me.step3GB.Controls.Add(Me.GroupBox1)
        Me.step3GB.Controls.Add(Me.step3BackBtn)
        Me.step3GB.Controls.Add(Me.saveBtn)
        Me.step3GB.Location = New System.Drawing.Point(18, 46)
        Me.step3GB.Name = "step3GB"
        Me.step3GB.Size = New System.Drawing.Size(553, 386)
        Me.step3GB.TabIndex = 34
        Me.step3GB.TabStop = False
        Me.step3GB.Text = "Step 3: Save Billing Invoice File"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.projectNameLbl)
        Me.GroupBox1.Controls.Add(Me.dueDateLbl)
        Me.GroupBox1.Controls.Add(Me.totalHoursLbl)
        Me.GroupBox1.Controls.Add(Me.totalHoursBilledLbl)
        Me.GroupBox1.Controls.Add(Me.employeeRatePerHourLbl)
        Me.GroupBox1.Controls.Add(Me.employeeNameLbl)
        Me.GroupBox1.Controls.Add(Me.projectManagerLbl)
        Me.GroupBox1.Controls.Add(Me.employeeNumberLbl)
        Me.GroupBox1.Controls.Add(Me.projectCodeLbl)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.billingDateLbl)
        Me.GroupBox1.Controls.Add(Me.clientAddressLbl)
        Me.GroupBox1.Controls.Add(Me.clientNameLbl)
        Me.GroupBox1.Controls.Add(Me.clientCodeLbl)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(529, 329)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Billing Invoice Summary"
        '
        'projectNameLbl
        '
        Me.projectNameLbl.AutoSize = True
        Me.projectNameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.projectNameLbl.Location = New System.Drawing.Point(229, 183)
        Me.projectNameLbl.Name = "projectNameLbl"
        Me.projectNameLbl.Size = New System.Drawing.Size(71, 13)
        Me.projectNameLbl.TabIndex = 50
        Me.projectNameLbl.Text = "Project Name"
        '
        'dueDateLbl
        '
        Me.dueDateLbl.AutoSize = True
        Me.dueDateLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dueDateLbl.Location = New System.Drawing.Point(6, 301)
        Me.dueDateLbl.Name = "dueDateLbl"
        Me.dueDateLbl.Size = New System.Drawing.Size(61, 13)
        Me.dueDateLbl.TabIndex = 49
        Me.dueDateLbl.Text = "Due Date"
        '
        'totalHoursLbl
        '
        Me.totalHoursLbl.AutoSize = True
        Me.totalHoursLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalHoursLbl.Location = New System.Drawing.Point(6, 283)
        Me.totalHoursLbl.Name = "totalHoursLbl"
        Me.totalHoursLbl.Size = New System.Drawing.Size(121, 13)
        Me.totalHoursLbl.TabIndex = 48
        Me.totalHoursLbl.Text = "TOTAL NO. HOURS"
        '
        'totalHoursBilledLbl
        '
        Me.totalHoursBilledLbl.AutoSize = True
        Me.totalHoursBilledLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalHoursBilledLbl.Location = New System.Drawing.Point(6, 264)
        Me.totalHoursBilledLbl.Name = "totalHoursBilledLbl"
        Me.totalHoursBilledLbl.Size = New System.Drawing.Size(142, 13)
        Me.totalHoursBilledLbl.TabIndex = 47
        Me.totalHoursBilledLbl.Text = "TOTAL HOURS BILLED"
        '
        'employeeRatePerHourLbl
        '
        Me.employeeRatePerHourLbl.AutoSize = True
        Me.employeeRatePerHourLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeRatePerHourLbl.Location = New System.Drawing.Point(419, 239)
        Me.employeeRatePerHourLbl.Name = "employeeRatePerHourLbl"
        Me.employeeRatePerHourLbl.Size = New System.Drawing.Size(34, 13)
        Me.employeeRatePerHourLbl.TabIndex = 46
        Me.employeeRatePerHourLbl.Text = "Rate"
        '
        'employeeNameLbl
        '
        Me.employeeNameLbl.AutoSize = True
        Me.employeeNameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeNameLbl.Location = New System.Drawing.Point(177, 239)
        Me.employeeNameLbl.Name = "employeeNameLbl"
        Me.employeeNameLbl.Size = New System.Drawing.Size(39, 13)
        Me.employeeNameLbl.TabIndex = 45
        Me.employeeNameLbl.Text = "Name"
        '
        'projectManagerLbl
        '
        Me.projectManagerLbl.AutoSize = True
        Me.projectManagerLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.projectManagerLbl.Location = New System.Drawing.Point(6, 205)
        Me.projectManagerLbl.Name = "projectManagerLbl"
        Me.projectManagerLbl.Size = New System.Drawing.Size(85, 13)
        Me.projectManagerLbl.TabIndex = 44
        Me.projectManagerLbl.Text = "Project Manager"
        '
        'employeeNumberLbl
        '
        Me.employeeNumberLbl.AutoSize = True
        Me.employeeNumberLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeNumberLbl.Location = New System.Drawing.Point(6, 239)
        Me.employeeNumberLbl.Name = "employeeNumberLbl"
        Me.employeeNumberLbl.Size = New System.Drawing.Size(108, 13)
        Me.employeeNumberLbl.TabIndex = 43
        Me.employeeNumberLbl.Text = "Employee Number"
        '
        'projectCodeLbl
        '
        Me.projectCodeLbl.AutoSize = True
        Me.projectCodeLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.projectCodeLbl.Location = New System.Drawing.Point(6, 183)
        Me.projectCodeLbl.Name = "projectCodeLbl"
        Me.projectCodeLbl.Size = New System.Drawing.Size(68, 13)
        Me.projectCodeLbl.TabIndex = 42
        Me.projectCodeLbl.Text = "Project Code"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(211, 157)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 17)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Billing Details"
        '
        'billingDateLbl
        '
        Me.billingDateLbl.AutoSize = True
        Me.billingDateLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.billingDateLbl.Location = New System.Drawing.Point(408, 97)
        Me.billingDateLbl.Name = "billingDateLbl"
        Me.billingDateLbl.Size = New System.Drawing.Size(60, 13)
        Me.billingDateLbl.TabIndex = 40
        Me.billingDateLbl.Text = "Billing Date"
        '
        'clientAddressLbl
        '
        Me.clientAddressLbl.AutoSize = True
        Me.clientAddressLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clientAddressLbl.Location = New System.Drawing.Point(6, 141)
        Me.clientAddressLbl.Name = "clientAddressLbl"
        Me.clientAddressLbl.Size = New System.Drawing.Size(74, 13)
        Me.clientAddressLbl.TabIndex = 39
        Me.clientAddressLbl.Text = "Client Address"
        '
        'clientNameLbl
        '
        Me.clientNameLbl.AutoSize = True
        Me.clientNameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clientNameLbl.Location = New System.Drawing.Point(6, 119)
        Me.clientNameLbl.Name = "clientNameLbl"
        Me.clientNameLbl.Size = New System.Drawing.Size(64, 13)
        Me.clientNameLbl.TabIndex = 38
        Me.clientNameLbl.Text = "Client Name"
        '
        'clientCodeLbl
        '
        Me.clientCodeLbl.AutoSize = True
        Me.clientCodeLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clientCodeLbl.Location = New System.Drawing.Point(6, 97)
        Me.clientCodeLbl.Name = "clientCodeLbl"
        Me.clientCodeLbl.Size = New System.Drawing.Size(61, 13)
        Me.clientCodeLbl.TabIndex = 37
        Me.clientCodeLbl.Text = "Client Code"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(210, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 17)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Billing Invoice"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(196, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 20)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "ABC COMPANY"
        '
        'step3BackBtn
        '
        Me.step3BackBtn.Location = New System.Drawing.Point(342, 357)
        Me.step3BackBtn.Name = "step3BackBtn"
        Me.step3BackBtn.Size = New System.Drawing.Size(75, 23)
        Me.step3BackBtn.TabIndex = 1
        Me.step3BackBtn.Text = "Back"
        Me.step3BackBtn.UseVisualStyleBackColor = True
        '
        'saveBtn
        '
        Me.saveBtn.Location = New System.Drawing.Point(423, 357)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(124, 23)
        Me.saveBtn.TabIndex = 0
        Me.saveBtn.Text = "Save Billing Invoice"
        Me.saveBtn.UseVisualStyleBackColor = True
        '
        'GenerateBillingInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 442)
        Me.Controls.Add(Me.backToMainMenuBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.step3GB)
        Me.Controls.Add(Me.step2GB)
        Me.Controls.Add(Me.step1GB)
        Me.Name = "GenerateBillingInvoice"
        Me.Text = "GenerateBillingInvoice"
        Me.step2GB.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.projectsDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.clientsDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.step1GB.ResumeLayout(False)
        CType(Me.employeesDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.step3GB.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents backToMainMenuBtn As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents step2GB As System.Windows.Forms.GroupBox
    Friend WithEvents step1GB As System.Windows.Forms.GroupBox
    Friend WithEvents employeesDGV As System.Windows.Forms.DataGridView
    Friend WithEvents step1NextBtn As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents projectsDGV As System.Windows.Forms.DataGridView
    Friend WithEvents clientsDGV As System.Windows.Forms.DataGridView
    Friend WithEvents step2NextBtn As System.Windows.Forms.Button
    Friend WithEvents step3GB As System.Windows.Forms.GroupBox
    Friend WithEvents saveBtn As System.Windows.Forms.Button
    Friend WithEvents employeeIDCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents employeeNumberCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents employeeLastNameCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents employeeFirstNameCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents employeeMiddleNameCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents employeeBirthdateCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents employeeRatePerHourCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents employeeTypeCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clientIDCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clientCodeCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clientNameCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clientAddressCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clientCityCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clientContactPersonCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clientContactNumberCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents projectIDCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents projectCodeCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents projectNameCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents projectManagerCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents projectStartCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents projectEndCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents projectClientCodeCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents step2BackBtn As System.Windows.Forms.Button
    Friend WithEvents step3BackBtn As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents projectNameLbl As System.Windows.Forms.Label
    Friend WithEvents dueDateLbl As System.Windows.Forms.Label
    Friend WithEvents totalHoursLbl As System.Windows.Forms.Label
    Friend WithEvents totalHoursBilledLbl As System.Windows.Forms.Label
    Friend WithEvents employeeRatePerHourLbl As System.Windows.Forms.Label
    Friend WithEvents employeeNameLbl As System.Windows.Forms.Label
    Friend WithEvents projectManagerLbl As System.Windows.Forms.Label
    Friend WithEvents employeeNumberLbl As System.Windows.Forms.Label
    Friend WithEvents projectCodeLbl As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents billingDateLbl As System.Windows.Forms.Label
    Friend WithEvents clientAddressLbl As System.Windows.Forms.Label
    Friend WithEvents clientNameLbl As System.Windows.Forms.Label
    Friend WithEvents clientCodeLbl As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
