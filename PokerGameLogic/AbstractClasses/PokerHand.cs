
using PokerGameLogic;
using System.Collections.Generic;
using System.Linq;

namespace PokerGameLogic.AbstractClasses
{
    public abstract class PokerHand
    {
        protected List<Card> hand = new List<Card>();
        protected string cardRanks = "High Card: ";
        public List<Card> Hand { 
            get { return hand; }
        }
        virtual public bool IsHand(List<Card> cards)
        {
            //aici trebuie puse ceva exceptii
            if (cards.Count == 0)
                return false;


            List<Card> orderedCards = cards.OrderBy(o=>o.CardNumber).ToList();
            
            if (orderedCards[0].CardNumber == 1)
            {
                hand.Add(orderedCards[0]);
                return true;
            }

            hand.Add(orderedCards[orderedCards.Count-1]);
            return true;
        }


        public string RankingToString()
        {
            string result = "";
            for (int i=0; i<hand.Count-1; i++)
                result+=hand[i].GetCard() + ",";
            result += hand[hand.Count - 1].GetCard();
            return cardRanks+result;
        }

        virtual public void Clear()
        { 
            hand.Clear();
        }

        public string HandType {
            get
            {
                return cardRanks;
            }
        }
    }
}
