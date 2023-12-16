using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace _03.Cards.Models
{
    public class Card
    {
        private List<string> cardFacePossibility = new() { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        private List<string> cardSuitPossibility = new() { "\u2660", "\u2665", "\u2666", "\u2663" };

        private string cardFace;
        private string cardSuit;

        public Card(string cardFace, string cardSuit)
        {
            this.CardFace = cardFace;
            this.CardSuit = cardSuit;
        }

        public string CardFace
        {
            get => this.cardFace;
            private set
            {
                if (!cardFacePossibility.Contains(value))
                {
                    throw new ArgumentException("Invalid card!");
                }

                this.cardFace = value;
            }
        }

        public string CardSuit
        { 
            get => this.cardSuit;
            private set
            {
                if (!cardSuitPossibility.Contains(value))
                {
                    throw new ArgumentException("Invalid card!");
                }

                this.cardSuit = value;
            }
        }

        public override string ToString()
        {
            return $"[{this.CardFace}{this.CardSuit}]";
        }
    }
}