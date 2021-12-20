Module Module1

    Sub Main()
        Dim i As Integer
        Dim count As Integer
        Dim inputstr As String
        Dim x As Integer
        Dim firstchar As Char
        Dim f_string As String
        Dim cmpchar As Char

        i = 0
        cmpchar = ""

        count = 0
        inputstr = ""
        x = 0
        firstchar = ""
        f_string = ""

        Console.WriteLine("Enter the String :")
        inputstr = Console.ReadLine()
        firstchar = Mid(inputstr, 1, 1)
        f_string = f_string + firstchar
        Console.WriteLine(firstchar)
        For i = 2 To Len(inputstr)
            cmpchar = Mid(inputstr, i, 1)
            Console.WriteLine(cmpchar)
            If firstchar <> Mid(inputstr, i, 1) Then
                f_string = f_string + cmpchar
                Console.WriteLine(f_string)
            Else : If count = 0 Then
                    f_string = f_string + "*"

                    Console.WriteLine(f_string)

                End If

                count = count + 1


            End If




        Next
        Console.WriteLine(f_string)
        Console.ReadKey()
    End Sub

End Module
