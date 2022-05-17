using System;
using System.Collections.Generic;
using System.Drawing;

namespace PokerGameLogic
{
    public struct Card
    {
        private int _cardNumber;
        private string _suit;
        private Bitmap _bitmap;
        public Card(int cardNumber, string suit, Bitmap bitmap)
        {
            this._cardNumber = cardNumber;
            this._suit = suit;
            if (bitmap != null)
                this._bitmap = new Bitmap(bitmap);
            else
                this._bitmap = null;
        }

        public string GetCard()
        {
            return this._suit + this._cardNumber.ToString();
        }

        public int CardNumber
        {
            get { return this._cardNumber; }
        }

        public string Suit
        {
            get { return this._suit; }
        }

        public Bitmap Bitmap 
        {
            get { return this._bitmap; }
        }
    }

    public class Pack
    { 
        private List<Card> _packOfCards;
        private int _numberOfSuits;
        private int _numberOfCardsPerSuit;
        private int _startingCard;
        static private Random _random = new Random();
        static private List<String> _suits = new List<string> { "clubs", "diamonds", "hearts", "spades" };
        static private Dictionary<string, List<Bitmap>> _sprites;
        static private Dictionary<string, string> _folders;
        static private string _path; 
        static Pack()
        {
            _random = new Random();
            _suits = new List<string> {"spades", "clubs", "diamonds", "hearts" };
            _sprites = new Dictionary<string, List<Bitmap>>();
            _folders = new Dictionary<string, string>{ { "Black Hearts", "spades"}, { "Clubs", "clubs" }, { "Diamonds", "diamonds" }, { "Red Hearts", "hearts" } };
            _path = AppDomain.CurrentDomain.BaseDirectory + "CardsV2(Easy)\\";
            ReadSprites();
        }

        public Pack(int startingCard, int numberOfSuits, int numberOfCardsPerSuit) 
        { 

            _packOfCards = new List<Card>();
            
            this._numberOfSuits = numberOfSuits;
            this._numberOfCardsPerSuit = numberOfCardsPerSuit;
            this._startingCard = startingCard;
            

            for (int i = 0; i < this._numberOfSuits; i++)
                for (int j = this._startingCard; j <= this._numberOfCardsPerSuit; j++)
                    _packOfCards.Add(new Card(j, _suits[i], _sprites[_suits[i]][j-1]));
            
        }

        public string GetCardsFromPack(int numberOfCards)
        {
            string result = "";
            for (int i = 1; i <= numberOfCards; i++)
            {
                Card card = DrawCard();
                result += card.GetCard() + "\r\n";
                
            }
            return result;

        }


        public Card DrawCard()
        {
            Card card;
            do
            {
                int cardType = _random.Next(1, _numberOfSuits+1);
                string cardSuit;
                //"clubs","diamonds","hearts","spades"
                switch (cardType)
                {
                    case 1:
                        cardSuit = "clubs";
                        break;
                    case 2:
                        cardSuit = "diamonds";
                        break;
                    case 3:
                        cardSuit = "hearts";
                        break;
                    case 4:
                        cardSuit = "spades";
                        break;
                    default:
                        cardSuit = "clubs";
                        break;
                }

                int cardNumber = _random.Next(1, _numberOfCardsPerSuit+1);
                card = _packOfCards.Find(item => item.Suit == cardSuit && item.CardNumber == cardNumber);
            }while (card.CardNumber ==0 && _packOfCards.Count!=0);

            if (_packOfCards.Count != 0)
                _packOfCards.Remove(card);
            else
                card = new Card(-1, "NoCard!!", null);
            return card;
        }

        static private void ReadSprites()
        {
            foreach (var folder in _folders)
            {
                _sprites.Add(folder.Value, new List<Bitmap>());
                for (int i = 1; i <= 13; i++)
                {
                    string myPath = _path + folder.Key +"\\"+ i.ToString() + ".png";
                    _sprites[folder.Value].Add(new Bitmap(myPath));
                }
            }
        }

    }
}
