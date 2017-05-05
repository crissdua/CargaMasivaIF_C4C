<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BtnSaldo = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnUsoMaq = New System.Windows.Forms.Button()
        Me.BtnHistServ = New System.Windows.Forms.Button()
        Me.BtnExBodega = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnSaldo
        '
        Me.BtnSaldo.Location = New System.Drawing.Point(17, 24)
        Me.BtnSaldo.Name = "BtnSaldo"
        Me.BtnSaldo.Size = New System.Drawing.Size(79, 48)
        Me.BtnSaldo.TabIndex = 0
        Me.BtnSaldo.Text = "Saldos"
        Me.BtnSaldo.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.BtnUsoMaq)
        Me.Panel1.Controls.Add(Me.BtnHistServ)
        Me.Panel1.Controls.Add(Me.BtnExBodega)
        Me.Panel1.Controls.Add(Me.BtnSaldo)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(4, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(364, 106)
        Me.Panel1.TabIndex = 14
        '
        'BtnUsoMaq
        '
        Me.BtnUsoMaq.Location = New System.Drawing.Point(272, 24)
        Me.BtnUsoMaq.Name = "BtnUsoMaq"
        Me.BtnUsoMaq.Size = New System.Drawing.Size(79, 48)
        Me.BtnUsoMaq.TabIndex = 17
        Me.BtnUsoMaq.Text = "Uso de Maquina"
        Me.BtnUsoMaq.UseVisualStyleBackColor = True
        '
        'BtnHistServ
        '
        Me.BtnHistServ.Location = New System.Drawing.Point(187, 24)
        Me.BtnHistServ.Name = "BtnHistServ"
        Me.BtnHistServ.Size = New System.Drawing.Size(79, 48)
        Me.BtnHistServ.TabIndex = 16
        Me.BtnHistServ.Text = "Historial de Servicio"
        Me.BtnHistServ.UseVisualStyleBackColor = True
        '
        'BtnExBodega
        '
        Me.BtnExBodega.Location = New System.Drawing.Point(102, 24)
        Me.BtnExBodega.Name = "BtnExBodega"
        Me.BtnExBodega.Size = New System.Drawing.Size(79, 48)
        Me.BtnExBodega.TabIndex = 15
        Me.BtnExBodega.Text = "Existencia Bodegas"
        Me.BtnExBodega.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label6.Location = New System.Drawing.Point(-2, -2)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 104)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "B1if"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(145, 120)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalir.TabIndex = 16
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.logosolutionsap
        Me.PictureBox1.Location = New System.Drawing.Point(0, 149)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(161, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 198)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Form1"
        Me.Text = " IF + C4C"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnSaldo As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnUsoMaq As Button
    Friend WithEvents BtnHistServ As Button
    Friend WithEvents BtnExBodega As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
