Public Class Transition

    Public Shared Sub FadeIn(ByVal form As Form, ByVal timer As Timer)

        Dim opacityFade As Single

        For opacityFade = 0 To 1 Step 0.25
            form.Opacity = opacityFade
            form.Refresh()
        Next
        form.Opacity = 1
        timer.Stop()


    End Sub

    Public Shared Sub FadeOut(ByVal form As Form, ByVal timer As Timer)

        Dim opacityFade As Single

        For opacityFade = 1 To 0 Step -0.25
            form.Opacity = opacityFade
            form.Refresh()
        Next
        form.Opacity = 0
        form.Close()
        timer.Stop()

    End Sub

End Class
