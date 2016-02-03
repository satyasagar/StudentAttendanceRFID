<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class searchlib
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Signout = New System.Windows.Forms.Button
        Me.t1 = New System.Windows.Forms.TextBox
        Me.Due = New System.Windows.Forms.Button
        Me.All = New System.Windows.Forms.Button
        Me.dg = New System.Windows.Forms.DataGridView
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(233, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search Library"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(233, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter Tag"
        '
        'Signout
        '
        Me.Signout.BackColor = System.Drawing.Color.Black
        Me.Signout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Signout.ForeColor = System.Drawing.Color.White
        Me.Signout.Location = New System.Drawing.Point(456, 47)
        Me.Signout.Name = "Signout"
        Me.Signout.Size = New System.Drawing.Size(75, 23)
        Me.Signout.TabIndex = 4
        Me.Signout.Text = "Back"
        Me.Signout.UseVisualStyleBackColor = False
        '
        't1
        '
        Me.t1.BackColor = System.Drawing.Color.Black
        Me.t1.ForeColor = System.Drawing.Color.White
        Me.t1.Location = New System.Drawing.Point(308, 98)
        Me.t1.Name = "t1"
        Me.t1.Size = New System.Drawing.Size(100, 20)
        Me.t1.TabIndex = 5
        '
        'Due
        '
        Me.Due.BackColor = System.Drawing.Color.Black
        Me.Due.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Due.ForeColor = System.Drawing.Color.White
        Me.Due.Location = New System.Drawing.Point(375, 263)
        Me.Due.Name = "Due"
        Me.Due.Size = New System.Drawing.Size(75, 23)
        Me.Due.TabIndex = 6
        Me.Due.Text = "Due"
        Me.Due.UseVisualStyleBackColor = False
        '
        'All
        '
        Me.All.BackColor = System.Drawing.Color.Black
        Me.All.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.All.ForeColor = System.Drawing.Color.White
        Me.All.Location = New System.Drawing.Point(456, 263)
        Me.All.Name = "All"
        Me.All.Size = New System.Drawing.Size(75, 23)
        Me.All.TabIndex = 7
        Me.All.Text = "All"
        Me.All.UseVisualStyleBackColor = False
        '
        'dg
        '
        Me.dg.BackgroundColor = System.Drawing.Color.Black
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Location = New System.Drawing.Point(77, 156)
        Me.dg.Name = "dg"
        Me.dg.Size = New System.Drawing.Size(454, 78)
        Me.dg.TabIndex = 8
        '
        'searchlib
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProjectGuis.My.Resources.Resources.black_background1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(605, 339)
        Me.ControlBox = False
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.All)
        Me.Controls.Add(Me.Due)
        Me.Controls.Add(Me.t1)
        Me.Controls.Add(Me.Signout)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "searchlib"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "searchlib"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Signout As System.Windows.Forms.Button
    Friend WithEvents t1 As System.Windows.Forms.TextBox
    Friend WithEvents Due As System.Windows.Forms.Button
    Friend WithEvents All As System.Windows.Forms.Button
    Friend WithEvents dg As System.Windows.Forms.DataGridView
End Class
