<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newSalesWindow
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
        Me.cappuccinoAmountBox = New System.Windows.Forms.TextBox()
        Me.cappuccinoAmountLabel = New System.Windows.Forms.Label()
        Me.espressoAmountBox = New System.Windows.Forms.TextBox()
        Me.espressoAmountLabel = New System.Windows.Forms.Label()
        Me.latteAmountBox = New System.Windows.Forms.TextBox()
        Me.latteAmountLabel = New System.Windows.Forms.Label()
        Me.icedAmountBox = New System.Windows.Forms.TextBox()
        Me.icedAmountLabel = New System.Windows.Forms.Label()
        Me.cappuccinoPriceLabel = New System.Windows.Forms.Label()
        Me.espressoPriceLabel = New System.Windows.Forms.Label()
        Me.lattePriceLabel = New System.Windows.Forms.Label()
        Me.icedPriceLabel = New System.Windows.Forms.Label()
        Me.subTotalLabel = New System.Windows.Forms.Label()
        Me.subTotalValue = New System.Windows.Forms.Label()
        Me.totalValue = New System.Windows.Forms.Label()
        Me.totalLabel = New System.Windows.Forms.Label()
        Me.taxValue = New System.Windows.Forms.Label()
        Me.taxLabel = New System.Windows.Forms.Label()
        Me.takewayConfirmation = New System.Windows.Forms.CheckBox()
        Me.completeButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.takewayValueLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cappuccinoAmountBox
        '
        Me.cappuccinoAmountBox.Location = New System.Drawing.Point(12, 25)
        Me.cappuccinoAmountBox.Name = "cappuccinoAmountBox"
        Me.cappuccinoAmountBox.Size = New System.Drawing.Size(47, 20)
        Me.cappuccinoAmountBox.TabIndex = 0
        '
        'cappuccinoAmountLabel
        '
        Me.cappuccinoAmountLabel.AutoSize = True
        Me.cappuccinoAmountLabel.Font = New System.Drawing.Font("Gabriola", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cappuccinoAmountLabel.Location = New System.Drawing.Point(55, 14)
        Me.cappuccinoAmountLabel.Name = "cappuccinoAmountLabel"
        Me.cappuccinoAmountLabel.Size = New System.Drawing.Size(118, 39)
        Me.cappuccinoAmountLabel.TabIndex = 3
        Me.cappuccinoAmountLabel.Text = "x Cappuccino/s"
        '
        'espressoAmountBox
        '
        Me.espressoAmountBox.Location = New System.Drawing.Point(12, 109)
        Me.espressoAmountBox.Name = "espressoAmountBox"
        Me.espressoAmountBox.Size = New System.Drawing.Size(47, 20)
        Me.espressoAmountBox.TabIndex = 4
        '
        'espressoAmountLabel
        '
        Me.espressoAmountLabel.AutoSize = True
        Me.espressoAmountLabel.Font = New System.Drawing.Font("Gabriola", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.espressoAmountLabel.Location = New System.Drawing.Point(55, 98)
        Me.espressoAmountLabel.Name = "espressoAmountLabel"
        Me.espressoAmountLabel.Size = New System.Drawing.Size(96, 39)
        Me.espressoAmountLabel.TabIndex = 5
        Me.espressoAmountLabel.Text = "x Espresso/s"
        '
        'latteAmountBox
        '
        Me.latteAmountBox.Location = New System.Drawing.Point(204, 25)
        Me.latteAmountBox.Name = "latteAmountBox"
        Me.latteAmountBox.Size = New System.Drawing.Size(47, 20)
        Me.latteAmountBox.TabIndex = 6
        '
        'latteAmountLabel
        '
        Me.latteAmountLabel.AutoSize = True
        Me.latteAmountLabel.Font = New System.Drawing.Font("Gabriola", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.latteAmountLabel.Location = New System.Drawing.Point(247, 14)
        Me.latteAmountLabel.Name = "latteAmountLabel"
        Me.latteAmountLabel.Size = New System.Drawing.Size(72, 39)
        Me.latteAmountLabel.TabIndex = 7
        Me.latteAmountLabel.Text = "x Latte/s"
        '
        'icedAmountBox
        '
        Me.icedAmountBox.Location = New System.Drawing.Point(204, 109)
        Me.icedAmountBox.Name = "icedAmountBox"
        Me.icedAmountBox.Size = New System.Drawing.Size(47, 20)
        Me.icedAmountBox.TabIndex = 8
        '
        'icedAmountLabel
        '
        Me.icedAmountLabel.AutoSize = True
        Me.icedAmountLabel.Font = New System.Drawing.Font("Gabriola", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.icedAmountLabel.Location = New System.Drawing.Point(247, 98)
        Me.icedAmountLabel.Name = "icedAmountLabel"
        Me.icedAmountLabel.Size = New System.Drawing.Size(109, 39)
        Me.icedAmountLabel.TabIndex = 9
        Me.icedAmountLabel.Text = "x Iced Coffee/s"
        '
        'cappuccinoPriceLabel
        '
        Me.cappuccinoPriceLabel.AutoSize = True
        Me.cappuccinoPriceLabel.Font = New System.Drawing.Font("Gabriola", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cappuccinoPriceLabel.Location = New System.Drawing.Point(55, 42)
        Me.cappuccinoPriceLabel.Name = "cappuccinoPriceLabel"
        Me.cappuccinoPriceLabel.Size = New System.Drawing.Size(87, 39)
        Me.cappuccinoPriceLabel.TabIndex = 10
        Me.cappuccinoPriceLabel.Text = "$3.00 Each"
        '
        'espressoPriceLabel
        '
        Me.espressoPriceLabel.AutoSize = True
        Me.espressoPriceLabel.Font = New System.Drawing.Font("Gabriola", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.espressoPriceLabel.Location = New System.Drawing.Point(55, 126)
        Me.espressoPriceLabel.Name = "espressoPriceLabel"
        Me.espressoPriceLabel.Size = New System.Drawing.Size(85, 39)
        Me.espressoPriceLabel.TabIndex = 11
        Me.espressoPriceLabel.Text = "$2.25 Each"
        '
        'lattePriceLabel
        '
        Me.lattePriceLabel.AutoSize = True
        Me.lattePriceLabel.Font = New System.Drawing.Font("Gabriola", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lattePriceLabel.Location = New System.Drawing.Point(247, 42)
        Me.lattePriceLabel.Name = "lattePriceLabel"
        Me.lattePriceLabel.Size = New System.Drawing.Size(86, 39)
        Me.lattePriceLabel.TabIndex = 12
        Me.lattePriceLabel.Text = "$2.50 Each"
        '
        'icedPriceLabel
        '
        Me.icedPriceLabel.AutoSize = True
        Me.icedPriceLabel.Font = New System.Drawing.Font("Gabriola", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.icedPriceLabel.Location = New System.Drawing.Point(247, 126)
        Me.icedPriceLabel.Name = "icedPriceLabel"
        Me.icedPriceLabel.Size = New System.Drawing.Size(86, 39)
        Me.icedPriceLabel.TabIndex = 13
        Me.icedPriceLabel.Text = "$2.50 Each"
        '
        'subTotalLabel
        '
        Me.subTotalLabel.AutoSize = True
        Me.subTotalLabel.Font = New System.Drawing.Font("Gabriola", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subTotalLabel.Location = New System.Drawing.Point(12, 179)
        Me.subTotalLabel.Name = "subTotalLabel"
        Me.subTotalLabel.Size = New System.Drawing.Size(93, 45)
        Me.subTotalLabel.TabIndex = 14
        Me.subTotalLabel.Text = "Sub Total:"
        '
        'subTotalValue
        '
        Me.subTotalValue.AutoSize = True
        Me.subTotalValue.Font = New System.Drawing.Font("Gabriola", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subTotalValue.Location = New System.Drawing.Point(38, 213)
        Me.subTotalValue.Name = "subTotalValue"
        Me.subTotalValue.Size = New System.Drawing.Size(39, 45)
        Me.subTotalValue.TabIndex = 15
        Me.subTotalValue.Text = "$0"
        '
        'totalValue
        '
        Me.totalValue.AutoSize = True
        Me.totalValue.Font = New System.Drawing.Font("Gabriola", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalValue.Location = New System.Drawing.Point(317, 213)
        Me.totalValue.Name = "totalValue"
        Me.totalValue.Size = New System.Drawing.Size(41, 45)
        Me.totalValue.TabIndex = 17
        Me.totalValue.Text = "$0"
        '
        'totalLabel
        '
        Me.totalLabel.AutoSize = True
        Me.totalLabel.Font = New System.Drawing.Font("Gabriola", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalLabel.Location = New System.Drawing.Point(291, 179)
        Me.totalLabel.Name = "totalLabel"
        Me.totalLabel.Size = New System.Drawing.Size(62, 45)
        Me.totalLabel.TabIndex = 16
        Me.totalLabel.Text = "Total"
        '
        'taxValue
        '
        Me.taxValue.AutoSize = True
        Me.taxValue.Font = New System.Drawing.Font("Gabriola", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.taxValue.Location = New System.Drawing.Point(183, 213)
        Me.taxValue.Name = "taxValue"
        Me.taxValue.Size = New System.Drawing.Size(39, 45)
        Me.taxValue.TabIndex = 19
        Me.taxValue.Text = "$0"
        '
        'taxLabel
        '
        Me.taxLabel.AutoSize = True
        Me.taxLabel.Font = New System.Drawing.Font("Gabriola", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.taxLabel.Location = New System.Drawing.Point(157, 179)
        Me.taxLabel.Name = "taxLabel"
        Me.taxLabel.Size = New System.Drawing.Size(50, 45)
        Me.taxLabel.TabIndex = 18
        Me.taxLabel.Text = "Tax:"
        '
        'takewayConfirmation
        '
        Me.takewayConfirmation.AutoSize = True
        Me.takewayConfirmation.Font = New System.Drawing.Font("Gabriola", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.takewayConfirmation.Location = New System.Drawing.Point(358, 12)
        Me.takewayConfirmation.Name = "takewayConfirmation"
        Me.takewayConfirmation.Size = New System.Drawing.Size(105, 43)
        Me.takewayConfirmation.TabIndex = 20
        Me.takewayConfirmation.Text = "Takeaway?"
        Me.takewayConfirmation.UseVisualStyleBackColor = True
        '
        'completeButton
        '
        Me.completeButton.Font = New System.Drawing.Font("Gabriola", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.completeButton.Location = New System.Drawing.Point(436, 191)
        Me.completeButton.Name = "completeButton"
        Me.completeButton.Size = New System.Drawing.Size(190, 52)
        Me.completeButton.TabIndex = 21
        Me.completeButton.Text = "Complete Purchase"
        Me.completeButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Café_au_Bean.My.Resources.Resources.Café_au_Bean_Logo
        Me.PictureBox1.Location = New System.Drawing.Point(374, 61)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(252, 113)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'takewayValueLabel
        '
        Me.takewayValueLabel.AutoSize = True
        Me.takewayValueLabel.Font = New System.Drawing.Font("Gabriola", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.takewayValueLabel.Location = New System.Drawing.Point(452, 20)
        Me.takewayValueLabel.Name = "takewayValueLabel"
        Me.takewayValueLabel.Size = New System.Drawing.Size(59, 29)
        Me.takewayValueLabel.TabIndex = 23
        Me.takewayValueLabel.Text = "(5% Tax)"
        '
        'newSalesWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 255)
        Me.Controls.Add(Me.takewayValueLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.completeButton)
        Me.Controls.Add(Me.takewayConfirmation)
        Me.Controls.Add(Me.taxValue)
        Me.Controls.Add(Me.taxLabel)
        Me.Controls.Add(Me.totalValue)
        Me.Controls.Add(Me.totalLabel)
        Me.Controls.Add(Me.subTotalValue)
        Me.Controls.Add(Me.subTotalLabel)
        Me.Controls.Add(Me.icedAmountBox)
        Me.Controls.Add(Me.espressoAmountBox)
        Me.Controls.Add(Me.latteAmountBox)
        Me.Controls.Add(Me.icedPriceLabel)
        Me.Controls.Add(Me.lattePriceLabel)
        Me.Controls.Add(Me.espressoPriceLabel)
        Me.Controls.Add(Me.cappuccinoAmountBox)
        Me.Controls.Add(Me.cappuccinoAmountLabel)
        Me.Controls.Add(Me.cappuccinoPriceLabel)
        Me.Controls.Add(Me.icedAmountLabel)
        Me.Controls.Add(Me.latteAmountLabel)
        Me.Controls.Add(Me.espressoAmountLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "newSalesWindow"
        Me.Text = "New Sale"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cappuccinoAmountBox As TextBox
    Friend WithEvents cappuccinoAmountLabel As Label
    Friend WithEvents espressoAmountBox As TextBox
    Friend WithEvents espressoAmountLabel As Label
    Friend WithEvents latteAmountBox As TextBox
    Friend WithEvents latteAmountLabel As Label
    Friend WithEvents icedAmountBox As TextBox
    Friend WithEvents icedAmountLabel As Label
    Friend WithEvents cappuccinoPriceLabel As Label
    Friend WithEvents espressoPriceLabel As Label
    Friend WithEvents lattePriceLabel As Label
    Friend WithEvents icedPriceLabel As Label
    Friend WithEvents subTotalLabel As Label
    Friend WithEvents subTotalValue As Label
    Friend WithEvents totalValue As Label
    Friend WithEvents totalLabel As Label
    Friend WithEvents taxValue As Label
    Friend WithEvents taxLabel As Label
    Friend WithEvents takewayConfirmation As CheckBox
    Friend WithEvents completeButton As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents takewayValueLabel As Label
End Class
