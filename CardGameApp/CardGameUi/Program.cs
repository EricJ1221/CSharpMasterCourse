using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameUi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PokerDeck deck = new PokerDeck();
            var hand = deck.DealCards();

            foreach (var card in hand) 
            {
                Console.WriteLine($"{card.Value.ToString()} { card.Suit.ToString() }");
            }
            
            Console.ReadLine();
        }
    }

    public abstract class Deck // Putting these in a class libary would be best to keep them inaccessible
    {
        protected List<PlayingCardModel> fullDeck = new List<PlayingCardModel>();     // Protected modifier so we can get access in our overloaded classes.
        protected List<PlayingCardModel> drawPile = new List<PlayingCardModel>();     // Everything in the full deck will get added to the draw pile once shuffled.
        protected List<PlayingCardModel> discardPile = new List<PlayingCardModel>();  // Anything returned to the deal will be added to the discard pile.
        protected void CreateDeck()
        {
            fullDeck.Clear();
            drawPile.Clear();

            for(int suit = 0; suit < 4; suit++) 
            { 
                for(int val = 0; val < 13; val++) 
                {
                    fullDeck.Add(new PlayingCardModel { Suit = (CardSuit)suit, Value = (CardValue)val });
                }
            }
        }

        public virtual void ShuffleDeck() // So that different shuffling techniques could be implemented for different games
        {
            // How to shuffle a list with a random/Lambda expression
            var rnd = new Random();    // Generates pseudo random numbers, you wouldn't use this for writing a cryptographic library,
                                        // its based on the current tick value of your clock, possible to exploit
            drawPile = fullDeck.OrderBy(x => rnd.Next()).ToList(); // The "OrderBy" allows us to order our list based upon a value
                                                                   // The lamda expression is essentially a shortcut
        }
        public abstract List<PlayingCardModel> DealCards();
        
        public virtual PlayingCardModel DrawOneCard()
        {
            PlayingCardModel output = drawPile.Take(1).First(); // Take does not remove the card.
            drawPile.Remove(output);
            return output;
        }

    }

    public class PokerDeck : Deck
    {
        public PokerDeck() // Constructor
        { 
            CreateDeck();
            ShuffleDeck();
        }
        public override List<PlayingCardModel> DealCards()
        {
            List<PlayingCardModel> output = new List<PlayingCardModel>();
            for (int i = 0; i < 5; i++)
            {
                output.Add(DrawOneCard());
            }

            return output;
        }

        public List<PlayingCardModel> RequestCards(List<PlayingCardModel> cardsToDiscard)
        {
            List<PlayingCardModel> output = new List<PlayingCardModel> ();

            foreach (var card in cardsToDiscard)
            {
                output.Add (DrawOneCard());
                discardPile.Add(card);
            }
            return output;
        }
    }

    public class BlackjackDeck : Deck
    {
        public BlackjackDeck()
        {
            CreateDeck();
            ShuffleDeck();
        }
        public override List<PlayingCardModel> DealCards()
        {
            List<PlayingCardModel> output = new List<PlayingCardModel>();
            for (int i = 0; i < 2; i++)
            {
                output.Add(DrawOneCard());
            }

            return output;
        }
        public PlayingCardModel RequestCard()
        {
            return DrawOneCard();
        }
    }

    public class UnoDeck :Deck // Would need to modify the enums as well as the game logic to fully implement
    {
        public UnoDeck()
        {
            CreateDeck();
            ShuffleDeck();
        }
        public override List<PlayingCardModel> DealCards()
        {
            List<PlayingCardModel> output = new List<PlayingCardModel>();
            for (int i = 0; i < 5; i++)
            {
                output.Add(DrawOneCard());
            }

            return output;
        }
        public PlayingCardModel RequestCard()
        {
            return DrawOneCard();
        }
    }
}
