Module screenDetection

    Public screenwidth As Integer = Screen.PrimaryScreen.Bounds.Width
    Public screenHeight As Integer = Screen.PrimaryScreen.Bounds.Width
    Public Function detectScreen() As Integer
        Dim totalResolution As Integer = screenHeight * screenwidth
        Return totalResolution
    End Function
End Module
