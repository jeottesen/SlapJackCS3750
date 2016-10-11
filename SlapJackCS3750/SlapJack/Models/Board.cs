namespace SlapJack.Models
{
    using System;
    using System.Collections.Generic;

    public class Board
    {
        private List<Card> pile;
        private Player[] players;
        private Deck deck;
        private bool hasBeenSlapped;

        public Card getTopCard()
        {
            return pile[0];
        }

        public Board()
        {
            //instantiate objects needed for game
            pile = new List<Card>();
            players = new Player[2];
            players[0] = new Player(this);
            players[1] = new Player(this);
            deck = new Deck();
            hasBeenSlapped = false;

            //deal players their cards
            for (int i = 0; i < 26; i++)
            {
                players[0].receiveCard(deck.deal());
                players[1].receiveCard(deck.deal());
            }
            // pile.Add(new Card(Suit.Spades, Face.Ace));
        }

        //get a player
        //used by SlapJackCLI to call methods on the player
        public Player getPlayer(int playerNum)
        {
            return players[playerNum - 1];
        }

        public void addCard(Card newCard)
        {
            pile.Insert(0, newCard);
        }

        public void playerSlapped(Player player)
        {
            if (isValidSlap())
            {
                for(int i = 0; i < pile.Count; i++)
                {
                    player.receiveCard(pile[0]);
                    pile.RemoveAt(0);
                }
                hasBeenSlapped = false;
            }
        }

        public Boolean isValidSlap()
        {
            if (!hasBeenSlapped)
            {
                hasBeenSlapped = true;
                Card topCard = getTopCard();
                if (topCard.faceValue.Equals(Face.Jack))
                {
                    return true;
                }
                return false;
            }
            return false;
        }
    }
}
