﻿Imports MySql.Data.MySqlClient

Public Class ViewTransaction
    Dim con As MySqlConnection
    Dim str, query As String
    Dim comm As MySqlCommand
    Dim reader As MySqlDataReader

    Dim sda As New MySqlDataAdapter
    Dim data As New DataTable
    Dim source As New BindingSource

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Timer2.Start()
        View.Show()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Transition.FadeOut(Me, Timer2)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Transition.FadeIn(Me, Timer1)
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        str = "Server=localhost; user id=root; password=lala; database=sirloin; SslMode=none"
        con = New MySqlConnection(str)

        Try
            con.Open()

            query = "DELETE FROM Transaction order by transaction_id desc limit 1;"
            comm = New MySqlCommand(query, con)
            reader = comm.ExecuteReader

            DataGridView1.Rows.RemoveAt(DataGridView1.Rows.Count - 1)
            con.Close()
        Catch ex As Exception
            MessageBox.Show("This record is used elsewhere, please delete them before deleting this one." + Environment.NewLine + ex.Message)
        End Try
    End Sub

    Private Sub ViewRating_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = 0
        Timer1.Start()

        DataGridView1.Font = New Font("Constantia", 10, FontStyle.Italic)

        str = "Server=localhost; user id=root; password=lala; database=sirloin; SslMode=none"
        con = New MySqlConnection(str)
        'query tambah inner join
        Try
            con.Open()

            query = "SELECT Transaction.date, Transaction.transaction_id, Branch.branch_location, Customer.customer_name, Product.product_name, Transaction.quantity

                    FROM (((Transaction

                    INNER JOIN Branch ON Transaction.branch_id = Branch.branch_id)
                    INNER JOIN Customer ON Transaction.customer_id = Customer.customer_id)
                    INNER JOIN Product ON Transaction.product_id = Product.product_id);"

            comm = New MySqlCommand(query, con)
            sda.SelectCommand = comm
            sda.Fill(data)
            source.DataSource = data
            DataGridView1.DataSource = source
            sda.Update(data)

            con.Close()
        Catch ex As Exception
            MessageBox.Show("An error occured while selecting : " + ex.Message)
        End Try
    End Sub
End Class