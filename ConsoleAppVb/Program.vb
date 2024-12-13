Imports System

Module Program
    Sub Main(args As String())

        Dim firstName As String = "Sue"
        Dim age As Integer = 189

        Select Case age
            Case >= 0 And <18
        Console.WriteLine("You are a child")
            Case >= 18 And <66
        Console.WriteLine("You should have a job")
            Case >= 66
                Console.WriteLine("Hopefully you are retired or retiring soon.")
            Case Else
                Console.WriteLine("Age was not in an expected range.")
        End Select

        'Select Case firstName.ToLower()
        '    'Case "sue"
        '    Case "tim", "sue"
        '        Console.WriteLine("Hello Professor")
        '    Case "tom"
        '        Console.WriteLine("Hello Tom")
        '    Case Else
        '        Console.WriteLine("I don't know you")
        'End Select

    End Sub
End Module
