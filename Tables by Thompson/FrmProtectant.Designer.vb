<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProtectant
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProtectant))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pbWax = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pbFabricShield = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pbNoProtectant = New System.Windows.Forms.PictureBox()
        CType(Me.pbWax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbFabricShield, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbNoProtectant, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(537, 209)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(180, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Waterproofing Wax Treatment (8.50)"
        '
        'pbWax
        '
        Me.pbWax.Image = CType(resources.GetObject("pbWax.Image"), System.Drawing.Image)
        Me.pbWax.Location = New System.Drawing.Point(583, 100)
        Me.pbWax.Name = "pbWax"
        Me.pbWax.Size = New System.Drawing.Size(88, 97)
        Me.pbWax.TabIndex = 12
        Me.pbWax.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(343, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Fabric Shield (5.00)"
        '
        'pbFabricShield
        '
        Me.pbFabricShield.Image = CType(resources.GetObject("pbFabricShield.Image"), System.Drawing.Image)
        Me.pbFabricShield.Location = New System.Drawing.Point(348, 103)
        Me.pbFabricShield.Name = "pbFabricShield"
        Me.pbFabricShield.Size = New System.Drawing.Size(88, 97)
        Me.pbFabricShield.TabIndex = 10
        Me.pbFabricShield.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(113, 209)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "No additional Protectant"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(232, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(336, 26)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Choose Preferred Drop Length"
        '
        'pbNoProtectant
        '
        Me.pbNoProtectant.Image = CType(resources.GetObject("pbNoProtectant.Image"), System.Drawing.Image)
        Me.pbNoProtectant.Location = New System.Drawing.Point(129, 102)
        Me.pbNoProtectant.Name = "pbNoProtectant"
        Me.pbNoProtectant.Size = New System.Drawing.Size(88, 97)
        Me.pbNoProtectant.TabIndex = 7
        Me.pbNoProtectant.TabStop = False
        '
        'FrmProtectant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.pbWax)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pbFabricShield)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pbNoProtectant)
        Me.Name = "FrmProtectant"
        Me.Text = "FrmProtectant"
        CType(Me.pbWax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbFabricShield, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbNoProtectant, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents pbWax As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents pbFabricShield As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pbNoProtectant As PictureBox
End Class
