using PokerGameLogic.AbstractClasses;
using PokerGameLogic.Hands;
using System.Collections.Generic;

namespace PokerGameLogic.Hands
{
    public class RoyalFlush:PokerHand
    {
        private PokerHand _straigth = new Straight();
        private PokerHand _flush = new Flush();
        public override bool IsHand(List<Card> cards)
        {
            this.cardRanks = "Royal Flush: ";
            if (_straigth.IsHand(cards) && _flush.IsHand(cards))
            {
                hand = new List<Card>(_straigth.Hand);
                if (hand[hand.Count - 1].CardNumber == 1)
                    return true;

            }
            return false;
        }

        public override void Clear()
        {
            base.Clear();
            _straigth.Clear(); 
            _flush.Clear(); 
        }
    }
}
