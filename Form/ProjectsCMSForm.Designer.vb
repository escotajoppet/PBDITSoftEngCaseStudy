<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProjectsCMSForm
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
        Me.viewProjectsGB = New System.Windows.Forms.GroupBox()
        Me.clientCodeLbl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.projectDeleteBtn = New System.Windows.Forms.Button()
        Me.projectEditBtn = New System.Windows.Forms.Button()
        Me.projectsDGV = New System.Windows.Forms.DataGridView()
        Me.crudAddProjectBtn = New System.Windows.Forms.Button()
        Me.backToMainMenuBtn = New System.Windows.Forms.Button()
        Me.projectFormGB = New System.Windows.Forms.GroupBox()
        Me.cancelAddEditBtn = New System.Windows.Forms.Button()
        Me.projectEndDTP = New System.Windows.Forms.DateTimePicker()
        Me.projectStartDTP = New System.Windows.Forms.DateTimePicker()
        Me.addEditProjectBtn = New System.Windows.Forms.Button()
        Me.projectManagerTB = New System.Windows.Forms.TextBox()
        Me.projectNameTB = New System.Windows.Forms.TextBox()
        Me.projectCodeTB = New System.Windows.Forms.TextBox()
        Me.projectEndLbl = New System.Windows.Forms.Label()
        Me.projectStartLbl = New System.Windows.Forms.Label()
        Me.projectManagerLabel = New System.Windows.Forms.Label()
        Me.projectNameLbl = New System.Windows.Forms.Label()
        Me.projectCodeLbl = New System.Windows.Forms.Label()
        Me.projectIDCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.projectCodeCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.projectNameCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.projectManagerCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.projectStartCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.projectEndCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.projectClientCodeCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.viewProjectsGB.SuspendLayout()
        CType(Me.projectsDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.projectFormGB.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(266, 29)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Projects Management"
        '
        'viewProjectsGB
        '
        Me.viewProjectsGB.Controls.Add(Me.clientCodeLbl)
        Me.viewProjectsGB.Controls.Add(Me.Label1)
        Me.viewProjectsGB.Controls.Add(Me.projectDeleteBtn)
        Me.viewProjectsGB.Controls.Add(Me.projectEditBtn)
        Me.viewProjectsGB.Controls.Add(Me.projectsDGV)
        Me.viewProjectsGB.Controls.Add(Me.crudAddProjectBtn)
        Me.viewProjectsGB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewProjectsGB.Location = New System.Drawing.Point(14, 43)
        Me.viewProjectsGB.Name = "viewProjectsGB"
        Me.viewProjectsGB.Size = New System.Drawing.Size(556, 389)
        Me.viewProjectsGB.TabIndex = 24
        Me.viewProjectsGB.TabStop = False
        Me.viewProjectsGB.Text = "Projects List"
        '
        'clientCodeLbl
        '
        Me.clientCodeLbl.AutoSize = True
        Me.clientCodeLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clientCodeLbl.Location = New System.Drawing.Point(83, 17)
        Me.clientCodeLbl.Name = "clientCodeLbl"
        Me.clientCodeLbl.Size = New System.Drawing.Size(20, 17)
        Me.clientCodeLbl.TabIndex = 27
        Me.clientCodeLbl.Text = "..."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Client Code:"
        '
        'projectDeleteBtn
        '
        Me.projectDeleteBtn.BackColor = System.Drawing.SystemColors.Control
        Me.projectDeleteBtn.BackgroundImage = Global.PBDITSoftEngCaseStudy.My.Resources.Resources.remove
        Me.projectDeleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.projectDeleteBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.projectDeleteBtn.Location = New System.Drawing.Point(518, 9)
        Me.projectDeleteBtn.Name = "projectDeleteBtn"
        Me.projectDeleteBtn.Size = New System.Drawing.Size(29, 27)
        Me.projectDeleteBtn.TabIndex = 2
        Me.projectDeleteBtn.UseVisualStyleBackColor = False
        '
        'projectEditBtn
        '
        Me.projectEditBtn.BackColor = System.Drawing.SystemColors.Control
        Me.projectEditBtn.BackgroundImage = Global.PBDITSoftEngCaseStudy.My.Resources.Resources.edit
        Me.projectEditBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.projectEditBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.projectEditBtn.Location = New System.Drawing.Point(483, 9)
        Me.projectEditBtn.Name = "projectEditBtn"
        Me.projectEditBtn.Size = New System.Drawing.Size(29, 27)
        Me.projectEditBtn.TabIndex = 1
        Me.projectEditBtn.UseVisualStyleBackColor = False
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
        Me.projectsDGV.Location = New System.Drawing.Point(9, 40)
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
        Me.projectsDGV.Size = New System.Drawing.Size(538, 343)
        Me.projectsDGV.TabIndex = 0
        '
        'crudAddProjectBtn
        '
        Me.crudAddProjectBtn.BackColor = System.Drawing.SystemColors.Control
        Me.crudAddProjectBtn.BackgroundImage = Global.PBDITSoftEngCaseStudy.My.Resources.Resources.add
        Me.crudAddProjectBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.crudAddProjectBtn.Location = New System.Drawing.Point(446, 9)
        Me.crudAddProjectBtn.Name = "crudAddProjectBtn"
        Me.crudAddProjectBtn.Size = New System.Drawing.Size(29, 27)
        Me.crudAddProjectBtn.TabIndex = 25
        Me.crudAddProjectBtn.UseVisualStyleBackColor = False
        '
        'backToMainMenuBtn
        '
        Me.backToMainMenuBtn.BackColor = System.Drawing.SystemColors.Control
        Me.backToMainMenuBtn.BackgroundImage = Global.PBDITSoftEngCaseStudy.My.Resources.Resources.list
        Me.backToMainMenuBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.backToMainMenuBtn.Location = New System.Drawing.Point(541, 13)
        Me.backToMainMenuBtn.Name = "backToMainMenuBtn"
        Me.backToMainMenuBtn.Size = New System.Drawing.Size(29, 27)
        Me.backToMainMenuBtn.TabIndex = 26
        Me.backToMainMenuBtn.UseVisualStyleBackColor = False
        '
        'projectFormGB
        '
        Me.projectFormGB.Controls.Add(Me.cancelAddEditBtn)
        Me.projectFormGB.Controls.Add(Me.projectEndDTP)
        Me.projectFormGB.Controls.Add(Me.projectStartDTP)
        Me.projectFormGB.Controls.Add(Me.addEditProjectBtn)
        Me.projectFormGB.Controls.Add(Me.projectManagerTB)
        Me.projectFormGB.Controls.Add(Me.projectNameTB)
        Me.projectFormGB.Controls.Add(Me.projectCodeTB)
        Me.projectFormGB.Controls.Add(Me.projectEndLbl)
        Me.projectFormGB.Controls.Add(Me.projectStartLbl)
        Me.projectFormGB.Controls.Add(Me.projectManagerLabel)
        Me.projectFormGB.Controls.Add(Me.projectNameLbl)
        Me.projectFormGB.Controls.Add(Me.projectCodeLbl)
        Me.projectFormGB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.projectFormGB.Location = New System.Drawing.Point(14, 43)
        Me.projectFormGB.Name = "projectFormGB"
        Me.projectFormGB.Size = New System.Drawing.Size(556, 389)
        Me.projectFormGB.TabIndex = 27
        Me.projectFormGB.TabStop = False
        Me.projectFormGB.Visible = False
        '
        'cancelAddEditBtn
        '
        Me.cancelAddEditBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelAddEditBtn.Location = New System.Drawing.Point(438, 360)
        Me.cancelAddEditBtn.Name = "cancelAddEditBtn"
        Me.cancelAddEditBtn.Size = New System.Drawing.Size(112, 23)
        Me.cancelAddEditBtn.TabIndex = 25
        Me.cancelAddEditBtn.Text = "Cancel"
        Me.cancelAddEditBtn.UseVisualStyleBackColor = True
        '
        'projectEndDTP
        '
        Me.projectEndDTP.CustomFormat = "M-dd-yyyy"
        Me.projectEndDTP.Location = New System.Drawing.Point(116, 307)
        Me.projectEndDTP.Name = "projectEndDTP"
        Me.projectEndDTP.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.projectEndDTP.Size = New System.Drawing.Size(434, 20)
        Me.projectEndDTP.TabIndex = 24
        '
        'projectStartDTP
        '
        Me.projectStartDTP.CustomFormat = "M-dd-yyyy"
        Me.projectStartDTP.Location = New System.Drawing.Point(116, 234)
        Me.projectStartDTP.Name = "projectStartDTP"
        Me.projectStartDTP.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.projectStartDTP.Size = New System.Drawing.Size(434, 20)
        Me.projectStartDTP.TabIndex = 23
        '
        'addEditProjectBtn
        '
        Me.addEditProjectBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addEditProjectBtn.Location = New System.Drawing.Point(320, 360)
        Me.addEditProjectBtn.Name = "addEditProjectBtn"
        Me.addEditProjectBtn.Size = New System.Drawing.Size(112, 23)
        Me.addEditProjectBtn.TabIndex = 22
        Me.addEditProjectBtn.UseVisualStyleBackColor = True
        '
        'projectManagerTB
        '
        Me.projectManagerTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.projectManagerTB.Location = New System.Drawing.Point(116, 162)
        Me.projectManagerTB.Name = "projectManagerTB"
        Me.projectManagerTB.Size = New System.Drawing.Size(434, 20)
        Me.projectManagerTB.TabIndex = 7
        '
        'projectNameTB
        '
        Me.projectNameTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.projectNameTB.Location = New System.Drawing.Point(116, 90)
        Me.projectNameTB.Name = "projectNameTB"
        Me.projectNameTB.Size = New System.Drawing.Size(434, 20)
        Me.projectNameTB.TabIndex = 6
        '
        'projectCodeTB
        '
        Me.projectCodeTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.projectCodeTB.Location = New System.Drawing.Point(116, 18)
        Me.projectCodeTB.Name = "projectCodeTB"
        Me.projectCodeTB.Size = New System.Drawing.Size(434, 20)
        Me.projectCodeTB.TabIndex = 5
        '
        'projectEndLbl
        '
        Me.projectEndLbl.AutoSize = True
        Me.projectEndLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.projectEndLbl.Location = New System.Drawing.Point(6, 311)
        Me.projectEndLbl.Name = "projectEndLbl"
        Me.projectEndLbl.Size = New System.Drawing.Size(55, 13)
        Me.projectEndLbl.TabIndex = 4
        Me.projectEndLbl.Text = "End Date:"
        '
        'projectStartLbl
        '
        Me.projectStartLbl.AutoSize = True
        Me.projectStartLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.projectStartLbl.Location = New System.Drawing.Point(6, 238)
        Me.projectStartLbl.Name = "projectStartLbl"
        Me.projectStartLbl.Size = New System.Drawing.Size(58, 13)
        Me.projectStartLbl.TabIndex = 3
        Me.projectStartLbl.Text = "Start Date:"
        '
        'projectManagerLabel
        '
        Me.projectManagerLabel.AutoSize = True
        Me.projectManagerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.projectManagerLabel.Location = New System.Drawing.Point(6, 166)
        Me.projectManagerLabel.Name = "projectManagerLabel"
        Me.projectManagerLabel.Size = New System.Drawing.Size(88, 13)
        Me.projectManagerLabel.TabIndex = 2
        Me.projectManagerLabel.Text = "Project Manager:"
        '
        'projectNameLbl
        '
        Me.projectNameLbl.AutoSize = True
        Me.projectNameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.projectNameLbl.Location = New System.Drawing.Point(6, 94)
        Me.projectNameLbl.Name = "projectNameLbl"
        Me.projectNameLbl.Size = New System.Drawing.Size(74, 13)
        Me.projectNameLbl.TabIndex = 1
        Me.projectNameLbl.Text = "Project Name:"
        '
        'projectCodeLbl
        '
        Me.projectCodeLbl.AutoSize = True
        Me.projectCodeLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.projectCodeLbl.Location = New System.Drawing.Point(6, 22)
        Me.projectCodeLbl.Name = "projectCodeLbl"
        Me.projectCodeLbl.Size = New System.Drawing.Size(71, 13)
        Me.projectCodeLbl.TabIndex = 0
        Me.projectCodeLbl.Text = "Project Code:"
        '
        'projectIDCol
        '
        Me.projectIDCol.HeaderText = "ID"
        Me.projectIDCol.Name = "projectIDCol"
        Me.projectIDCol.ReadOnly = True
        Me.projectIDCol.Visible = False
        Me.projectIDCol.Width = 120
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
        '
        'projectEndCol
        '
        Me.projectEndCol.HeaderText = "End Date"
        Me.projectEndCol.Name = "projectEndCol"
        Me.projectEndCol.ReadOnly = True
        '
        'projectClientCodeCol
        '
        Me.projectClientCodeCol.HeaderText = "Client Code"
        Me.projectClientCodeCol.Name = "projectClientCodeCol"
        Me.projectClientCodeCol.ReadOnly = True
        Me.projectClientCodeCol.Visible = False
        '
        'ProjectsCMSForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 442)
        Me.Controls.Add(Me.backToMainMenuBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.viewProjectsGB)
        Me.Controls.Add(Me.projectFormGB)
        Me.Name = "ProjectsCMSForm"
        Me.Text = "Projects CMS"
        Me.viewProjectsGB.ResumeLayout(False)
        Me.viewProjectsGB.PerformLayout()
        CType(Me.projectsDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.projectFormGB.ResumeLayout(False)
        Me.projectFormGB.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents viewProjectsGB As System.Windows.Forms.GroupBox
    Friend WithEvents projectDeleteBtn As System.Windows.Forms.Button
    Friend WithEvents projectEditBtn As System.Windows.Forms.Button
    Friend WithEvents projectsDGV As System.Windows.Forms.DataGridView
    Friend WithEvents crudAddProjectBtn As System.Windows.Forms.Button
    Friend WithEvents projectFormGB As System.Windows.Forms.GroupBox
    Friend WithEvents projectEndDTP As System.Windows.Forms.DateTimePicker
    Friend WithEvents projectStartDTP As System.Windows.Forms.DateTimePicker
    Friend WithEvents addEditProjectBtn As System.Windows.Forms.Button
    Friend WithEvents projectManagerTB As System.Windows.Forms.TextBox
    Friend WithEvents projectNameTB As System.Windows.Forms.TextBox
    Friend WithEvents projectCodeTB As System.Windows.Forms.TextBox
    Friend WithEvents projectEndLbl As System.Windows.Forms.Label
    Friend WithEvents projectStartLbl As System.Windows.Forms.Label
    Friend WithEvents projectManagerLabel As System.Windows.Forms.Label
    Friend WithEvents projectNameLbl As System.Windows.Forms.Label
    Friend WithEvents projectCodeLbl As System.Windows.Forms.Label
    Friend WithEvents backToMainMenuBtn As System.Windows.Forms.Button
    Friend WithEvents cancelAddEditBtn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents clientCodeLbl As System.Windows.Forms.Label
    Friend WithEvents projectIDCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents projectCodeCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents projectNameCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents projectManagerCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents projectStartCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents projectEndCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents projectClientCodeCol As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
