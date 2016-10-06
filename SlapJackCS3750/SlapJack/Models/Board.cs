namespace SlapJack.Models
{
    using System;
    using System.Collections.Generic;

    public class Board
    {
        private List<Card> pile;

        public Card getTopCard()
        {
            return pile[0];
        }

        public Board()
        {
            pile = new List<Card>();
            pile.Add(new Card(Suit.Spades, Face.Ace));
        }
    }
}
