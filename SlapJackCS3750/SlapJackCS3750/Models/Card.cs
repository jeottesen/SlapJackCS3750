﻿namespace SlapJackCS3750.Models
{
    public enum Suit { Diamonds, Spades, Clubs, Hearts };
    public enum Face { Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King, Ace };

    public class Card
    {
        private Suit suit;
        private Face face;

        // Card constructor used for populating Deck array.
        public Card(Suit suit, Face face)
        {
            this.suit = suit;
            this.face = face;
        }

        public override string ToString()
        {
            return face.ToString() + "_of_" + suit.ToString() + ".png";
        }

        private Suit suitValue
        {
            get
            {
                return suit;
            }

            set
            {
                suit = value;
            }
        }

        private Face faceValue
        {
            get
            {
                return face;
            }

            set
            {
                face = value;
            }
        }
    }
}
