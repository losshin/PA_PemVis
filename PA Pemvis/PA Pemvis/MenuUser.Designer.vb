<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuUser
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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnPesan = New System.Windows.Forms.Button()
        Me.BtnPemesanan = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnBack.Image = Global.PA_Pemvis.My.Resources.Resources.logout
        Me.btnBack.Location = New System.Drawing.Point(18, 18)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(112, 65)
        Me.btnBack.TabIndex = 0
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(234, 50)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 33)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Welcome!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(87, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Daftar Pesanan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(412, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Buat Pesanan"
        '
        'btnPesan
        '
        Me.btnPesan.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnPesan.BackgroundImage = Global.PA_Pemvis.My.Resources.Resources.add_package
        Me.btnPesan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnPesan.Location = New System.Drawing.Point(346, 160)
        Me.btnPesan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnPesan.Name = "btnPesan"
        Me.btnPesan.Size = New System.Drawing.Size(235, 117)
        Me.btnPesan.TabIndex = 6
        Me.btnPesan.UseVisualStyleBackColor = False
        '
        'BtnPemesanan
        '
        Me.BtnPemesanan.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.BtnPemesanan.BackgroundImage = Global.PA_Pemvis.My.Resources.Resources.checklist
        Me.BtnPemesanan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnPemesanan.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnPemesanan.Location = New System.Drawing.Point(38, 160)
        Me.BtnPemesanan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnPemesanan.Name = "BtnPemesanan"
        Me.BtnPemesanan.Size = New System.Drawing.Size(235, 117)
        Me.BtnPemesanan.TabIndex = 5
        Me.BtnPemesanan.UseVisualStyleBackColor = False
        '
        'MenuUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(641, 372)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnPesan)
        Me.Controls.Add(Me.BtnPemesanan)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBack)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MenuUser"
        Me.Text = "MenuUser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnPesan As Button
    Friend WithEvents BtnPemesanan As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
