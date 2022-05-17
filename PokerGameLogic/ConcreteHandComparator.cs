using PokerGameLogic.AbstractClasses;
using PokerGameLogic.Interfaces;
using System.Collections.Generic;

namespace PokerGameLogic
{
    public class ConcreteHandComparator : HandComparator
    {
        private List<string> _ranking;
        static ConcreteHandComparator _comparator = null;
        private ConcreteHandComparator()
        { 
            _ranking = new List<string> {"High Card", "Pair", "Two Pairs", "Three of a Kind", "Straight", "Flush", "Full House", "FourOfAKind", "Straight flush", "Royal Flush" };
        }

        public static ConcreteHandComparator GetComparator()
        { 
            if(_comparator == null)
                _comparator = new ConcreteHandComparator();
            return _comparator;
        }

        public int CompareHands(PokerHand handA, PokerHand handB)
        {
            
            int handARanking = _ranking.IndexOf(handA.HandType);
            int handBranking = _ranking.IndexOf(handB.HandType);
            if (handARanking > handBranking)
                return 1;
            else if (handARanking < handBranking)
                return -1;
            else
            {
                var cardListA = handA.Hand;
                var cardListB = handB.Hand;
                for (int i = 0; i < cardListA.Count; i++)
                    if (cardListA[i].CardNumber > cardListB[i].CardNumber)
                        return 1;
                    else if (cardListA[i].CardNumber < cardListB[i].CardNumber)
                        return -1;
                return 0;
            
            }

        }
    }
}
