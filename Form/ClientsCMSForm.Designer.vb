<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientsCMSForm
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
        Me.backToMainMenuBtn = New System.Windows.Forms.Button()
        Me.viewClientsGB = New System.Windows.Forms.GroupBox()
        Me.deleteClientBtn = New System.Windows.Forms.Button()
        Me.editClientBtn = New System.Windows.Forms.Button()
        Me.clientsDGV = New System.Windows.Forms.DataGridView()
        Me.clientIDCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clientCodeCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clientNameCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clientAddressCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clientCityCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clientContactPersonCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clientContactNumberCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.crudAddClientBtn = New System.Windows.Forms.Button()
        Me.formClientGB = New System.Windows.Forms.GroupBox()
        Me.cancelAddEditBtn = New System.Windows.Forms.Button()
        Me.addEditClientBtn = New System.Windows.Forms.Button()
        Me.clientContactNumberTB = New System.Windows.Forms.TextBox()
        Me.clientContactPersonTB = New System.Windows.Forms.TextBox()
        Me.clientCityTB = New System.Windows.Forms.TextBox()
        Me.clientAddressTB = New System.Windows.Forms.TextBox()
        Me.clientNameTB = New System.Windows.Forms.TextBox()
        Me.clientCodeTB = New System.Windows.Forms.TextBox()
        Me.clientContactNumberLbl = New System.Windows.Forms.Label()
        Me.clientContactPersonLbl = New System.Windows.Forms.Label()
        Me.clientCityLbl = New System.Windows.Forms.Label()
        Me.clientAddressLbl = New System.Windows.Forms.Label()
        Me.clientNameLbl = New System.Windows.Forms.Label()
        Me.clientCodeLbl = New System.Windows.Forms.Label()
        Me.viewClientsGB.SuspendLayout()
        CType(Me.clientsDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.formClientGB.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(251, 29)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Clients Management"
        '
        'backToMainMenuBtn
        '
        Me.backToMainMenuBtn.BackColor = System.Drawing.SystemColors.Control
        Me.backToMainMenuBtn.BackgroundImage = Global.PBDITSoftEngCaseStudy.My.Resources.Resources.list
        Me.backToMainMenuBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.backToMainMenuBtn.Location = New System.Drawing.Point(541, 13)
        Me.backToMainMenuBtn.Name = "backToMainMenuBtn"
        Me.backToMainMenuBtn.Size = New System.Drawing.Size(29, 27)
        Me.backToMainMenuBtn.TabIndex = 29
        Me.backToMainMenuBtn.UseVisualStyleBackColor = False
        '
        'viewClientsGB
        '
        Me.viewClientsGB.Controls.Add(Me.deleteClientBtn)
        Me.viewClientsGB.Controls.Add(Me.editClientBtn)
        Me.viewClientsGB.Controls.Add(Me.clientsDGV)
        Me.viewClientsGB.Controls.Add(Me.crudAddClientBtn)
        Me.viewClientsGB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewClientsGB.Location = New System.Drawing.Point(14, 43)
        Me.viewClientsGB.Name = "viewClientsGB"
        Me.viewClientsGB.Size = New System.Drawing.Size(556, 389)
        Me.viewClientsGB.TabIndex = 28
        Me.viewClientsGB.TabStop = False
        Me.viewClientsGB.Text = "Clients List"
        '
        'deleteClientBtn
        '
        Me.deleteClientBtn.BackColor = System.Drawing.SystemColors.Control
        Me.deleteClientBtn.BackgroundImage = Global.PBDITSoftEngCaseStudy.My.Resources.Resources.remove
        Me.deleteClientBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.deleteClientBtn.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.deleteClientBtn.Location = New System.Drawing.Point(518, 9)
        Me.deleteClientBtn.Name = "deleteClientBtn"
        Me.deleteClientBtn.Size = New System.Drawing.Size(29, 27)
        Me.deleteClientBtn.TabIndex = 2
        Me.deleteClientBtn.UseVisualStyleBackColor = False
        '
        'editClientBtn
        '
        Me.editClientBtn.BackColor = System.Drawing.SystemColors.Control
        Me.editClientBtn.BackgroundImage = Global.PBDITSoftEngCaseStudy.My.Resources.Resources.edit
        Me.editClientBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.editClientBtn.Location = New System.Drawing.Point(483, 9)
        Me.editClientBtn.Name = "editClientBtn"
        Me.editClientBtn.Size = New System.Drawing.Size(29, 27)
        Me.editClientBtn.TabIndex = 1
        Me.editClientBtn.UseVisualStyleBackColor = False
        '
        'clientsDGV
        '
        Me.clientsDGV.AllowUserToAddRows = False
        Me.clientsDGV.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clientsDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.clientsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.clientsDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clientIDCol, Me.clientCodeCol, Me.clientNameCol, Me.clientAddressCol, Me.clientCityCol, Me.clientContactPersonCol, Me.clientContactNumberCol})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clientsDGV.DefaultCellStyle = DataGridViewCellStyle2
        Me.clientsDGV.Location = New System.Drawing.Point(9, 39)
        Me.clientsDGV.Name = "clientsDGV"
        Me.clientsDGV.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clientsDGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.clientsDGV.RowHeadersVisible = False
        Me.clientsDGV.Size = New System.Drawing.Size(538, 344)
        Me.clientsDGV.TabIndex = 0
        '
        'clientIDCol
        '
        Me.clientIDCol.HeaderText = "ID"
        Me.clientIDCol.Name = "clientIDCol"
        Me.clientIDCol.ReadOnly = True
        Me.clientIDCol.Visible = False
        Me.clientIDCol.Width = 120
        '
        'clientCodeCol
        '
        Me.clientCodeCol.HeaderText = "Client Code"
        Me.clientCodeCol.Name = "clientCodeCol"
        Me.clientCodeCol.ReadOnly = True
        '
        'clientNameCol
        '
        Me.clientNameCol.HeaderText = "Client Name"
        Me.clientNameCol.Name = "clientNameCol"
        Me.clientNameCol.ReadOnly = True
        '
        'clientAddressCol
        '
        Me.clientAddressCol.HeaderText = "Address"
        Me.clientAddressCol.Name = "clientAddressCol"
        Me.clientAddressCol.ReadOnly = True
        '
        'clientCityCol
        '
        Me.clientCityCol.HeaderText = "City"
        Me.clientCityCol.Name = "clientCityCol"
        Me.clientCityCol.ReadOnly = True
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
        'crudAddClientBtn
        '
        Me.crudAddClientBtn.BackColor = System.Drawing.SystemColors.Control
        Me.crudAddClientBtn.BackgroundImage = Global.PBDITSoftEngCaseStudy.My.Resources.Resources.add
        Me.crudAddClientBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.crudAddClientBtn.Location = New System.Drawing.Point(448, 9)
        Me.crudAddClientBtn.Name = "crudAddClientBtn"
        Me.crudAddClientBtn.Size = New System.Drawing.Size(29, 27)
        Me.crudAddClientBtn.TabIndex = 27
        Me.crudAddClientBtn.UseVisualStyleBackColor = False
        '
        'formClientGB
        '
        Me.formClientGB.Controls.Add(Me.cancelAddEditBtn)
        Me.formClientGB.Controls.Add(Me.addEditClientBtn)
        Me.formClientGB.Controls.Add(Me.clientContactNumberTB)
        Me.formClientGB.Controls.Add(Me.clientContactPersonTB)
        Me.formClientGB.Controls.Add(Me.clientCityTB)
        Me.formClientGB.Controls.Add(Me.clientAddressTB)
        Me.formClientGB.Controls.Add(Me.clientNameTB)
        Me.formClientGB.Controls.Add(Me.clientCodeTB)
        Me.formClientGB.Controls.Add(Me.clientContactNumberLbl)
        Me.formClientGB.Controls.Add(Me.clientContactPersonLbl)
        Me.formClientGB.Controls.Add(Me.clientCityLbl)
        Me.formClientGB.Controls.Add(Me.clientAddressLbl)
        Me.formClientGB.Controls.Add(Me.clientNameLbl)
        Me.formClientGB.Controls.Add(Me.clientCodeLbl)
        Me.formClientGB.Cursor = System.Windows.Forms.Cursors.Default
        Me.formClientGB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.formClientGB.Location = New System.Drawing.Point(14, 43)
        Me.formClientGB.Name = "formClientGB"
        Me.formClientGB.Size = New System.Drawing.Size(556, 389)
        Me.formClientGB.TabIndex = 30
        Me.formClientGB.TabStop = False
        '
        'cancelAddEditBtn
        '
        Me.cancelAddEditBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelAddEditBtn.Location = New System.Drawing.Point(435, 360)
        Me.cancelAddEditBtn.Name = "cancelAddEditBtn"
        Me.cancelAddEditBtn.Size = New System.Drawing.Size(112, 23)
        Me.cancelAddEditBtn.TabIndex = 14
        Me.cancelAddEditBtn.Text = "Cancel"
        Me.cancelAddEditBtn.UseVisualStyleBackColor = True
        '
        'addEditClientBtn
        '
        Me.addEditClientBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addEditClientBtn.Location = New System.Drawing.Point(317, 360)
        Me.addEditClientBtn.Name = "addEditClientBtn"
        Me.addEditClientBtn.Size = New System.Drawing.Size(112, 23)
        Me.addEditClientBtn.TabIndex = 13
        Me.addEditClientBtn.UseVisualStyleBackColor = True
        '
        'clientContactNumberTB
        '
        Me.clientContactNumberTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clientContactNumberTB.Location = New System.Drawing.Point(89, 325)
        Me.clientContactNumberTB.Name = "clientContactNumberTB"
        Me.clientContactNumberTB.Size = New System.Drawing.Size(458, 20)
        Me.clientContactNumberTB.TabIndex = 12
        '
        'clientContactPersonTB
        '
        Me.clientContactPersonTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clientContactPersonTB.Location = New System.Drawing.Point(89, 263)
        Me.clientContactPersonTB.Name = "clientContactPersonTB"
        Me.clientContactPersonTB.Size = New System.Drawing.Size(458, 20)
        Me.clientContactPersonTB.TabIndex = 11
        '
        'clientCityTB
        '
        Me.clientCityTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clientCityTB.Location = New System.Drawing.Point(89, 203)
        Me.clientCityTB.Name = "clientCityTB"
        Me.clientCityTB.Size = New System.Drawing.Size(458, 20)
        Me.clientCityTB.TabIndex = 10
        '
        'clientAddressTB
        '
        Me.clientAddressTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clientAddressTB.Location = New System.Drawing.Point(89, 142)
        Me.clientAddressTB.Name = "clientAddressTB"
        Me.clientAddressTB.Size = New System.Drawing.Size(458, 20)
        Me.clientAddressTB.TabIndex = 9
        '
        'clientNameTB
        '
        Me.clientNameTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clientNameTB.Location = New System.Drawing.Point(89, 81)
        Me.clientNameTB.Name = "clientNameTB"
        Me.clientNameTB.Size = New System.Drawing.Size(458, 20)
        Me.clientNameTB.TabIndex = 8
        '
        'clientCodeTB
        '
        Me.clientCodeTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clientCodeTB.Location = New System.Drawing.Point(89, 20)
        Me.clientCodeTB.Name = "clientCodeTB"
        Me.clientCodeTB.Size = New System.Drawing.Size(458, 20)
        Me.clientCodeTB.TabIndex = 7
        '
        'clientContactNumberLbl
        '
        Me.clientContactNumberLbl.AutoSize = True
        Me.clientContactNumberLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clientContactNumberLbl.Location = New System.Drawing.Point(6, 328)
        Me.clientContactNumberLbl.Name = "clientContactNumberLbl"
        Me.clientContactNumberLbl.Size = New System.Drawing.Size(67, 13)
        Me.clientContactNumberLbl.TabIndex = 6
        Me.clientContactNumberLbl.Text = "Contact No.:"
        '
        'clientContactPersonLbl
        '
        Me.clientContactPersonLbl.AutoSize = True
        Me.clientContactPersonLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clientContactPersonLbl.Location = New System.Drawing.Point(6, 266)
        Me.clientContactPersonLbl.Name = "clientContactPersonLbl"
        Me.clientContactPersonLbl.Size = New System.Drawing.Size(83, 13)
        Me.clientContactPersonLbl.TabIndex = 5
        Me.clientContactPersonLbl.Text = "Contact Person:"
        '
        'clientCityLbl
        '
        Me.clientCityLbl.AutoSize = True
        Me.clientCityLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clientCityLbl.Location = New System.Drawing.Point(6, 206)
        Me.clientCityLbl.Name = "clientCityLbl"
        Me.clientCityLbl.Size = New System.Drawing.Size(27, 13)
        Me.clientCityLbl.TabIndex = 4
        Me.clientCityLbl.Text = "City:"
        '
        'clientAddressLbl
        '
        Me.clientAddressLbl.AutoSize = True
        Me.clientAddressLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clientAddressLbl.Location = New System.Drawing.Point(6, 145)
        Me.clientAddressLbl.Name = "clientAddressLbl"
        Me.clientAddressLbl.Size = New System.Drawing.Size(48, 13)
        Me.clientAddressLbl.TabIndex = 3
        Me.clientAddressLbl.Text = "Address:"
        '
        'clientNameLbl
        '
        Me.clientNameLbl.AutoSize = True
        Me.clientNameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clientNameLbl.Location = New System.Drawing.Point(6, 84)
        Me.clientNameLbl.Name = "clientNameLbl"
        Me.clientNameLbl.Size = New System.Drawing.Size(67, 13)
        Me.clientNameLbl.TabIndex = 2
        Me.clientNameLbl.Text = "Client Name:"
        '
        'clientCodeLbl
        '
        Me.clientCodeLbl.AutoSize = True
        Me.clientCodeLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clientCodeLbl.Location = New System.Drawing.Point(6, 23)
        Me.clientCodeLbl.Name = "clientCodeLbl"
        Me.clientCodeLbl.Size = New System.Drawing.Size(64, 13)
        Me.clientCodeLbl.TabIndex = 0
        Me.clientCodeLbl.Text = "Client Code:"
        '
        'ClientsCMSForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 442)
        Me.Controls.Add(Me.backToMainMenuBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.formClientGB)
        Me.Controls.Add(Me.viewClientsGB)
        Me.Name = "ClientsCMSForm"
        Me.Text = "Clients CMS"
        Me.viewClientsGB.ResumeLayout(False)
        CType(Me.clientsDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.formClientGB.ResumeLayout(False)
        Me.formClientGB.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents backToMainMenuBtn As System.Windows.Forms.Button
    Friend WithEvents viewClientsGB As System.Windows.Forms.GroupBox
    Friend WithEvents deleteClientBtn As System.Windows.Forms.Button
    Friend WithEvents editClientBtn As System.Windows.Forms.Button
    Friend WithEvents clientsDGV As System.Windows.Forms.DataGridView
    Friend WithEvents clientIDCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clientCodeCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clientNameCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clientAddressCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clientCityCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clientContactPersonCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clientContactNumberCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents crudAddClientBtn As System.Windows.Forms.Button
    Friend WithEvents formClientGB As System.Windows.Forms.GroupBox
    Friend WithEvents addEditClientBtn As System.Windows.Forms.Button
    Friend WithEvents clientContactNumberTB As System.Windows.Forms.TextBox
    Friend WithEvents clientContactPersonTB As System.Windows.Forms.TextBox
    Friend WithEvents clientCityTB As System.Windows.Forms.TextBox
    Friend WithEvents clientAddressTB As System.Windows.Forms.TextBox
    Friend WithEvents clientNameTB As System.Windows.Forms.TextBox
    Friend WithEvents clientCodeTB As System.Windows.Forms.TextBox
    Friend WithEvents clientContactNumberLbl As System.Windows.Forms.Label
    Friend WithEvents clientContactPersonLbl As System.Windows.Forms.Label
    Friend WithEvents clientCityLbl As System.Windows.Forms.Label
    Friend WithEvents clientAddressLbl As System.Windows.Forms.Label
    Friend WithEvents clientNameLbl As System.Windows.Forms.Label
    Friend WithEvents clientCodeLbl As System.Windows.Forms.Label
    Friend WithEvents cancelAddEditBtn As System.Windows.Forms.Button
End Class
