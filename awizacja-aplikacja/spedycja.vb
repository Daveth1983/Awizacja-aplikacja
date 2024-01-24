
Imports System
Imports System.Globalization
Imports System.Threading
Public Class spedycja

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

    Private Sub spedycja_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Label4.Text = "aktyalny tydzien" + Str(CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(Today, CalendarWeekRule.FirstDay, DayOfWeek.Monday))

        CB_GodzinaAwizacji.DataSource = awizacjaCzasy

    End Sub



    Private Sub CB_GodzinaAwizacji_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_GodzinaAwizacji.SelectedIndexChanged

        Label1.Text = Int(CB_GodzinaAwizacji.SelectedIndex) + 1

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub



    Public Sub DTP_DataAwizacji_ValueChanged(sender As Object, e As EventArgs) Handles DTP_DataAwizacji.ValueChanged

        Label2.Text = CInt(Weekday(DTP_DataAwizacji.Value) - 1)
        Label3.Text = "numer tygoodnia z DTP:" + Str(CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(DTP_DataAwizacji.Text, CalendarWeekRule.FirstDay, DayOfWeek.Monday))

    End Sub

   
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If CB_Spedytor.Visible = True And TextBox1.Visible = False Then
            CB_Spedytor.Visible = False
            TextBox1.Visible = True
            Button4.Text = "-"

        Else
            CB_Spedytor.Visible = True
            TextBox1.Visible = False
            With Button4

                .Text = "+"


            End With

        End If

      
    End Sub
End Class