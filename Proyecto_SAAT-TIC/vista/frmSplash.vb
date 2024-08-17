Public Class frmSplash
    Dim contador As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (ProgressBar1.Value < 70) Then
            contador = contador + 25
            ProgressBar1.Value = contador
        Else
            Me.Hide()
            frmLogin.Show()
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub frmSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class