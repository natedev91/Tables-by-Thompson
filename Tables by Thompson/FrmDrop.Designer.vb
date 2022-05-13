<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDrop
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDrop))
        Me.pbShortDrop = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pbMidDrop = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pbLongDrop = New System.Windows.Forms.PictureBox()
        CType(Me.pbShortDrop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbMidDrop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLongDrop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbShortDrop
        '
        Me.pbShortDrop.Image = CType(resources.GetObject("pbShortDrop.Image"), System.Drawing.Image)
        Me.pbShortDrop.Location = New System.Drawing.Point(122, 151)
        Me.pbShortDrop.Name = "pbShortDrop"
        Me.pbShortDrop.Size = New System.Drawing.Size(136, 60)
        Me.pbShortDrop.TabIndex = 0
        Me.pbShortDrop.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(254, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(336, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Choose Preferred Drop Length"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(137, 221)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Add 12"" to each side"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(367, 221)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Add 15"" to each side"
        '
        'pbMidDrop
        '
        Me.pbMidDrop.Image = CType(resources.GetObject("pbMidDrop.Image"), System.Drawing.Image)
        Me.pbMidDrop.Location = New System.Drawing.Point(352, 152)
        Me.pbMidDrop.Name = "pbMidDrop"
        Me.pbMidDrop.Size = New System.Drawing.Size(136, 60)
        Me.pbMidDrop.TabIndex = 3
        Me.pbMidDrop.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(602, 221)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Add 30"" to each side"
        '
        'pbLongDrop
        '
        Me.pbLongDrop.Image = CType(resources.GetObject("pbLongDrop.Image"), System.Drawing.Image)
        Me.pbLongDrop.Location = New System.Drawing.Point(587, 151)
        Me.pbLongDrop.Name = "pbLongDrop"
        Me.pbLongDrop.Size = New System.Drawing.Size(136, 60)
        Me.pbLongDrop.TabIndex = 5
        Me.pbLongDrop.TabStop = False
        '
        'FrmDrop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 461)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.pbLongDrop)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pbMidDrop)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pbShortDrop)
        Me.Name = "FrmDrop"
        Me.Text = "FrmDrop"
        CType(Me.pbShortDrop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbMidDrop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLongDrop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbShortDrop As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents pbMidDrop As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents pbLongDrop As PictureBox
End Class
