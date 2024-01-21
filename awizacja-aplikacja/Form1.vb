Public Class Form1

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub


    Dim godziny As New List(Of String)({"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"})
    Dim minuty As New List(Of String)({"00", "15", "30", "45"})
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CB_GodzinaAwizacji.DataSource = godziny
        CB_MinutaAwizacji.DataSource = minuty

        Me.AutoSize = False
        Me.AutoScaleMode = AutoScaleMode.Font

    End Sub

   

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim button As New TextBox
        TableLayoutPanel1.Controls.Add(button, 0, 0)
        TextBox5.Text = godziny(NumericUpDown1.Value)

    End Sub
End Class
