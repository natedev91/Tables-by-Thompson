Public Class FrmProtectant
    ' User chooses which protectent, or none, to be applied to tablecloth
    ' Fabric Shield $5.00
    ' Waterproofing Wax $8.50

    Private Sub pbNoProtectant_Click(sender As Object, e As EventArgs) Handles pbNoProtectant.Click
        g_strProtectantName = "No Protectant Added"
        g_decProtectantCost = 0D
        Me.Close()
    End Sub

    Private Sub pbFabricShield_Click(sender As Object, e As EventArgs) Handles pbFabricShield.Click
        g_strProtectantName = "Fabric Shield $5.00"
        g_decProtectantCost = 5D
        Me.Close()
    End Sub

    Private Sub pbWax_Click(sender As Object, e As EventArgs) Handles pbWax.Click
        g_strProtectantName = "Waterproof Wax Treatment $8.50"
        g_decProtectantCost = 8.5D
        Me.Close()
    End Sub

    Private Sub FrmProtectant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        g_strProtectantName = "<no selection>"
    End Sub
End Class