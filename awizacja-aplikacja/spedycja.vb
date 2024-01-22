﻿
Imports System
Imports System.Globalization
Imports System.Threading
Public Class spedycja

    Dim godziny As New List(Of String)({"06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22"})
    Dim minuty As New List(Of String)({"00", "15", "30", "45"})

    Dim numerdnia As Integer = Weekday(DTP_DataAwizacji.Value) - 1
    Dim nrtygodnia As Integer = CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(DTP_DataAwizacji.Text, CalendarWeekRule.FirstDay, DayOfWeek.Monday)
    Dim nrwiersza As Integer = CB_GodzinaAwizacji.SelectedIndex + 1
    Dim aktualnytydzien As Integer = CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(Today, CalendarWeekRule.FirstDay, DayOfWeek.Monday)
    Private Sub spedycja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CB_GodzinaAwizacji.DataSource = Form1.awizacjaCzasy

        Label4.Text = "aktyalny tydzien" + Str(CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(Today, CalendarWeekRule.FirstDay, DayOfWeek.Monday))



    End Sub



    Private Sub CB_GodzinaAwizacji_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_GodzinaAwizacji.SelectedIndexChanged

        Label1.Text = "Numer wiersza z godziny: " + Str(Int(CB_GodzinaAwizacji.SelectedIndex) + 1)





    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub



    Public Sub DTP_DataAwizacji_ValueChanged(sender As Object, e As EventArgs) Handles DTP_DataAwizacji.ValueChanged

        Label2.Text = "numer dzien : " + Str(Weekday(DTP_DataAwizacji.Value) - 1)

        Label3.Text = "numer tygoodnia z DTP:" + Str(CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(DTP_DataAwizacji.Text, CalendarWeekRule.FirstDay, DayOfWeek.Monday))



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim textbox As New TextBox
        textbox.Text = "nowy wpis"


        Form1.TableLayoutPanel1.Controls.Add(textbox, Label2.Text, Label1.Text)
        textbox.BackColor = Color.Crimson
        'textbox.Dock = DockStyle.Fill

    End Sub


End Class