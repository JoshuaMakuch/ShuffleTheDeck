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

        DrawAndShuffle()
        Console.WriteLine("Goodbye!")

    End Sub
    Function DrawAndShuffle() As Boolean

        Dim random As New Random
        Dim suits As String() = {"Spades", "Clubs", "Hearts", "Diamonds"}
        Dim values As String() = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace"}
        Dim userInput As String
        Dim randomSuit As Integer
        Dim randomValue As Integer
        Dim indexOfTotalDrawn As Integer
        Dim indexOfRandomDrawn As Integer
        Dim drawnCards(3, 12) As Boolean
        Dim allDrawn As Boolean

        While True

            Console.WriteLine(vbCrLf & "Hello user, press 1 to shuffle, press 2 to deal a card, press 3 to quit the program at any time.")
            userInput = Console.ReadLine()
            Console.Clear()

            If userInput = "1" Or allDrawn Then

                'When the user chooses to, or when needed, clears the array
                For i As Integer = 0 To 3
                    For j As Integer = 0 To 12
                        drawnCards(i, j) = False
                    Next
                Next
                allDrawn = False
                indexOfTotalDrawn = 0
                Console.WriteLine("Deck has been shuffled..." & vbCrLf & $"{indexOfTotalDrawn} cards drawn")

            ElseIf userInput = "2" Then

                'Generates a random card value
                randomSuit = random.Next(0, 4)
                randomValue = random.Next(0, 13)

                'Continuously generates a drawn card until it has picked a card that has not been drawn yet
                While drawnCards(randomSuit, randomValue)

                    randomSuit = random.Next(0, 4)
                    randomValue = random.Next(0, 13)

                End While

                'Once a card that hasn't been drawn, is drawn, it sets that card to true and displays what the card drawn is.
                drawnCards(randomSuit, randomValue) = True
                Console.WriteLine($"Drawn Card: {values(randomValue)} of {suits(randomSuit)}")


                'Immediatly assumes all cards have been drawn
                allDrawn = True
                'Checks if all the cards have been drawn after each new card is drawn and exits the for loops if it does find a not drawn card
                For i As Integer = 0 To 3
                    For j As Integer = 0 To 12
                        If drawnCards(i, j) = False Then
                            allDrawn = False
                            Exit For
                        End If
                    Next
                    If allDrawn = False Then
                        Exit For
                    End If
                Next
                'Prints out how many cards have been drawn
                indexOfTotalDrawn += 1
                Console.WriteLine($"{indexOfTotalDrawn} cards drawn")

            ElseIf userInput = "3" Then

                'When the user chooses 3 or to quit then the function is ended and the code is finshied.
                Return True

            Else
                Console.WriteLine("That's not a proper input...")
            End If



        End While

        Return True

    End Function

End Module