using _03.Cards.Engine.Interfaces;
using _03.Cards.IO.Interfaces;
using _03.Cards.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Cards.Engine
{
    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;

        public Engine(IReader reader, IWriter writer)
        {
            this.reader = reader;
            this.writer = writer;
        }

        public void Run()
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<Card> deckOfCards = new List<Card>();

            string[] cards = reader.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            foreach (string card in cards)
            {
                string[] cardArguments = card.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string currentCardFace = cardArguments[0];
                string cardSuit = cardArguments[1];

                string cardSuitCode = string.Empty;
                switch (cardSuit)
                {
                    case "S":
                        cardSuitCode = "♠";
                        break;
                    case "H":
                        cardSuitCode = "♥";
                        break;
                    case "D":
                        cardSuitCode = "♦";
                        break;
                    case "C":
                        cardSuitCode = "♣";
                        break;
                }

                Card currentCard = default;
                try
                {
                    currentCard = new Card(currentCardFace, cardSuitCode);
                    deckOfCards.Add(currentCard);
                }
                catch (ArgumentException ex)
                {
                    writer.WriteLine(ex.Message);
                }
            }

            writer.WriteLine(string.Join(" ", deckOfCards));
        }
    }
}