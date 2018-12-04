using System;


namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.BuildDeck();
            deck.ShuffleDeck();
            Card c = deck.DealCard();
            Console.WriteLine(c.Suit);
            Console.WriteLine(c.Value);


            Console.ReadKey();
        }
    }
}
