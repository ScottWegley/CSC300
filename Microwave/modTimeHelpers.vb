Module modTimeHelpers

    Public Function convertToTimeDisplay(ByVal intSeconds As Integer) As String
        Dim intMinutes As Integer = 0
        Dim dblSeconds As Double = 0
        If Not intSeconds < 0 Then
            intMinutes = intSeconds \ 60
            dblSeconds = intSeconds Mod 60
        End If
        Return CStr(intMinutes).PadLeft(2, "0") + ":" + CStr(dblSeconds).PadLeft(2, "0")
    End Function

End Module
