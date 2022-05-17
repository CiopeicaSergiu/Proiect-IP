using PokerGameLogic.AbstractClasses;
using System.Collections.Generic;
using System.Linq;
namespace PokerGameLogic.Hands
{
    public class FullHouse:PokerHand
    {
        public override bool IsHand(List<Card> cards)
        {
            this.cardRanks = "Full House: ";
            Dictionary<int, int> cardFrequency = new Dictionary<int, int>();
            List<Card> orderedCards = cards.OrderBy(o => o.CardNumber).ToList();

            for (int i = 0; i < orderedCards.Count; i++)
                if (cardFrequency.ContainsKey(orderedCards[i].CardNumber))
                    cardFrequency[orderedCards[i].CardNumber]++;
                else
                    cardFrequency.Add(orderedCards[i].CardNumber, 1);

            bool maybeFullHouse = false;

            foreach (var entry in cardFrequency)
                if (entry.Value == 3)
                    maybeFullHouse = true;
                else if (maybeFullHouse && entry.Value == 2)
                {
                    foreach (var card in orderedCards)
                        hand.Add(card);
                    return true;
                }

            return false;
        }
    }
}
