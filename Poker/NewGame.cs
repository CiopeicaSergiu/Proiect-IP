using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using PokerGameLogic;
using SocketsComunication;
namespace Poker
{
    public partial class NewGame : Form
    {
        private Client _client = null;
        private Queue<string> _messagesIn = new Queue<string>();
        private Queue<string> _messagesOut = new Queue<string>();
        public NewGame()
        {
            InitializeComponent();
            _client = new Client(_messagesIn, _messagesOut);
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

        }

        private void ShowCards(object sender, MouseEventArgs e)
        {
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
            _messagesOut.Enqueue(_handRanking[j].RankingToString());
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
                _cardPictureBox1.BackColor = Color.Black;
                _cardPictureBox1.Image = null;
                
            }
            else if (_hand.Count > 0)
                {
                    _cardPictureBox1.BackColor = Color.Transparent;
                    _cardPictureBox1.Image = _hand[0].Bitmap;
                }

            
            _cardPictureBox1.Update();
        }

        private void MarkForDiscard2(object sender, EventArgs e)
        {
            if (_cardPictureBox2.Image != null)
            {
                _cardPictureBox2.BackColor = Color.Black;
                _cardPictureBox2.Image = null;
            }
            else if (_hand.Count > 0)
                {
                    _cardPictureBox2.BackColor = Color.Transparent;
                    _cardPictureBox2.Image = _hand[1].Bitmap;
                    
                }
            _cardPictureBox2.Update();
        }

        private void MarkForDiscard3(object sender, EventArgs e)
        {
            if (_cardPictureBox3.Image != null)
            {
                _cardPictureBox3.BackColor = Color.Black;
                _cardPictureBox3.Image = null;
            }
            else if (_hand.Count > 0)
                {
                    _cardPictureBox3.BackColor = Color.Transparent;
                    _cardPictureBox3.Image = _hand[2].Bitmap;
                    
                }
            _cardPictureBox3.Update();

        }

        private void MarkForDiscard4(object sender, EventArgs e)
        {
            if (_cardPictureBox4.Image != null)
            {
                _cardPictureBox4.BackColor = Color.Black;
                _cardPictureBox4.Image = null;
            }
            else if (_hand.Count > 0)
                {
                    _cardPictureBox4.BackColor = Color.Transparent;
                    _cardPictureBox4.Image = _hand[3].Bitmap;
                    
                }
            _cardPictureBox4.Update();

        }

        private void MarkForDiscard5(object sender, EventArgs e)
        {
            if (_cardPictureBox5.Image != null)
            {
                _cardPictureBox5.BackColor = Color.Black;
                _cardPictureBox5.Image = null;
            }
            else if (_hand.Count > 0)
            {
                _cardPictureBox5.BackColor = Color.Transparent;
                _cardPictureBox5.Image = _hand[4].Bitmap;
                    
            }
            _cardPictureBox5.Update();
        }

        private void ShowCardsOnChatBox(object sender, EventArgs e)
        {
            string message = _messagesIn.Dequeue();
            string[] messageParts = message.Split(':');
            int player = int.Parse(messageParts[0]);
            switch (player)
            {
                case 1:
                    _textBoxCards.Text = messageParts[1];
                    break;
                case 2:
                    _textBoxCards2.Text = messageParts[1];
                    break;

            }
            
        }
    }
}
