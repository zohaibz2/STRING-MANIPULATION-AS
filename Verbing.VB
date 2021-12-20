Module Module1

    Sub Main()
        Dim str1 As String
        str1 = ""
        Console.Write("Enter the verb :")
        str1 = Console.ReadLine()
        If Len(str1) >= 3 Then
            If InStr(str1, "ing") > 0 Then


                str1 = str1 & "ly"
            Else : str1 = str1 & "ing"
            End If



        End If
        Console.WriteLine(str1)
        Console.ReadKey()
    End Sub

End Module
