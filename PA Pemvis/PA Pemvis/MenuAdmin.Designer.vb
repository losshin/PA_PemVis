<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuAdmin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnPesan = New System.Windows.Forms.Button()
        Me.BtnPemesanan = New System.Windows.Forms.Button()
        Me.btnEkspedisi = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnBack.Image = Global.PA_Pemvis.My.Resources.Resources.logout
        Me.btnBack.Location = New System.Drawing.Point(13, 14)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(112, 76)
        Me.btnBack.TabIndex = 0
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(202, 33)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Menu Admin"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Ekspedisi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 276)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Daftar Pesanan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 405)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Buat Pesanan"
        '
        'btnPesan
        '
        Me.btnPesan.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnPesan.BackgroundImage = Global.PA_Pemvis.My.Resources.Resources.add_package
        Me.btnPesan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnPesan.Location = New System.Drawing.Point(180, 359)
        Me.btnPesan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnPesan.Name = "btnPesan"
        Me.btnPesan.Size = New System.Drawing.Size(253, 112)
        Me.btnPesan.TabIndex = 4
        Me.btnPesan.UseVisualStyleBackColor = False
        '
        'BtnPemesanan
        '
        Me.BtnPemesanan.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.BtnPemesanan.BackgroundImage = Global.PA_Pemvis.My.Resources.Resources.checklist
        Me.BtnPemesanan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnPemesanan.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnPemesanan.Location = New System.Drawing.Point(180, 230)
        Me.BtnPemesanan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnPemesanan.Name = "BtnPemesanan"
        Me.BtnPemesanan.Size = New System.Drawing.Size(253, 112)
        Me.BtnPemesanan.TabIndex = 3
        Me.BtnPemesanan.UseVisualStyleBackColor = False
        '
        'btnEkspedisi
        '
        Me.btnEkspedisi.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnEkspedisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnEkspedisi.Image = Global.PA_Pemvis.My.Resources.Resources.truck__1_
        Me.btnEkspedisi.Location = New System.Drawing.Point(180, 97)
        Me.btnEkspedisi.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnEkspedisi.Name = "btnEkspedisi"
        Me.btnEkspedisi.Size = New System.Drawing.Size(253, 112)
        Me.btnEkspedisi.TabIndex = 2
        Me.btnEkspedisi.UseVisualStyleBackColor = False
        '
        'MenuAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(579, 485)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnPesan)
        Me.Controls.Add(Me.BtnPemesanan)
        Me.Controls.Add(Me.btnEkspedisi)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBack)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MenuAdmin"
        Me.Text = "MainMenu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnEkspedisi As Button
    Friend WithEvents BtnPemesanan As Button
    Friend WithEvents btnPesan As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
