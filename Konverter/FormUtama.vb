Public Class FormUtama

    Private Sub tombolKonversiMeter_Click(sender As Object, e As EventArgs) Handles tombolKonversiMeter.Click
        Dim frmMeterKeEnglish As New FormMeterKeEnglish
        frmMeterKeEnglish.Show()
    End Sub

    Private Sub tombolKonversiInci_Click(sender As Object, e As EventArgs) Handles tombolKonversiInci.Click
        Dim frmInciKeMetrik As New FormInciKeMetrik
        frmInciKeMetrik.Show()
    End Sub

    Private Sub tombolKeluar_Click(sender As Object, e As EventArgs) Handles tombolKeluar.Click
        'Menutup form
        Me.Close()
    End Sub
End Class
