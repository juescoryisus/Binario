Imports System.IO

Public Class Form1

    Dim writestream As FileStream
    Dim readstream As FileStream
    Dim msg As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        writestream = New FileStream("abc.dat", FileMode.Create)
        Dim writeBin As New BinaryWriter(writestream)
        writeBin.Write("hola mundo")
        writeBin.Close()
        readstream = New FileStream("abc.dat", FileMode.Open)
        Dim readBinary As New BinaryReader(readstream)
        msg = readBinary.ReadString()

        MsgBox(msg)
        readstream.Close()
    End Sub
End Class
