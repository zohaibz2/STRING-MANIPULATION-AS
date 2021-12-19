Module Module1

    Sub Main()
        'Find if entered string is a Pangram

        Dim Str1, Alphabets As String
        Dim isPangram As Boolean
        Dim Char1 As Char
        Dim count As Integer

        'Initialization
        Str1 = ""
        Alphabets = "abcdefghijklmnopqrstuvwxyz"
        isPangram = (True)
        Char1 = ""
        count = 0

        'Input
        Console.WriteLine("Enter String to be processed: ")
        Str1 = Console.ReadLine
        Str1 = LCase(Str1)

        'Process
        For count = 1 To Len(Alphabets)
            Char1 = Mid(Alphabets, count, 1)
            If InStr(Str1, Char1) = 0 Then isPangram = False
            If isPangram = False Then Exit For
        Next count

        'Output
        If isPangram = True Then
            Console.WriteLine("Entered string is a Pangram.")
        Else
            Console.WriteLine("Entered string is not a Pangram.")
        End If

        Console.ReadKey()
    End Sub

End Module
