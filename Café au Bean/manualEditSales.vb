Public Class manualEditSales
    Private Function updateSalesValues()
        mainWindow.cappuccinoSalesValue.Text = GlobalVariables.cappuccinoSales
        mainWindow.espressoSalesValue.Text = GlobalVariables.espressoSales
        mainWindow.latteSalesValue.Text = GlobalVariables.latteSales
        mainWindow.icedSalesValue.Text = GlobalVariables.icedSales
    End Function

    Private Function saveSalesValues()
        My.Settings.soldCappuccino = mainWindow.cappuccinoSalesValue.Text
        My.Settings.soldEspresso = mainWindow.espressoSalesValue.Text
        My.Settings.soldLatte = mainWindow.latteSalesValue.Text
        My.Settings.soldIced = mainWindow.icedSalesValue.Text
        My.Settings.Save()
    End Function

    Private Sub manualEditSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cappuccinoSalesEdit.Text = mainWindow.cappuccinoSalesValue.Text
        espressoSalesEdit.Text = mainWindow.espressoSalesValue.Text
        latteSalesEdit.Text = mainWindow.latteSalesValue.Text
        icedSalesEdit.Text = mainWindow.icedSalesValue.Text
    End Sub

    Private Sub saveButton_Click(sender As Object, e As EventArgs) Handles saveButton.Click
        GlobalVariables.cappuccinoSales = cappuccinoSalesEdit.Text
        GlobalVariables.espressoSales = espressoSalesEdit.Text
        GlobalVariables.latteSales = latteSalesEdit.Text
        GlobalVariables.icedSales = icedSalesEdit.Text
        updateSalesValues()
        saveSalesValues()
    End Sub

    Private Sub cappuccinoSalesEdit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cappuccinoSalesEdit.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub espressoSalesEdit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles espressoSalesEdit.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub latteSalesEdit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles latteSalesEdit.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub icedSalesEdit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles icedSalesEdit.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

End Class
