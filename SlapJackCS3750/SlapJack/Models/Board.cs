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
            
            lastPlayed = 2;

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

        ///
        /// <param name="playerId">The id of the player who slapped</param>
        /// <returns>true if the players slap is valid. false if it was not.</returns>
        public bool playerSlapped(int playerId)
        {
            bool slapValidity = isValidSlap();
            if (slapValidity)
            {
                getPlayer(playerId).addToBottom(pile);
                Console.WriteLine("Player " + playerId + "'s slap succeded! He added " + pile.Count + " cards to his hand");
                pile.Clear();

            }
            else
            {
                Console.WriteLine("Player " + playerId + "'s slap failed. He gave a card to player " + (3 - playerId));
                getPlayer((3 - playerId)).receiveCard(getPlayer(playerId).Flip());
            }

            return slapValidity;
        }

        public Card playerFlipped(int playerId)
        {
            if (playerId != lastPlayed)
            {
                Card card = getPlayer(playerId).Flip();
                if (card == null)
                    return null;
                //addCard(card);
                lastPlayed = playerId;
                return card;
            }
            return null;
        }

        /// <summary>
        /// Checks each players hand for a winner
        /// </summary>
        /// <returns>-1 if there is no winner or the id of the player that won</returns>
        public int checkWinner()
        {
            int winnerId = -1;
            for (int playerId = 0; playerId < MAX_PLAYERS; playerId++)
            {
                winnerId = players[playerId].getHandCount() >= 52 ? playerId : winnerId;
            }
            for (int playerId = 0; playerId < MAX_PLAYERS; playerId++)
            {
                winnerId = (players[playerId].getHandCount() + pile.Count) >= 52 ? playerId : winnerId;
            }
            return winnerId;
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
