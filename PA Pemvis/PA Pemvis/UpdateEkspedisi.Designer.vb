<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateEkspedisi
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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.txtEstimasi = New System.Windows.Forms.TextBox()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtTujuan = New System.Windows.Forms.TextBox()
        Me.txtAsal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Button3.Image = Global.PA_Pemvis.My.Resources.Resources.left_arrow__1_
        Me.Button3.Location = New System.Drawing.Point(15, 32)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 35)
        Me.Button3.TabIndex = 27
        Me.Button3.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnClear.Location = New System.Drawing.Point(352, 466)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(112, 35)
        Me.btnClear.TabIndex = 26
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnUpdate.Location = New System.Drawing.Point(191, 466)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(112, 35)
        Me.btnUpdate.TabIndex = 25
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'txtEstimasi
        '
        Me.txtEstimasi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEstimasi.Location = New System.Drawing.Point(153, 391)
        Me.txtEstimasi.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtEstimasi.Name = "txtEstimasi"
        Me.txtEstimasi.Size = New System.Drawing.Size(336, 19)
        Me.txtEstimasi.TabIndex = 24
        '
        'txtHarga
        '
        Me.txtHarga.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtHarga.Location = New System.Drawing.Point(153, 330)
        Me.txtHarga.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(336, 19)
        Me.txtHarga.TabIndex = 22
        '
        'txtNama
        '
        Me.txtNama.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNama.Location = New System.Drawing.Point(153, 267)
        Me.txtNama.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(336, 19)
        Me.txtNama.TabIndex = 21
        '
        'txtTujuan
        '
        Me.txtTujuan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTujuan.Location = New System.Drawing.Point(153, 208)
        Me.txtTujuan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTujuan.Name = "txtTujuan"
        Me.txtTujuan.Size = New System.Drawing.Size(336, 19)
        Me.txtTujuan.TabIndex = 20
        '
        'txtAsal
        '
        Me.txtAsal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAsal.Location = New System.Drawing.Point(153, 150)
        Me.txtAsal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtAsal.Name = "txtAsal"
        Me.txtAsal.Size = New System.Drawing.Size(336, 19)
        Me.txtAsal.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(206, 65)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(258, 33)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Update Ekspedisi"
        '
        'UpdateEkspedisi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(618, 553)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtEstimasi)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtTujuan)
        Me.Controls.Add(Me.txtAsal)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "UpdateEkspedisi"
        Me.Text = "UpdateEkspedisi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button3 As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents txtEstimasi As TextBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtTujuan As TextBox
    Friend WithEvents txtAsal As TextBox
    Friend WithEvents Label1 As Label
End Class
