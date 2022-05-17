using System.Collections.Generic;
using System.Linq;
using PokerGameLogic.AbstractClasses;
namespace PokerGameLogic.Hands
{
    public class FourOfAKind:PokerHand
    {
        public override bool IsHand(List<Card> cards)
        {
            this.cardRanks = "FourOfAKind: ";
            Dictionary<int, int> cardFrequency = new Dictionary<int, int>();
            for(int i= 0; i<cards.Count; i++)
                if(cardFrequency.ContainsKey(cards[i].CardNumber))
                    cardFrequency[cards[i].CardNumber]++;
                else
                    cardFrequency.Add(cards[i].CardNumber, 1);

            if (cardFrequency.ContainsValue(4))
            { 
                var key = cardFrequency.FirstOrDefault(entry =>Equals(entry.Value, 4)).Key;
                foreach (var card in cards)
                    if (card.CardNumber == key)
                        hand.Add(card);
                return true;
            }

            return false;

        }
    }
}
