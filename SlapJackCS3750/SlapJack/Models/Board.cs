﻿namespace SlapJack.Models
{
    using System;
    using System.Collections.Generic;

    public class Board
    {
        private static int MAX_PLAYERS = 2;
        private List<Card> pile;
        public List<Player> players { get; }
        private Deck deck;
        public int lastPlayed { get; set; }

        public Card getTopCard()
        {
            try
            {
                return pile[0];
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("There are no cards on the pile.");
            }
            return null;
        }

        public int getPileCount()
        {
            return pile.Count;
        }
        
        public Board()
        {
            //instantiate objects needed for game
            pile = new List<Card>();
            players = new List<Player>();
            for (int playerId = 0; playerId < MAX_PLAYERS; playerId++)
                players.Add(new Player());
            
            lastPlayed = 1;

            //deal players their cards
            deck = new Deck();
            Card nextCard = deck.deal();
            while (nextCard != null)
            {
                for (int playerId = 0; playerId < MAX_PLAYERS; playerId++)
                {
                    players[playerId].receiveCard(nextCard);
                    nextCard = deck.deal();

                }
            }
        }

        //get a player
        //used by SlapJackCLI to call methods on the player
        public Player getPlayer(int playerNum)
        {
            return players[playerNum - 1];
        }

        public void addCard(Card newCard)
        {
            if (newCard != null)
                pile.Insert(0, newCard);
        }

        public bool playerSlapped(int playerId)
        {
            if (isValidSlap())
            {
                players[playerId - 1].addToBottom(pile);
                Console.WriteLine("Player " + playerId + "'s slap succeded! He added " + pile.Count + " cards to his hand");
                pile.Clear();
                return players[playerId].getHandCount() == 52;

            }
            else
            {
                Console.WriteLine("Player " + playerId + "'s slap failed. He gave a card to player " + lastPlayed);
                players[playerId - 1].addToBottom(players[lastPlayed - 1].Flip());
            }

            return false;
        }

        public Boolean isValidSlap()
        {

            try
            {
                return getTopCard().faceValue == Face.Jack;
            }
            catch (NullReferenceException)
            {
                return false;
            }
        }
        
    }
}
