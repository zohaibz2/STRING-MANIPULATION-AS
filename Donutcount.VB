Module Module1

    Sub Main()
        Dim count As Integer
        count = 0
        Dim i As Integer
        i = 0
        Dim isMany As Boolean
        isMany = False

        Console.Write("Enter the number of donuts :")
        count = Console.ReadLine()
        If count > 10 Then
            isMany = True
        End If


        If isMany = True Then
            Console.WriteLine("Number of donuts: Many")
        Else
            Console.WriteLine("Number of donuts:" & count)
        End If
        Console.ReadKey()

    End Sub

End Module
