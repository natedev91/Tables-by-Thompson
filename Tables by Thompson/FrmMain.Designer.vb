<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnPickFabric = New System.Windows.Forms.Button()
        Me.lblFabric = New System.Windows.Forms.Label()
        Me.btnPickDrop = New System.Windows.Forms.Button()
        Me.lblDrop = New System.Windows.Forms.Label()
        Me.btnPickProtectant = New System.Windows.Forms.Button()
        Me.lblProtectant = New System.Windows.Forms.Label()
        Me.txtLength = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtWidth = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblDimensions = New System.Windows.Forms.Label()
        Me.lblErrors = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblFabricCost = New System.Windows.Forms.Label()
        Me.lblProtectantCost = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(185, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(430, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tables by Thompson -- Tablecloth Calculator"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCalculate)
        Me.GroupBox1.Controls.Add(Me.btnPickFabric)
        Me.GroupBox1.Controls.Add(Me.lblFabric)
        Me.GroupBox1.Controls.Add(Me.btnPickDrop)
        Me.GroupBox1.Controls.Add(Me.lblDrop)
        Me.GroupBox1.Controls.Add(Me.btnPickProtectant)
        Me.GroupBox1.Controls.Add(Me.lblProtectant)
        Me.GroupBox1.Controls.Add(Me.txtLength)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtWidth)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(51, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(376, 315)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Table Dimensions"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(128, 257)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(120, 23)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "&Calculate Cost"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnPickFabric
        '
        Me.btnPickFabric.Location = New System.Drawing.Point(38, 128)
        Me.btnPickFabric.Name = "btnPickFabric"
        Me.btnPickFabric.Size = New System.Drawing.Size(144, 23)
        Me.btnPickFabric.TabIndex = 2
        Me.btnPickFabric.Text = "Choose Fabric"
        Me.btnPickFabric.UseVisualStyleBackColor = True
        '
        'lblFabric
        '
        Me.lblFabric.Location = New System.Drawing.Point(205, 128)
        Me.lblFabric.Name = "lblFabric"
        Me.lblFabric.Size = New System.Drawing.Size(134, 23)
        Me.lblFabric.TabIndex = 8
        Me.lblFabric.Text = "<no selection>"
        Me.lblFabric.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPickDrop
        '
        Me.btnPickDrop.Location = New System.Drawing.Point(38, 157)
        Me.btnPickDrop.Name = "btnPickDrop"
        Me.btnPickDrop.Size = New System.Drawing.Size(144, 23)
        Me.btnPickDrop.TabIndex = 3
        Me.btnPickDrop.Text = "Choose Drop"
        Me.btnPickDrop.UseVisualStyleBackColor = True
        '
        'lblDrop
        '
        Me.lblDrop.Location = New System.Drawing.Point(205, 157)
        Me.lblDrop.Name = "lblDrop"
        Me.lblDrop.Size = New System.Drawing.Size(134, 23)
        Me.lblDrop.TabIndex = 6
        Me.lblDrop.Text = "<no selection>"
        Me.lblDrop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPickProtectant
        '
        Me.btnPickProtectant.Location = New System.Drawing.Point(38, 186)
        Me.btnPickProtectant.Name = "btnPickProtectant"
        Me.btnPickProtectant.Size = New System.Drawing.Size(144, 23)
        Me.btnPickProtectant.TabIndex = 4
        Me.btnPickProtectant.Text = "Choose Fabric Protectant"
        Me.btnPickProtectant.UseVisualStyleBackColor = True
        '
        'lblProtectant
        '
        Me.lblProtectant.Location = New System.Drawing.Point(205, 186)
        Me.lblProtectant.Name = "lblProtectant"
        Me.lblProtectant.Size = New System.Drawing.Size(134, 23)
        Me.lblProtectant.TabIndex = 4
        Me.lblProtectant.Text = "<no selection>"
        Me.lblProtectant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtLength
        '
        Me.txtLength.Location = New System.Drawing.Point(164, 71)
        Me.txtLength.Name = "txtLength"
        Me.txtLength.Size = New System.Drawing.Size(100, 20)
        Me.txtLength.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(113, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Length"
        '
        'txtWidth
        '
        Me.txtWidth.Location = New System.Drawing.Point(164, 36)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(100, 20)
        Me.txtWidth.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(120, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Width"
        '
        'lblDimensions
        '
        Me.lblDimensions.Location = New System.Drawing.Point(496, 80)
        Me.lblDimensions.Name = "lblDimensions"
        Me.lblDimensions.Size = New System.Drawing.Size(250, 23)
        Me.lblDimensions.TabIndex = 2
        '
        'lblErrors
        '
        Me.lblErrors.Location = New System.Drawing.Point(453, 309)
        Me.lblErrors.Name = "lblErrors"
        Me.lblErrors.Size = New System.Drawing.Size(319, 86)
        Me.lblErrors.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(502, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Fabric Cost:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFabricCost
        '
        Me.lblFabricCost.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.lblFabricCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFabricCost.Enabled = False
        Me.lblFabricCost.Location = New System.Drawing.Point(598, 117)
        Me.lblFabricCost.Name = "lblFabricCost"
        Me.lblFabricCost.Size = New System.Drawing.Size(100, 23)
        Me.lblFabricCost.TabIndex = 5
        Me.lblFabricCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblProtectantCost
        '
        Me.lblProtectantCost.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.lblProtectantCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProtectantCost.Enabled = False
        Me.lblProtectantCost.Location = New System.Drawing.Point(598, 150)
        Me.lblProtectantCost.Name = "lblProtectantCost"
        Me.lblProtectantCost.Size = New System.Drawing.Size(100, 23)
        Me.lblProtectantCost.TabIndex = 7
        Me.lblProtectantCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(509, 153)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 15)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Protectant:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTax
        '
        Me.lblTax.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTax.Enabled = False
        Me.lblTax.Location = New System.Drawing.Point(598, 237)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(100, 23)
        Me.lblTax.TabIndex = 11
        Me.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(551, 240)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 15)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Tax:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSubtotal
        '
        Me.lblSubtotal.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSubtotal.Enabled = False
        Me.lblSubtotal.Location = New System.Drawing.Point(598, 208)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(100, 23)
        Me.lblSubtotal.TabIndex = 9
        Me.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(521, 211)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 15)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Subtotal:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Enabled = False
        Me.lblTotal.Location = New System.Drawing.Point(598, 266)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblTotal.TabIndex = 13
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(542, 269)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 15)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Total:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmMain
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblSubtotal)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblProtectantCost)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblFabricCost)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblErrors)
        Me.Controls.Add(Me.lblDimensions)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmMain"
        Me.Text = "Tables By Thompson"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnPickFabric As Button
    Friend WithEvents btnPickDrop As Button
    Friend WithEvents btnPickProtectant As Button
    Friend WithEvents txtLength As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtWidth As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblDimensions As Label
    Friend WithEvents lblErrors As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblFabricCost As Label
    Friend WithEvents lblProtectantCost As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblFabric As Label
    Friend WithEvents lblDrop As Label
    Friend WithEvents lblProtectant As Label
End Class
