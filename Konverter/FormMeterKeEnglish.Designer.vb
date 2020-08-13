<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMeterKeEnglish
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.teksJumMeter = New System.Windows.Forms.TextBox()
        Me.tombolKonversiKeInci = New System.Windows.Forms.Button()
        Me.tombolKonversiKeKaki = New System.Windows.Forms.Button()
        Me.tombolKonversiKeYard = New System.Windows.Forms.Button()
        Me.tombolTutup = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Masukkan Jumlah Meter:"
        '
        'teksJumMeter
        '
        Me.teksJumMeter.Location = New System.Drawing.Point(145, 22)
        Me.teksJumMeter.Name = "teksJumMeter"
        Me.teksJumMeter.Size = New System.Drawing.Size(159, 20)
        Me.teksJumMeter.TabIndex = 1
        '
        'tombolKonversiKeInci
        '
        Me.tombolKonversiKeInci.Location = New System.Drawing.Point(15, 79)
        Me.tombolKonversiKeInci.Name = "tombolKonversiKeInci"
        Me.tombolKonversiKeInci.Size = New System.Drawing.Size(83, 40)
        Me.tombolKonversiKeInci.TabIndex = 2
        Me.tombolKonversiKeInci.Text = "Konversi Ke Inci"
        Me.tombolKonversiKeInci.UseVisualStyleBackColor = True
        '
        'tombolKonversiKeKaki
        '
        Me.tombolKonversiKeKaki.Location = New System.Drawing.Point(117, 79)
        Me.tombolKonversiKeKaki.Name = "tombolKonversiKeKaki"
        Me.tombolKonversiKeKaki.Size = New System.Drawing.Size(83, 40)
        Me.tombolKonversiKeKaki.TabIndex = 3
        Me.tombolKonversiKeKaki.Text = "Konversi Ke Kaki"
        Me.tombolKonversiKeKaki.UseVisualStyleBackColor = True
        '
        'tombolKonversiKeYard
        '
        Me.tombolKonversiKeYard.Location = New System.Drawing.Point(221, 79)
        Me.tombolKonversiKeYard.Name = "tombolKonversiKeYard"
        Me.tombolKonversiKeYard.Size = New System.Drawing.Size(83, 40)
        Me.tombolKonversiKeYard.TabIndex = 4
        Me.tombolKonversiKeYard.Text = "Konversi Ke Yard"
        Me.tombolKonversiKeYard.UseVisualStyleBackColor = True
        '
        'tombolTutup
        '
        Me.tombolTutup.Location = New System.Drawing.Point(117, 135)
        Me.tombolTutup.Name = "tombolTutup"
        Me.tombolTutup.Size = New System.Drawing.Size(83, 40)
        Me.tombolTutup.TabIndex = 5
        Me.tombolTutup.Text = "Tutup"
        Me.tombolTutup.UseVisualStyleBackColor = True
        '
        'FormMeterKeEnglish
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(316, 188)
        Me.Controls.Add(Me.tombolTutup)
        Me.Controls.Add(Me.tombolKonversiKeYard)
        Me.Controls.Add(Me.tombolKonversiKeKaki)
        Me.Controls.Add(Me.tombolKonversiKeInci)
        Me.Controls.Add(Me.teksJumMeter)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormMeterKeEnglish"
        Me.Text = "FormMeterKeEnglish"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents teksJumMeter As System.Windows.Forms.TextBox
    Friend WithEvents tombolKonversiKeInci As System.Windows.Forms.Button
    Friend WithEvents tombolKonversiKeKaki As System.Windows.Forms.Button
    Friend WithEvents tombolKonversiKeYard As System.Windows.Forms.Button
    Friend WithEvents tombolTutup As System.Windows.Forms.Button
End Class
