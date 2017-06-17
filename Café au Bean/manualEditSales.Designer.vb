<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class manualEditSales
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
        Me.icedSalesLabel = New System.Windows.Forms.Label()
        Me.latteSalesLabel = New System.Windows.Forms.Label()
        Me.espressoSalesLabel = New System.Windows.Forms.Label()
        Me.cappuccinoSalesLabel = New System.Windows.Forms.Label()
        Me.icedSalesEdit = New System.Windows.Forms.TextBox()
        Me.latteSalesEdit = New System.Windows.Forms.TextBox()
        Me.espressoSalesEdit = New System.Windows.Forms.TextBox()
        Me.cappuccinoSalesEdit = New System.Windows.Forms.TextBox()
        Me.saveButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'icedSalesLabel
        '
        Me.icedSalesLabel.AutoSize = True
        Me.icedSalesLabel.Font = New System.Drawing.Font("Gabriola", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.icedSalesLabel.Location = New System.Drawing.Point(21, 126)
        Me.icedSalesLabel.Name = "icedSalesLabel"
        Me.icedSalesLabel.Size = New System.Drawing.Size(95, 39)
        Me.icedSalesLabel.TabIndex = 13
        Me.icedSalesLabel.Text = "Iced Coffees:"
        '
        'latteSalesLabel
        '
        Me.latteSalesLabel.AutoSize = True
        Me.latteSalesLabel.Font = New System.Drawing.Font("Gabriola", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.latteSalesLabel.Location = New System.Drawing.Point(58, 87)
        Me.latteSalesLabel.Name = "latteSalesLabel"
        Me.latteSalesLabel.Size = New System.Drawing.Size(58, 39)
        Me.latteSalesLabel.TabIndex = 12
        Me.latteSalesLabel.Text = "Lattes:"
        '
        'espressoSalesLabel
        '
        Me.espressoSalesLabel.AutoSize = True
        Me.espressoSalesLabel.Font = New System.Drawing.Font("Gabriola", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.espressoSalesLabel.Location = New System.Drawing.Point(34, 48)
        Me.espressoSalesLabel.Name = "espressoSalesLabel"
        Me.espressoSalesLabel.Size = New System.Drawing.Size(82, 39)
        Me.espressoSalesLabel.TabIndex = 11
        Me.espressoSalesLabel.Text = "Espressos:"
        '
        'cappuccinoSalesLabel
        '
        Me.cappuccinoSalesLabel.AutoSize = True
        Me.cappuccinoSalesLabel.Font = New System.Drawing.Font("Gabriola", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cappuccinoSalesLabel.Location = New System.Drawing.Point(12, 9)
        Me.cappuccinoSalesLabel.Name = "cappuccinoSalesLabel"
        Me.cappuccinoSalesLabel.Size = New System.Drawing.Size(104, 39)
        Me.cappuccinoSalesLabel.TabIndex = 10
        Me.cappuccinoSalesLabel.Text = "Cappuccinos:"
        '
        'icedSalesEdit
        '
        Me.icedSalesEdit.Location = New System.Drawing.Point(113, 137)
        Me.icedSalesEdit.Name = "icedSalesEdit"
        Me.icedSalesEdit.Size = New System.Drawing.Size(100, 20)
        Me.icedSalesEdit.TabIndex = 14
        '
        'latteSalesEdit
        '
        Me.latteSalesEdit.Location = New System.Drawing.Point(113, 98)
        Me.latteSalesEdit.Name = "latteSalesEdit"
        Me.latteSalesEdit.Size = New System.Drawing.Size(100, 20)
        Me.latteSalesEdit.TabIndex = 15
        '
        'espressoSalesEdit
        '
        Me.espressoSalesEdit.Location = New System.Drawing.Point(113, 59)
        Me.espressoSalesEdit.Name = "espressoSalesEdit"
        Me.espressoSalesEdit.Size = New System.Drawing.Size(100, 20)
        Me.espressoSalesEdit.TabIndex = 16
        '
        'cappuccinoSalesEdit
        '
        Me.cappuccinoSalesEdit.Location = New System.Drawing.Point(113, 20)
        Me.cappuccinoSalesEdit.Name = "cappuccinoSalesEdit"
        Me.cappuccinoSalesEdit.Size = New System.Drawing.Size(100, 20)
        Me.cappuccinoSalesEdit.TabIndex = 17
        '
        'saveButton
        '
        Me.saveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveButton.Location = New System.Drawing.Point(65, 168)
        Me.saveButton.Name = "saveButton"
        Me.saveButton.Size = New System.Drawing.Size(102, 40)
        Me.saveButton.TabIndex = 18
        Me.saveButton.Text = "Save"
        Me.saveButton.UseVisualStyleBackColor = True
        '
        'manualEditSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(234, 220)
        Me.Controls.Add(Me.saveButton)
        Me.Controls.Add(Me.cappuccinoSalesEdit)
        Me.Controls.Add(Me.espressoSalesEdit)
        Me.Controls.Add(Me.latteSalesEdit)
        Me.Controls.Add(Me.icedSalesEdit)
        Me.Controls.Add(Me.icedSalesLabel)
        Me.Controls.Add(Me.latteSalesLabel)
        Me.Controls.Add(Me.espressoSalesLabel)
        Me.Controls.Add(Me.cappuccinoSalesLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "manualEditSales"
        Me.ShowIcon = False
        Me.Text = "Editing Sales Manually"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents icedSalesLabel As Label
    Friend WithEvents latteSalesLabel As Label
    Friend WithEvents espressoSalesLabel As Label
    Friend WithEvents cappuccinoSalesLabel As Label
    Friend WithEvents icedSalesEdit As TextBox
    Friend WithEvents latteSalesEdit As TextBox
    Friend WithEvents espressoSalesEdit As TextBox
    Friend WithEvents cappuccinoSalesEdit As TextBox
    Friend WithEvents saveButton As Button
End Class
