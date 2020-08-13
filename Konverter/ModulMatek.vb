Module ModulMatek
    'Konstanta-konstanta untuk faktor-faktor konversi meter ke English
    Public Const dblMETER_KE_INCI As Double = 39.37
    Public Const dblMETER_KE_KAKI As Double = 3.28
    Public Const dblMETER_KE_YARD As Double = 1.09

    'Konstanta-konstanta untuk faktor-faktor konversi inci ke metrik
    Public Const dblINCI_KE_MM As Double = 25.4
    Public Const dblINCI_KE_CM As Double = 2.54
    Public Const dblINCI_KE_METER As Double = 0.0254

    'Fungsi MeterKeInci menerima jumlah meter sebagai argumennya
    'dan menghasilkan jumlah inci ekivalen sebagai nilai balik.
    Public Function MeterKeInci(ByVal dblMeter As Double) As Double
        Return dblMeter * dblMETER_KE_INCI
    End Function

    'Fungsi MeterKeKaki menerima jumlah meter sebagai argumennya
    'dan menghasilkan jumlah kaki ekivalen sebagai nilai balik.
    Public Function MeterKeKaki(ByVal dblMeter As Double) As Double
        Return dblMeter * dblMETER_KE_KAKI
    End Function

    'Fungsi MeterKeYard menerima jumlah meter sebagai argumennya
    'dan menghasilkan jumlah yard ekivalen sebagai nilai balik.
    Public Function MeterKeYard(ByVal dblMeter As Double) As Double
        Return dblMeter * dblMETER_KE_YARD
    End Function

    'Fungsi InciKeMM menerima jumlah inci sebagai argumennya
    'dan menghasilkan jumlah milimeter ekivalen sebagai nilai balik.
    Public Function InciKeMM(ByVal dblInci As Double) As Double
        Return dblInci * dblINCI_KE_MM
    End Function

    'Fungsi InciKeCM menerima jumlah inci sebagai argumennya
    'dan menghasilkan jumlah centimeter ekivalen sebagai nilai balik.
    Public Function InciKeCM(ByVal dblInches As Double) As Double
        Return dblInches * dblINCI_KE_CM
    End Function

    'Fungsi InciKeMeter menerima jumlah inci sebagai argumennya
    'dan menghasilkan jumlah meter ekivalen sebagai nilai balik.
    Public Function InciKeMeter(ByVal dblInci As Double) As Double
        Return dblInci * dblINCI_KE_METER
    End Function
End Module
