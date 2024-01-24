<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class spedycja
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
        Me.LBL_NrTelefonu = New System.Windows.Forms.Label()
        Me.LBL_Kierowca = New System.Windows.Forms.Label()
        Me.LBL_Komentarz = New System.Windows.Forms.Label()
        Me.LBL_DataAwizacji = New System.Windows.Forms.Label()
        Me.LBL_GodzinaAwizacji = New System.Windows.Forms.Label()
        Me.LBL_NrNaczepy = New System.Windows.Forms.Label()
        Me.LBL_nrRejestracyjny = New System.Windows.Forms.Label()
        Me.LBL_Spedytor = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TB_NrTelefonu = New System.Windows.Forms.TextBox()
        Me.TB_Kierowca = New System.Windows.Forms.TextBox()
        Me.CB_Spedytor = New System.Windows.Forms.ComboBox()
        Me.GB_TypAwizacji = New System.Windows.Forms.GroupBox()
        Me.RB_Dostawa = New System.Windows.Forms.RadioButton()
        Me.RB_Odbior = New System.Windows.Forms.RadioButton()
        Me.RTB_Komentarz = New System.Windows.Forms.RichTextBox()
        Me.TB_NrNaczepy = New System.Windows.Forms.TextBox()
        Me.TB_NrRejestracyjny = New System.Windows.Forms.TextBox()
        Me.CB_GodzinaAwizacji = New System.Windows.Forms.ComboBox()
        Me.DTP_DataAwizacji = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GB_TypAwizacji.SuspendLayout()
        Me.SuspendLayout()
        '
        'LBL_NrTelefonu
        '
        Me.LBL_NrTelefonu.AutoSize = True
        Me.LBL_NrTelefonu.BackColor = System.Drawing.Color.Transparent
        Me.LBL_NrTelefonu.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LBL_NrTelefonu.ForeColor = System.Drawing.Color.CadetBlue
        Me.LBL_NrTelefonu.Location = New System.Drawing.Point(778, 242)
        Me.LBL_NrTelefonu.Name = "LBL_NrTelefonu"
        Me.LBL_NrTelefonu.Size = New System.Drawing.Size(91, 19)
        Me.LBL_NrTelefonu.TabIndex = 39
        Me.LBL_NrTelefonu.Text = "Nr Telefonu"
        '
        'LBL_Kierowca
        '
        Me.LBL_Kierowca.AutoSize = True
        Me.LBL_Kierowca.BackColor = System.Drawing.Color.Transparent
        Me.LBL_Kierowca.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LBL_Kierowca.ForeColor = System.Drawing.Color.CadetBlue
        Me.LBL_Kierowca.Location = New System.Drawing.Point(778, 162)
        Me.LBL_Kierowca.Name = "LBL_Kierowca"
        Me.LBL_Kierowca.Size = New System.Drawing.Size(77, 19)
        Me.LBL_Kierowca.TabIndex = 38
        Me.LBL_Kierowca.Text = "Kierowca"
        '
        'LBL_Komentarz
        '
        Me.LBL_Komentarz.AutoSize = True
        Me.LBL_Komentarz.BackColor = System.Drawing.Color.Transparent
        Me.LBL_Komentarz.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LBL_Komentarz.ForeColor = System.Drawing.Color.CadetBlue
        Me.LBL_Komentarz.Location = New System.Drawing.Point(82, 318)
        Me.LBL_Komentarz.Name = "LBL_Komentarz"
        Me.LBL_Komentarz.Size = New System.Drawing.Size(87, 19)
        Me.LBL_Komentarz.TabIndex = 37
        Me.LBL_Komentarz.Text = "Komentarz"
        '
        'LBL_DataAwizacji
        '
        Me.LBL_DataAwizacji.AutoSize = True
        Me.LBL_DataAwizacji.BackColor = System.Drawing.Color.Transparent
        Me.LBL_DataAwizacji.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LBL_DataAwizacji.ForeColor = System.Drawing.Color.CadetBlue
        Me.LBL_DataAwizacji.Location = New System.Drawing.Point(62, 229)
        Me.LBL_DataAwizacji.Name = "LBL_DataAwizacji"
        Me.LBL_DataAwizacji.Size = New System.Drawing.Size(106, 19)
        Me.LBL_DataAwizacji.TabIndex = 36
        Me.LBL_DataAwizacji.Text = "Data Awizacji"
        '
        'LBL_GodzinaAwizacji
        '
        Me.LBL_GodzinaAwizacji.AutoSize = True
        Me.LBL_GodzinaAwizacji.BackColor = System.Drawing.Color.Transparent
        Me.LBL_GodzinaAwizacji.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LBL_GodzinaAwizacji.ForeColor = System.Drawing.Color.CadetBlue
        Me.LBL_GodzinaAwizacji.Location = New System.Drawing.Point(34, 271)
        Me.LBL_GodzinaAwizacji.Name = "LBL_GodzinaAwizacji"
        Me.LBL_GodzinaAwizacji.Size = New System.Drawing.Size(132, 19)
        Me.LBL_GodzinaAwizacji.TabIndex = 35
        Me.LBL_GodzinaAwizacji.Text = "Godzina Awizacji"
        '
        'LBL_NrNaczepy
        '
        Me.LBL_NrNaczepy.AutoSize = True
        Me.LBL_NrNaczepy.BackColor = System.Drawing.Color.Transparent
        Me.LBL_NrNaczepy.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LBL_NrNaczepy.ForeColor = System.Drawing.Color.CadetBlue
        Me.LBL_NrNaczepy.Location = New System.Drawing.Point(81, 160)
        Me.LBL_NrNaczepy.Name = "LBL_NrNaczepy"
        Me.LBL_NrNaczepy.Size = New System.Drawing.Size(95, 19)
        Me.LBL_NrNaczepy.TabIndex = 34
        Me.LBL_NrNaczepy.Text = "Nr Naczepy"
        '
        'LBL_nrRejestracyjny
        '
        Me.LBL_nrRejestracyjny.AutoSize = True
        Me.LBL_nrRejestracyjny.BackColor = System.Drawing.Color.Transparent
        Me.LBL_nrRejestracyjny.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LBL_nrRejestracyjny.ForeColor = System.Drawing.Color.CadetBlue
        Me.LBL_nrRejestracyjny.Location = New System.Drawing.Point(42, 117)
        Me.LBL_nrRejestracyjny.Name = "LBL_nrRejestracyjny"
        Me.LBL_nrRejestracyjny.Size = New System.Drawing.Size(134, 19)
        Me.LBL_nrRejestracyjny.TabIndex = 33
        Me.LBL_nrRejestracyjny.Text = "Nr  Rejestracyjny"
        '
        'LBL_Spedytor
        '
        Me.LBL_Spedytor.AutoSize = True
        Me.LBL_Spedytor.BackColor = System.Drawing.Color.Transparent
        Me.LBL_Spedytor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LBL_Spedytor.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LBL_Spedytor.ForeColor = System.Drawing.Color.CadetBlue
        Me.LBL_Spedytor.Location = New System.Drawing.Point(100, 72)
        Me.LBL_Spedytor.Name = "LBL_Spedytor"
        Me.LBL_Spedytor.Size = New System.Drawing.Size(75, 19)
        Me.LBL_Spedytor.TabIndex = 32
        Me.LBL_Spedytor.Text = "Spedytor"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(891, 638)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 55)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "Zamknij"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TB_NrTelefonu
        '
        Me.TB_NrTelefonu.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TB_NrTelefonu.Location = New System.Drawing.Point(783, 266)
        Me.TB_NrTelefonu.Name = "TB_NrTelefonu"
        Me.TB_NrTelefonu.Size = New System.Drawing.Size(217, 26)
        Me.TB_NrTelefonu.TabIndex = 30
        '
        'TB_Kierowca
        '
        Me.TB_Kierowca.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TB_Kierowca.Location = New System.Drawing.Point(783, 186)
        Me.TB_Kierowca.Name = "TB_Kierowca"
        Me.TB_Kierowca.Size = New System.Drawing.Size(217, 26)
        Me.TB_Kierowca.TabIndex = 29
        '
        'CB_Spedytor
        '
        Me.CB_Spedytor.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.CB_Spedytor.FormattingEnabled = True
        Me.CB_Spedytor.Location = New System.Drawing.Point(183, 66)
        Me.CB_Spedytor.Name = "CB_Spedytor"
        Me.CB_Spedytor.Size = New System.Drawing.Size(280, 27)
        Me.CB_Spedytor.TabIndex = 28
        '
        'GB_TypAwizacji
        '
        Me.GB_TypAwizacji.BackColor = System.Drawing.Color.Transparent
        Me.GB_TypAwizacji.Controls.Add(Me.RB_Dostawa)
        Me.GB_TypAwizacji.Controls.Add(Me.RB_Odbior)
        Me.GB_TypAwizacji.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GB_TypAwizacji.ForeColor = System.Drawing.Color.CadetBlue
        Me.GB_TypAwizacji.Location = New System.Drawing.Point(783, 318)
        Me.GB_TypAwizacji.Name = "GB_TypAwizacji"
        Me.GB_TypAwizacji.Size = New System.Drawing.Size(138, 111)
        Me.GB_TypAwizacji.TabIndex = 27
        Me.GB_TypAwizacji.TabStop = False
        Me.GB_TypAwizacji.Text = "Typ Awizacji"
        '
        'RB_Dostawa
        '
        Me.RB_Dostawa.AutoSize = True
        Me.RB_Dostawa.BackColor = System.Drawing.Color.Transparent
        Me.RB_Dostawa.ForeColor = System.Drawing.Color.CadetBlue
        Me.RB_Dostawa.Location = New System.Drawing.Point(6, 60)
        Me.RB_Dostawa.Name = "RB_Dostawa"
        Me.RB_Dostawa.Size = New System.Drawing.Size(96, 23)
        Me.RB_Dostawa.TabIndex = 1
        Me.RB_Dostawa.TabStop = True
        Me.RB_Dostawa.Text = "Dostawa"
        Me.RB_Dostawa.UseVisualStyleBackColor = False
        '
        'RB_Odbior
        '
        Me.RB_Odbior.AutoSize = True
        Me.RB_Odbior.BackColor = System.Drawing.Color.Transparent
        Me.RB_Odbior.ForeColor = System.Drawing.Color.CadetBlue
        Me.RB_Odbior.Location = New System.Drawing.Point(6, 26)
        Me.RB_Odbior.Name = "RB_Odbior"
        Me.RB_Odbior.Size = New System.Drawing.Size(83, 23)
        Me.RB_Odbior.TabIndex = 0
        Me.RB_Odbior.TabStop = True
        Me.RB_Odbior.Text = "Odbiór"
        Me.RB_Odbior.UseVisualStyleBackColor = False
        '
        'RTB_Komentarz
        '
        Me.RTB_Komentarz.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.RTB_Komentarz.Location = New System.Drawing.Point(183, 314)
        Me.RTB_Komentarz.Name = "RTB_Komentarz"
        Me.RTB_Komentarz.Size = New System.Drawing.Size(391, 293)
        Me.RTB_Komentarz.TabIndex = 26
        Me.RTB_Komentarz.Text = ""
        '
        'TB_NrNaczepy
        '
        Me.TB_NrNaczepy.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TB_NrNaczepy.Location = New System.Drawing.Point(183, 151)
        Me.TB_NrNaczepy.Name = "TB_NrNaczepy"
        Me.TB_NrNaczepy.Size = New System.Drawing.Size(134, 26)
        Me.TB_NrNaczepy.TabIndex = 24
        '
        'TB_NrRejestracyjny
        '
        Me.TB_NrRejestracyjny.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TB_NrRejestracyjny.Location = New System.Drawing.Point(183, 114)
        Me.TB_NrRejestracyjny.Name = "TB_NrRejestracyjny"
        Me.TB_NrRejestracyjny.Size = New System.Drawing.Size(134, 26)
        Me.TB_NrRejestracyjny.TabIndex = 23
        '
        'CB_GodzinaAwizacji
        '
        Me.CB_GodzinaAwizacji.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.CB_GodzinaAwizacji.FormattingEnabled = True
        Me.CB_GodzinaAwizacji.Location = New System.Drawing.Point(183, 258)
        Me.CB_GodzinaAwizacji.Name = "CB_GodzinaAwizacji"
        Me.CB_GodzinaAwizacji.Size = New System.Drawing.Size(100, 27)
        Me.CB_GodzinaAwizacji.TabIndex = 21
        '
        'DTP_DataAwizacji
        '
        Me.DTP_DataAwizacji.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.DTP_DataAwizacji.Location = New System.Drawing.Point(183, 222)
        Me.DTP_DataAwizacji.Name = "DTP_DataAwizacji"
        Me.DTP_DataAwizacji.Size = New System.Drawing.Size(391, 26)
        Me.DTP_DataAwizacji.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(174, 626)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(174, 646)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 20)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Label2"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(748, 638)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(111, 55)
        Me.Button2.TabIndex = 42
        Me.Button2.Text = "dodaj"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(174, 666)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 20)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(174, 686)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 20)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Label4"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(320, 658)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 35)
        Me.Button3.TabIndex = 45
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(474, 66)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(53, 35)
        Me.Button4.TabIndex = 46
        Me.Button4.Text = "+"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(183, 66)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(280, 26)
        Me.TextBox1.TabIndex = 47
        Me.TextBox1.Visible = False
        '
        'spedycja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BackgroundImage = Global.awizacja_aplikacja.My.Resources.Resources.Untitled___21
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1048, 745)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LBL_NrTelefonu)
        Me.Controls.Add(Me.LBL_Kierowca)
        Me.Controls.Add(Me.LBL_Komentarz)
        Me.Controls.Add(Me.LBL_DataAwizacji)
        Me.Controls.Add(Me.LBL_GodzinaAwizacji)
        Me.Controls.Add(Me.LBL_NrNaczepy)
        Me.Controls.Add(Me.LBL_nrRejestracyjny)
        Me.Controls.Add(Me.LBL_Spedytor)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TB_NrTelefonu)
        Me.Controls.Add(Me.TB_Kierowca)
        Me.Controls.Add(Me.CB_Spedytor)
        Me.Controls.Add(Me.GB_TypAwizacji)
        Me.Controls.Add(Me.RTB_Komentarz)
        Me.Controls.Add(Me.TB_NrNaczepy)
        Me.Controls.Add(Me.TB_NrRejestracyjny)
        Me.Controls.Add(Me.CB_GodzinaAwizacji)
        Me.Controls.Add(Me.DTP_DataAwizacji)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "spedycja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "spedycja"
        Me.GB_TypAwizacji.ResumeLayout(False)
        Me.GB_TypAwizacji.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBL_NrTelefonu As System.Windows.Forms.Label
    Friend WithEvents LBL_Kierowca As System.Windows.Forms.Label
    Friend WithEvents LBL_Komentarz As System.Windows.Forms.Label
    Friend WithEvents LBL_DataAwizacji As System.Windows.Forms.Label
    Friend WithEvents LBL_GodzinaAwizacji As System.Windows.Forms.Label
    Friend WithEvents LBL_NrNaczepy As System.Windows.Forms.Label
    Friend WithEvents LBL_nrRejestracyjny As System.Windows.Forms.Label
    Friend WithEvents LBL_Spedytor As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TB_NrTelefonu As System.Windows.Forms.TextBox
    Friend WithEvents TB_Kierowca As System.Windows.Forms.TextBox
    Friend WithEvents CB_Spedytor As System.Windows.Forms.ComboBox
    Friend WithEvents GB_TypAwizacji As System.Windows.Forms.GroupBox
    Friend WithEvents RB_Dostawa As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Odbior As System.Windows.Forms.RadioButton
    Friend WithEvents RTB_Komentarz As System.Windows.Forms.RichTextBox
    Friend WithEvents TB_NrNaczepy As System.Windows.Forms.TextBox
    Friend WithEvents TB_NrRejestracyjny As System.Windows.Forms.TextBox
    Friend WithEvents CB_GodzinaAwizacji As System.Windows.Forms.ComboBox
    Friend WithEvents DTP_DataAwizacji As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
