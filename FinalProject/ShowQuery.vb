Imports MySql.Data.MySqlClient

Public Class ShowQuery
    Dim con As MySqlConnection
    Dim str, query As String
    Dim comm As MySqlCommand
    Dim reader As MySqlDataReader

    Dim column, table, condition1, condition2 As String

    Private Sub ShowQuery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = 0
        Timer1.Start()

        ComboBox2.Items.Add("Branch")
        ComboBox2.Items.Add("Product")
        ComboBox2.Items.Add("Pricing")
        ComboBox2.Items.Add("Staff")
        ComboBox2.Items.Add("Customer")
        ComboBox2.Items.Add("Transaction")


    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Timer2.Start()
        Main.Show()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

        ComboBox1.Items.Clear()
        ComboBox3.Items.Clear()
        TextBox1.Clear()

        If ComboBox2.SelectedItem = "Branch" Then

            ComboBox1.Items.Add("branch_id")
            ComboBox1.Items.Add("branch_location")
            ComboBox1.Items.Add("branch_manager")
            ComboBox1.Items.Add("num_of_staff")
            ComboBox1.Items.Add("branch_id")

            ComboBox3.Items.Add("branch_id")
            ComboBox3.Items.Add("branch_location")
            ComboBox3.Items.Add("branch_manager")
            ComboBox3.Items.Add("num_of_staff")
            ComboBox3.Items.Add("branch_id")

        ElseIf ComboBox2.SelectedItem = "Product" Then

            ComboBox1.Items.Add("product_id")
            ComboBox1.Items.Add("branch_id")
            ComboBox1.Items.Add("product_name")
            ComboBox1.Items.Add("product_category")

            ComboBox3.Items.Add("product_id")
            ComboBox3.Items.Add("branch_id")
            ComboBox3.Items.Add("product_name")
            ComboBox3.Items.Add("product_category")

        ElseIf ComboBox2.SelectedItem = "Pricing" Then

            ComboBox1.Items.Add("product_id")
            ComboBox1.Items.Add("product_cost")
            ComboBox1.Items.Add("product_price")
            ComboBox1.Items.Add("product_gross_profit")

            ComboBox3.Items.Add("product_id")
            ComboBox3.Items.Add("product_cost")
            ComboBox3.Items.Add("product_price")
            ComboBox3.Items.Add("product_gross_profit")

        ElseIf ComboBox2.SelectedItem = "Staff" Then

            ComboBox1.Items.Add("staff_id")
            ComboBox1.Items.Add("branch_id")
            ComboBox1.Items.Add("staff_name")
            ComboBox1.Items.Add("staff_age")
            ComboBox1.Items.Add("staff_gender")
            ComboBox1.Items.Add("staff_phone")
            ComboBox1.Items.Add("staff_position")
            ComboBox1.Items.Add("staff_office")

            ComboBox3.Items.Add("staff_id")
            ComboBox3.Items.Add("branch_id")
            ComboBox3.Items.Add("staff_name")
            ComboBox3.Items.Add("staff_age")
            ComboBox3.Items.Add("staff_gender")
            ComboBox3.Items.Add("staff_phone")
            ComboBox3.Items.Add("staff_position")
            ComboBox3.Items.Add("staff_office")

        ElseIf ComboBox2.SelectedItem = "Customer" Then

            ComboBox1.Items.Add("customer_id")
            ComboBox1.Items.Add("customer_name")

            ComboBox3.Items.Add("customer_id")
            ComboBox3.Items.Add("customer_name")

        ElseIf ComboBox2.SelectedItem = "Transaction" Then

            ComboBox1.Items.Add("date")
            ComboBox1.Items.Add("transaction_id")
            ComboBox1.Items.Add("branch_id")
            ComboBox1.Items.Add("customer_id")
            ComboBox1.Items.Add("product_id")
            ComboBox1.Items.Add("quantity")

            ComboBox3.Items.Add("date")
            ComboBox3.Items.Add("transaction_id")
            ComboBox3.Items.Add("branch_id")
            ComboBox3.Items.Add("customer_id")
            ComboBox3.Items.Add("product_id")
            ComboBox3.Items.Add("quantity")

        End If
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

        table = ComboBox2.SelectedItem
        column = ComboBox1.SelectedItem
        condition1 = ComboBox3.SelectedItem
        condition2 = TextBox1.Text

        Try
            con.Open()

            query = "SELECT " + column + " FROM " + table + " WHERE " + condition1 + condition2 + ";"
            comm = New MySqlCommand(query, con)
            reader = comm.ExecuteReader

            If reader.HasRows Then
                While reader.Read()
                    ListBox1.Items.Add(reader.Item(column).ToString)
                End While
            End If

            con.Close()
        Catch ex As Exception
            MessageBox.Show("An error occured while selecting : " + query)
        End Try

        GroupBox1.Visible = True
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        GroupBox1.Visible = False
        ListBox1.Items.Clear()
        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        ComboBox3.Items.Clear()
        TextBox1.Clear()
    End Sub

End Class