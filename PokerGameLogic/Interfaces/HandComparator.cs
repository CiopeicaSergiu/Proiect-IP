using PokerGameLogic.AbstractClasses;
namespace PokerGameLogic.Interfaces
{
    interface HandComparator
    {
        int CompareHands(PokerHand handA, PokerHand handB);
    }
}
