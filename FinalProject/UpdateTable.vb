Imports MySql.Data.MySqlClient

Public Class UpdateTable

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

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        GroupBox1.Visible = False
    End Sub

    Private Sub Update_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = 0
        Timer1.Start()

        Table.Items.Add("Branch")
        Table.Items.Add("Product")
        Table.Items.Add("Pricing")
        Table.Items.Add("Staff")
        Table.Items.Add("Customer")
        Table.Items.Add("Transaction")
    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        Transition.FadeIn(Me, Timer1)
    End Sub

    Private Sub Table_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Table.SelectedIndexChanged

        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        TextBox1.Clear()

        If Table.SelectedItem = "Branch" Then

            ComboBox1.Items.Add("branch_id")
            ComboBox1.Items.Add("branch_location")
            ComboBox1.Items.Add("branch_manager")
            ComboBox1.Items.Add("num_of_staff")
            ComboBox1.Items.Add("num_of_office")

            ComboBox2.Items.Add("branch_id")
            ComboBox2.Items.Add("branch_location")
            ComboBox2.Items.Add("branch_manager")
            ComboBox2.Items.Add("num_of_staff")
            ComboBox2.Items.Add("num_of_office")

        ElseIf Table.SelectedItem = "Product" Then

            ComboBox1.Items.Add("product_id")
            ComboBox1.Items.Add("branch_id")
            ComboBox1.Items.Add("product_name")
            ComboBox1.Items.Add("product_category")

            ComboBox2.Items.Add("product_id")
            ComboBox2.Items.Add("branch_id")
            ComboBox2.Items.Add("product_name")
            ComboBox2.Items.Add("product_category")

        ElseIf Table.SelectedItem = "Pricing" Then

            ComboBox1.Items.Add("product_id")
            ComboBox1.Items.Add("product_cost")
            ComboBox1.Items.Add("product_price")

            ComboBox2.Items.Add("product_id")
            ComboBox2.Items.Add("product_cost")
            ComboBox2.Items.Add("product_price")

        ElseIf Table.SelectedItem = "Staff" Then

            ComboBox1.Items.Add("staff_id")
            ComboBox1.Items.Add("branch_id")
            ComboBox1.Items.Add("staff_name")
            ComboBox1.Items.Add("staff_age")
            ComboBox1.Items.Add("staff_gender")
            ComboBox1.Items.Add("staff_phone")
            ComboBox1.Items.Add("staff_position")
            ComboBox1.Items.Add("staff_office")

            ComboBox2.Items.Add("staff_id")
            ComboBox2.Items.Add("branch_id")
            ComboBox2.Items.Add("staff_name")
            ComboBox2.Items.Add("staff_age")
            ComboBox2.Items.Add("staff_gender")
            ComboBox2.Items.Add("staff_phone")
            ComboBox2.Items.Add("staff_position")
            ComboBox2.Items.Add("staff_office")

        ElseIf Table.SelectedItem = "Customer" Then

            ComboBox1.Items.Add("customer_id")
            ComboBox1.Items.Add("customer_name")

            ComboBox2.Items.Add("customer_id")
            ComboBox2.Items.Add("customer_name")

        ElseIf Table.SelectedItem = "Transaction" Then

            ComboBox1.Items.Add("date")
            ComboBox1.Items.Add("transaction_id")
            ComboBox1.Items.Add("branch_id")
            ComboBox1.Items.Add("customer_id")
            ComboBox1.Items.Add("product_id")
            ComboBox1.Items.Add("quantity")

            ComboBox2.Items.Add("date")
            ComboBox2.Items.Add("transaction_id")
            ComboBox2.Items.Add("branch_id")
            ComboBox2.Items.Add("customer_id")
            ComboBox2.Items.Add("product_id")
            ComboBox2.Items.Add("quantity")

        End If
    End Sub

    Private Sub DoButton_Click(sender As Object, e As EventArgs) Handles DoButton.Click
        str = "Server = localhost; user id = root; password = lala; database = sirloin; SslMode = none"
        con = New MySqlConnection(str)

        Try
            con.Open()

            query = "UPDATE " + Table.SelectedItem + " SET " + ComboBox1.SelectedItem + "=" + TextBox1.Text + " WHERE " + ComboBox2.SelectedItem + "=" + TextBox2.Text
            comm = New MySqlCommand(query, con)
            reader = comm.ExecuteReader

            MessageBox.Show("Update Successful!")
            ListBox1.Items.Add(query)

            con.Close()
        Catch ex As Exception
            MessageBox.Show("An error occured while inserting : " + ex.Message)
        End Try
    End Sub

    Private Sub Timer2_Tick_1(sender As Object, e As EventArgs) Handles Timer2.Tick
        Transition.FadeOut(Me, Timer2)
    End Sub



End Class