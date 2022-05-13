Public Class FrmMain
    Dim strWidth As String
    Dim strLength As String
    ' Price displaying variables
    Dim decFabricCost As Decimal
    Dim decProtectantCost As Decimal
    ' Customer's Cost variables
    Dim decSubtotal As Decimal
    Dim decTax As Decimal
    Dim decTotal As Decimal
    Dim intWidth As Integer             'Input width
    Dim intLength As Integer            'Input length
    Dim intFabricWidth As Integer       'Fabric width after drop included
    Dim intFabricLength As Integer      'Fabric length after drop included
    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load, txtWidth.TextChanged, txtLength.TextChanged
        clearFields()
    End Sub
    Private Sub btnPickFabric_Click(sender As Object, e As EventArgs) Handles btnPickFabric.Click
        Dim Frm As New FrmFabric
        FrmFabric.ShowDialog()
        clearFields()
        lblFabric.Text = g_strFabricName
    End Sub
    Private Sub btnPickDrop_Click(sender As Object, e As EventArgs) Handles btnPickDrop.Click
        Dim Frm As New FrmDrop
        FrmDrop.ShowDialog()
        clearFields()
        lblDrop.Text = g_strDropDescription
    End Sub
    Private Sub btnPickProtectant_Click(sender As Object, e As EventArgs) Handles btnPickProtectant.Click
        Dim Frm As New FrmProtectant
        FrmProtectant.ShowDialog()
        clearFields()
        lblProtectant.Text = g_strProtectantName
    End Sub
    Public Sub clearFields()
        lblFabricCost.Text = String.Empty
        lblProtectantCost.Text = String.Empty
        lblDimensions.Text = String.Empty
        lblSubtotal.Text = String.Empty
        lblTax.Text = String.Empty
        lblTotal.Text = String.Empty
        lblErrors.Text = String.Empty
    End Sub
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        lblErrors.Text = String.Empty

        Try
            intWidth = CInt(txtWidth.Text)

            If intWidth <= 0 Then
                lblErrors.Text += "Invalid Width" & vbCrLf
            End If
        Catch ex As Exception
            lblErrors.Text = "Invalid Width" & vbCrLf
        End Try

        Try
            intLength = CInt(txtLength.Text)

            If intLength <= 0 Then
                lblErrors.Text += "Invalid Length" & vbCrLf
            End If
        Catch ex As Exception
            lblErrors.Text += "Invalid Length" & vbCrLf
        End Try

        If lblFabric.Text = "<no selection>" Then
            lblErrors.Text += "Please select Fabric" & vbCrLf
        End If

        If lblDrop.Text = "<no selection>" Then
            lblErrors.Text += "Please select Drop" & vbCrLf
        End If

        If lblProtectant.Text = "<no selection>" Then
            lblErrors.Text += "Please select Protectant"
        End If

        If lblErrors.Text = String.Empty Then
            'Get fabric size integer for pricing and display dimensions
            intFabricWidth = intWidth + (g_intDropSize * 2)
            intFabricLength = intLength + (g_intDropSize * 2)
            lblDimensions.Text = "Tablecloth Size: " & intFabricWidth.ToString() & " x " & intFabricLength.ToString()
            'Calculate and display cost of fabric 
            decFabricCost = g_decFabricCost * (intFabricWidth * intFabricLength)
            lblFabricCost.Text = decFabricCost.ToString("c")
            'Calculate and display cost of protectant
            decProtectantCost = g_decProtectantCost
            lblProtectantCost.Text = decProtectantCost.ToString("c")
            'Calculate and display Subtotal
            decSubtotal = decFabricCost + decProtectantCost
            lblSubtotal.Text = decSubtotal.ToString("c")
            'Calculate and display applied tax
            decTax = decSubtotal * 0.07
            lblTax.Text = decTax.ToString("c")
            'Calculate and display total price
            decTotal = decSubtotal + decTax
            lblTotal.Text = decTotal.ToString("c")
        End If
    End Sub
End Class
