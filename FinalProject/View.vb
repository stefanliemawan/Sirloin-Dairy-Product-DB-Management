
Public Class View

    Private Sub ViewButton_Click(sender As Object, e As EventArgs) Handles ViewButton.Click

        If RBProduct.Checked Then
            Timer2.Start()
            ViewProduct.Show()
        ElseIf RBBranch.Checked Then
            Timer2.Start()
            ViewBranch.Show()
        ElseIf RBStaff.Checked Then
            Timer2.Start()
            ViewStaff.Show()
        ElseIf RBCustomer.Checked Then
            Timer2.Start()
            ViewCustomer.Show()
        ElseIf RBTransaction.Checked Then
            Timer2.Start()
            ViewTransaction.Show()
        ElseIf RBPricing.Checked Then
            Timer2.Start()
            ViewPricing.Show()
        Else
            MessageBox.Show("Please Check a Table!")
        End If
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Timer2.Start()
        Main.Show()
    End Sub

    Private Sub View_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = 0
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Transition.FadeIn(Me, Timer1)
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Transition.FadeOut(Me, Timer2)
    End Sub
End Class
