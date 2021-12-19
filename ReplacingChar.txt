Module Module1

    Sub Main()
        Dim Str1, Str2, Char1, Char2, nextChar As String
        Dim Counter As Integer

        Str1 = ""
        Str2 = ""
        Char1 = ""
        Char2 = ""
        nextChar = ""
        Counter = 0

        Console.WriteLine("Enter String to process: ")
        Str1 = Console.ReadLine

        Console.WriteLine("Enter Character to be removed: ")
        Char1 = Console.ReadLine

        Console.WriteLine("Enter Character to be replaced with: ")
        Char2 = Console.ReadLine

        For Counter = 1 To Len(Str1)
            nextChar = Mid(Str1, Counter, 1)
            If nextChar = Char1 Then
                nextChar = Char2
            End If
            Str2 = Str2 & nextChar
        Next

        Console.WriteLine("Final String = " & Str2)
        Console.ReadKey()
    End Sub

End Module
