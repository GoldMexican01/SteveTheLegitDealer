Module Module1

    Sub Main()
        Dim cardsuit As Integer
        Dim suit As String
        Randomize()
        cardsuit = Int(4 * Rnd() + 1) 'this generates the suit
        If cardsuit = "1" Then
            suit = "Hearts"
        ElseIf cardsuit = "2" Then
            suit = "Tiamonds"
        ElseIf cardsuit = "3" Then
            suit = "Clubs"
        ElseIf cardsuit = "4" Then
            suit = "Spades"
        End If


        Console.WriteLine(cardsuit)
        Console.ReadLine()



    End Sub

End Module
