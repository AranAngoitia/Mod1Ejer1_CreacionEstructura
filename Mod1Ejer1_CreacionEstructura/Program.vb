Imports System

Structure Persona
    Dim _nombre, _primerapellido As String
    Dim _edad As Integer

    'Constructor
    Public Sub New(ByVal nombre As String, ByVal primerapellido As String, ByVal edad As Integer)
        _nombre = nombre
        _primerapellido = primerapellido
        _edad = edad
    End Sub

    Public Overloads Overrides Function ToString() As String
        Return "Nombre completo y edad de la persona: " + _nombre + " " + _primerapellido + ", " + _edad.ToString() + " años."
    End Function
End Structure

Module Program
    Sub Main(args As String())
        Dim p As Persona = New Persona("Marta", "Abad", 42)
        Console.WriteLine(p)

        Console.WriteLine("Pulse cualquier tecla para continuar")
        Console.ReadKey(True)
    End Sub
End Module
