Public Class newSalesWindow
    Dim cappuccinoAmount, espressoAmount, latteAmount, icedAmount As Integer
    Dim subTotalFigure, taxFigure, totalFigure As Decimal
    Dim taxEnabled As Boolean

    Dim cappuccinoPrice As Decimal = 3
    Dim espressoPrice As Decimal = 2.25
    Dim lattePrice As Decimal = 2.5
    Dim icedPrice As Decimal = 2.5
    Dim taxRate As Decimal = 0.05

    Private Function resetForNewSale()
        cappuccinoAmountBox.Text = 0
        espressoAmountBox.Text = 0
        latteAmountBox.Text = 0
        icedAmountBox.Text = 0
        takewayConfirmation.CheckState = 0
        subTotalFigure = 0
        taxFigure = 0
        totalFigure = 0
        updateFigureNumbers()
        updateTakeaway()
    End Function

    Private Function updateTakeaway()
        If takewayConfirmation.CheckState = 1 Then
            taxEnabled = True
        ElseIf takewayConfirmation.CheckState = 0 Then
            taxEnabled = False
        End If
    End Function

    Function updateFigureNumbers()
        If cappuccinoAmountBox.Text = "" Or espressoAmountBox.Text = "" Or latteAmountBox.Text = "" Or icedAmountBox.Text = "" Then
        Else
            cappuccinoAmount = Convert.ToDecimal(cappuccinoAmountBox.Text)
            espressoAmount = Convert.ToDecimal(espressoAmountBox.Text)
            latteAmount = Convert.ToDecimal(latteAmountBox.Text)
            icedAmount = Convert.ToDecimal(icedAmountBox.Text)
            subTotalFigure = ((cappuccinoPrice * cappuccinoAmount) + (espressoPrice * espressoAmount) + (lattePrice * latteAmount) + (icedPrice * icedAmount))
            If taxEnabled = True Then
                taxFigure = (subTotalFigure * taxRate)
            ElseIf taxEnabled = False Then
                taxFigure = 0
            End If
            totalFigure = subTotalFigure + taxFigure
            subTotalValue.Text = ("$" & Math.Round(subTotalFigure, 2, MidpointRounding.AwayFromZero))
            taxValue.Text = ("$" & Math.Round(taxFigure, 2, MidpointRounding.AwayFromZero))
            totalValue.Text = ("$" & Math.Round(totalFigure, 2, MidpointRounding.AwayFromZero))
        End If
    End Function

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

    Private Function updateSalesTotal()
        mainWindow.salesTotalValue.Text = ("$" & Math.Round(GlobalVariables.totalSalesFigure, 2, MidpointRounding.AwayFromZero))
    End Function

    Private Function saveSalesTotal()
        My.Settings.salesTotalFigure = GlobalVariables.totalSalesFigure
        My.Settings.Save()
    End Function

    Private Function savePurchaseHistory()
        If My.Settings.purchaseHistoryStore Is Nothing Then
            My.Settings.purchaseHistoryStore = New System.Collections.Specialized.StringCollection()
        End If
        My.Settings.purchaseHistoryStore.Clear()
        For Each item In mainWindow.purchaseHistoryBox.Items
            My.Settings.purchaseHistoryStore.Add(item)
        Next
        My.Settings.Save()
    End Function

    Private Sub completeButton_Click(sender As Object, e As EventArgs) Handles completeButton.Click
        GlobalVariables.cappuccinoSales = GlobalVariables.cappuccinoSales + cappuccinoAmount
        GlobalVariables.espressoSales = GlobalVariables.espressoSales + espressoAmount
        GlobalVariables.latteSales = GlobalVariables.latteSales + latteAmount
        GlobalVariables.icedSales = GlobalVariables.icedSales + icedAmount
        GlobalVariables.totalSalesFigure = GlobalVariables.totalSalesFigure + totalFigure
        updateSalesValues()
        saveSalesValues()
        updateSalesTotal()
        saveSalesTotal()
        If cappuccinoAmountBox.Text = 0 And espressoAmountBox.Text = 0 And latteAmountBox.Text = 0 And icedAmountBox.Text = 0 Then
        ElseIf cappuccinoAmountBox.Text = "" Or espressoAmountBox.Text = "" Or latteAmountBox.Text = "" Or icedAmountBox.Text = "" Then
        Else
            mainWindow.purchaseHistoryBox.Items.Add(DateTime.Now.ToShortTimeString() & "  |  Cappu: " & cappuccinoAmount & "   Espre: " & espressoAmount & "   Latte: " & latteAmount & "   Iced: " & icedAmount & "  | TAway: " & taxEnabled & "  Total: $" & Math.Round(totalFigure, 2, MidpointRounding.AwayFromZero))
        End If
        savePurchaseHistory()
        Me.Close()
    End Sub

    Private Sub takewayConfirmation_CheckedChanged(sender As Object, e As EventArgs) Handles takewayConfirmation.CheckedChanged
        updateTakeaway()
        updateFigureNumbers()
    End Sub

    Private Sub newSalesWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        resetForNewSale()
    End Sub

    Private Sub cappuccinoAmountBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cappuccinoAmountBox.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub espressoAmountBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles espressoAmountBox.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub latteAmountBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles latteAmountBox.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub icedAmountBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles icedAmountBox.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub cappuccinoAmountBox_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cappuccinoAmountBox.KeyUp
        updateFigureNumbers()
    End Sub

    Private Sub espressoAmountBox_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles espressoAmountBox.KeyUp
        updateFigureNumbers()
    End Sub

    Private Sub latteAmountBox_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles latteAmountBox.KeyUp
        updateFigureNumbers()
    End Sub

    Private Sub icedAmountBox_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles icedAmountBox.KeyUp
        updateFigureNumbers()
    End Sub
End Class