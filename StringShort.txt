Module Module1

    Sub Main()
        Dim i As Integer
        Dim count As Integer
        Dim inputstr As String
        Dim x As Integer
        Dim firstchar As Char
        Dim f_string As String
        Dim cmpchar As Char
        Dim secondchar As Char
        Dim lastchar As Char
        Dim seclastchar As Char
        i = 0
        cmpchar = ""
        count = 0
        inputstr = ""
        x = 0
        firstchar = ""
        secondchar = ""
        lastchar = ""
        seclastchar = ""
        f_string = ""


        Console.WriteLine("Enter the String :")
        inputstr = Console.ReadLine()
        firstchar = Mid(inputstr, 1, 1)
        secondchar = Mid(inputstr, 2, 1)

        For i = Len(inputstr) To 1 Step -1
            lastchar = Mid(inputstr, i, 1)

            seclastchar = Mid(inputstr, i - 1, 1)

            Exit For
        Next
        Console.WriteLine(firstchar & secondchar & seclastchar & lastchar)

        
        Console.ReadKey()
    End Sub

End Module
