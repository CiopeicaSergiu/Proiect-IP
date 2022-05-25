using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using PokerGameLogic;
using SocketsComunication;
using PokerGameLogic.Interfaces;
namespace Poker
{
    public partial class NewGame : Form
    {
        private Client _client = null;
        private Queue<string> _messagesIn = new Queue<string>();
        private Queue<string> _messagesOut = new Queue<string>();
        private List<int> _players = new List<int>() {-1, -1, -1, -1, -1};
        private int _discardedCards = 0;
        
        public NewGame()
        {
            InitializeComponent();
            _client = new Client(_messagesIn, _messagesOut);
            while (true)
            {
                if (_messagesIn.Count != 0)
                {
                    
                    int value;
                    try
                    {
                        string myMsg = _messagesIn.Dequeue();
                        string []msg = myMsg.Split(',');
                       
                        /*
                        MessageBox.Show(msg);
                        value = int.Parse(msg);
                        _players[0] = value;
                        */
                        for (int i = 0; i < msg.Length; i++)
                                _players[i] = int.Parse(msg[i]);
                        break;
                    }
                    catch (Exception ex)
                    { 
                        
                    }
                   
                    //string msg = _messagesIn.Dequeue();
                    //MessageBox.Show(msg);

                }
            }
        }

        private void Back(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ChangeElementsPositions(Size oldSize)
        {
            float widthPercent = (float)this.Width / (float)oldSize.Width;
            float heightPercent = (float)this.Height / (float)oldSize.Height;

            //To do label
            int newX = (int)Math.Round(_gameLabel.Location.X * widthPercent);
            int newY = (int)Math.Round(_gameLabel.Location.Y * heightPercent);

            int newWidth = (int)Math.Round(_gameLabel.Size.Width * widthPercent);
            int newHeight = (int)Math.Round(_gameLabel.Size.Height * heightPercent);

            _gameLabel.Size = new Size(newWidth, newHeight);
            _gameLabel.Location = new Point(newX, newY);
            _gameLabel.Font = new Font("Mongolian Baiti", heightPercent > widthPercent ? widthPercent * _gameLabel.Font.Size : heightPercent * _gameLabel.Font.Size);

            //Back Button
            
            newX = (int)Math.Round(_backButton.Location.X * widthPercent);
            newY = (int)Math.Round(_backButton.Location.Y * heightPercent);

            newWidth = (int)Math.Round(_backButton.Size.Width * widthPercent);
            newHeight = (int)Math.Round(_backButton.Size.Height * heightPercent);

            _backButton.Size = new Size(newWidth, newHeight);
            _backButton.Location = new Point(newX, newY);
            _backButton.Font = new Font("Mongolian Baiti", heightPercent > widthPercent ? widthPercent * _backButton.Font.Size : heightPercent * _backButton.Font.Size);

            //Show Cards Button
            
            newX = (int)Math.Round(_showCardsButton.Location.X * widthPercent);
            newY = (int)Math.Round(_showCardsButton.Location.Y * heightPercent);

            newWidth = (int)Math.Round(_showCardsButton.Size.Width * widthPercent);
            newHeight = (int)Math.Round(_showCardsButton.Size.Height * heightPercent);

            _showCardsButton.Size = new Size(newWidth, newHeight);
            _showCardsButton.Location = new Point(newX, newY);
            _showCardsButton.Font = new Font("Mongolian Baiti", heightPercent > widthPercent ? widthPercent * _showCardsButton.Font.Size : heightPercent * _showCardsButton.Font.Size);

           
            //Picture box 1

            newX = (int)Math.Round(_cardPictureBox1.Location.X * widthPercent);
            newY = (int)Math.Round(_cardPictureBox1.Location.Y * heightPercent);

            newWidth = (int)Math.Round(_cardPictureBox1.Size.Width * widthPercent);
            newHeight = (int)Math.Round(_cardPictureBox1.Size.Height * heightPercent);

            _cardPictureBox1.Size = new Size(newWidth, newHeight);
            _cardPictureBox1.Location = new Point(newX, newY);
            _cardPictureBox1.Font = new Font("Mongolian Baiti", heightPercent > widthPercent ? widthPercent * _cardPictureBox1.Font.Size : heightPercent * _cardPictureBox1.Font.Size);

            //Picture box 2

            newX = (int)Math.Round(_cardPictureBox2.Location.X * widthPercent);
            newY = (int)Math.Round(_cardPictureBox2.Location.Y * heightPercent);

            newWidth = (int)Math.Round(_cardPictureBox2.Size.Width * widthPercent);
            newHeight = (int)Math.Round(_cardPictureBox2.Size.Height * heightPercent);

            _cardPictureBox2.Size = new Size(newWidth, newHeight);
            _cardPictureBox2.Location = new Point(newX, newY);
            _cardPictureBox2.Font = new Font("Mongolian Baiti", heightPercent > widthPercent ? widthPercent * _cardPictureBox2.Font.Size : heightPercent * _cardPictureBox2.Font.Size);

            //Picture box 3

            newX = (int)Math.Round(_cardPictureBox3.Location.X * widthPercent);
            newY = (int)Math.Round(_cardPictureBox3.Location.Y * heightPercent);

            newWidth = (int)Math.Round(_cardPictureBox3.Size.Width * widthPercent);
            newHeight = (int)Math.Round(_cardPictureBox3.Size.Height * heightPercent);

            _cardPictureBox3.Size = new Size(newWidth, newHeight);
            _cardPictureBox3.Location = new Point(newX, newY);
            _cardPictureBox3.Font = new Font("Mongolian Baiti", heightPercent > widthPercent ? widthPercent * _cardPictureBox3.Font.Size : heightPercent * _cardPictureBox3.Font.Size);

            //Picture box 4

            newX = (int)Math.Round(_cardPictureBox4.Location.X * widthPercent);
            newY = (int)Math.Round(_cardPictureBox4.Location.Y * heightPercent);

            newWidth = (int)Math.Round(_cardPictureBox4.Size.Width * widthPercent);
            newHeight = (int)Math.Round(_cardPictureBox4.Size.Height * heightPercent);

            _cardPictureBox4.Size = new Size(newWidth, newHeight);
            _cardPictureBox4.Location = new Point(newX, newY);
            _cardPictureBox4.Font = new Font("Mongolian Baiti", heightPercent > widthPercent ? widthPercent * _cardPictureBox4.Font.Size : heightPercent * _cardPictureBox4.Font.Size);

            //Picture box 5

            newX = (int)Math.Round(_cardPictureBox5.Location.X * widthPercent);
            newY = (int)Math.Round(_cardPictureBox5.Location.Y * heightPercent);

            newWidth = (int)Math.Round(_cardPictureBox5.Size.Width * widthPercent);
            newHeight = (int)Math.Round(_cardPictureBox5.Size.Height * heightPercent);

            _cardPictureBox5.Size = new Size(newWidth, newHeight);
            _cardPictureBox5.Location = new Point(newX, newY);
            _cardPictureBox5.Font = new Font("Mongolian Baiti", heightPercent > widthPercent ? widthPercent * _cardPictureBox5.Font.Size : heightPercent * _cardPictureBox5.Font.Size);

            //Text Box Cards

            newX = (int)Math.Round(_textBoxCards.Location.X * widthPercent);
            newY = (int)Math.Round(_textBoxCards.Location.Y * heightPercent);

            newWidth = (int)Math.Round(_textBoxCards.Size.Width * widthPercent);
            newHeight = (int)Math.Round(_textBoxCards.Size.Height * heightPercent);

            _textBoxCards.Size = new Size(newWidth, newHeight);
            _textBoxCards.Location = new Point(newX, newY);
            _textBoxCards.Font = new Font("Mongolian Baiti", heightPercent > widthPercent ? widthPercent * _textBoxCards.Font.Size : heightPercent * _textBoxCards.Font.Size);

            //Text Box Cards 2

            newX = (int)Math.Round(_textBoxCards2.Location.X * widthPercent);
            newY = (int)Math.Round(_textBoxCards2.Location.Y * heightPercent);

            newWidth = (int)Math.Round(_textBoxCards2.Size.Width * widthPercent);
            newHeight = (int)Math.Round(_textBoxCards2.Size.Height * heightPercent);

            _textBoxCards2.Size = new Size(newWidth, newHeight);
            _textBoxCards2.Location = new Point(newX, newY);
            _textBoxCards2.Font = new Font("Mongolian Baiti", heightPercent > widthPercent ? widthPercent * _textBoxCards2.Font.Size : heightPercent * _textBoxCards2.Font.Size);
        }

        private void ShowCards(object sender, MouseEventArgs e)
        {
            _discardedCards = 0;
            //Card 1
            if (_cardPictureBox1.Image == null)
            {
                Card card = _pack.DrawCard();
                if (card.CardNumber != -1)
                {
                    _cardPictureBox1.BackColor = Color.Transparent;
                    _cardPictureBox1.Image = card.Bitmap;

                    if (_hand.Count < 5)
                        _hand.Add(card);
                    else
                        _hand[0] = card;
                }
            }

            //Card 2
            if (_cardPictureBox2.Image == null)
            {
                Card card = _pack.DrawCard();
                if (card.CardNumber != -1)
                {
                    _cardPictureBox2.BackColor = Color.Transparent;
                    _cardPictureBox2.Image = card.Bitmap;
                    if (_hand.Count < 5)
                        _hand.Add(card);
                    else
                        _hand[1] = card;
                }
            }

            //Card 3
            if (_cardPictureBox3.Image == null)
            {
                Card card = _pack.DrawCard();
                if (card.CardNumber != -1)
                {
                    _cardPictureBox3.BackColor = Color.Transparent;
                    _cardPictureBox3.Image = card.Bitmap;

                    if (_hand.Count < 5)
                        _hand.Add(card);
                    else
                        _hand[2] = card;
                }
            }

            //Card 4
            if (_cardPictureBox4.Image == null)
            {
                Card card = _pack.DrawCard();
                if (card.CardNumber != -1)
                {
                    _cardPictureBox4.BackColor = Color.Transparent;
                    _cardPictureBox4.Image = card.Bitmap;

                    if (_hand.Count < 5)
                        _hand.Add(card);
                    else
                        _hand[3] = card;
                }
            }

            //Card 5
            if (_cardPictureBox5.Image == null)
            {
                Card card = _pack.DrawCard();
                if (card.CardNumber != -1)
                {
                    _cardPictureBox5.BackColor = Color.Transparent;
                    _cardPictureBox5.Image = card.Bitmap;
                    if (_hand.Count < 5)
                        _hand.Add(card);
                    else
                        _hand[4] = card;
                }
            }

            int j=0;

            for (int i = _handRanking.Count - 1; i >= 0; i--)
                if (_handRanking[i].IsHand(new List<Card>(_hand)))
                {
                    j = i;
                    break;
                }
                else
                {
                    _handRanking[i].Clear();
                }


            //_textBoxCards.Text = _handRanking[j].RankingToString();
            _messagesOut.Enqueue(_players[0].ToString()+":"+_handRanking[j].RankingToString());
            _handRanking[j].Clear();

            /*
            string result = "";
            foreach(var card in _hand)
            {
                result += card.GetCard() + "\r\n";
            }

            _textBoxCards.Text = result;
            */
        }

        private void MarkForDiscard1(object sender, EventArgs e)
        {
            if (_cardPictureBox1.Image != null)
            {
                if (_discardedCards <= 2)
                {
                    _cardPictureBox1.BackColor = Color.Black;
                    _cardPictureBox1.Image = null;
                    ++_discardedCards;
                }
                
            }
            else if (_hand.Count > 0)
                {
                    _cardPictureBox1.BackColor = Color.Transparent;
                    _cardPictureBox1.Image = _hand[0].Bitmap;
                    --_discardedCards;
                }

            
            _cardPictureBox1.Update();
        }

        private void MarkForDiscard2(object sender, EventArgs e)
        {
            if ( _cardPictureBox2.Image != null)
            {
                if (_discardedCards <= 2)
                {
                    _cardPictureBox2.BackColor = Color.Black;
                    _cardPictureBox2.Image = null;
                    ++_discardedCards;
                }
            }
            else if (_hand.Count > 0)
                {
                    _cardPictureBox2.BackColor = Color.Transparent;
                    _cardPictureBox2.Image = _hand[1].Bitmap;
                 --_discardedCards;

            }
            _cardPictureBox2.Update();
        }

        private void MarkForDiscard3(object sender, EventArgs e)
        {
            if ( _cardPictureBox3.Image != null)
            {
                if (_discardedCards <= 2)
                {
                    _cardPictureBox3.BackColor = Color.Black;
                    _cardPictureBox3.Image = null;
                    ++_discardedCards;
                }
            }
            else if (_hand.Count > 0)
                {
                    _cardPictureBox3.BackColor = Color.Transparent;
                    _cardPictureBox3.Image = _hand[2].Bitmap;
                --_discardedCards;

            }
            _cardPictureBox3.Update();

        }

        private void MarkForDiscard4(object sender, EventArgs e)
        {
            if ( _cardPictureBox4.Image != null)
            {
                if (_discardedCards <= 2)
                {
                    _cardPictureBox4.BackColor = Color.Black;
                    _cardPictureBox4.Image = null;
                    ++_discardedCards;
                }
            }
            else if (_hand.Count > 0)
                {
                    _cardPictureBox4.BackColor = Color.Transparent;
                    _cardPictureBox4.Image = _hand[3].Bitmap;
                --_discardedCards;

            }
            _cardPictureBox4.Update();

        }

        private void MarkForDiscard5(object sender, EventArgs e)
        {
            if ( _cardPictureBox5.Image != null)
            {
                if (_discardedCards <= 2)
                {
                    _cardPictureBox5.BackColor = Color.Black;
                    _cardPictureBox5.Image = null;
                    ++_discardedCards;
                }
            }
            else if (_hand.Count > 0)
            {
                _cardPictureBox5.BackColor = Color.Transparent;
                _cardPictureBox5.Image = _hand[4].Bitmap;
                --_discardedCards;

            }
            _cardPictureBox5.Update();
        }

        private int FindFreeSeat()
        {
            for (int i = 0; i < _players.Count; i++)
                if (_players[i] == -1)
                    return i;
            return -1;
        }

        private void DisconnectUser(int user)
        {
            for (int i = 0; i < _players.Count; i++)
            {
                if (_players[i]==user)
                {
                    _players[i] = -1;
                    return;
                }
            }
        }

        private int NumberOfUsers()
        {
            int nr = 0;
            foreach (var el in _players)
            {
                if (el != -1)
                {
                    ++nr;
                }
            }

            return nr;

        }

        private void ShowCardsOnChatBox(object sender, EventArgs e)
        {


            if (_messagesIn.Count != 0)
            {


                string message = _messagesIn.Dequeue();
                string[] messageParts = message.Split(':');
                int player;
                try
                {
                    player = int.Parse(messageParts[0]);
                }
                catch (Exception exception)
                {
                    return;
                }

                if (messageParts.Length == 1)
                    _players[0] = player;
                else
                if (messageParts[1] == "connect" && _players[0] != player)
                {
                    int pos = FindFreeSeat();
                    if (pos != -1)
                        _players[pos] = player;

                }
                else if (messageParts[1] == "disconnect")
                {
                    DisconnectUser(player);
                }
                else
                if (messageParts[1] != "connect")
                {
                    if (player == _players[0])
                        _textBoxCards.Text = messageParts[1] + ":" + messageParts[2];
                    else if (player == _players[1])
                        _textBoxCards2.Text = messageParts[1] + ":" + messageParts[2];
                    if (_textBoxCards.Text != "" && _textBoxCards2.Text != "" && NumberOfUsers() >= 2)
                    {
                        ConcreteHandComparator handComparator = ConcreteHandComparator.GetComparator();
                        int nr = handComparator.CompareHands(_textBoxCards.Text, _textBoxCards2.Text);
                        if (nr == -1)
                            _textBoxWinner.Text = "Winner Player 2";
                        else if (nr == 1)
                            _textBoxWinner.Text = "Winner Player 1";
                    }
                }

            }

            
        }
    }
}
