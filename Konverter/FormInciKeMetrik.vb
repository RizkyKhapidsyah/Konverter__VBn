Public Class FormInciKeMetrik

    Private Sub tombolKonversiKeMiliMeter_Click(sender As Object, e As EventArgs) Handles tombolKonversiKeMiliMeter.Click
        Dim dblInci As Double        'Untuk memuat inci
        Dim dblMiliMeter As Double   'Untuk memuat milimeter

        Try
            'Membaca inci
            dblInci = CDbl(teksJumInci.Text)

            'Konversi inci ke milimeter
            dblMiliMeter = InciKeMM(dblInci)

            'Menampilkan hasil
            MessageBox.Show(dblInci.ToString() & " inci ekivalen dengan " & dblMiliMeter.ToString() & " milimeter.")
        Catch
            'Menampilkan pesan error untuk masukan tak valid
            MessageBox.Show("Error: Masukkan nilai numerik")
        End Try
    End Sub

    Private Sub tombolKonversiKeSentimeter_Click(sender As Object, e As EventArgs) Handles tombolKonversiKeSentimeter.Click
        Dim dblInci As Double        'Untuk memuat inci
        Dim dblCentiMeter As Double   'Untuk memuat milimeter

        Try
            'Membaca inci
            dblInci = CDbl(teksJumInci.Text)

            'Konversi inci ke centimeter
            dblCentiMeter = InciKeCM(dblInci)

            'Menampilkan hasil
            MessageBox.Show(dblInci.ToString() & " inci ekivalen dengan " & dblCentiMeter.ToString() & " centimeter.")
        Catch
            'Menampilkan pesan error untuk masukan tak valid
            MessageBox.Show("Error: Masukkan nilai numerik")
        End Try
    End Sub

    Private Sub tombolKonversiKeMeter_Click(sender As Object, e As EventArgs) Handles tombolKonversiKeMeter.Click
        Dim dblInci As Double        'Untuk memuat inci
        Dim dblMeter As Double       'Untuk memuat meter

        Try
            'Membaca inci
            dblInci = CDbl(teksJumInci.Text)

            'Konversi inci ke meter
            dblMeter = InciKeMeter(dblInci)

            'Menampilkan hasil
            MessageBox.Show(dblInci.ToString() & " inci ekivalen dengan " & dblMeter.ToString() & " meter.")
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