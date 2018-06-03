Imports MySql.Data.MySqlClient

Public Class Query1
    Dim con As MySqlConnection
    Dim str, query As String
    Dim comm As MySqlCommand
    Dim reader As MySqlDataReader

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Timer2.Start()
        Main.Show()
    End Sub

    Private Sub HistoryButton_Click(sender As Object, e As EventArgs) Handles HistoryButton.Click
        GroupBox1.Visible = True
    End Sub

    Private Sub ClsButton_Click(sender As Object, e As EventArgs) Handles ClsButton.Click
        GroupBox1.Visible = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Transition.FadeIn(Me, Timer1)
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Transition.FadeOut(Me, Timer2)
    End Sub

    Private Sub Query1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = 0
        Timer1.Start()

        str = "Server = localhost; user id = root; password = lala; database = sirloin; SslMode = none"
        con = New MySqlConnection(str)

        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        ComboBox3.Items.Clear()

        Try
            con.Open()

            query = "SELECT * FROM Branch"
            comm = New MySqlCommand(query, con)
            reader = comm.ExecuteReader

            If reader.HasRows Then
                While reader.Read()
                    ComboBox1.Items.Add(reader.Item("branch_id").ToString)
                End While
            End If

            con.Close()
            con.Open()

            query = "SELECT * FROM Customer"
            comm = New MySqlCommand(query, con)
            reader = comm.ExecuteReader

            If reader.HasRows Then
                While reader.Read()
                    ComboBox2.Items.Add(reader.Item("customer_id").ToString)
                End While
            End If

            con.Close()
            con.Open()

            query = "SELECT * FROM Product"
            comm = New MySqlCommand(query, con)
            reader = comm.ExecuteReader

            If reader.HasRows Then
                While reader.Read()
                    ComboBox3.Items.Add(reader.Item("product_id").ToString)
                End While
            End If

            con.Close()
        Catch ex As Exception
            MessageBox.Show("An error occured while selecting : " + ex.Message)
        End Try

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub QueryButton_Click(sender As Object, e As EventArgs) Handles QueryButton.Click

        str = "Server = localhost; user id = root; password = lala; database = sirloin; SslMode = none"
        con = New MySqlConnection(str)

        Dim branch_id As String = ComboBox1.SelectedItem.ToString
        Dim customer_id As String = ComboBox2.SelectedItem.ToString
        Dim product_id As String = ComboBox3.SelectedItem.ToString
        Dim quan As String = TextBox1.Text

        Try
            con.Open()
            query = "Insert Into Transaction values (now(),null," + branch_id + "," + customer_id + "," + product_id + "," + quan + ");"
            comm = New MySqlCommand(query, con)
            reader = comm.ExecuteReader
            ListBox2.Items.Add(query)
            MessageBox.Show("Query Done!")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        con.Close()
    End Sub
End Class