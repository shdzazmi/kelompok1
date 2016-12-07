Module Fade_Effect
    Public Sub FadeIn()
        Dim fade As Double
        For fade = 0.0 To 1.1 Step 0.2
            formStore.opacity = fade
            formStore.refresh()
            Threading.Thread.sleep(100)
        Next
    End Sub

    Public Sub fadeout()
        Dim Fade As Double
        For fade = 1.1 To 0.0 Step -0.3
            formStore.Opacity = fade
            formStore.refresh()
            threading.thread.sleep(100)
        Next
    End Sub
End Module
