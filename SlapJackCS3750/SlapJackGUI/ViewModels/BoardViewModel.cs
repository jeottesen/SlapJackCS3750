﻿namespace SlapJackGUI.ViewModels
{
    using Caliburn.Micro;
    using SlapJack.Models;
    using System;
    using System.Windows;

    public class BoardViewModel : Conductor<object>
    {
        private string cardURL;
        public string CardURL
        {
            get { return cardURL; }
            set
            {
                cardURL = "/Img/" + value + ".png";
                NotifyOfPropertyChange(() => CardURL);

            }
        }

        private Board board;

        private bool gameEnd;

        private int pileCount;

        public int PileCount
        {
            get { return pileCount; }
            set
            {
                pileCount = value;
                NotifyOfPropertyChange(() => PileCount);
            }
        }

        private int player1HandCount;

        public int Player1HandCount
        {
            get { return player1HandCount; }
            set
            {
                player1HandCount = value;
                NotifyOfPropertyChange(() => Player1HandCount);
            }
        }

        private int player2HandCount;

        public int Player2HandCount
        {
            get { return player2HandCount; }
            set
            {
                player2HandCount = value;
                NotifyOfPropertyChange(() => Player2HandCount);
            }
        }

        private string winnerLabel = "Player 2's turn";

        public string WinnerLabel
        {
            get { return winnerLabel; }
            set
            {
                winnerLabel = value;
                NotifyOfPropertyChange(() => WinnerLabel);
            }
        }


        public void onSlap(int playerNum)
        {
            
            bool validSlap = board.playerSlapped(playerNum);
            updateCounts();
            if (validSlap)
                CardURL = "";
            else
                WinnerLabel = "Player " + playerNum + "'s slap failed. He gave a card to player " + (3 - playerNum);
            
            checkAndDisplayWinner();

        }


        public void onFlip(int playerNum)
        {

            Card card = board.playerFlipped(playerNum);
            if (card == null)
            {
                checkAndDisplayWinner();
                return;
            }
            else
            {
                board.addCard(card);
                CardURL = card.ToString();
                updateCounts();
            }
        }

        private void updateCounts()
        {
            PileCount = board.getPileCount();
            Player1HandCount = board.getPlayer(1).getHandCount();
            Player2HandCount = board.getPlayer(2).getHandCount();
            Console.WriteLine(Player2HandCount);
            if (player1HandCount == 0 || Player2HandCount == 0)
                checkAndDisplayWinner();
            else
            {
                WinnerLabel = "Player " + (3 - board.lastPlayed) + "'s turn";
            }
            

        }

        private void checkAndDisplayWinner()
        {
            int playerId = board.checkWinner();
            if (playerId != -1)
            {
                playerId++;
                WinnerLabel = "Player " + playerId + " Wins!!!";
            }
            
        }


        public BoardViewModel()
        {
            board = new Board();
            updateCounts();
        }
        
    }
}