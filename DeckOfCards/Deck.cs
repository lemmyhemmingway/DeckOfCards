using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeckOfCards
{
    class Deck
    {
        private Stack<Card> _deck = new Stack<Card>();

        private readonly Random _rnd = new Random();

        private readonly string[] _suits = { "Spades", "Clubs", "Hearts", "Diamonds" };

        public void BuildDeck()
        {
            if (_deck != null && _deck.Count != 52)
            {
                _deck.Clear();
            }
            else
            {
                Console.WriteLine("Deck Full");
                return;
            }

            foreach (string s in _suits)
            {
                for (int value = 1; value < 14; value++)
                {
                    Card card = new Card(value, s);
                    _deck.Push(card);
                }
            }
        }

        public void ShuffleDeck()
        {
            _deck = new Stack<Card>(_deck.OrderBy(x => _rnd.Next()));
        }

        public Card DealCard()
        {
            return _deck.Pop();
        }

    }
}
