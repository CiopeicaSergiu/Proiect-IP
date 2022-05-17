using PokerGameLogic.AbstractClasses;
using System.Collections.Generic;
using System.Linq;
namespace PokerGameLogic.Hands
{
    public class Flush:PokerHand
    {
        public override bool IsHand(List<Card> cards)
        {
            this.cardRanks = "Flush: ";
            List<Card> orderedCards = cards.OrderBy(o => o.CardNumber).ToList();
            for (int i = 0; i < orderedCards.Count-1; i++)
            {
                if (orderedCards[i].Suit != orderedCards[i + 1].Suit)
                    return false;
                hand.Add(orderedCards[i]);
            }
            return true;
        }
    }
}
