Module Module1

    Sub Main()
        Dim str1 As String
        Dim str2 As String
        Dim str3 As String
        Dim Firststring As String
        Dim Endstring As String
        Dim rightstring As String
        Dim x As Integer
        Dim y As Integer
        Endstring = ""
        rightstring = ""
        x = 0
        str1 = ""
        str2 = ""
        Firststring = ""

        Console.WriteLine("Enter the string : ")
        str1 = Console.ReadLine()
        str2 = "not"
        str3 = "bad"
        x = InStr(str1, str2)
        y = InStr(str1, str3)

        If x > 0 Then
            Endstring = Left(str1, x - 1)

            If y > 0 Then
                rightstring = Mid(str1, y + 3, Len(str1))


            End If
        End If
        Firststring = Endstring + "good" + rightstring
        Console.WriteLine(Firststring)
        Console.ReadKey()
    End Sub

End Module
