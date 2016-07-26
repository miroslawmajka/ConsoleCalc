Module Program

    Sub Main()
        Dim calc = New Calculator()

        Dim elements = New List(Of Integer) From {1, 2, 3}

        Console.WriteLine($"Adding elements {String.Join(", ", elements)}: {calc.Add(elements)}.")
        Console.WriteLine($"Subtracting 4 and 1: {calc.Subtract(4, 1)}.")

        Console.ReadKey()
    End Sub

End Module
