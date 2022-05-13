Public Class FrmFabric
    Private Sub FrmFabric_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        g_strFabricName = "<no selection>"
    End Sub

    Private Sub pbWhiteDamask_Click(sender As Object, e As EventArgs) Handles pbWhiteDamask.Click
        g_strFabricName = "White Damask"
        g_decFabricCost = 0.0044
        Me.Close()
    End Sub

    Private Sub pbOrangeDamask_Click(sender As Object, e As EventArgs) Handles pbOrangeDamask.Click
        g_strFabricName = "Orange Damask"
        g_decFabricCost = 0.0047
        Me.Close()
    End Sub

    Private Sub pbRedDamask_Click(sender As Object, e As EventArgs) Handles pbRedDamask.Click
        g_strFabricName = "Red Damask"
        g_decFabricCost = 0.0051
        Me.Close()
    End Sub

    Private Sub pbBlueDamask_Click(sender As Object, e As EventArgs) Handles pbBlueDamask.Click
        g_strFabricName = "Blue Damask"
        g_decFabricCost = 0.0068
        Me.Close()
    End Sub

    Private Sub pbGreenDamask_Click(sender As Object, e As EventArgs) Handles pbGreenDamask.Click
        g_strFabricName = "Green Damask"
        g_decFabricCost = 0.0068
        Me.Close()
    End Sub

    Private Sub pbGrayPoly_Click(sender As Object, e As EventArgs) Handles pbGrayPoly.Click
        g_strFabricName = "Gray Polyester"
        g_decFabricCost = 0.002
        Me.Close()
    End Sub

    Private Sub pbCreamPoly_Click(sender As Object, e As EventArgs) Handles pbCreamPoly.Click
        g_strFabricName = "Cream Polyester"
        g_decFabricCost = 0.0034
        Me.Close()
    End Sub

    Private Sub pbRedPoly_Click(sender As Object, e As EventArgs) Handles pbRedPoly.Click
        g_strFabricName = "Red Polyester"
        g_decFabricCost = 0.0031
        Me.Close()
    End Sub

    Private Sub pbBluePoly_Click(sender As Object, e As EventArgs) Handles pbBluePoly.Click
        g_strFabricName = "Blue Polyester"
        g_decFabricCost = 0.0041
        Me.Close()
    End Sub

    Private Sub pbWhitePoly_Click(sender As Object, e As EventArgs) Handles pbWhitePoly.Click
        g_strFabricName = "White Polyester"
        g_decFabricCost = 0.0034
        Me.Close()
    End Sub

End Class