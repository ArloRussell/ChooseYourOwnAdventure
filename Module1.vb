Module Module1
    'Arlo Russell
    '10/16/23
    '"FlowChart"
    Sub Main()
        getAOneOrTwo()
    End Sub

    Function getAOneOrTwo() As String 'Note: Functions RETURN a value

        Dim input As String 'This is our first rectangle

        Do
            Console.Write("Plase enter a 1 or 2 >> ") 'This is our first parallelogram
            input = Console.ReadLine() 'Second parallelogram
            input = input.Trim 'this is the second rectangle

            'this is the rhombus
            If input <> "1" OrElse input <> "2" Then
                Console.WriteLine("Invalid Input")
            End If
        Loop While input <> "1" AndAlso input <> "2"

        Return input 'This is the process just before the end
    End Function

End Module
