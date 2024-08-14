Module Module1

    Sub Main()
        System.Console.ForegroundColor = ConsoleColor.Cyan
        System.Console.Write("Please Enter The Number Of Grades : ")
        Dim Counter As Integer = 0
        System.Console.ForegroundColor = ConsoleColor.Yellow
        Dim Number As Integer = System.Convert.ToInt32(System.Console.ReadLine())
        System.Console.ResetColor()
        Dim Point As Double() = New Double(Number - 1) {}

        For i As Integer = 0 To Number - 1
            System.Console.ForegroundColor = ConsoleColor.Green
            System.Console.Write("Pls Enter Number {0} : ", (i + 1))
            System.Console.ForegroundColor = ConsoleColor.Blue
            Point(i) = System.Convert.ToDouble(System.Console.ReadLine())
        Next

        For Each item In Point

            If item < 12 Then
                Counter += 1
            End If
        Next
        System.Console.ForegroundColor = ConsoleColor.Gray
        System.Console.WriteLine("--------------------------")
        System.Console.ForegroundColor = ConsoleColor.Blue
        System.Console.Write("You failed this many lessons : ")
        System.Console.BackgroundColor = ConsoleColor.Blue
        System.Console.ForegroundColor = ConsoleColor.White
        System.Console.WriteLine(Counter)
        System.Console.ResetColor()
        System.Console.ForegroundColor = ConsoleColor.Magenta
        System.Console.WriteLine("-----------------------")
        System.Console.ForegroundColor = ConsoleColor.Red
        System.Console.WriteLine("Programmer : Amin Mirzaei - Github(UserName) : AminMirzaeiOne")

        System.Console.ReadKey()

    End Sub

End Module
