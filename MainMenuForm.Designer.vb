<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenuForm
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
        Me.mainMenuGB = New System.Windows.Forms.GroupBox()
        Me.generateBillingInvoiceBtn = New System.Windows.Forms.Button()
        Me.searchBtn = New System.Windows.Forms.Button()
        Me.logInOutBtn = New System.Windows.Forms.Button()
        Me.assignEmployeeBtn = New System.Windows.Forms.Button()
        Me.projectsCMStBtn = New System.Windows.Forms.Button()
        Me.clientsCMSBtn = New System.Windows.Forms.Button()
        Me.employeesCMSBtn = New System.Windows.Forms.Button()
        Me.mainMenuGB.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainMenuGB
        '
        Me.mainMenuGB.Controls.Add(Me.generateBillingInvoiceBtn)
        Me.mainMenuGB.Controls.Add(Me.searchBtn)
        Me.mainMenuGB.Controls.Add(Me.logInOutBtn)
        Me.mainMenuGB.Controls.Add(Me.assignEmployeeBtn)
        Me.mainMenuGB.Controls.Add(Me.projectsCMStBtn)
        Me.mainMenuGB.Controls.Add(Me.clientsCMSBtn)
        Me.mainMenuGB.Controls.Add(Me.employeesCMSBtn)
        Me.mainMenuGB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mainMenuGB.Location = New System.Drawing.Point(12, 12)
        Me.mainMenuGB.Name = "mainMenuGB"
        Me.mainMenuGB.Size = New System.Drawing.Size(317, 307)
        Me.mainMenuGB.TabIndex = 0
        Me.mainMenuGB.TabStop = False
        Me.mainMenuGB.Text = "Main Menu"
        '
        'generateBillingInvoiceBtn
        '
        Me.generateBillingInvoiceBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.generateBillingInvoiceBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.generateBillingInvoiceBtn.Location = New System.Drawing.Point(3, 262)
        Me.generateBillingInvoiceBtn.Name = "generateBillingInvoiceBtn"
        Me.generateBillingInvoiceBtn.Size = New System.Drawing.Size(311, 41)
        Me.generateBillingInvoiceBtn.TabIndex = 6
        Me.generateBillingInvoiceBtn.Text = "Generate Billing Invoice"
        Me.generateBillingInvoiceBtn.UseVisualStyleBackColor = True
        '
        'searchBtn
        '
        Me.searchBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.searchBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchBtn.Location = New System.Drawing.Point(3, 221)
        Me.searchBtn.Name = "searchBtn"
        Me.searchBtn.Size = New System.Drawing.Size(311, 41)
        Me.searchBtn.TabIndex = 5
        Me.searchBtn.Text = "Search"
        Me.searchBtn.UseVisualStyleBackColor = True
        '
        'logInOutBtn
        '
        Me.logInOutBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.logInOutBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logInOutBtn.Location = New System.Drawing.Point(3, 180)
        Me.logInOutBtn.Name = "logInOutBtn"
        Me.logInOutBtn.Size = New System.Drawing.Size(311, 41)
        Me.logInOutBtn.TabIndex = 4
        Me.logInOutBtn.Text = "Log In/Out"
        Me.logInOutBtn.UseVisualStyleBackColor = True
        '
        'assignEmployeeBtn
        '
        Me.assignEmployeeBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.assignEmployeeBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.assignEmployeeBtn.Location = New System.Drawing.Point(3, 139)
        Me.assignEmployeeBtn.Name = "assignEmployeeBtn"
        Me.assignEmployeeBtn.Size = New System.Drawing.Size(311, 41)
        Me.assignEmployeeBtn.TabIndex = 3
        Me.assignEmployeeBtn.Text = "Assign Employee to Project"
        Me.assignEmployeeBtn.UseVisualStyleBackColor = True
        '
        'projectsCMStBtn
        '
        Me.projectsCMStBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.projectsCMStBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.projectsCMStBtn.Location = New System.Drawing.Point(3, 98)
        Me.projectsCMStBtn.Name = "projectsCMStBtn"
        Me.projectsCMStBtn.Size = New System.Drawing.Size(311, 41)
        Me.projectsCMStBtn.TabIndex = 2
        Me.projectsCMStBtn.Text = "Projects Management"
        Me.projectsCMStBtn.UseVisualStyleBackColor = True
        '
        'clientsCMSBtn
        '
        Me.clientsCMSBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.clientsCMSBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clientsCMSBtn.Location = New System.Drawing.Point(3, 57)
        Me.clientsCMSBtn.Name = "clientsCMSBtn"
        Me.clientsCMSBtn.Size = New System.Drawing.Size(311, 41)
        Me.clientsCMSBtn.TabIndex = 1
        Me.clientsCMSBtn.Text = "Clients Management"
        Me.clientsCMSBtn.UseVisualStyleBackColor = True
        '
        'employeesCMSBtn
        '
        Me.employeesCMSBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.employeesCMSBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeesCMSBtn.Location = New System.Drawing.Point(3, 16)
        Me.employeesCMSBtn.Name = "employeesCMSBtn"
        Me.employeesCMSBtn.Size = New System.Drawing.Size(311, 41)
        Me.employeesCMSBtn.TabIndex = 0
        Me.employeesCMSBtn.Text = "Employees Management"
        Me.employeesCMSBtn.UseVisualStyleBackColor = True
        '
        'MainMenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 329)
        Me.Controls.Add(Me.mainMenuGB)
        Me.Name = "MainMenuForm"
        Me.Text = "PBDIT Software Engineering Case Study"
        Me.mainMenuGB.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents mainMenuGB As System.Windows.Forms.GroupBox
    Friend WithEvents generateBillingInvoiceBtn As System.Windows.Forms.Button
    Friend WithEvents searchBtn As System.Windows.Forms.Button
    Friend WithEvents logInOutBtn As System.Windows.Forms.Button
    Friend WithEvents assignEmployeeBtn As System.Windows.Forms.Button
    Friend WithEvents projectsCMStBtn As System.Windows.Forms.Button
    Friend WithEvents clientsCMSBtn As System.Windows.Forms.Button
    Friend WithEvents employeesCMSBtn As System.Windows.Forms.Button
End Class
