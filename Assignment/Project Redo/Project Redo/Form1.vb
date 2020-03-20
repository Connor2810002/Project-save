Imports System.Data
Imports System.Data.OleDb
Public Class Form1
    Private Structure importvalues
        Dim name_ As String
        Dim score As Integer
    End Structure
    Dim leaderboard(9999) As importvalues


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim name As String
        Dim answer As String
        Dim points As Integer

        name = InputBox("please insert your full name")
        answer = InputBox("who is the first president of the US")
        If answer = "george washington" Or answer = "George washington" Or answer = "George Washington" Or answer = "George Washington" Then
            points = points + 50
        Else MsgBox(" your answer was incorrect")
        End If

        answer = InputBox("What is the capital of england?")
        If answer = "London" Or answer = "london" Then
            points = points + 50
        Else MsgBox(" your answer was incorrect")
        End If

        answer = InputBox("How many yellow cards are needed to get a red in football")
        If answer = "two" Or answer = "2" Or answer = "Two" Then
            points = points + 50
        Else MsgBox(" your answer was incorrect")
        End If

        answer = InputBox("Who is the current US president")
        If answer = "Donald Trump" Or answer = "Donald trump" Or answer = "donald trump" Or answer = "Trump" Then
            points = points + 50
        Else MsgBox(" your answer was incorrect")
        End If

        answer = InputBox("How many pairs of wings does a pidgeon have")
        If answer = "1" Or answer = "One" Or answer = "1" Or answer = "one" Then
            points = points + 50
        Else MsgBox(" your answer was incorrect")
        End If

        TextBox1.Text = TextBox1.Text + "your score was " + Str(points) + vbNewLine

        Printresults()
        Insertresults()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim name As String
        Dim answer As String
        Dim points As Integer

        name = InputBox("Please enter your name ")
        answer = InputBox("How many points is a try worth in rugby")
        If answer = "5" Or answer = "Five" Or answer = "five" Then
            points = points + 75
        Else MsgBox(" your answer was incorrect")
        End If

        answer = InputBox("what is the capital of scotland")
        If answer = "Edinburugh" Or answer = "edinburugh" Then
            points = points + 75
        Else MsgBox(" your answer was incorrect")
        End If

        answer = InputBox("what element is represented by the letter O on the periodic table")
        If answer = "Oxygen" Or answer = "oxygen" Then
            points = points + 75
        Else MsgBox(" your answer was incorrect")
        End If

        answer = InputBox("Who is married to Victoria Adams ")
        If answer = "David beckham" Or answer = "David Beckham" Or answer = "david beckham" Or answer = "Beckham" Then
            points = points + 75
        Else MsgBox(" your answer was incorrect")
        End If

        answer = InputBox("How many pairs of wings does a bee have")
        If answer = "2" Or answer = "Two" Or answer = "2" Or answer = "two" Then
            points = points + 100
        Else MsgBox(" your answer was incorrect")
        End If



        Printresults()

    End Sub








    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim name As String
        Dim answer As String
        Dim points As Integer

        name = InputBox("Please enter your name ")
        answer = InputBox("How many points is a covertion worth in rugby")
        If answer = "2" Or answer = "Two" Or answer = "two" Then
            points = points + 100
        Else MsgBox(" your answer was incorrect")
        End If

        answer = InputBox("what is the capital of Brazil")
        If answer = "brasilia" Or answer = "Brasilia" Then
            points = points + 100
        Else MsgBox(" your answer was incorrect")
        End If

        answer = InputBox("what element is represented by the letter K on the periodic table")
        If answer = "Potassium" Or answer = "potassium" Then
            points = points + 100
        Else MsgBox(" your answer was incorrect")
        End If

        answer = InputBox("Who is the current prime minister ")
        If answer = "Boris Johnson " Or answer = "Boris johnson" Or answer = "boris johnson" Or answer = "johnson" Then
            points = points + 100
        Else MsgBox(" your answer was incorrect")
        End If

        answer = InputBox("How many european cups have manchester city won as of the 2018/19 season")
        If answer = "0" Or answer = "Zero" Or answer = "zero" Then
            points = points + 100
        Else MsgBox(" your answer was incorrect")
        End If

        TextBox1.Text = TextBox1.Text + "your score was " + points

        Printresults()
    End Sub

    Private Sub Printresults()


        Try
            Dim SQLReader As OleDbDataReader
            Dim connection_type As String = "provider = Microsoft.Jet.OLEDB.4.0;"
            Dim file_location As String = " data source = D:\Assignment DB.mdb"
            Dim conn As OleDbConnection
            conn = New OleDbConnection(connection_type & file_location)
            conn.Open()


            Dim query1 As String = "select * from [Assignment DB]"
            Dim command1 As New OleDbCommand(query1, conn)
            SQLReader = command1.ExecuteReader()

            If SQLReader.HasRows Then
                While SQLReader.Read

                    TextBox1.Text = TextBox1.Text + SQLReader("Name_") + SQLReader("Score") + vbNewLine

                End While

            End If


        Catch ex As Exception
            TextBox1.Text = ex.Message
        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub
End Class
