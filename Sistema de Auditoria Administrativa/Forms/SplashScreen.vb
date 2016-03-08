Public Class SplashScreen
    Sub New
        InitializeComponent()
    End Sub

    Public Overrides Sub ProcessCommand(ByVal cmd As System.Enum, ByVal arg As Object)
        MyBase.ProcessCommand(cmd, arg)
    End Sub

    Public Enum SplashScreenCommand
        SomeCommandId
    End Enum

    Private Sub SplashScreen_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Progress.Position += 1
    End Sub

    Private Sub Progress_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles Progress.EditValueChanged

        If Progress.Position = 30 Then
            Main.Show()
            Me.Hide()
        End If
    End Sub
End Class
