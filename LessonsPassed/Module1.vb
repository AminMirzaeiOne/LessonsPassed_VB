' Module declaration
Module Module1

    ' Main program entry point
    Sub Main()

        ' Set console foreground color to cyan for user prompt
        System.Console.ForegroundColor = ConsoleColor.Cyan

        ' Prompt user to enter the number of grades
        System.Console.Write("Please Enter The Number Of Grades: ")

        ' Set console foreground color to yellow for user input
        System.Console.ForegroundColor = ConsoleColor.Yellow

        ' Read the number of grades as an integer and store it in the 'Number' variable
        Dim Number As Integer = System.Convert.ToInt32(Console.ReadLine())

        ' Reset console colors to default
        System.Console.ResetColor()

        ' Create an array named 'Point' to store grades (size is Number - 1 because arrays are 0-based)
        ' Initialize all elements to 0 using empty array initializer syntax
        Dim Point As Double() = New Double(Number - 1) {}

        ' Loop to get grades from the user
        For i As Integer = 0 To Number - 1
            ' Set console foreground color to green for grade prompt
            System.Console.ForegroundColor = ConsoleColor.Green

            ' Prompt user to enter grade number (i + 1)
            System.Console.Write("Pls Enter Number {0} : ", (i + 1))

            ' Set console foreground color to blue for user input
            System.Console.ForegroundColor = ConsoleColor.Blue

            ' Read the entered grade as a double and store it in the corresponding element of the 'Point' array
            Point(i) = System.Convert.ToDouble(System.Console.ReadLine())
        Next

        ' Counter to track the number of failing grades
        Dim Counter As Integer = 0

        ' Loop through each grade in the 'Point' array using a For Each loop
        For Each item In Point

            ' Check if the grade is less than 12 (failing grade)
            If item < 12 Then
                ' Increment the counter if it's a failing grade
                Counter += 1
            End If
        Next

        ' Set console foreground color to gray for separator line
        System.Console.ForegroundColor = ConsoleColor.Gray

        ' Print a separator line
        System.Console.WriteLine("--------------------------")

        ' Set console foreground color to blue for output message
        System.Console.ForegroundColor = ConsoleColor.Blue

        ' Display a message before the number of failed grades
        System.Console.Write("You failed this many lessons : ")

        ' Set console background and foreground colors for failed grades count display
        System.Console.BackgroundColor = ConsoleColor.Blue
        System.Console.ForegroundColor = ConsoleColor.White

        ' Print the number of failing grades from the counter
        System.Console.WriteLine(Counter)

        ' Reset console colors to default
        System.Console.ResetColor()

        ' Set console foreground color to magenta for separator line
        System.Console.ForegroundColor = ConsoleColor.Magenta

        ' Print a separator line
        System.Console.WriteLine("-----------------------")

        ' Set console foreground color to red for programmer information
        System.Console.ForegroundColor = ConsoleColor.Red

        ' Print programmer information including GitHub username
        System.Console.WriteLine("Programmer : Amin Mirzaei - Github(UserName) : AminMirzaeiOne")

        ' Wait for user to press any key before closing the console
        System.Console.ReadKey()

    End Sub

End Module
