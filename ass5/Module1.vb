Module Module1
    Public capital As Boolean = False
    Public lower As Boolean = False
    Public Speacial As Boolean = False
    Public Length As Boolean = False
    Public AllCondition As Boolean = False
    Public LastChecked As Integer = 0
    Dim speacialCharacters As String = "!@#$&"
    Sub resetFlags()
        capital = False
        lower = False
        Speacial = False
        Length = False
        AllCondition = False
        LastChecked = 0
    End Sub
    Sub updateFlag(ch As Char)
        If Not capital AndAlso Char.IsUpper(ch) Then
            capital = True
        End If
        If Not lower AndAlso Char.IsLower(ch) Then
            lower = True
        End If
        If Not Speacial AndAlso speacialCharacters.Contains(ch) Then
            Speacial = True
        End If
        If capital AndAlso lower AndAlso Speacial AndAlso Length Then
            AllCondition = True
        End If
    End Sub
End Module
