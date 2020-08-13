<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUtama
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
        Me.tombolKonversiMeter = New System.Windows.Forms.Button()
        Me.tombolKonversiInci = New System.Windows.Forms.Button()
        Me.tombolKeluar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(314, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Aplikasi ini mengkonversi meter ke sejumlah unit English dan inci ke sejumlah uni" & _
    "t metrik"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tombolKonversiMeter
        '
        Me.tombolKonversiMeter.Location = New System.Drawing.Point(13, 86)
        Me.tombolKonversiMeter.Name = "tombolKonversiMeter"
        Me.tombolKonversiMeter.Size = New System.Drawing.Size(83, 34)
        Me.tombolKonversiMeter.TabIndex = 1
        Me.tombolKonversiMeter.Text = "Konversi Meter"
        Me.tombolKonversiMeter.UseVisualStyleBackColor = True
        '
        'tombolKonversiInci
        '
        Me.tombolKonversiInci.Location = New System.Drawing.Point(135, 86)
        Me.tombolKonversiInci.Name = "tombolKonversiInci"
        Me.tombolKonversiInci.Size = New System.Drawing.Size(83, 34)
        Me.tombolKonversiInci.TabIndex = 2
        Me.tombolKonversiInci.Text = "Konversi Inci"
        Me.tombolKonversiInci.UseVisualStyleBackColor = True
        '
        'tombolKeluar
        '
        Me.tombolKeluar.Location = New System.Drawing.Point(253, 86)
        Me.tombolKeluar.Name = "tombolKeluar"
        Me.tombolKeluar.Size = New System.Drawing.Size(83, 34)
        Me.tombolKeluar.TabIndex = 3
        Me.tombolKeluar.Text = "Keluar"
        Me.tombolKeluar.UseVisualStyleBackColor = True
        '
        'FormUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 150)
        Me.Controls.Add(Me.tombolKeluar)
        Me.Controls.Add(Me.tombolKonversiInci)
        Me.Controls.Add(Me.tombolKonversiMeter)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormUtama"
        Me.Text = "Konverter"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tombolKonversiMeter As System.Windows.Forms.Button
    Friend WithEvents tombolKonversiInci As System.Windows.Forms.Button
    Friend WithEvents tombolKeluar As System.Windows.Forms.Button

End Class
