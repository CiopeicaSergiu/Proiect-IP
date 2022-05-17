using PokerGameLogic.AbstractClasses;
using System.Collections.Generic;
using System.Linq;
namespace PokerGameLogic.Hands
{
    public class StraightFlush:PokerHand
    {
        private PokerHand _straight = new Straight();
        private PokerHand _flush = new Flush();
        public override bool IsHand(List<Card> cards)
        {
            this.cardRanks = "Straight flush: ";

            List<Card> orderedCards = cards.OrderBy(o => o.CardNumber).ToList();
            if (_straight.IsHand(cards) && _flush.IsHand(cards))
            {
                hand = new List<Card>(_straight.Hand);
                return true;
            }
            return false;
        }

        public override void Clear()
        {
            base.Clear();
            _straight.Clear();
            _flush.Clear();
        }

    }


}
