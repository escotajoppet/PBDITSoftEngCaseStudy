<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchForm
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
        Me.backToMainMenuBtn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.searchResultsDGV = New System.Windows.Forms.DataGridView()
        Me.searchTB = New System.Windows.Forms.TextBox()
        Me.searchCB = New System.Windows.Forms.ComboBox()
        Me.byCB = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.searchResultsDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 29)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Search Contents"
        '
        'backToMainMenuBtn
        '
        Me.backToMainMenuBtn.BackColor = System.Drawing.SystemColors.Control
        Me.backToMainMenuBtn.BackgroundImage = Global.PBDITSoftEngCaseStudy.My.Resources.Resources.list
        Me.backToMainMenuBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.backToMainMenuBtn.Location = New System.Drawing.Point(548, 10)
        Me.backToMainMenuBtn.Name = "backToMainMenuBtn"
        Me.backToMainMenuBtn.Size = New System.Drawing.Size(29, 27)
        Me.backToMainMenuBtn.TabIndex = 29
        Me.backToMainMenuBtn.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.searchResultsDGV)
        Me.GroupBox1.Controls.Add(Me.searchTB)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(555, 389)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Form"
        '
        'searchResultsDGV
        '
        Me.searchResultsDGV.AllowUserToAddRows = False
        Me.searchResultsDGV.AllowUserToDeleteRows = False
        Me.searchResultsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.searchResultsDGV.Location = New System.Drawing.Point(10, 45)
        Me.searchResultsDGV.Name = "searchResultsDGV"
        Me.searchResultsDGV.ReadOnly = True
        Me.searchResultsDGV.RowHeadersVisible = False
        Me.searchResultsDGV.Size = New System.Drawing.Size(539, 338)
        Me.searchResultsDGV.TabIndex = 6
        '
        'searchTB
        '
        Me.searchTB.Location = New System.Drawing.Point(10, 19)
        Me.searchTB.Name = "searchTB"
        Me.searchTB.Size = New System.Drawing.Size(539, 20)
        Me.searchTB.TabIndex = 4
        '
        'searchCB
        '
        Me.searchCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.searchCB.FormattingEnabled = True
        Me.searchCB.Items.AddRange(New Object() {"Employees", "Clients", "Projects"})
        Me.searchCB.Location = New System.Drawing.Point(273, 13)
        Me.searchCB.Name = "searchCB"
        Me.searchCB.Size = New System.Drawing.Size(100, 21)
        Me.searchCB.TabIndex = 0
        '
        'byCB
        '
        Me.byCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.byCB.FormattingEnabled = True
        Me.byCB.Location = New System.Drawing.Point(407, 13)
        Me.byCB.Name = "byCB"
        Me.byCB.Size = New System.Drawing.Size(119, 21)
        Me.byCB.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(223, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Search:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(379, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "By:"
        '
        'SearchForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 442)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.backToMainMenuBtn)
        Me.Controls.Add(Me.byCB)
        Me.Controls.Add(Me.searchCB)
        Me.Name = "SearchForm"
        Me.Text = "Search"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.searchResultsDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents backToMainMenuBtn As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents searchTB As System.Windows.Forms.TextBox
    Friend WithEvents searchCB As System.Windows.Forms.ComboBox
    Friend WithEvents byCB As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents searchResultsDGV As System.Windows.Forms.DataGridView
End Class
