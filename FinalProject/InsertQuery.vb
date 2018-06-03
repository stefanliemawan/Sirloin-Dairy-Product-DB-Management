Imports MySql.Data.MySqlClient

Public Class InsertQuery
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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Transition.FadeIn(Me, Timer1)
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Transition.FadeOut(Me, Timer2)
    End Sub

    Private Sub InsertUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = 0
        Timer1.Start()

        Table.Items.Add("Branch")
        Table.Items.Add("Product")
        Table.Items.Add("Pricing")
        Table.Items.Add("Staff")
        Table.Items.Add("Customer")
        Table.Items.Add("Transaction")

    End Sub

    Private Sub Table_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Table.SelectedIndexChanged
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()

        If Table.SelectedItem = "Branch" Then

            Label1.Text = "branch_location"
            Label1.Visible = True
            TextBox1.Visible = True

            Label2.Text = "branch_manager"
            Label2.Visible = True
            TextBox2.Visible = True

            Label3.Text = "num_of_staff"
            Label3.Visible = True
            TextBox3.Visible = True

            Label4.Text = "num_of_office"
            Label4.Visible = True
            TextBox4.Visible = True

            Label5.Visible = False
            TextBox5.Visible = False
            Label6.Visible = False
            TextBox6.Visible = False
            Label7.Visible = False
            TextBox7.Visible = False

        ElseIf Table.SelectedItem = "Product" Then

            Label1.Text = "branch_id"
            Label1.Visible = True
            TextBox1.Visible = True

            Label2.Text = "product_name"
            Label2.Visible = True
            TextBox2.Visible = True

            Label3.Text = "product_category"
            Label3.Visible = True
            TextBox3.Visible = True

            Label4.Visible = False
            TextBox4.Visible = False
            Label5.Visible = False
            TextBox5.Visible = False
            Label6.Visible = False
            TextBox6.Visible = False
            Label7.Visible = False
            TextBox7.Visible = False

        ElseIf Table.SelectedItem = "Pricing" Then

            Label1.Text = "product_id"
            Label1.Visible = True
            TextBox1.Visible = True

            Label2.Text = "product_cost"
            Label2.Visible = True
            TextBox2.Visible = True

            Label3.Text = "product_price"
            Label3.Visible = True
            TextBox3.Visible = True

            Label4.Visible = False
            TextBox4.Visible = False
            Label5.Visible = False
            TextBox5.Visible = False
            Label6.Visible = False
            TextBox6.Visible = False
            Label7.Visible = False
            TextBox7.Visible = False

        ElseIf Table.SelectedItem = "Staff" Then

            Label1.Text = "branch_id"
            Label1.Visible = True
            TextBox1.Visible = True

            Label2.Text = "staff_name"
            Label2.Visible = True
            TextBox2.Visible = True

            Label3.Text = "staff_age"
            Label3.Visible = True
            TextBox3.Visible = True

            Label4.Text = "staff_gender"
            Label4.Visible = True
            TextBox4.Visible = True

            Label5.Text = "staff_phone"
            Label5.Visible = True
            TextBox5.Visible = True

            Label6.Text = "staff_position"
            Label6.Visible = True
            TextBox6.Visible = True

            Label7.Text = "staff_office"
            Label7.Visible = True
            TextBox7.Visible = True

        ElseIf Table.SelectedItem = "Customer" Then

            Label1.Text = "customer_name"
            Label1.Visible = True
            TextBox1.Visible = True

            Label2.Visible = False
            TextBox2.Visible = False
            Label3.Visible = False
            TextBox3.Visible = False
            Label4.Visible = False
            TextBox4.Visible = False
            Label5.Visible = False
            TextBox5.Visible = False
            Label6.Visible = False
            TextBox6.Visible = False
            Label7.Visible = False
            TextBox7.Visible = False

        ElseIf Table.SelectedItem = "Transaction" Then

            Label1.Text = "branch_id"
            Label1.Visible = True
            TextBox1.Visible = True

            Label2.Text = "customer_id"
            Label2.Visible = True
            TextBox2.Visible = True

            Label3.Text = "product_id"
            Label3.Visible = True
            TextBox3.Visible = True

            Label4.Text = "quantity"
            Label4.Visible = True
            TextBox4.Visible = True

            Label5.Visible = False
            TextBox5.Visible = False
            Label6.Visible = False
            TextBox6.Visible = False
            Label7.Visible = False
            TextBox7.Visible = False
        End If

    End Sub

    Private Sub DoButton_Click(sender As Object, e As EventArgs) Handles DoButton.Click
        str = "Server = localhost; user id = root; password = lala; database = sirloin; SslMode = none"
        con = New MySqlConnection(str)

        If Table.SelectedItem = "Branch" Then
            Try
                con.Open()

                query = "INSERT INTO Branch values (null," + "'" + TextBox1.Text + "','" + TextBox2.Text + "'," + TextBox3.Text + "," + TextBox4.Text + ");"
                comm = New MySqlCommand(query, con)
                reader = comm.ExecuteReader

                MessageBox.Show("Insert Successful!")
                ListBox1.Items.Add(query)

                con.Close()
            Catch ex As Exception
                MessageBox.Show("An error occured while inserting : " + ex.Message)
            End Try
        ElseIf Table.SelectedItem = "Product" Then
            Try
                con.Open()

                query = "INSERT INTO Product values (null," + "" + TextBox1.Text + ",'" + TextBox2.Text + "','" + TextBox3.Text + "');"
                comm = New MySqlCommand(query, con)
                reader = comm.ExecuteReader

                MessageBox.Show("Insert Successful!")
                ListBox1.Items.Add(query)

                con.Close()
            Catch ex As Exception
                MessageBox.Show("An error occured while inserting : " + ex.Message)
            End Try
        ElseIf Table.SelectedItem = "Pricing" Then
            Try
                con.Open()

                query = "INSERT INTO Pricing values (null," + TextBox1.Text + "," + TextBox2.Text + ");"
                comm = New MySqlCommand(query, con)
                reader = comm.ExecuteReader

                MessageBox.Show("Insert Successful!")
                ListBox1.Items.Add(query)

                con.Close()
            Catch ex As Exception
                MessageBox.Show("An error occured while inserting : " + ex.Message)
            End Try
        ElseIf Table.SelectedItem = "Staff" Then
            Try
                con.Open()

                query = "INSERT INTO Staff values (null," + TextBox1.Text + ",'" + TextBox2.Text + "'," + TextBox3.Text + ",'" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "');"
                comm = New MySqlCommand(query, con)
                reader = comm.ExecuteReader

                MessageBox.Show("Insert Successful!")
                ListBox1.Items.Add(query)

                con.Close()
            Catch ex As Exception
                MessageBox.Show("An error occured while inserting : " + ex.Message)
            End Try
        ElseIf Table.SelectedItem = "Customer" Then
            Try
                con.Open()

                query = "INSERT INTO Customer values (NULL,'" + TextBox1.Text + "');"
                comm = New MySqlCommand(query, con)
                reader = comm.ExecuteReader

                MessageBox.Show("Insert Successful!")
                ListBox1.Items.Add(query)

                con.Close()
            Catch ex As Exception
                MessageBox.Show("An error occured while inserting : " + ex.Message)
            End Try
        ElseIf Table.SelectedItem = "Transaction" Then
            Try
                con.Open()

                query = "INSERT INTO Transaction values (null," + TextBox1.Text + "," + TextBox2.Text + "," + TextBox3.Text + "," + TextBox4.Text + ");"
                comm = New MySqlCommand(query, con)
                reader = comm.ExecuteReader

                MessageBox.Show("Insert Successful!")
                ListBox1.Items.Add(query)

                con.Close()
            Catch ex As Exception
                MessageBox.Show("An error occured while inserting : " + ex.Message)
            End Try
        End If
    End Sub

End Class