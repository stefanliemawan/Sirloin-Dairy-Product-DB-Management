﻿Imports MySql.Data.MySqlClient

Public Class ShowQuery
    Dim con As MySqlConnection
    Dim str, query As String
    Dim comm As MySqlCommand
    Dim reader As MySqlDataReader

    Dim column, table, condition1, condition2 As String

    Private Sub ShowQuery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = 0
        Timer1.Start()
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Timer2.Start()
        Main.Show()
    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        Transition.FadeIn(Me, Timer1)
    End Sub

    Private Sub Timer2_Tick_1(sender As Object, e As EventArgs) Handles Timer2.Tick
        Transition.FadeOut(Me, Timer2)
    End Sub

    Private Sub ViewButton_Click(sender As Object, e As EventArgs) Handles ViewButton.Click
        str = "Server = localhost; user id = root; password = lala; database = sirloin; SslMode = none"
        con = New MySqlConnection(str)

        column = TextBox1.Text
        table = TextBox2.Text
        condition1 = TextBox3.Text
        condition2 = TextBox4.Text

        Try
            con.Open()

            query = "SELECT " + column + " FROM " + table + " WHERE " + condition1 + " = " + condition2 + ";"
            comm = New MySqlCommand(query, con)
            reader = comm.ExecuteReader

            If reader.HasRows Then
                While reader.Read()
                    ListBox1.Items.Add(reader.Item(column).ToString)
                End While
            End If

            con.Close()
        Catch ex As Exception
            MessageBox.Show("An error occured while selecting : " + ex.Message)
        End Try

        GroupBox1.Visible = True
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        GroupBox1.Visible = False
        ListBox1.Items.Clear()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
    End Sub

End Class