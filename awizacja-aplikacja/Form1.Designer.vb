<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TB_NrTelefonu = New System.Windows.Forms.TextBox()
        Me.TB_Kierowca = New System.Windows.Forms.TextBox()
        Me.CB_Spedytor = New System.Windows.Forms.ComboBox()
        Me.GB_TypAwizacji = New System.Windows.Forms.GroupBox()
        Me.RB_Dostawa = New System.Windows.Forms.RadioButton()
        Me.RB_Odbior = New System.Windows.Forms.RadioButton()
        Me.RTB_Komentarz = New System.Windows.Forms.RichTextBox()
        Me.CB_MinutaAwizacji = New System.Windows.Forms.ComboBox()
        Me.TB_NrNaczepy = New System.Windows.Forms.TextBox()
        Me.TB_NrRejestracyjny = New System.Windows.Forms.TextBox()
        Me.CKB_Spedytor = New System.Windows.Forms.CheckBox()
        Me.CB_GodzinaAwizacji = New System.Windows.Forms.ComboBox()
        Me.DTP_DataAwizacji = New System.Windows.Forms.DateTimePicker()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.LBL_Spedytor = New System.Windows.Forms.Label()
        Me.LBL_nrRejestracyjny = New System.Windows.Forms.Label()
        Me.LBL_NrNaczepy = New System.Windows.Forms.Label()
        Me.LBL_GodzinaAwizacji = New System.Windows.Forms.Label()
        Me.LBL_DataAwizacji = New System.Windows.Forms.Label()
        Me.LBL_Komentarz = New System.Windows.Forms.Label()
        Me.LBL_Kierowca = New System.Windows.Forms.Label()
        Me.LBL_NrTelefonu = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GB_TypAwizacji.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte), True)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1122, 650)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TabPage1.Location = New System.Drawing.Point(33, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1085, 642)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Magazyn"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.LBL_NrTelefonu)
        Me.TabPage2.Controls.Add(Me.LBL_Kierowca)
        Me.TabPage2.Controls.Add(Me.LBL_Komentarz)
        Me.TabPage2.Controls.Add(Me.LBL_DataAwizacji)
        Me.TabPage2.Controls.Add(Me.LBL_GodzinaAwizacji)
        Me.TabPage2.Controls.Add(Me.LBL_NrNaczepy)
        Me.TabPage2.Controls.Add(Me.LBL_nrRejestracyjny)
        Me.TabPage2.Controls.Add(Me.LBL_Spedytor)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.TB_NrTelefonu)
        Me.TabPage2.Controls.Add(Me.TB_Kierowca)
        Me.TabPage2.Controls.Add(Me.CB_Spedytor)
        Me.TabPage2.Controls.Add(Me.GB_TypAwizacji)
        Me.TabPage2.Controls.Add(Me.RTB_Komentarz)
        Me.TabPage2.Controls.Add(Me.CB_MinutaAwizacji)
        Me.TabPage2.Controls.Add(Me.TB_NrNaczepy)
        Me.TabPage2.Controls.Add(Me.TB_NrRejestracyjny)
        Me.TabPage2.Controls.Add(Me.CKB_Spedytor)
        Me.TabPage2.Controls.Add(Me.CB_GodzinaAwizacji)
        Me.TabPage2.Controls.Add(Me.DTP_DataAwizacji)
        Me.TabPage2.Location = New System.Drawing.Point(33, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1085, 642)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Spedycja"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(916, 579)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 44)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TB_NrTelefonu
        '
        Me.TB_NrTelefonu.Location = New System.Drawing.Point(838, 288)
        Me.TB_NrTelefonu.Name = "TB_NrTelefonu"
        Me.TB_NrTelefonu.Size = New System.Drawing.Size(194, 26)
        Me.TB_NrTelefonu.TabIndex = 10
        '
        'TB_Kierowca
        '
        Me.TB_Kierowca.Location = New System.Drawing.Point(838, 230)
        Me.TB_Kierowca.Name = "TB_Kierowca"
        Me.TB_Kierowca.Size = New System.Drawing.Size(194, 26)
        Me.TB_Kierowca.TabIndex = 9
        '
        'CB_Spedytor
        '
        Me.CB_Spedytor.FormattingEnabled = True
        Me.CB_Spedytor.Location = New System.Drawing.Point(171, 59)
        Me.CB_Spedytor.Name = "CB_Spedytor"
        Me.CB_Spedytor.Size = New System.Drawing.Size(250, 31)
        Me.CB_Spedytor.TabIndex = 8
        '
        'GB_TypAwizacji
        '
        Me.GB_TypAwizacji.Controls.Add(Me.RB_Dostawa)
        Me.GB_TypAwizacji.Controls.Add(Me.RB_Odbior)
        Me.GB_TypAwizacji.Location = New System.Drawing.Point(696, 28)
        Me.GB_TypAwizacji.Name = "GB_TypAwizacji"
        Me.GB_TypAwizacji.Size = New System.Drawing.Size(200, 100)
        Me.GB_TypAwizacji.TabIndex = 7
        Me.GB_TypAwizacji.TabStop = False
        Me.GB_TypAwizacji.Text = "Typ Awizacji"
        '
        'RB_Dostawa
        '
        Me.RB_Dostawa.AutoSize = True
        Me.RB_Dostawa.Location = New System.Drawing.Point(37, 64)
        Me.RB_Dostawa.Name = "RB_Dostawa"
        Me.RB_Dostawa.Size = New System.Drawing.Size(96, 24)
        Me.RB_Dostawa.TabIndex = 1
        Me.RB_Dostawa.TabStop = True
        Me.RB_Dostawa.Text = "Dostawa"
        Me.RB_Dostawa.UseVisualStyleBackColor = True
        '
        'RB_Odbior
        '
        Me.RB_Odbior.AutoSize = True
        Me.RB_Odbior.Location = New System.Drawing.Point(37, 33)
        Me.RB_Odbior.Name = "RB_Odbior"
        Me.RB_Odbior.Size = New System.Drawing.Size(80, 24)
        Me.RB_Odbior.TabIndex = 0
        Me.RB_Odbior.TabStop = True
        Me.RB_Odbior.Text = "Odbiór"
        Me.RB_Odbior.UseVisualStyleBackColor = True
        '
        'RTB_Komentarz
        '
        Me.RTB_Komentarz.Location = New System.Drawing.Point(171, 288)
        Me.RTB_Komentarz.Name = "RTB_Komentarz"
        Me.RTB_Komentarz.Size = New System.Drawing.Size(463, 235)
        Me.RTB_Komentarz.TabIndex = 6
        Me.RTB_Komentarz.Text = ""
        '
        'CB_MinutaAwizacji
        '
        Me.CB_MinutaAwizacji.FormattingEnabled = True
        Me.CB_MinutaAwizacji.Location = New System.Drawing.Point(301, 181)
        Me.CB_MinutaAwizacji.Name = "CB_MinutaAwizacji"
        Me.CB_MinutaAwizacji.Size = New System.Drawing.Size(90, 31)
        Me.CB_MinutaAwizacji.TabIndex = 5
        '
        'TB_NrNaczepy
        '
        Me.TB_NrNaczepy.Location = New System.Drawing.Point(171, 136)
        Me.TB_NrNaczepy.Name = "TB_NrNaczepy"
        Me.TB_NrNaczepy.Size = New System.Drawing.Size(250, 26)
        Me.TB_NrNaczepy.TabIndex = 4
        '
        'TB_NrRejestracyjny
        '
        Me.TB_NrRejestracyjny.Location = New System.Drawing.Point(171, 103)
        Me.TB_NrRejestracyjny.Name = "TB_NrRejestracyjny"
        Me.TB_NrRejestracyjny.Size = New System.Drawing.Size(250, 26)
        Me.TB_NrRejestracyjny.TabIndex = 3
        '
        'CKB_Spedytor
        '
        Me.CKB_Spedytor.AutoSize = True
        Me.CKB_Spedytor.Location = New System.Drawing.Point(440, 59)
        Me.CKB_Spedytor.Name = "CKB_Spedytor"
        Me.CKB_Spedytor.Size = New System.Drawing.Size(78, 24)
        Me.CKB_Spedytor.TabIndex = 2
        Me.CKB_Spedytor.Text = "Wpisz"
        Me.CKB_Spedytor.UseVisualStyleBackColor = True
        '
        'CB_GodzinaAwizacji
        '
        Me.CB_GodzinaAwizacji.FormattingEnabled = True
        Me.CB_GodzinaAwizacji.Location = New System.Drawing.Point(171, 181)
        Me.CB_GodzinaAwizacji.Name = "CB_GodzinaAwizacji"
        Me.CB_GodzinaAwizacji.Size = New System.Drawing.Size(90, 31)
        Me.CB_GodzinaAwizacji.TabIndex = 1
        '
        'DTP_DataAwizacji
        '
        Me.DTP_DataAwizacji.Location = New System.Drawing.Point(171, 229)
        Me.DTP_DataAwizacji.Name = "DTP_DataAwizacji"
        Me.DTP_DataAwizacji.Size = New System.Drawing.Size(348, 26)
        Me.DTP_DataAwizacji.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.NumericUpDown1)
        Me.TabPage3.Controls.Add(Me.TextBox5)
        Me.TabPage3.Controls.Add(Me.Button2)
        Me.TabPage3.Controls.Add(Me.TableLayoutPanel1)
        Me.TabPage3.Location = New System.Drawing.Point(33, 4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1085, 642)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Plan"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(544, 551)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(177, 55)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(144, 104)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(707, 328)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(120, 487)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(270, 26)
        Me.TextBox5.TabIndex = 2
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(242, 584)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 26)
        Me.NumericUpDown1.TabIndex = 3
        '
        'LBL_Spedytor
        '
        Me.LBL_Spedytor.AutoSize = True
        Me.LBL_Spedytor.Location = New System.Drawing.Point(92, 62)
        Me.LBL_Spedytor.Name = "LBL_Spedytor"
        Me.LBL_Spedytor.Size = New System.Drawing.Size(75, 20)
        Me.LBL_Spedytor.TabIndex = 12
        Me.LBL_Spedytor.Text = "Spedytor"
        '
        'LBL_nrRejestracyjny
        '
        Me.LBL_nrRejestracyjny.AutoSize = True
        Me.LBL_nrRejestracyjny.Location = New System.Drawing.Point(27, 106)
        Me.LBL_nrRejestracyjny.Name = "LBL_nrRejestracyjny"
        Me.LBL_nrRejestracyjny.Size = New System.Drawing.Size(138, 20)
        Me.LBL_nrRejestracyjny.TabIndex = 13
        Me.LBL_nrRejestracyjny.Text = "Nr  Rejestracyjny"
        '
        'LBL_NrNaczepy
        '
        Me.LBL_NrNaczepy.AutoSize = True
        Me.LBL_NrNaczepy.Location = New System.Drawing.Point(58, 142)
        Me.LBL_NrNaczepy.Name = "LBL_NrNaczepy"
        Me.LBL_NrNaczepy.Size = New System.Drawing.Size(97, 20)
        Me.LBL_NrNaczepy.TabIndex = 14
        Me.LBL_NrNaczepy.Text = "Nr Naczepy"
        '
        'LBL_GodzinaAwizacji
        '
        Me.LBL_GodzinaAwizacji.AutoSize = True
        Me.LBL_GodzinaAwizacji.Location = New System.Drawing.Point(29, 192)
        Me.LBL_GodzinaAwizacji.Name = "LBL_GodzinaAwizacji"
        Me.LBL_GodzinaAwizacji.Size = New System.Drawing.Size(138, 20)
        Me.LBL_GodzinaAwizacji.TabIndex = 15
        Me.LBL_GodzinaAwizacji.Text = "Godzina Awizacji"
        '
        'LBL_DataAwizacji
        '
        Me.LBL_DataAwizacji.AutoSize = True
        Me.LBL_DataAwizacji.Location = New System.Drawing.Point(17, 236)
        Me.LBL_DataAwizacji.Name = "LBL_DataAwizacji"
        Me.LBL_DataAwizacji.Size = New System.Drawing.Size(112, 20)
        Me.LBL_DataAwizacji.TabIndex = 16
        Me.LBL_DataAwizacji.Text = "Data Awizacji"
        '
        'LBL_Komentarz
        '
        Me.LBL_Komentarz.AutoSize = True
        Me.LBL_Komentarz.Location = New System.Drawing.Point(43, 303)
        Me.LBL_Komentarz.Name = "LBL_Komentarz"
        Me.LBL_Komentarz.Size = New System.Drawing.Size(90, 20)
        Me.LBL_Komentarz.TabIndex = 17
        Me.LBL_Komentarz.Text = "Komentarz"
        '
        'LBL_Kierowca
        '
        Me.LBL_Kierowca.AutoSize = True
        Me.LBL_Kierowca.Location = New System.Drawing.Point(716, 236)
        Me.LBL_Kierowca.Name = "LBL_Kierowca"
        Me.LBL_Kierowca.Size = New System.Drawing.Size(78, 20)
        Me.LBL_Kierowca.TabIndex = 18
        Me.LBL_Kierowca.Text = "Kierowca"
        '
        'LBL_NrTelefonu
        '
        Me.LBL_NrTelefonu.AutoSize = True
        Me.LBL_NrTelefonu.Location = New System.Drawing.Point(716, 294)
        Me.LBL_NrTelefonu.Name = "LBL_NrTelefonu"
        Me.LBL_NrTelefonu.Size = New System.Drawing.Size(96, 20)
        Me.LBL_NrTelefonu.TabIndex = 19
        Me.LBL_NrTelefonu.Text = "Nr Telefonu"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1122, 650)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GB_TypAwizacji.ResumeLayout(False)
        Me.GB_TypAwizacji.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TB_NrNaczepy As System.Windows.Forms.TextBox
    Friend WithEvents TB_NrRejestracyjny As System.Windows.Forms.TextBox
    Friend WithEvents CKB_Spedytor As System.Windows.Forms.CheckBox
    Friend WithEvents CB_GodzinaAwizacji As System.Windows.Forms.ComboBox
    Friend WithEvents DTP_DataAwizacji As System.Windows.Forms.DateTimePicker
    Friend WithEvents CB_MinutaAwizacji As System.Windows.Forms.ComboBox
    Friend WithEvents TB_NrTelefonu As System.Windows.Forms.TextBox
    Friend WithEvents TB_Kierowca As System.Windows.Forms.TextBox
    Friend WithEvents CB_Spedytor As System.Windows.Forms.ComboBox
    Friend WithEvents GB_TypAwizacji As System.Windows.Forms.GroupBox
    Friend WithEvents RB_Dostawa As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Odbior As System.Windows.Forms.RadioButton
    Friend WithEvents RTB_Komentarz As System.Windows.Forms.RichTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents LBL_GodzinaAwizacji As System.Windows.Forms.Label
    Friend WithEvents LBL_NrNaczepy As System.Windows.Forms.Label
    Friend WithEvents LBL_nrRejestracyjny As System.Windows.Forms.Label
    Friend WithEvents LBL_Spedytor As System.Windows.Forms.Label
    Friend WithEvents LBL_DataAwizacji As System.Windows.Forms.Label
    Friend WithEvents LBL_Komentarz As System.Windows.Forms.Label
    Friend WithEvents LBL_NrTelefonu As System.Windows.Forms.Label
    Friend WithEvents LBL_Kierowca As System.Windows.Forms.Label

End Class
