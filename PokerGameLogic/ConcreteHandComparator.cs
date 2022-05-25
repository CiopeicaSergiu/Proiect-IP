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

        public int CompareHands(string handA, string handB)
        {
            
            string []handARanking = handA.Split(':');
            string []handBRanking = handB.Split(':');

            int indexA = _ranking.IndexOf(handARanking[0].Replace(" ", string.Empty));
            int indexB = _ranking.IndexOf(handBRanking[0].Replace(" ", string.Empty));


            if (indexA > indexB)
                return 1;
            else if (indexA < indexB)
                return -1;
            else
            {
                string[] cardsA = handARanking[1].Split(',');
                string[] cardsB = handBRanking[1].Split(',');


                for (int i = 0; i < cardsA.Length; i++)
                {
                    string cardNumberA = cardsA[i].Split('-')[1];
                    string cardNumberB = cardsB[i].Split('-')[1];
                    if (int.Parse(cardNumberA) > int.Parse(cardNumberB))
                        return 1;
                    else if (int.Parse(cardNumberA) < int.Parse(cardNumberB))
                        return -1;

                }

                return 0;
            
            }

        }
    }
}
