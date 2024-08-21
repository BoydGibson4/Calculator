Imports System

Module Program
    Sub Main(args As String())
        Dim num1, num2 As Double
        Dim result As Double
        Dim operation As String

        Console.WriteLine("Simple Calculator")
        Console.WriteLine("-----------------")

        ' Get first number
        Console.Write("Enter the first number: ")
        num1 = Convert.ToDouble(Console.ReadLine())

        ' Get second number
        Console.Write("Enter the second number: ")
        num2 = Convert.ToDouble(Console.ReadLine())

        ' Get the operation
        Console.WriteLine("Enter the operation (+, -, *, /): ")
        operation = Console.ReadLine()

        ' Perform the operation
        Select Case operation
            Case "+"
                result = num1 + num2
            Case "-"
                result = num1 - num2
            Case "*"
                result = num1 * num2
            Case "/"
                If num2 <> 0 Then
                    result = num1 / num2
                Else
                    Console.WriteLine("Error: Division by zero is not allowed.")
                    Return
                End If
            Case Else
                Console.WriteLine("Error: Invalid operation.")
                Return
        End Select

        ' Display the result
        Console.WriteLine("Result: " & result)

        ' Wait for user input to close
        Console.WriteLine("Press any key to exit...")
        Console.ReadKey()
    End Sub
End Module
