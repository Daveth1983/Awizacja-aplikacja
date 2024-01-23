Public Class Form1

    Private Sub TabPage2_Click(sender As Object, e As EventArgs)

    End Sub


   
    Public awizacjaCzasy As New List(Of String)({
                                             "06:00", "06:15", "06:30", "06:45",
                                             "07:00", "07:15", "07:30", "07:45",
                                             "08:00", "08:15", "08:30", "08:45",
                                             "09:00", "09:15", "09:30", "09:45",
                                             "10:00", "10:15", "10:30", "10:45",
                                             "11:00", "11:15", "11:30", "11:45",
                                             "12:00", "12:15", "12:30", "12:45",
                                             "13:00", "13:15", "13:30", "13:45",
                                             "14:00", "14:15", "14:30", "14:45",
                                             "15:00", "15:15", "15:30", "15:45",
                                             "16:00", "16:15", "16:30", "16:45",
                                             "17:00", "17:15", "17:30", "17:45",
                                             "18:00", "18:15", "18:30", "18:45",
                                             "19:00", "19:15", "19:30", "19:45",
                                             "20:00", "20:15", "20:30", "20:45",
                                             "21:00", "21:15", "21:30", "21:45"
                                             })



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
   

        dodaj_godziny(awizacjaCzasy)





    End Sub



   

    Private Sub dodaj_godziny(awizacjaDane)
        'przeszukanie listy awizacjaCzasy i dodanie wartości do pierwszej kolumny w Tablelayoutpanelu

        For i = 0 To awizacjaDane.Count - 1
            Dim label As New Label
            label.Text = awizacjaDane(i)
            TableLayoutPanel1.Controls.Add(label, 0, i + 1)
            label.Dock = DockStyle.Fill
            label.TextAlign = ContentAlignment.MiddleCenter

        Next

    End Sub

 
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        spedycja.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        'przycisk tymczowy dodajacy tetbox do wskazanego pola z textbox5 i 7


        Dim textbox As New TextBox
        textbox.Text = "nowy wpis"


        TableLayoutPanel1.Controls.Add(textbox, Label1.Text, Label2.Text)
        textbox.BackColor = Color.Crimson
        'textbox.Dock = DockStyle.Fill

    End Sub

 
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
