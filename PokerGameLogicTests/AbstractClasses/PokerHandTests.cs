using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PokerGameLogic.Hands;
namespace PokerGameLogic.AbstractClasses.Tests
{
    [TestClass()]
    public class PokerHandTests
    {

        [TestMethod()]
        public void IsHandTest()
        {
            //{ "clubs", "diamonds", "hearts", "spades" };
            List<Card> hand = new List<Card>() { new Card(3, "diamonds", null),
                                                 new Card(6, "spades", null),
                                                 new Card(5, "clubs", null),
                                                 new Card(1, "clubs", null),
                                                 new Card(14, "clubs", null)};
            PokerHand pokerHand = new HighCard();


            Assert.AreEqual(true, pokerHand.IsHand(hand));
        }

        [TestMethod()]
        public void IsHandTestHighCard()
        {
            //{ "clubs", "diamonds", "hearts", "spades" };
            List<Card> hand = new List<Card>() { new Card(3, "diamonds", null),
                                                 new Card(6, "spades", null),
                                                 new Card(5, "clubs", null),
                                                 new Card(1, "clubs", null),
                                                 new Card(14, "clubs", null)};
            PokerHand pokerHand = new HighCard();
            pokerHand.IsHand(hand);

            Assert.AreEqual("High Card: ", pokerHand.HandType);
        }

        [TestMethod()]
        public void IsHandTestPair()
        {
            //{ "clubs", "diamonds", "hearts", "spades" };
            List<Card> hand = new List<Card>() { new Card(3, "diamonds", null),
                                                 new Card(5, "spades", null),
                                                 new Card(5, "clubs", null),
                                                 new Card(1, "clubs", null),
                                                 new Card(14, "clubs", null)};
            PokerHand pokerHand = new Pair();
            pokerHand.IsHand(hand);

            Assert.AreEqual("Pair: ", pokerHand.HandType);
        }

        [TestMethod()]
        public void IsHandTestTwoPair()
        {
            //{ "clubs", "diamonds", "hearts", "spades" };
            List<Card> hand = new List<Card>() { new Card(1, "diamonds", null),
                                                 new Card(5, "spades", null),
                                                 new Card(5, "clubs", null),
                                                 new Card(1, "clubs", null),
                                                 new Card(14, "clubs", null)};
            PokerHand pokerHand = new TwoPairs();
            pokerHand.IsHand(hand);

            Assert.AreEqual("Two Pairs: ", pokerHand.HandType);
        }

        [TestMethod()]
        public void IsHandTestThreeOfAKind()
        {
            //{ "clubs", "diamonds", "hearts", "spades" };
            List<Card> hand = new List<Card>() { new Card(3, "diamonds", null),
                                                 new Card(5, "spades", null),
                                                 new Card(5, "clubs", null),
                                                 new Card(5, "hearts", null),
                                                 new Card(14, "clubs", null)};
            PokerHand pokerHand = new ThreeOfAKind();
            pokerHand.IsHand(hand);

            Assert.AreEqual("Three of a Kind: ", pokerHand.HandType);
        }

        [TestMethod()]
        public void IsHandTestStraight()
        {
            //{ "clubs", "diamonds", "hearts", "spades" };
            List<Card> hand = new List<Card>() { new Card(12, "diamonds", null),
                                                 new Card(10, "spades", null),
                                                 new Card(13, "clubs", null),
                                                 new Card(11, "hearts", null),
                                                 new Card(14, "clubs", null)};
            PokerHand pokerHand = new Straight();
            pokerHand.IsHand(hand);

            Assert.AreEqual("Straight: ", pokerHand.HandType);
        }

        [TestMethod()]
        public void IsHandTestFlush()
        {
            //{ "clubs", "diamonds", "hearts", "spades" };
            List<Card> hand = new List<Card>() { new Card(3, "diamonds", null),
                                                 new Card(5, "diamonds", null),
                                                 new Card(5, "diamonds", null),
                                                 new Card(5, "diamonds", null),
                                                 new Card(14, "diamonds", null)};
            PokerHand pokerHand = new Flush();
            pokerHand.IsHand(hand);

            Assert.AreEqual("Flush: ", pokerHand.HandType);
        }

        [TestMethod()]
        public void IsHandTestFullHouse()
        {
            //{ "clubs", "diamonds", "hearts", "spades" };
            List<Card> hand = new List<Card>() { new Card(3, "diamonds", null),
                                                 new Card(5, "spades", null),
                                                 new Card(5, "clubs", null),
                                                 new Card(5, "hearts", null),
                                                 new Card(3, "clubs", null)};
            PokerHand pokerHand = new FullHouse();
            pokerHand.IsHand(hand);

            Assert.AreEqual("Full House: ", pokerHand.HandType);
        }

        [TestMethod()]
        public void IsHandTestFourOfAKind()
        {
            //{ "clubs", "diamonds", "hearts", "spades" };
            List<Card> hand = new List<Card>() { new Card(5, "diamonds", null),
                                                 new Card(5, "spades", null),
                                                 new Card(5, "clubs", null),
                                                 new Card(5, "hearts", null),
                                                 new Card(14, "clubs", null)};
            PokerHand pokerHand = new FourOfAKind();
            pokerHand.IsHand(hand);

            Assert.AreEqual("FourOfAKind: ", pokerHand.HandType);
        }

        [TestMethod()]
        public void IsHandTestStraightFlush()
        {
            //{ "clubs", "diamonds", "hearts", "spades" };
            List<Card> hand = new List<Card>() { new Card(1, "diamonds", null),
                                                 new Card(5, "diamonds", null),
                                                 new Card(4, "diamonds", null),
                                                 new Card(2, "diamonds", null),
                                                 new Card(3, "diamonds", null)};
            PokerHand pokerHand = new StraightFlush();
            pokerHand.IsHand(hand);

            Assert.AreEqual("Straight flush: ", pokerHand.HandType);
        }

        [TestMethod()]
        public void IsHandTestRoyalFlush()
        {
            //{ "clubs", "diamonds", "hearts", "spades" };
            List<Card> hand = new List<Card>() { new Card(10, "hearts", null),
                                                 new Card(13, "hearts", null),
                                                 new Card(11, "hearts", null),
                                                 new Card(12, "hearts", null),
                                                 new Card(14, "hearts", null)};
            PokerHand pokerHand = new RoyalFlush();
            pokerHand.IsHand(hand);

            Assert.AreEqual("Royal Flush: ", pokerHand.HandType);
        }

        [TestMethod()]
        public void IsHandTestHighCardBool()
        {
            //{ "clubs", "diamonds", "hearts", "spades" };
            List<Card> hand = new List<Card>() { new Card(3, "diamonds", null),
                                                 new Card(6, "spades", null),
                                                 new Card(5, "clubs", null),
                                                 new Card(1, "clubs", null),
                                                 new Card(14, "clubs", null)};
            PokerHand pokerHand = new HighCard();
           

            Assert.AreEqual(true, pokerHand.IsHand(hand));
        }

        [TestMethod()]
        public void IsHandTestPairBool()
        {
            //{ "clubs", "diamonds", "hearts", "spades" };
            List<Card> hand = new List<Card>() { new Card(3, "diamonds", null),
                                                 new Card(5, "spades", null),
                                                 new Card(8, "clubs", null),
                                                 new Card(1, "clubs", null),
                                                 new Card(14, "clubs", null)};
            PokerHand pokerHand = new Pair();
           

            Assert.AreEqual(false, pokerHand.IsHand(hand));
        }

        [TestMethod()]
        public void IsHandTestTwoPairBool()
        {
            //{ "clubs", "diamonds", "hearts", "spades" };
            List<Card> hand = new List<Card>() { new Card(1, "diamonds", null),
                                                 new Card(5, "spades", null),
                                                 new Card(5, "clubs", null),
                                                 new Card(1, "clubs", null),
                                                 new Card(14, "clubs", null)};
            PokerHand pokerHand = new TwoPairs();
            

            Assert.AreEqual(true, pokerHand.IsHand(hand));
        }

        [TestMethod()]
        public void IsHandTestThreeOfAKindBool()
        {
            //{ "clubs", "diamonds", "hearts", "spades" };
            List<Card> hand = new List<Card>() { new Card(3, "diamonds", null),
                                                 new Card(5, "spades", null),
                                                 new Card(5, "clubs", null),
                                                 new Card(1, "hearts", null),
                                                 new Card(14, "clubs", null)};
            PokerHand pokerHand = new ThreeOfAKind();
            

            Assert.AreEqual(false, pokerHand.IsHand(hand));
        }

        [TestMethod()]
        public void IsHandTestStraightBool()
        {
            //{ "clubs", "diamonds", "hearts", "spades" };
            List<Card> hand = new List<Card>() { new Card(12, "diamonds", null),
                                                 new Card(10, "spades", null),
                                                 new Card(13, "clubs", null),
                                                 new Card(11, "hearts", null),
                                                 new Card(14, "clubs", null)};
            PokerHand pokerHand = new Straight();
          

            Assert.AreEqual(true, pokerHand.IsHand(hand));
        }

        [TestMethod()]
        public void IsHandTestFlushBool()
        {
            //{ "clubs", "diamonds", "hearts", "spades" };
            List<Card> hand = new List<Card>() { new Card(3, "diamonds", null),
                                                 new Card(5, "diamonds", null),
                                                 new Card(5, "diamonds", null),
                                                 new Card(5, "diamonds", null),
                                                 new Card(14, "clubs", null)};
            PokerHand pokerHand = new Flush();
          

            Assert.AreEqual(false, pokerHand.IsHand(hand));
        }

        [TestMethod()]
        public void IsHandTestFullHouseBool()
        {
            //{ "clubs", "diamonds", "hearts", "spades" };
            List<Card> hand = new List<Card>() { new Card(3, "diamonds", null),
                                                 new Card(5, "spades", null),
                                                 new Card(5, "clubs", null),
                                                 new Card(2, "hearts", null),
                                                 new Card(3, "clubs", null)};
            PokerHand pokerHand = new FullHouse();
           

            Assert.AreEqual(false, pokerHand.IsHand(hand));
        }

        [TestMethod()]
        public void IsHandTestFourOfAKindBool()
        {
            //{ "clubs", "diamonds", "hearts", "spades" };
            List<Card> hand = new List<Card>() { new Card(5, "diamonds", null),
                                                 new Card(5, "spades", null),
                                                 new Card(5, "clubs", null),
                                                 new Card(5, "hearts", null),
                                                 new Card(14, "clubs", null)};
            PokerHand pokerHand = new FourOfAKind();
            

            Assert.AreEqual(true, pokerHand.IsHand(hand));
        }

        [TestMethod()]
        public void IsHandTestStraightFlushBool()
        {
            //{ "clubs", "diamonds", "hearts", "spades" };
            List<Card> hand = new List<Card>() { new Card(1, "diamonds", null),
                                                 new Card(5, "diamonds", null),
                                                 new Card(4, "diamonds", null),
                                                 new Card(2, "diamonds", null),
                                                 new Card(3, "diamonds", null)};
            PokerHand pokerHand = new StraightFlush();
            

            Assert.AreEqual(true, pokerHand.IsHand(hand));
        }

        [TestMethod()]
        public void IsHandTestRoyalFlushBool()
        {
            //{ "clubs", "diamonds", "hearts", "spades" };
            List<Card> hand = new List<Card>() { new Card(10, "hearts", null),
                                                 new Card(13, "hearts", null),
                                                 new Card(9, "hearts", null),
                                                 new Card(12, "hearts", null),
                                                 new Card(14, "hearts", null)};
            PokerHand pokerHand = new RoyalFlush();
           

            Assert.AreEqual(false, pokerHand.IsHand(hand));
        }

    }
}