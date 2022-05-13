Public Class FrmDrop
    ' User picks the preferred negth of table top
    ' Long add 30" to the tabletop
    ' Mid adds 15" to the tabletop
    ' Shortadds 12" to the tabletop
    Public Const int_SHORT_DROP As Integer = 12
    Public Const int_MID_DROP As Integer = 15
    Public Const int_LONG_DROP As Integer = 30
    Private Sub FrmDrop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        g_strDropDescription = "<no selection>"
    End Sub
    Private Sub pbShortDrop_Click(sender As Object, e As EventArgs) Handles pbShortDrop.Click
        g_intDropSize = int_SHORT_DROP
        g_strDropDescription = "12 inch drop"
        Me.Close()
    End Sub
    Private Sub pbMidDrop_Click(sender As Object, e As EventArgs) Handles pbMidDrop.Click
        g_intDropSize = int_MID_DROP
        g_strDropDescription = "15 inch drop"
        Me.Close()
    End Sub
    Private Sub pbLongDrop_Click(sender As Object, e As EventArgs) Handles pbLongDrop.Click
        g_intDropSize = int_LONG_DROP
        g_strDropDescription = "30 inch drop"
        Me.Close()
    End Sub
End Class