'Declaration
        Dim Str1, Str2, Alphabets As String
        Dim Char1, mychar As Char
        Dim i, Counter, Alphacounter, Digitcounter, Othercounter As Integer


        'initialization
        Str1 = ""
        Str2 = ""
        Alphabets = "abcdefghijklmnopqrstuvwxyz"
        Char1 = ""
        mychar = "0123456789"
        i = 0
        Counter = 0
        Alphacounter = 0
        Digitcounter = 0
        Othercounter = 0

        'Input 
        Console.WriteLine("Enter String to be processsed: ")
        Str1 = Console.ReadLine
        Str1 = LCase(Str1)

        Console.WriteLine("Enter Character to be searched: ")
        Str2 = Console.ReadLine
        Str2 = LCase(Str2)

        'process
        For i = 1 To Len(Str1)
            Char1 = Mid(Str1, i, 1)
            If Char1 = Str2 Then
                Counter = Counter + 1
            ElseIf InStr(Alphabets, Char1) Then
                Alphacounter = Alphacounter + 1
            ElseIf Char1 >= "0" And Char1 <= "9" Then
                Digitcounter = Digitcounter + 1
            Else
                Othercounter = Othercounter + 1
            End If

        Next
        Console.WriteLine("The number of entered character in the String are : " & Counter)
        Console.WriteLine("The Alphabets in the string are: " & Alphacounter)
        Console.WriteLine("The Digits in the string are: " & Digitcounter)
        Console.WriteLine("The other Characters are: " & Othercounter)
        Console.ReadKey()
