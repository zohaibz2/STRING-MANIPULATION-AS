Module Module1

    Sub Main()
        Dim str1 As String
        Dim str2 As String
        Dim i As Integer
        Dim cmpchar As Char
        Dim fstring As String
        Dim fstring2 As String
        Dim newstring As String
        Dim newstring2 As String
        Dim nf As String
        nf = ""
        newstring2 = ""
        newstring = ""
        str1 = ""
        fstring = ""
        str2 = ""
        i = 0
        fstring2 = ""
        cmpchar = ""

        Console.Write("Enter the first string: ")
        str1 = Console.ReadLine()
        Console.Write("Enter the second string: ")
        str2 = Console.ReadLine()

        For i = 1 To Len(str2)
            cmpchar = Mid(str2, i, 1)
            If i <= 2 Then
                fstring = fstring + cmpchar
            End If

        Next


        For i = 1 To Len(str1)
            cmpchar = Mid(str1, i, 1)
            If i <= 2 Then
                fstring2 = fstring2 + cmpchar
            End If

        Next

        For i = 3 To Len(str1)
            cmpchar = Mid(str1, i, 1)
            nf = nf + cmpchar
            newstring = fstring + nf

        Next
        nf = ""

        For i = 3 To Len(str2)
            cmpchar = Mid(str2, i, 1)
            nf = nf + cmpchar
            newstring2 = fstring2 + nf

        Next

        Console.WriteLine(newstring & " " & newstring2)

        Console.ReadKey()

    End Sub

End Module
