using PokerGameLogic.AbstractClasses;
namespace PokerGameLogic.Interfaces
{
    interface HandComparator
    {
        int CompareHands(string handA, string handB);
    }
}
