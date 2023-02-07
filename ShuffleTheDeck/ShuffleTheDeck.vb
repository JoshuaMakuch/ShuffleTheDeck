'Joshua Makuch
'RCET0265
'Winter 2023
'Shuffle the deck
'https://github.com/JoshuaMakuch/ShuffleTheDeck.git

Option Explicit On
Option Strict On

Imports System

Module ShuffleTheDeck
    Sub Main()

        drawAndShuffle()


    End Sub
    Function drawAndShuffle() As Boolean

        Dim random As New Random
        Dim suits As String() = {"Spades", "Clubs", "Hearts", "Diamonds"}
        Dim values As String() = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"}
        Dim drawnCards(3, 12) As Boolean
        Dim userInput As String

        While True

            Console.WriteLine("Hello user, press 1 to shuffle, press 2 to deal a card, press 3 to quit the program at any time.")
            userInput = Console.ReadLine()

            Select Case userInput

                Case "1"
                    For i As Integer = 0 To 3
                        For j As Integer = 0 To 12
                            drawnCards(i, j) = False
                        Next
                    Next
                Case "2"

                Case "3"
                    Return True

            End Select



        End While

    End Function

End Module