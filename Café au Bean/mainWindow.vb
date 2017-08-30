Public Class mainWindow

    'Functions

    'Function to update text boxes within form to global variable values
    Private Function updateSalesValues()
        cappuccinoSalesValue.Text = GlobalVariables.cappuccinoSales
        espressoSalesValue.Text = GlobalVariables.espressoSales
        latteSalesValue.Text = GlobalVariables.latteSales
        icedSalesValue.Text = GlobalVariables.icedSales
    End Function

    'Function to update the daily cache of sales stored locally on user's PC
    Private Function saveSalesValues()
        My.Settings.soldCappuccino = cappuccinoSalesValue.Text
        My.Settings.soldEspresso = espressoSalesValue.Text
        My.Settings.soldLatte = latteSalesValue.Text
        My.Settings.soldIced = icedSalesValue.Text
        My.Settings.Save()
    End Function

    'Function to clear the values of each global variable involved
    Private Function clearSalesValues()
        GlobalVariables.cappuccinoSales = 0
        GlobalVariables.espressoSales = 0
        GlobalVariables.latteSales = 0
        GlobalVariables.icedSales = 0
        updateSalesValues()
        saveSalesValues()
    End Function

    'Function to save the last run date to local cache on user's PC
    Private Function saveLastRunDate()
        My.Settings.lastDateRun = GlobalVariables.currentDate
    End Function

    'Function to save the purchase history within the form to local daily cache on user's PC
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

    'Function to clear all items on the purchaseHistoryBox within the form
    Private Function clearPurchaseHistory()
        purchaseHistoryBox.Items.Clear()
        savePurchaseHistory()
    End Function

    'Function to update total sales value
    Private Function updateSalesTotal()
        salesTotalValue.Text = ("$" & Math.Round(GlobalVariables.totalSalesFigure, 2, MidpointRounding.AwayFromZero))
    End Function

    'Function to save total sales value to local cache on User's PC
    Private Function saveSalesTotal()
        My.Settings.salesTotalFigure = GlobalVariables.totalSalesFigure
        My.Settings.Save()
    End Function

    'Function to clear the global vairable; totalSalesFigure 
    Private Function clearSalesTotal()
        GlobalVariables.totalSalesFigure = 0
        updateSalesTotal()
        saveSalesTotal()
    End Function

    'Modules

    'Runs upon the form opening
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

    'Runs whenever clear sales button is clicked
    Private Sub clearSalesButton_Click(sender As Object, e As EventArgs) Handles clearSalesButton.Click
        clearSalesValues()
        clearPurchaseHistory()
        clearSalesTotal()
        MsgBox("Sale Numbers and Purchase History for " & GlobalVariables.currentDate & " have been cleared successfully!")
    End Sub
    'Runs whenver new sale button is clicked
    Private Sub newSalesButton_Click(sender As Object, e As EventArgs) Handles newSalesButton.Click
        newSalesWindow.Show()
    End Sub

End Class
