<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbOutput = New System.Windows.Forms.TextBox()
        Me.btnControl = New System.Windows.Forms.Button()
        Me.rbPriklady = New System.Windows.Forms.RadioButton()
        Me.rbNasobilka = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbNasobilka = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbVysledekNasobilka = New System.Windows.Forms.TextBox()
        Me.tbNasobilkaCislo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbPriklad = New System.Windows.Forms.GroupBox()
        Me.tbVysledekPriklad = New System.Windows.Forms.TextBox()
        Me.tbPriklad = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbError = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbNasobilka.SuspendLayout()
        Me.gbPriklad.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(270, 276)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.Location = New System.Drawing.Point(42, 377)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 29)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Výsledek je:"
        '
        'tbOutput
        '
        Me.tbOutput.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbOutput.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.tbOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbOutput.Location = New System.Drawing.Point(47, 409)
        Me.tbOutput.Multiline = True
        Me.tbOutput.Name = "tbOutput"
        Me.tbOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbOutput.Size = New System.Drawing.Size(396, 169)
        Me.tbOutput.TabIndex = 5
        '
        'btnControl
        '
        Me.btnControl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnControl.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnControl.Location = New System.Drawing.Point(1007, 497)
        Me.btnControl.Name = "btnControl"
        Me.btnControl.Size = New System.Drawing.Size(126, 81)
        Me.btnControl.TabIndex = 6
        Me.btnControl.Text = "Zkontroluj mě"
        Me.btnControl.UseVisualStyleBackColor = False
        '
        'rbPriklady
        '
        Me.rbPriklady.AutoSize = True
        Me.rbPriklady.Location = New System.Drawing.Point(714, 65)
        Me.rbPriklady.Name = "rbPriklady"
        Me.rbPriklady.Size = New System.Drawing.Size(169, 24)
        Me.rbPriklady.TabIndex = 7
        Me.rbPriklady.TabStop = True
        Me.rbPriklady.Text = "Příklady z násobení"
        Me.rbPriklady.UseVisualStyleBackColor = True
        '
        'rbNasobilka
        '
        Me.rbNasobilka.AutoSize = True
        Me.rbNasobilka.Location = New System.Drawing.Point(544, 65)
        Me.rbNasobilka.Name = "rbNasobilka"
        Me.rbNasobilka.Size = New System.Drawing.Size(150, 24)
        Me.rbNasobilka.TabIndex = 7
        Me.rbNasobilka.TabStop = True
        Me.rbNasobilka.Text = "Násobilka v řadě"
        Me.rbNasobilka.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(539, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 29)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Vyber typ úkolu"
        '
        'gbNasobilka
        '
        Me.gbNasobilka.Controls.Add(Me.Label5)
        Me.gbNasobilka.Controls.Add(Me.Label4)
        Me.gbNasobilka.Controls.Add(Me.tbVysledekNasobilka)
        Me.gbNasobilka.Controls.Add(Me.tbNasobilkaCislo)
        Me.gbNasobilka.Controls.Add(Me.Label2)
        Me.gbNasobilka.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gbNasobilka.Location = New System.Drawing.Point(544, 128)
        Me.gbNasobilka.Name = "gbNasobilka"
        Me.gbNasobilka.Size = New System.Drawing.Size(433, 231)
        Me.gbNasobilka.TabIndex = 9
        Me.gbNasobilka.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(147, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "čísla odděluj čárkou"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Napiš řešení:"
        '
        'tbVysledekNasobilka
        '
        Me.tbVysledekNasobilka.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbVysledekNasobilka.Location = New System.Drawing.Point(188, 111)
        Me.tbVysledekNasobilka.Multiline = True
        Me.tbVysledekNasobilka.Name = "tbVysledekNasobilka"
        Me.tbVysledekNasobilka.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbVysledekNasobilka.Size = New System.Drawing.Size(198, 114)
        Me.tbVysledekNasobilka.TabIndex = 2
        '
        'tbNasobilkaCislo
        '
        Me.tbNasobilkaCislo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.tbNasobilkaCislo.Enabled = False
        Me.tbNasobilkaCislo.Location = New System.Drawing.Point(188, 39)
        Me.tbNasobilkaCislo.Name = "tbNasobilkaCislo"
        Me.tbNasobilkaCislo.Size = New System.Drawing.Size(95, 35)
        Me.tbNasobilkaCislo.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 29)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Násobilka čísla"
        '
        'gbPriklad
        '
        Me.gbPriklad.Controls.Add(Me.tbVysledekPriklad)
        Me.gbPriklad.Controls.Add(Me.tbPriklad)
        Me.gbPriklad.Controls.Add(Me.Label7)
        Me.gbPriklad.Controls.Add(Me.Label6)
        Me.gbPriklad.Location = New System.Drawing.Point(544, 377)
        Me.gbPriklad.Name = "gbPriklad"
        Me.gbPriklad.Size = New System.Drawing.Size(433, 201)
        Me.gbPriklad.TabIndex = 10
        Me.gbPriklad.TabStop = False
        '
        'tbVysledekPriklad
        '
        Me.tbVysledekPriklad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbVysledekPriklad.Location = New System.Drawing.Point(188, 130)
        Me.tbVysledekPriklad.Name = "tbVysledekPriklad"
        Me.tbVysledekPriklad.Size = New System.Drawing.Size(169, 35)
        Me.tbVysledekPriklad.TabIndex = 2
        '
        'tbPriklad
        '
        Me.tbPriklad.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.tbPriklad.Enabled = False
        Me.tbPriklad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbPriklad.Location = New System.Drawing.Point(188, 23)
        Me.tbPriklad.Name = "tbPriklad"
        Me.tbPriklad.Size = New System.Drawing.Size(168, 35)
        Me.tbPriklad.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 133)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(171, 29)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Tvůj výsledek: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label6.Location = New System.Drawing.Point(54, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 29)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Vypočítej:"
        '
        'btnNext
        '
        Me.btnNext.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnNext.Location = New System.Drawing.Point(1007, 389)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(126, 81)
        Me.btnNext.TabIndex = 6
        Me.btnNext.Text = "Další příklad"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label8.Location = New System.Drawing.Point(47, 313)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(176, 25)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Počet chyb celkem"
        '
        'tbError
        '
        Me.tbError.ForeColor = System.Drawing.Color.Red
        Me.tbError.Location = New System.Drawing.Point(230, 313)
        Me.tbError.Name = "tbError"
        Me.tbError.Size = New System.Drawing.Size(71, 26)
        Me.tbError.TabIndex = 12
        Me.tbError.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1145, 634)
        Me.Controls.Add(Me.tbError)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.gbPriklad)
        Me.Controls.Add(Me.gbNasobilka)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rbNasobilka)
        Me.Controls.Add(Me.rbPriklady)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnControl)
        Me.Controls.Add(Me.tbOutput)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.MinimumSize = New System.Drawing.Size(1167, 690)
        Me.Name = "Form1"
        Me.Text = "Robot BELA"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbNasobilka.ResumeLayout(False)
        Me.gbNasobilka.PerformLayout()
        Me.gbPriklad.ResumeLayout(False)
        Me.gbPriklad.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbOutput As TextBox
    Friend WithEvents btnControl As Button
    Friend WithEvents rbPriklady As RadioButton
    Friend WithEvents rbNasobilka As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents gbNasobilka As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tbVysledekNasobilka As TextBox
    Friend WithEvents tbNasobilkaCislo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents gbPriklad As GroupBox
    Friend WithEvents tbVysledekPriklad As TextBox
    Friend WithEvents tbPriklad As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents tbError As TextBox
End Class
