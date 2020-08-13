Public Class FormMeterKeEnglish

    Private Sub tombolKonversiKeInci_Click(sender As Object, e As EventArgs) Handles tombolKonversiKeInci.Click
        Dim dblMeter As Double   'Untuk memuat meter
        Dim dblInci As Double   'Untuk memuat inci

        Try
            'Membaca meter
            dblMeter = CDbl(teksJumMeter.Text)

            'Konversi meter ke inci
            dblInci = MeterKeInci(dblMeter)

            'Menampilkan hasil
            MessageBox.Show(dblMeter.ToString() & " meter ekivalen dengan " & dblInci.ToString() & " inci.")
        Catch
            'Menampilkan pesan error untuk masukan tak valid
            MessageBox.Show("Error: Masukkan nilai numerik")
        End Try
    End Sub

    Private Sub tombolKonversiKeKaki_Click(sender As Object, e As EventArgs) Handles tombolKonversiKeKaki.Click
        Dim dblMeter As Double   'Untuk memuat meter
        Dim dblKaki As Double   'Untuk memuat kaki

        Try
            'Membaca meter
            dblMeter = CDbl(teksJumMeter.Text)

            'Konversi meter ke kaki
            dblKaki = MeterKeKaki(dblMeter)

            'Menampilkan hasil
            MessageBox.Show(dblMeter.ToString() & " meter ekivalen dengan " & dblKaki.ToString() & " kaki.")
        Catch
            'Menampilkan pesan error untuk masukan tak valid
            MessageBox.Show("Error: Masukkan nilai numerik")
        End Try
    End Sub

    Private Sub tombolKonversiKeYard_Click(sender As Object, e As EventArgs) Handles tombolKonversiKeYard.Click
        Dim dblMeter As Double   'Untuk memuat meter
        Dim dblYard As Double   'Untuk memuat yard

        Try
            'Membaca meter
            dblMeter = CDbl(teksJumMeter.Text)

            'Konversi meter ke yard
            dblYard = MeterKeYard(dblMeter)

            'Menampilkan hasil
            MessageBox.Show(dblMeter.ToString() & " meter ekivalen dengan " & dblYard.ToString() & " yard.")
        Catch
            'Menampilkan pesan error untuk masukan tak valid
            MessageBox.Show("Error: Masukkan nilai numerik")
        End Try
    End Sub

    Private Sub tombolTutup_Click(sender As Object, e As EventArgs) Handles tombolTutup.Click
        'Menutup form
        Me.Close()
    End Sub
End Class