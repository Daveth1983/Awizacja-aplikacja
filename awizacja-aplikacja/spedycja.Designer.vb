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
        Me.CKB_Spedytor = New System.Windows.Forms.CheckBox()
        Me.CB_GodzinaAwizacji = New System.Windows.Forms.ComboBox()
        Me.DTP_DataAwizacji = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GB_TypAwizacji.SuspendLayout()
        Me.SuspendLayout()
        '
        'LBL_NrTelefonu
        '
        Me.LBL_NrTelefonu.AutoSize = True
        Me.LBL_NrTelefonu.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LBL_NrTelefonu.Location = New System.Drawing.Point(560, 238)
        Me.LBL_NrTelefonu.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBL_NrTelefonu.Name = "LBL_NrTelefonu"
        Me.LBL_NrTelefonu.Size = New System.Drawing.Size(62, 14)
        Me.LBL_NrTelefonu.TabIndex = 39
        Me.LBL_NrTelefonu.Text = "Nr Telefonu"
        '
        'LBL_Kierowca
        '
        Me.LBL_Kierowca.AutoSize = True
        Me.LBL_Kierowca.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LBL_Kierowca.Location = New System.Drawing.Point(560, 191)
        Me.LBL_Kierowca.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBL_Kierowca.Name = "LBL_Kierowca"
        Me.LBL_Kierowca.Size = New System.Drawing.Size(54, 14)
        Me.LBL_Kierowca.TabIndex = 38
        Me.LBL_Kierowca.Text = "Kierowca"
        '
        'LBL_Komentarz
        '
        Me.LBL_Komentarz.AutoSize = True
        Me.LBL_Komentarz.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LBL_Komentarz.Location = New System.Drawing.Point(55, 245)
        Me.LBL_Komentarz.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBL_Komentarz.Name = "LBL_Komentarz"
        Me.LBL_Komentarz.Size = New System.Drawing.Size(59, 14)
        Me.LBL_Komentarz.TabIndex = 37
        Me.LBL_Komentarz.Text = "Komentarz"
        '
        'LBL_DataAwizacji
        '
        Me.LBL_DataAwizacji.AutoSize = True
        Me.LBL_DataAwizacji.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LBL_DataAwizacji.Location = New System.Drawing.Point(36, 191)
        Me.LBL_DataAwizacji.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBL_DataAwizacji.Name = "LBL_DataAwizacji"
        Me.LBL_DataAwizacji.Size = New System.Drawing.Size(73, 14)
        Me.LBL_DataAwizacji.TabIndex = 36
        Me.LBL_DataAwizacji.Text = "Data Awizacji"
        '
        'LBL_GodzinaAwizacji
        '
        Me.LBL_GodzinaAwizacji.AutoSize = True
        Me.LBL_GodzinaAwizacji.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LBL_GodzinaAwizacji.Location = New System.Drawing.Point(45, 155)
        Me.LBL_GodzinaAwizacji.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBL_GodzinaAwizacji.Name = "LBL_GodzinaAwizacji"
        Me.LBL_GodzinaAwizacji.Size = New System.Drawing.Size(91, 14)
        Me.LBL_GodzinaAwizacji.TabIndex = 35
        Me.LBL_GodzinaAwizacji.Text = "Godzina Awizacji"
        '
        'LBL_NrNaczepy
        '
        Me.LBL_NrNaczepy.AutoSize = True
        Me.LBL_NrNaczepy.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LBL_NrNaczepy.Location = New System.Drawing.Point(67, 114)
        Me.LBL_NrNaczepy.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBL_NrNaczepy.Name = "LBL_NrNaczepy"
        Me.LBL_NrNaczepy.Size = New System.Drawing.Size(64, 14)
        Me.LBL_NrNaczepy.TabIndex = 34
        Me.LBL_NrNaczepy.Text = "Nr Naczepy"
        '
        'LBL_nrRejestracyjny
        '
        Me.LBL_nrRejestracyjny.AutoSize = True
        Me.LBL_nrRejestracyjny.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LBL_nrRejestracyjny.Location = New System.Drawing.Point(43, 85)
        Me.LBL_nrRejestracyjny.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBL_nrRejestracyjny.Name = "LBL_nrRejestracyjny"
        Me.LBL_nrRejestracyjny.Size = New System.Drawing.Size(90, 14)
        Me.LBL_nrRejestracyjny.TabIndex = 33
        Me.LBL_nrRejestracyjny.Text = "Nr  Rejestracyjny"
        '
        'LBL_Spedytor
        '
        Me.LBL_Spedytor.AutoSize = True
        Me.LBL_Spedytor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LBL_Spedytor.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LBL_Spedytor.Location = New System.Drawing.Point(92, 49)
        Me.LBL_Spedytor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBL_Spedytor.Name = "LBL_Spedytor"
        Me.LBL_Spedytor.Size = New System.Drawing.Size(51, 14)
        Me.LBL_Spedytor.TabIndex = 32
        Me.LBL_Spedytor.Text = "Spedytor"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(710, 469)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(74, 36)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TB_NrTelefonu
        '
        Me.TB_NrTelefonu.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TB_NrTelefonu.Location = New System.Drawing.Point(651, 233)
        Me.TB_NrTelefonu.Margin = New System.Windows.Forms.Padding(2)
        Me.TB_NrTelefonu.Name = "TB_NrTelefonu"
        Me.TB_NrTelefonu.Size = New System.Drawing.Size(146, 20)
        Me.TB_NrTelefonu.TabIndex = 30
        '
        'TB_Kierowca
        '
        Me.TB_Kierowca.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TB_Kierowca.Location = New System.Drawing.Point(651, 186)
        Me.TB_Kierowca.Margin = New System.Windows.Forms.Padding(2)
        Me.TB_Kierowca.Name = "TB_Kierowca"
        Me.TB_Kierowca.Size = New System.Drawing.Size(146, 20)
        Me.TB_Kierowca.TabIndex = 29
        '
        'CB_Spedytor
        '
        Me.CB_Spedytor.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.CB_Spedytor.FormattingEnabled = True
        Me.CB_Spedytor.Location = New System.Drawing.Point(161, 47)
        Me.CB_Spedytor.Margin = New System.Windows.Forms.Padding(2)
        Me.CB_Spedytor.Name = "CB_Spedytor"
        Me.CB_Spedytor.Size = New System.Drawing.Size(188, 22)
        Me.CB_Spedytor.TabIndex = 28
        '
        'GB_TypAwizacji
        '
        Me.GB_TypAwizacji.Controls.Add(Me.RB_Dostawa)
        Me.GB_TypAwizacji.Controls.Add(Me.RB_Odbior)
        Me.GB_TypAwizacji.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GB_TypAwizacji.Location = New System.Drawing.Point(545, 22)
        Me.GB_TypAwizacji.Margin = New System.Windows.Forms.Padding(2)
        Me.GB_TypAwizacji.Name = "GB_TypAwizacji"
        Me.GB_TypAwizacji.Padding = New System.Windows.Forms.Padding(2)
        Me.GB_TypAwizacji.Size = New System.Drawing.Size(150, 81)
        Me.GB_TypAwizacji.TabIndex = 27
        Me.GB_TypAwizacji.TabStop = False
        Me.GB_TypAwizacji.Text = "Typ Awizacji"
        '
        'RB_Dostawa
        '
        Me.RB_Dostawa.AutoSize = True
        Me.RB_Dostawa.Location = New System.Drawing.Point(28, 52)
        Me.RB_Dostawa.Margin = New System.Windows.Forms.Padding(2)
        Me.RB_Dostawa.Name = "RB_Dostawa"
        Me.RB_Dostawa.Size = New System.Drawing.Size(69, 18)
        Me.RB_Dostawa.TabIndex = 1
        Me.RB_Dostawa.TabStop = True
        Me.RB_Dostawa.Text = "Dostawa"
        Me.RB_Dostawa.UseVisualStyleBackColor = True
        '
        'RB_Odbior
        '
        Me.RB_Odbior.AutoSize = True
        Me.RB_Odbior.Location = New System.Drawing.Point(28, 27)
        Me.RB_Odbior.Margin = New System.Windows.Forms.Padding(2)
        Me.RB_Odbior.Name = "RB_Odbior"
        Me.RB_Odbior.Size = New System.Drawing.Size(57, 18)
        Me.RB_Odbior.TabIndex = 0
        Me.RB_Odbior.TabStop = True
        Me.RB_Odbior.Text = "Odbiór"
        Me.RB_Odbior.UseVisualStyleBackColor = True
        '
        'RTB_Komentarz
        '
        Me.RTB_Komentarz.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.RTB_Komentarz.Location = New System.Drawing.Point(151, 233)
        Me.RTB_Komentarz.Margin = New System.Windows.Forms.Padding(2)
        Me.RTB_Komentarz.Name = "RTB_Komentarz"
        Me.RTB_Komentarz.Size = New System.Drawing.Size(348, 192)
        Me.RTB_Komentarz.TabIndex = 26
        Me.RTB_Komentarz.Text = ""
        '
        'TB_NrNaczepy
        '
        Me.TB_NrNaczepy.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TB_NrNaczepy.Location = New System.Drawing.Point(163, 109)
        Me.TB_NrNaczepy.Margin = New System.Windows.Forms.Padding(2)
        Me.TB_NrNaczepy.Name = "TB_NrNaczepy"
        Me.TB_NrNaczepy.Size = New System.Drawing.Size(188, 20)
        Me.TB_NrNaczepy.TabIndex = 24
        '
        'TB_NrRejestracyjny
        '
        Me.TB_NrRejestracyjny.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TB_NrRejestracyjny.Location = New System.Drawing.Point(163, 82)
        Me.TB_NrRejestracyjny.Margin = New System.Windows.Forms.Padding(2)
        Me.TB_NrRejestracyjny.Name = "TB_NrRejestracyjny"
        Me.TB_NrRejestracyjny.Size = New System.Drawing.Size(188, 20)
        Me.TB_NrRejestracyjny.TabIndex = 23
        '
        'CKB_Spedytor
        '
        Me.CKB_Spedytor.AutoSize = True
        Me.CKB_Spedytor.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.CKB_Spedytor.Location = New System.Drawing.Point(353, 47)
        Me.CKB_Spedytor.Margin = New System.Windows.Forms.Padding(2)
        Me.CKB_Spedytor.Name = "CKB_Spedytor"
        Me.CKB_Spedytor.Size = New System.Drawing.Size(56, 18)
        Me.CKB_Spedytor.TabIndex = 22
        Me.CKB_Spedytor.Text = "Wpisz"
        Me.CKB_Spedytor.UseVisualStyleBackColor = True
        '
        'CB_GodzinaAwizacji
        '
        Me.CB_GodzinaAwizacji.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.CB_GodzinaAwizacji.FormattingEnabled = True
        Me.CB_GodzinaAwizacji.Location = New System.Drawing.Point(161, 146)
        Me.CB_GodzinaAwizacji.Margin = New System.Windows.Forms.Padding(2)
        Me.CB_GodzinaAwizacji.Name = "CB_GodzinaAwizacji"
        Me.CB_GodzinaAwizacji.Size = New System.Drawing.Size(68, 22)
        Me.CB_GodzinaAwizacji.TabIndex = 21
        '
        'DTP_DataAwizacji
        '
        Me.DTP_DataAwizacji.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.DTP_DataAwizacji.Location = New System.Drawing.Point(151, 185)
        Me.DTP_DataAwizacji.Margin = New System.Windows.Forms.Padding(2)
        Me.DTP_DataAwizacji.Name = "DTP_DataAwizacji"
        Me.DTP_DataAwizacji.Size = New System.Drawing.Size(262, 20)
        Me.DTP_DataAwizacji.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(104, 469)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(104, 492)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Label2"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(563, 469)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(74, 36)
        Me.Button2.TabIndex = 42
        Me.Button2.Text = "dodaj"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(104, 517)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(104, 543)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Label4"
        '
        'spedycja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(882, 591)
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
        Me.Controls.Add(Me.CKB_Spedytor)
        Me.Controls.Add(Me.CB_GodzinaAwizacji)
        Me.Controls.Add(Me.DTP_DataAwizacji)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
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
    Friend WithEvents CKB_Spedytor As System.Windows.Forms.CheckBox
    Friend WithEvents CB_GodzinaAwizacji As System.Windows.Forms.ComboBox
    Friend WithEvents DTP_DataAwizacji As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
