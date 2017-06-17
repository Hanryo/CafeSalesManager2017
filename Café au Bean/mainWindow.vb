Public Class mainWindow
    Private Function updateSalesValues()
        cappuccinoSalesValue.Text = GlobalVariables.cappuccinoSales
        espressoSalesValue.Text = GlobalVariables.espressoSales
        latteSalesValue.Text = GlobalVariables.latteSales
        icedSalesValue.Text = GlobalVariables.icedSales
    End Function

    Private Function saveSalesValues()
        My.Settings.soldCappuccino = cappuccinoSalesValue.Text
        My.Settings.soldEspresso = espressoSalesValue.Text
        My.Settings.soldLatte = latteSalesValue.Text
        My.Settings.soldIced = icedSalesValue.Text
        My.Settings.Save()
    End Function

    Private Function clearSalesValues()
        GlobalVariables.cappuccinoSales = 0
        GlobalVariables.espressoSales = 0
        GlobalVariables.latteSales = 0
        GlobalVariables.icedSales = 0
        updateSalesValues()
        saveSalesValues()
    End Function

    Private Function saveLastRunDate()
        My.Settings.lastDateRun = GlobalVariables.currentDate
    End Function

    Private Function savePurchaseHistory()
        If My.Settings.purchaseHistoryStore Is Nothing Then
            My.Settings.purchaseHistoryStore = New System.Collections.Specialized.StringCollection()
        End If
        My.Settings.purchaseHistoryStore.Clear()
        For Each item In purchaseHistoryBox.Items
            My.Settings.purchaseHistoryStore.Add(item)
        Next
        My.Settings.Save()
    End Function

    Private Function clearPurchaseHistory()
        purchaseHistoryBox.Items.Clear()
        savePurchaseHistory()
    End Function

    Private Function updateSalesTotal()
        salesTotalValue.Text = ("$" & Math.Round(GlobalVariables.totalSalesFigure, 2, MidpointRounding.AwayFromZero))
    End Function

    Private Function saveSalesTotal()
        My.Settings.salesTotalFigure = GlobalVariables.totalSalesFigure
        My.Settings.Save()
    End Function

    Private Function clearSalesTotal()
        GlobalVariables.totalSalesFigure = 0
        updateSalesTotal()
        saveSalesTotal()
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GlobalVariables.currentDate = DateTime.Today
        GlobalVariables.lastDateOpened = My.Settings.lastDateRun
        If GlobalVariables.lastDateOpened = GlobalVariables.currentDate Then
            GlobalVariables.cappuccinoSales = My.Settings.soldCappuccino
            GlobalVariables.espressoSales = My.Settings.soldEspresso
            GlobalVariables.latteSales = My.Settings.soldLatte
            GlobalVariables.icedSales = My.Settings.soldIced
            If My.Settings.purchaseHistoryStore Is Nothing Then
                My.Settings.purchaseHistoryStore = New System.Collections.Specialized.StringCollection()
            End If
            For Each item In My.Settings.purchaseHistoryStore
                purchaseHistoryBox.Items.Add(item)
            Next
            GlobalVariables.totalSalesFigure = My.Settings.salesTotalFigure
        Else
            GlobalVariables.cappuccinoSales = 0
            GlobalVariables.espressoSales = 0
            GlobalVariables.latteSales = 0
            GlobalVariables.icedSales = 0
            GlobalVariables.totalSalesFigure = 0
            clearPurchaseHistory()
        End If
        currentDateLabel.Text = ("Current Date: " & GlobalVariables.currentDate)
        updateSalesTotal()
        updateSalesValues()
        saveSalesTotal()
        saveSalesValues()
        saveLastRunDate()
    End Sub

    Private Sub clearSalesButton_Click(sender As Object, e As EventArgs) Handles clearSalesButton.Click
        clearSalesValues()
        clearPurchaseHistory()
        clearSalesTotal()
        MsgBox("Sale Numbers and Purchase History for " & GlobalVariables.currentDate & " have been cleared successfully!")
    End Sub

    Private Sub manualEditSales_Click(sender As Object, e As EventArgs)
        manualEditSales.Show()
    End Sub

    Private Sub newSalesButton_Click(sender As Object, e As EventArgs) Handles newSalesButton.Click
        newSalesWindow.Show()
    End Sub
End Class
