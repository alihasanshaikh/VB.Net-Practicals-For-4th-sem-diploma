﻿Module Module1

    Sub Main()
        Dim num, i As Integer
        Dim b As Boolean
        Console.WriteLine("Enter the num ")
        num = Console.ReadLine()
        i = 2
        b = True
        While i < num
            If num Mod i = 0 Then
                b = False
                GoTo 25
            End If
            i = i + 1
        End While
25:     If b Then
            Console.WriteLine("{0} is prime no ", num)
        Else


            Console.WriteLine("{0} is prime not  ", num)
        End If
        Console.ReadKey()
    End Sub

End Module
