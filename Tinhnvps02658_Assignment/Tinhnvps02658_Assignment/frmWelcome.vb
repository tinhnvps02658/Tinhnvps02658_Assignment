Public Class frmWelcome


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        prbloading.Increment(1)
        If prbloading.Value = prbloading.Maximum Then
            Me.Close()
        End If
    End Sub

    
End Class