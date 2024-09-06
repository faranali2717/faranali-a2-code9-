Imports System.Console

Module Program
    Sub main()
        Dim grades As Integer
        WriteLine("enter grades ")
        grades = ReadLine()
        Select Case grades
            Case Is > 85
                WriteLine("A*")
            Case 75 To 84
                WriteLine("A")
            Case 65 To 74
                WriteLine("b")
            Case Is < 50
                WriteLine("U")
            Case Else
                WriteLine("C")
        End Select
        ReadLine()
    End Sub
End Module
