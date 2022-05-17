using PokerGameLogic.AbstractClasses;
using System.Collections.Generic;
using System.Linq;

namespace PokerGameLogic.Hands
{
    public class ThreeOfAKind:PokerHand
    {
        public override bool IsHand(List<Card> cards)
        {
            this.cardRanks = "Three of a Kind: ";
            List<Card> orderedCards = cards.OrderBy(o => o.CardNumber).ToList();
            for (int i = orderedCards.Count - 1; i >= 2; i--)
                if (orderedCards[i].CardNumber == orderedCards[i - 1].CardNumber && orderedCards[i - 1].CardNumber == orderedCards[i - 2].CardNumber)
                {
                    hand.Add(orderedCards[i]);
                    hand.Add(orderedCards[i-1]);
                    hand.Add(orderedCards[i]);
                    return true;
                }
            return false;
        }
    }
}
