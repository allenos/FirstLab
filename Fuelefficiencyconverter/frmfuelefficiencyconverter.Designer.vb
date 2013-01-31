<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmfuelefficiencyconverter
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
        Me.lblmpg = New System.Windows.Forms.Label()
        Me.txtmpg = New System.Windows.Forms.TextBox()
        Me.btnconvert = New System.Windows.Forms.Button()
        Me.lblkpl = New System.Windows.Forms.Label()
        Me.txtkpl = New System.Windows.Forms.TextBox()
        Me.lblinstructions = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblmpg
        '
        Me.lblmpg.AutoSize = True
        Me.lblmpg.Location = New System.Drawing.Point(28, 42)
        Me.lblmpg.Name = "lblmpg"
        Me.lblmpg.Size = New System.Drawing.Size(27, 13)
        Me.lblmpg.TabIndex = 0
        Me.lblmpg.Text = "mpg"
        '
        'txtmpg
        '
        Me.txtmpg.Location = New System.Drawing.Point(72, 35)
        Me.txtmpg.Name = "txtmpg"
        Me.txtmpg.Size = New System.Drawing.Size(100, 20)
        Me.txtmpg.TabIndex = 1
        '
        'btnconvert
        '
        Me.btnconvert.Location = New System.Drawing.Point(190, 32)
        Me.btnconvert.Name = "btnconvert"
        Me.btnconvert.Size = New System.Drawing.Size(75, 23)
        Me.btnconvert.TabIndex = 2
        Me.btnconvert.Text = "Convert"
        Me.btnconvert.UseVisualStyleBackColor = True
        '
        'lblkpl
        '
        Me.lblkpl.AutoSize = True
        Me.lblkpl.Location = New System.Drawing.Point(288, 42)
        Me.lblkpl.Name = "lblkpl"
        Me.lblkpl.Size = New System.Drawing.Size(21, 13)
        Me.lblkpl.TabIndex = 3
        Me.lblkpl.Text = "kpl"
        '
        'txtkpl
        '
        Me.txtkpl.Location = New System.Drawing.Point(331, 35)
        Me.txtkpl.Name = "txtkpl"
        Me.txtkpl.Size = New System.Drawing.Size(100, 20)
        Me.txtkpl.TabIndex = 4
        '
        'lblinstructions
        '
        Me.lblinstructions.AutoSize = True
        Me.lblinstructions.Location = New System.Drawing.Point(12, 9)
        Me.lblinstructions.Name = "lblinstructions"
        Me.lblinstructions.Size = New System.Drawing.Size(227, 13)
        Me.lblinstructions.TabIndex = 5
        Me.lblinstructions.Text = "Please Enter mpg in the box and press convert"
        '
        'frmfuelefficiencyconverter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 91)
        Me.Controls.Add(Me.lblinstructions)
        Me.Controls.Add(Me.txtkpl)
        Me.Controls.Add(Me.lblkpl)
        Me.Controls.Add(Me.btnconvert)
        Me.Controls.Add(Me.txtmpg)
        Me.Controls.Add(Me.lblmpg)
        Me.Name = "frmfuelefficiencyconverter"
        Me.Text = "Fuel Efficiency Converter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblmpg As System.Windows.Forms.Label
    Friend WithEvents txtmpg As System.Windows.Forms.TextBox
    Friend WithEvents btnconvert As System.Windows.Forms.Button
    Friend WithEvents lblkpl As System.Windows.Forms.Label
    Friend WithEvents txtkpl As System.Windows.Forms.TextBox
    Friend WithEvents lblinstructions As System.Windows.Forms.Label

End Class
