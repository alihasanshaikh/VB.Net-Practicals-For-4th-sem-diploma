﻿Module Module1

    Sub Main()
        Dim i As Integer
        Dim nvowles As Integer
        Dim vowles As String
        Dim inputString As String
        vowles = "a e i o u"
        Console.WriteLine("Enter the String")
        inputString = Console.ReadLine()
        For i = 1 To Len(inputString)
            If InStr(vowles, Mid(inputString, i, 1)) Then
                nvowles = nvowles + 1
            End If
        Next
        Console.WriteLine("The total no of vowels" & nvowles)
        Console.ReadLine()

    End Sub

End Module

