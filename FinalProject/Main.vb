' pictures are from https://www.thewallpapers.org/desktop/57133/cow-wallpaper

Public Class Main

    'inner join
    'update

    Private Sub QueryButton_Click(sender As Object, e As EventArgs) Handles QueryButton.Click
        Timer2.Start()
        ShowQuery.Show()
    End Sub

    Private Sub TransButton_Click(sender As Object, e As EventArgs) Handles InsertButton.Click
        Timer2.Start()
        InserTable.Show()
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

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Timer2.Start()
        UpdateTable.Show()
    End Sub
End Class