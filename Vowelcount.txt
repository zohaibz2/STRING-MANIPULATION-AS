Module Module1

    Sub Main()
        Dim Str1 As String
        Dim i, j, k As Integer
        Dim myChar As Char

        Console.Write("Enter String: ")
        Str1 = Console.ReadLine

        For i = 1 To Len(Str1)
            myChar = Mid(Str1, i, 1)
            k = InStr("AEIOU", UCase(myChar))
            If k > 0 Then j += 1
        Next

        Console.WriteLine("Number of vowels: " & j)
        Console.ReadKey()
    End Sub

End Module
