using PokerGameLogic.AbstractClasses;
using System.Collections.Generic;
using System.Linq;
namespace PokerGameLogic.Hands
{
    public class Pair:PokerHand
    {
        public override bool IsHand(List<Card> cards)
        {
            this.cardRanks = "Pair: ";
            List<Card> orderedCards = cards.OrderBy(o => o.CardNumber).ToList();
            for (int i = orderedCards.Count - 1; i >= 1; i--)
                if (orderedCards[i].CardNumber == orderedCards[i - 1].CardNumber)
                {
                    hand.Add(orderedCards[i]);
                    hand.Add(orderedCards[i-1]);
                    return true;
                }
            return false;
        }
    }
}
