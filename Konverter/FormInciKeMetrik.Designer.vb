<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInciKeMetrik
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
        Me.tombolTutup = New System.Windows.Forms.Button()
        Me.tombolKonversiKeMeter = New System.Windows.Forms.Button()
        Me.tombolKonversiKeSentimeter = New System.Windows.Forms.Button()
        Me.tombolKonversiKeMiliMeter = New System.Windows.Forms.Button()
        Me.teksJumInci = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tombolTutup
        '
        Me.tombolTutup.Location = New System.Drawing.Point(113, 126)
        Me.tombolTutup.Name = "tombolTutup"
        Me.tombolTutup.Size = New System.Drawing.Size(83, 40)
        Me.tombolTutup.TabIndex = 11
        Me.tombolTutup.Text = "Tutup"
        Me.tombolTutup.UseVisualStyleBackColor = True
        '
        'tombolKonversiKeMeter
        '
        Me.tombolKonversiKeMeter.Location = New System.Drawing.Point(217, 70)
        Me.tombolKonversiKeMeter.Name = "tombolKonversiKeMeter"
        Me.tombolKonversiKeMeter.Size = New System.Drawing.Size(83, 40)
        Me.tombolKonversiKeMeter.TabIndex = 10
        Me.tombolKonversiKeMeter.Text = "Konversi Ke Meter"
        Me.tombolKonversiKeMeter.UseVisualStyleBackColor = True
        '
        'tombolKonversiKeSentimeter
        '
        Me.tombolKonversiKeSentimeter.Location = New System.Drawing.Point(113, 70)
        Me.tombolKonversiKeSentimeter.Name = "tombolKonversiKeSentimeter"
        Me.tombolKonversiKeSentimeter.Size = New System.Drawing.Size(83, 40)
        Me.tombolKonversiKeSentimeter.TabIndex = 9
        Me.tombolKonversiKeSentimeter.Text = "Konversi Ke Sentimeter"
        Me.tombolKonversiKeSentimeter.UseVisualStyleBackColor = True
        '
        'tombolKonversiKeMiliMeter
        '
        Me.tombolKonversiKeMiliMeter.Location = New System.Drawing.Point(11, 70)
        Me.tombolKonversiKeMiliMeter.Name = "tombolKonversiKeMiliMeter"
        Me.tombolKonversiKeMiliMeter.Size = New System.Drawing.Size(83, 40)
        Me.tombolKonversiKeMiliMeter.TabIndex = 8
        Me.tombolKonversiKeMiliMeter.Text = "Konversi Ke Milimeter"
        Me.tombolKonversiKeMiliMeter.UseVisualStyleBackColor = True
        '
        'teksJumInci
        '
        Me.teksJumInci.Location = New System.Drawing.Point(141, 13)
        Me.teksJumInci.Name = "teksJumInci"
        Me.teksJumInci.Size = New System.Drawing.Size(159, 20)
        Me.teksJumInci.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Masukkan Jumlah Inci:"
        '
        'FormInciKeMetrik
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(315, 177)
        Me.Controls.Add(Me.tombolTutup)
        Me.Controls.Add(Me.tombolKonversiKeMeter)
        Me.Controls.Add(Me.tombolKonversiKeSentimeter)
        Me.Controls.Add(Me.tombolKonversiKeMiliMeter)
        Me.Controls.Add(Me.teksJumInci)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormInciKeMetrik"
        Me.Text = "FormInciKeMetrik"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tombolTutup As System.Windows.Forms.Button
    Friend WithEvents tombolKonversiKeMeter As System.Windows.Forms.Button
    Friend WithEvents tombolKonversiKeSentimeter As System.Windows.Forms.Button
    Friend WithEvents tombolKonversiKeMiliMeter As System.Windows.Forms.Button
    Friend WithEvents teksJumInci As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
