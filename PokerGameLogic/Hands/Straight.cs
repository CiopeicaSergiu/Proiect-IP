using System.Collections.Generic;
using System.Linq;
using PokerGameLogic.AbstractClasses;
using System;
namespace PokerGameLogic.Hands
{
    public class Straight:PokerHand
    {
        public override bool IsHand(List<Card> cards)
        {
            
            this.cardRanks = "Straight: ";
            List<Card> orderedCards = cards.OrderBy(o => o.CardNumber).ToList();

            for (int i = 0; i < orderedCards.Count - 1; i++)
            {
                hand.Add(orderedCards[i]);
                if (orderedCards[i].CardNumber != orderedCards[i + 1].CardNumber - 1 && orderedCards[i].CardNumber != 1)
                {
                        return false;
                }
            }
            hand.Add(orderedCards[orderedCards.Count-1]);
            if (hand[0].CardNumber == 1)
            { 
                Card aux = hand[0];
                hand.RemoveAt(0);
                hand.Add(aux);
            }
            return true;
        }
    }
}
