' pictures are from https://www.thewallpapers.org/desktop/57133/cow-wallpaper

Public Class Main

    Private Sub QueryButton_Click(sender As Object, e As EventArgs) Handles QueryButton.Click
        Timer2.Start()
        ShowQuery.Show()
    End Sub

    Private Sub TransButton_Click(sender As Object, e As EventArgs) Handles TransButton.Click
        Timer2.Start()
        InsertQuery.Show()
    End Sub

    Private Sub ViewTablesButton_Click(sender As Object, e As EventArgs) Handles ViewTablesButton.Click
        Timer2.Start()
        View.Show()
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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