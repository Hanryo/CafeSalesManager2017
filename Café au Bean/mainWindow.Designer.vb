<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainWindow
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
        Me.mainTabControl = New System.Windows.Forms.TabControl()
        Me.homeTab = New System.Windows.Forms.TabPage()
        Me.clearSalesButton = New System.Windows.Forms.Button()
        Me.salesTotalLabel = New System.Windows.Forms.Label()
        Me.salesTotalValue = New System.Windows.Forms.Label()
        Me.newSalesButton = New System.Windows.Forms.Button()
        Me.currentDateLabel = New System.Windows.Forms.Label()
        Me.icedSalesValue = New System.Windows.Forms.Label()
        Me.latteSalesValue = New System.Windows.Forms.Label()
        Me.espressoSalesValue = New System.Windows.Forms.Label()
        Me.cappuccinoSalesValue = New System.Windows.Forms.Label()
        Me.icedSalesLabel = New System.Windows.Forms.Label()
        Me.latteSalesLabel = New System.Windows.Forms.Label()
        Me.espressoSalesLabel = New System.Windows.Forms.Label()
        Me.cappuccinoSalesLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.historyTab = New System.Windows.Forms.TabPage()
        Me.purchaseHistoryBox = New System.Windows.Forms.ListBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.mainTabControl.SuspendLayout()
        Me.homeTab.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.historyTab.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mainTabControl
        '
        Me.mainTabControl.Controls.Add(Me.homeTab)
        Me.mainTabControl.Controls.Add(Me.historyTab)
        Me.mainTabControl.Location = New System.Drawing.Point(12, 114)
        Me.mainTabControl.Name = "mainTabControl"
        Me.mainTabControl.SelectedIndex = 0
        Me.mainTabControl.Size = New System.Drawing.Size(435, 340)
        Me.mainTabControl.TabIndex = 0
        '
        'homeTab
        '
        Me.homeTab.Controls.Add(Me.clearSalesButton)
        Me.homeTab.Controls.Add(Me.salesTotalLabel)
        Me.homeTab.Controls.Add(Me.salesTotalValue)
        Me.homeTab.Controls.Add(Me.newSalesButton)
        Me.homeTab.Controls.Add(Me.currentDateLabel)
        Me.homeTab.Controls.Add(Me.icedSalesValue)
        Me.homeTab.Controls.Add(Me.latteSalesValue)
        Me.homeTab.Controls.Add(Me.espressoSalesValue)
        Me.homeTab.Controls.Add(Me.cappuccinoSalesValue)
        Me.homeTab.Controls.Add(Me.icedSalesLabel)
        Me.homeTab.Controls.Add(Me.latteSalesLabel)
        Me.homeTab.Controls.Add(Me.espressoSalesLabel)
        Me.homeTab.Controls.Add(Me.cappuccinoSalesLabel)
        Me.homeTab.Controls.Add(Me.Label1)
        Me.homeTab.Controls.Add(Me.PictureBox1)
        Me.homeTab.Location = New System.Drawing.Point(4, 22)
        Me.homeTab.Name = "homeTab"
        Me.homeTab.Padding = New System.Windows.Forms.Padding(3)
        Me.homeTab.Size = New System.Drawing.Size(427, 314)
        Me.homeTab.TabIndex = 0
        Me.homeTab.Text = "Homepage"
        Me.homeTab.UseVisualStyleBackColor = True
        '
        'clearSalesButton
        '
        Me.clearSalesButton.Font = New System.Drawing.Font("Gabriola", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearSalesButton.Location = New System.Drawing.Point(294, 210)
        Me.clearSalesButton.Name = "clearSalesButton"
        Me.clearSalesButton.Size = New System.Drawing.Size(127, 34)
        Me.clearSalesButton.TabIndex = 10
        Me.clearSalesButton.Text = "Clear Today's Sales"
        Me.clearSalesButton.UseVisualStyleBackColor = True
        '
        'salesTotalLabel
        '
        Me.salesTotalLabel.AutoSize = True
        Me.salesTotalLabel.Font = New System.Drawing.Font("Gabriola", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salesTotalLabel.Location = New System.Drawing.Point(205, 235)
        Me.salesTotalLabel.Name = "salesTotalLabel"
        Me.salesTotalLabel.Size = New System.Drawing.Size(93, 35)
        Me.salesTotalLabel.TabIndex = 14
        Me.salesTotalLabel.Text = "Total Sales:"
        '
        'salesTotalValue
        '
        Me.salesTotalValue.AutoSize = True
        Me.salesTotalValue.Font = New System.Drawing.Font("Gabriola", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salesTotalValue.Location = New System.Drawing.Point(239, 249)
        Me.salesTotalValue.Name = "salesTotalValue"
        Me.salesTotalValue.Size = New System.Drawing.Size(81, 59)
        Me.salesTotalValue.TabIndex = 15
        Me.salesTotalValue.Text = "$0.00"
        '
        'newSalesButton
        '
        Me.newSalesButton.Font = New System.Drawing.Font("Gabriola", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newSalesButton.Location = New System.Drawing.Point(261, 152)
        Me.newSalesButton.Name = "newSalesButton"
        Me.newSalesButton.Size = New System.Drawing.Size(160, 52)
        Me.newSalesButton.TabIndex = 13
        Me.newSalesButton.Text = "Create New Sale"
        Me.newSalesButton.UseVisualStyleBackColor = True
        '
        'currentDateLabel
        '
        Me.currentDateLabel.AutoSize = True
        Me.currentDateLabel.Location = New System.Drawing.Point(3, 295)
        Me.currentDateLabel.Name = "currentDateLabel"
        Me.currentDateLabel.Size = New System.Drawing.Size(73, 13)
        Me.currentDateLabel.TabIndex = 12
        Me.currentDateLabel.Text = "Current Date: "
        '
        'icedSalesValue
        '
        Me.icedSalesValue.AutoSize = True
        Me.icedSalesValue.Location = New System.Drawing.Point(153, 257)
        Me.icedSalesValue.Name = "icedSalesValue"
        Me.icedSalesValue.Size = New System.Drawing.Size(13, 13)
        Me.icedSalesValue.TabIndex = 9
        Me.icedSalesValue.Text = "0"
        '
        'latteSalesValue
        '
        Me.latteSalesValue.AutoSize = True
        Me.latteSalesValue.Location = New System.Drawing.Point(153, 218)
        Me.latteSalesValue.Name = "latteSalesValue"
        Me.latteSalesValue.Size = New System.Drawing.Size(13, 13)
        Me.latteSalesValue.TabIndex = 8
        Me.latteSalesValue.Text = "0"
        '
        'espressoSalesValue
        '
        Me.espressoSalesValue.AutoSize = True
        Me.espressoSalesValue.Location = New System.Drawing.Point(153, 179)
        Me.espressoSalesValue.Name = "espressoSalesValue"
        Me.espressoSalesValue.Size = New System.Drawing.Size(13, 13)
        Me.espressoSalesValue.TabIndex = 7
        Me.espressoSalesValue.Text = "0"
        '
        'cappuccinoSalesValue
        '
        Me.cappuccinoSalesValue.AutoSize = True
        Me.cappuccinoSalesValue.Location = New System.Drawing.Point(153, 140)
        Me.cappuccinoSalesValue.Name = "cappuccinoSalesValue"
        Me.cappuccinoSalesValue.Size = New System.Drawing.Size(13, 13)
        Me.cappuccinoSalesValue.TabIndex = 6
        Me.cappuccinoSalesValue.Text = "0"
        '
        'icedSalesLabel
        '
        Me.icedSalesLabel.AutoSize = True
        Me.icedSalesLabel.Font = New System.Drawing.Font("Gabriola", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.icedSalesLabel.Location = New System.Drawing.Point(52, 243)
        Me.icedSalesLabel.Name = "icedSalesLabel"
        Me.icedSalesLabel.Size = New System.Drawing.Size(95, 39)
        Me.icedSalesLabel.TabIndex = 5
        Me.icedSalesLabel.Text = "Iced Coffees:"
        '
        'latteSalesLabel
        '
        Me.latteSalesLabel.AutoSize = True
        Me.latteSalesLabel.Font = New System.Drawing.Font("Gabriola", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.latteSalesLabel.Location = New System.Drawing.Point(89, 204)
        Me.latteSalesLabel.Name = "latteSalesLabel"
        Me.latteSalesLabel.Size = New System.Drawing.Size(58, 39)
        Me.latteSalesLabel.TabIndex = 4
        Me.latteSalesLabel.Text = "Lattes:"
        '
        'espressoSalesLabel
        '
        Me.espressoSalesLabel.AutoSize = True
        Me.espressoSalesLabel.Font = New System.Drawing.Font("Gabriola", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.espressoSalesLabel.Location = New System.Drawing.Point(65, 165)
        Me.espressoSalesLabel.Name = "espressoSalesLabel"
        Me.espressoSalesLabel.Size = New System.Drawing.Size(82, 39)
        Me.espressoSalesLabel.TabIndex = 3
        Me.espressoSalesLabel.Text = "Espressos:"
        '
        'cappuccinoSalesLabel
        '
        Me.cappuccinoSalesLabel.AutoSize = True
        Me.cappuccinoSalesLabel.Font = New System.Drawing.Font("Gabriola", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cappuccinoSalesLabel.Location = New System.Drawing.Point(43, 126)
        Me.cappuccinoSalesLabel.Name = "cappuccinoSalesLabel"
        Me.cappuccinoSalesLabel.Size = New System.Drawing.Size(104, 39)
        Me.cappuccinoSalesLabel.TabIndex = 2
        Me.cappuccinoSalesLabel.Text = "Cappuccinos:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gabriola", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 50)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Today's Sales"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Café_au_Bean.My.Resources.Resources.welcomeLogo
        Me.PictureBox1.Location = New System.Drawing.Point(-4, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(324, 104)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'historyTab
        '
        Me.historyTab.Controls.Add(Me.purchaseHistoryBox)
        Me.historyTab.Location = New System.Drawing.Point(4, 22)
        Me.historyTab.Name = "historyTab"
        Me.historyTab.Padding = New System.Windows.Forms.Padding(3)
        Me.historyTab.Size = New System.Drawing.Size(427, 314)
        Me.historyTab.TabIndex = 1
        Me.historyTab.Text = "Daily Purchase History"
        Me.historyTab.UseVisualStyleBackColor = True
        '
        'purchaseHistoryBox
        '
        Me.purchaseHistoryBox.FormattingEnabled = True
        Me.purchaseHistoryBox.HorizontalScrollbar = True
        Me.purchaseHistoryBox.Location = New System.Drawing.Point(6, 6)
        Me.purchaseHistoryBox.Name = "purchaseHistoryBox"
        Me.purchaseHistoryBox.ScrollAlwaysVisible = True
        Me.purchaseHistoryBox.Size = New System.Drawing.Size(415, 303)
        Me.purchaseHistoryBox.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Café_au_Bean.My.Resources.Resources.Café_au_Bean_Logo
        Me.PictureBox2.Location = New System.Drawing.Point(-4, -14)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(287, 122)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'mainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 466)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.mainTabControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "mainWindow"
        Me.Text = "Cafe au Bean Sales Manager"
        Me.mainTabControl.ResumeLayout(False)
        Me.homeTab.ResumeLayout(False)
        Me.homeTab.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.historyTab.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mainTabControl As TabControl
    Friend WithEvents homeTab As TabPage
    Friend WithEvents historyTab As TabPage
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents icedSalesLabel As Label
    Friend WithEvents latteSalesLabel As Label
    Friend WithEvents espressoSalesLabel As Label
    Friend WithEvents cappuccinoSalesLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents icedSalesValue As Label
    Friend WithEvents latteSalesValue As Label
    Friend WithEvents espressoSalesValue As Label
    Friend WithEvents cappuccinoSalesValue As Label
    Friend WithEvents clearSalesButton As Button
    Friend WithEvents currentDateLabel As Label
    Friend WithEvents purchaseHistoryBox As ListBox
    Friend WithEvents salesTotalLabel As Label
    Friend WithEvents salesTotalValue As Label
    Friend WithEvents newSalesButton As Button
End Class
