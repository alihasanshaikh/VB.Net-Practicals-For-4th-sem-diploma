﻿Module Module1

    Sub Main()
        Dim I As Integer = 2
        Dim b As Boolean = False
        While (I <= 100)
            Select Case I
                Case 2 : Console.WriteLine("{0}it is a Prime num", I)
                Case 3 : Console.WriteLine("{0}it is a Prime num", I)
                Case 5 : Console.WriteLine("{0}it is a Prime num", I)
                Case 7 : Console.WriteLine("{0}it is a Prime num", I)
                Case Else
                    b = True


            End Select
            If b Then
                If I Mod 2 <> 0 And I Mod 3 <> 0 And I Mod 5 <> 0 And I Mod 7 <> 0 Then
                    Console.WriteLine("{0} it is a Prime number:", I)
                    b = True
                End If
            End If
            I = I + 1
        End While
        Console.ReadKey()


           

    End Sub

End Module
