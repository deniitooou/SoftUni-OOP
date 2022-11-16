using System;
using System.Collections.Generic;
using System.Linq;

namespace Cards
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            List<Card> cardDeck = new List<Card>();

            string[] drawnCards = Console.ReadLine().Split(", ");

            for (int i = 0; i < drawnCards.Length; i++)
            {
                string face = drawnCards[i].Split().First();
                string suit = drawnCards[i].Split().Last();

                try
                {
                    cardDeck.Add(CreateCard(face, suit));
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine(string.Join(" ", cardDeck));
        }

        static Card CreateCard(string face, string suit)
        {
            string[] validFaces = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            string[] validSuits = new string[] { "S", "H", "D", "C" };

            if (!validFaces.Contains(face) || !validSuits.Contains(suit))
            {
                throw new ArgumentException("Invalid card!");
            }

            string currSuit = string.Empty;

            switch (suit)
            {
                case "S":
                    currSuit = "\u2660";
                    break;
                case "H":
                    currSuit = "\u2665";
                    break;
                case "D":
                    currSuit = "\u2666";
                    break;
                case "C":
                    currSuit = "\u2663";
                    break;
            }

            return new Card(face, currSuit);
        }
    }
}

public class Card
{
    public string Face { get; set; }

    public string Suit { get; set; }

    public Card(string face, string suit)
    {
        this.Face = face;
        this.Suit = suit;
    }

    public override string ToString()
    {
        return $"[{this.Face}{this.Suit}]";
    }
}
