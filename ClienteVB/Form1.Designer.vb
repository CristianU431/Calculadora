<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtNro1 = New System.Windows.Forms.TextBox()
        Me.txtNro2 = New System.Windows.Forms.TextBox()
        Me.btnSuma = New System.Windows.Forms.Button()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnResta = New System.Windows.Forms.Button()
        Me.btnMultiplicacion = New System.Windows.Forms.Button()
        Me.btnDivision = New System.Windows.Forms.Button()
        Me.btnPorcentaje = New System.Windows.Forms.Button()
        Me.btnPotencia = New System.Windows.Forms.Button()
        Me.btnSen = New System.Windows.Forms.Button()
        Me.btnCos = New System.Windows.Forms.Button()
        Me.btnTan = New System.Windows.Forms.Button()
        Me.btnfac = New System.Windows.Forms.Button()
        Me.btnInversa = New System.Windows.Forms.Button()
        Me.btnLog = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNro1
        '
        Me.txtNro1.Location = New System.Drawing.Point(184, 38)
        Me.txtNro1.Name = "txtNro1"
        Me.txtNro1.Size = New System.Drawing.Size(100, 22)
        Me.txtNro1.TabIndex = 0
        '
        'txtNro2
        '
        Me.txtNro2.Location = New System.Drawing.Point(184, 93)
        Me.txtNro2.Name = "txtNro2"
        Me.txtNro2.Size = New System.Drawing.Size(100, 22)
        Me.txtNro2.TabIndex = 1
        '
        'btnSuma
        '
        Me.btnSuma.Cursor = System.Windows.Forms.Cursors.No
        Me.btnSuma.Font = New System.Drawing.Font("Wide Latin", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuma.Location = New System.Drawing.Point(48, 150)
        Me.btnSuma.Name = "btnSuma"
        Me.btnSuma.Size = New System.Drawing.Size(84, 41)
        Me.btnSuma.TabIndex = 2
        Me.btnSuma.Text = "+"
        Me.btnSuma.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSuma.UseVisualStyleBackColor = True
        '
        'txtResultado
        '
        Me.txtResultado.Location = New System.Drawing.Point(184, 365)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(100, 22)
        Me.txtResultado.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(194, 346)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 16)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Resultado:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(160, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 16)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Inserte primer número"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(155, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(173, 16)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Inserte segundo número"
        '
        'btnResta
        '
        Me.btnResta.Cursor = System.Windows.Forms.Cursors.No
        Me.btnResta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnResta.Font = New System.Drawing.Font("Wide Latin", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResta.Location = New System.Drawing.Point(158, 150)
        Me.btnResta.Name = "btnResta"
        Me.btnResta.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnResta.Size = New System.Drawing.Size(84, 41)
        Me.btnResta.TabIndex = 19
        Me.btnResta.Text = "-"
        Me.btnResta.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnResta.UseVisualStyleBackColor = True
        '
        'btnMultiplicacion
        '
        Me.btnMultiplicacion.Cursor = System.Windows.Forms.Cursors.No
        Me.btnMultiplicacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnMultiplicacion.Font = New System.Drawing.Font("Wide Latin", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMultiplicacion.Location = New System.Drawing.Point(264, 150)
        Me.btnMultiplicacion.Name = "btnMultiplicacion"
        Me.btnMultiplicacion.Size = New System.Drawing.Size(84, 41)
        Me.btnMultiplicacion.TabIndex = 20
        Me.btnMultiplicacion.Text = "*"
        Me.btnMultiplicacion.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnMultiplicacion.UseVisualStyleBackColor = True
        '
        'btnDivision
        '
        Me.btnDivision.Cursor = System.Windows.Forms.Cursors.No
        Me.btnDivision.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnDivision.Font = New System.Drawing.Font("Wide Latin", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDivision.Location = New System.Drawing.Point(365, 150)
        Me.btnDivision.Name = "btnDivision"
        Me.btnDivision.Size = New System.Drawing.Size(84, 41)
        Me.btnDivision.TabIndex = 21
        Me.btnDivision.Text = "/"
        Me.btnDivision.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDivision.UseVisualStyleBackColor = True
        '
        'btnPorcentaje
        '
        Me.btnPorcentaje.Cursor = System.Windows.Forms.Cursors.No
        Me.btnPorcentaje.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnPorcentaje.Font = New System.Drawing.Font("Wide Latin", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPorcentaje.Location = New System.Drawing.Point(365, 274)
        Me.btnPorcentaje.Name = "btnPorcentaje"
        Me.btnPorcentaje.Size = New System.Drawing.Size(84, 41)
        Me.btnPorcentaje.TabIndex = 23
        Me.btnPorcentaje.Text = "%"
        Me.btnPorcentaje.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPorcentaje.UseVisualStyleBackColor = True
        '
        'btnPotencia
        '
        Me.btnPotencia.Cursor = System.Windows.Forms.Cursors.No
        Me.btnPotencia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnPotencia.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPotencia.Location = New System.Drawing.Point(48, 214)
        Me.btnPotencia.Name = "btnPotencia"
        Me.btnPotencia.Size = New System.Drawing.Size(84, 41)
        Me.btnPotencia.TabIndex = 29
        Me.btnPotencia.Text = "x^n"
        Me.btnPotencia.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPotencia.UseVisualStyleBackColor = True
        '
        'btnSen
        '
        Me.btnSen.Cursor = System.Windows.Forms.Cursors.No
        Me.btnSen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnSen.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSen.Location = New System.Drawing.Point(158, 212)
        Me.btnSen.Name = "btnSen"
        Me.btnSen.Size = New System.Drawing.Size(84, 41)
        Me.btnSen.TabIndex = 30
        Me.btnSen.Text = "Sen"
        Me.btnSen.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSen.UseVisualStyleBackColor = True
        '
        'btnCos
        '
        Me.btnCos.Cursor = System.Windows.Forms.Cursors.No
        Me.btnCos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnCos.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCos.Location = New System.Drawing.Point(264, 212)
        Me.btnCos.Name = "btnCos"
        Me.btnCos.Size = New System.Drawing.Size(84, 41)
        Me.btnCos.TabIndex = 31
        Me.btnCos.Text = "Cos"
        Me.btnCos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCos.UseVisualStyleBackColor = True
        '
        'btnTan
        '
        Me.btnTan.Cursor = System.Windows.Forms.Cursors.No
        Me.btnTan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnTan.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTan.Location = New System.Drawing.Point(365, 214)
        Me.btnTan.Name = "btnTan"
        Me.btnTan.Size = New System.Drawing.Size(84, 41)
        Me.btnTan.TabIndex = 32
        Me.btnTan.Text = "Tan"
        Me.btnTan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnTan.UseVisualStyleBackColor = True
        '
        'btnfac
        '
        Me.btnfac.Cursor = System.Windows.Forms.Cursors.No
        Me.btnfac.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnfac.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfac.Location = New System.Drawing.Point(48, 274)
        Me.btnfac.Name = "btnfac"
        Me.btnfac.Size = New System.Drawing.Size(84, 41)
        Me.btnfac.TabIndex = 33
        Me.btnfac.Text = "!"
        Me.btnfac.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnfac.UseVisualStyleBackColor = True
        '
        'btnInversa
        '
        Me.btnInversa.Cursor = System.Windows.Forms.Cursors.No
        Me.btnInversa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnInversa.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInversa.Location = New System.Drawing.Point(158, 272)
        Me.btnInversa.Name = "btnInversa"
        Me.btnInversa.Size = New System.Drawing.Size(84, 41)
        Me.btnInversa.TabIndex = 34
        Me.btnInversa.Text = "x^-1"
        Me.btnInversa.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnInversa.UseVisualStyleBackColor = True
        '
        'btnLog
        '
        Me.btnLog.Cursor = System.Windows.Forms.Cursors.No
        Me.btnLog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnLog.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLog.Location = New System.Drawing.Point(264, 272)
        Me.btnLog.Name = "btnLog"
        Me.btnLog.Size = New System.Drawing.Size(84, 41)
        Me.btnLog.TabIndex = 35
        Me.btnLog.Text = "Log"
        Me.btnLog.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLog.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 411)
        Me.Controls.Add(Me.btnLog)
        Me.Controls.Add(Me.btnInversa)
        Me.Controls.Add(Me.btnfac)
        Me.Controls.Add(Me.btnTan)
        Me.Controls.Add(Me.btnCos)
        Me.Controls.Add(Me.btnSen)
        Me.Controls.Add(Me.btnPotencia)
        Me.Controls.Add(Me.btnPorcentaje)
        Me.Controls.Add(Me.btnDivision)
        Me.Controls.Add(Me.btnMultiplicacion)
        Me.Controls.Add(Me.btnResta)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.btnSuma)
        Me.Controls.Add(Me.txtNro2)
        Me.Controls.Add(Me.txtNro1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNro1 As TextBox
    Friend WithEvents txtNro2 As TextBox
    Friend WithEvents btnSuma As Button
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnMultiplicacion As Button
    Friend WithEvents btnDivision As Button
    Friend WithEvents btnPorcentaje As Button
    Friend WithEvents btnPotencia As Button
    Friend WithEvents btnSen As Button
    Friend WithEvents btnCos As Button
    Friend WithEvents btnTan As Button
    Friend WithEvents btnfac As Button
    Friend WithEvents btnInversa As Button
    Friend WithEvents btnLog As Button
    Private WithEvents btnResta As Button
End Class
