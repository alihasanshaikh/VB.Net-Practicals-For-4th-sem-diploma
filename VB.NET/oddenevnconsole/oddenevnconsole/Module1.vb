﻿Module Module1

    Sub Main()
        Dim i As Integer
        i = 1
        While (i <= 10)
            If i Mod 2 = 0 Then
                Console.WriteLine("{0} Num is even", i)
            Else
                Console.WriteLine("{0} Num is odd", i)
            End If
            i = i + 1
        End While
        Console.ReadKey()

    End Sub

End Module
