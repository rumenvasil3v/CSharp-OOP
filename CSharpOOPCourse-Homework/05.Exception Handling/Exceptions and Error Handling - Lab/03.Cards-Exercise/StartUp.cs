using System.Reflection.PortableExecutable;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
List<ICard> deckOfCards = new List<ICard>();

string[] cards = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
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

    try
    {
        ICard currentCard = CreateCard(currentCardFace, cardSuitCode);
        deckOfCards.Add(currentCard);
    }
    catch (InvalidCardException ex)
    {
        Console.WriteLine(ex.Message);
    }
}

Console.WriteLine(string.Join(" ", deckOfCards));

ICard CreateCard(string cardFace, string cardSuit)
{
    ICard card = new Card(cardFace, cardSuit);
    return card;
}

public class Card : ICard
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
                throw new InvalidCardException("Invalid card!");
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
                throw new InvalidCardException("Invalid card!");
            }

            this.cardSuit = value;
        }
    }

    public override string ToString()
    {
        return $"[{this.CardFace}{this.CardSuit}]";
    }
}

public interface ICard
{
    string CardFace { get; }

    string CardSuit { get; }
}

public class InvalidCardException : Exception
{
    public InvalidCardException(string message) : base(message)
    {

    }
}