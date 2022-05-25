using PokerGameLogic;
using System.Collections.Generic;
using PokerGameLogic.AbstractClasses;
using PokerGameLogic.Hands;
namespace Poker
{
    partial class NewGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._gameLabel = new System.Windows.Forms.Label();
            this._backButton = new System.Windows.Forms.Button();
            this._textBoxCards = new System.Windows.Forms.TextBox();
            this._showCardsButton = new System.Windows.Forms.Button();
            this._cardPictureBox1 = new System.Windows.Forms.PictureBox();
            this._cardPictureBox2 = new System.Windows.Forms.PictureBox();
            this._cardPictureBox3 = new System.Windows.Forms.PictureBox();
            this._cardPictureBox4 = new System.Windows.Forms.PictureBox();
            this._cardPictureBox5 = new System.Windows.Forms.PictureBox();
            this._timerChatBox = new System.Windows.Forms.Timer(this.components);
            this._textBoxCards2 = new System.Windows.Forms.TextBox();
            this._textBoxWinner = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this._cardPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cardPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cardPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cardPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cardPictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // _gameLabel
            // 
            this._gameLabel.AutoSize = true;
            this._gameLabel.BackColor = System.Drawing.Color.Transparent;
            this._gameLabel.Font = new System.Drawing.Font("Mongolian Baiti", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._gameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this._gameLabel.Location = new System.Drawing.Point(113, 27);
            this._gameLabel.Name = "_gameLabel";
            this._gameLabel.Size = new System.Drawing.Size(562, 50);
            this._gameLabel.TabIndex = 0;
            this._gameLabel.Text = "To do ... (fa jocu sa mearga)";
            // 
            // _backButton
            // 
            this._backButton.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._backButton.Location = new System.Drawing.Point(54, 500);
            this._backButton.Name = "_backButton";
            this._backButton.Size = new System.Drawing.Size(100, 30);
            this._backButton.TabIndex = 1;
            this._backButton.Text = "Back";
            this._backButton.UseVisualStyleBackColor = true;
            this._backButton.Click += new System.EventHandler(this.Back);
            // 
            // _textBoxCards
            // 
            this._textBoxCards.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._textBoxCards.Location = new System.Drawing.Point(629, 336);
            this._textBoxCards.Multiline = true;
            this._textBoxCards.Name = "_textBoxCards";
            this._textBoxCards.Size = new System.Drawing.Size(147, 73);
            this._textBoxCards.TabIndex = 2;
            // 
            // _showCardsButton
            // 
            this._showCardsButton.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._showCardsButton.Location = new System.Drawing.Point(575, 500);
            this._showCardsButton.Name = "_showCardsButton";
            this._showCardsButton.Size = new System.Drawing.Size(100, 30);
            this._showCardsButton.TabIndex = 3;
            this._showCardsButton.Text = "Draw";
            this._showCardsButton.UseVisualStyleBackColor = true;
            this._showCardsButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ShowCards);
            // 
            // _cardPictureBox1
            // 
            this._cardPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this._cardPictureBox1.Location = new System.Drawing.Point(487, 424);
            this._cardPictureBox1.Name = "_cardPictureBox1";
            this._cardPictureBox1.Size = new System.Drawing.Size(53, 70);
            this._cardPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._cardPictureBox1.TabIndex = 4;
            this._cardPictureBox1.TabStop = false;
            this._cardPictureBox1.Click += new System.EventHandler(this.MarkForDiscard1);
            // 
            // _cardPictureBox2
            // 
            this._cardPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this._cardPictureBox2.Location = new System.Drawing.Point(546, 424);
            this._cardPictureBox2.Name = "_cardPictureBox2";
            this._cardPictureBox2.Size = new System.Drawing.Size(53, 70);
            this._cardPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._cardPictureBox2.TabIndex = 5;
            this._cardPictureBox2.TabStop = false;
            this._cardPictureBox2.Click += new System.EventHandler(this.MarkForDiscard2);
            // 
            // _cardPictureBox3
            // 
            this._cardPictureBox3.BackColor = System.Drawing.Color.Transparent;
            this._cardPictureBox3.Location = new System.Drawing.Point(605, 424);
            this._cardPictureBox3.Name = "_cardPictureBox3";
            this._cardPictureBox3.Size = new System.Drawing.Size(53, 70);
            this._cardPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._cardPictureBox3.TabIndex = 6;
            this._cardPictureBox3.TabStop = false;
            this._cardPictureBox3.Click += new System.EventHandler(this.MarkForDiscard3);
            // 
            // _cardPictureBox4
            // 
            this._cardPictureBox4.BackColor = System.Drawing.Color.Transparent;
            this._cardPictureBox4.Location = new System.Drawing.Point(664, 424);
            this._cardPictureBox4.Name = "_cardPictureBox4";
            this._cardPictureBox4.Size = new System.Drawing.Size(53, 70);
            this._cardPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._cardPictureBox4.TabIndex = 7;
            this._cardPictureBox4.TabStop = false;
            this._cardPictureBox4.Click += new System.EventHandler(this.MarkForDiscard4);
            // 
            // _cardPictureBox5
            // 
            this._cardPictureBox5.BackColor = System.Drawing.Color.Transparent;
            this._cardPictureBox5.Location = new System.Drawing.Point(723, 424);
            this._cardPictureBox5.Name = "_cardPictureBox5";
            this._cardPictureBox5.Size = new System.Drawing.Size(53, 70);
            this._cardPictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._cardPictureBox5.TabIndex = 8;
            this._cardPictureBox5.TabStop = false;
            this._cardPictureBox5.Click += new System.EventHandler(this.MarkForDiscard5);
            // 
            // _timerChatBox
            // 
            this._timerChatBox.Enabled = true;
            this._timerChatBox.Tick += new System.EventHandler(this.ShowCardsOnChatBox);
            // 
            // _textBoxCards2
            // 
            this._textBoxCards2.Location = new System.Drawing.Point(12, 120);
            this._textBoxCards2.Multiline = true;
            this._textBoxCards2.Name = "_textBoxCards2";
            this._textBoxCards2.Size = new System.Drawing.Size(142, 74);
            this._textBoxCards2.TabIndex = 9;
            // 
            // _textBoxWinner
            // 
            this._textBoxWinner.BackColor = System.Drawing.Color.IndianRed;
            this._textBoxWinner.Location = new System.Drawing.Point(338, 248);
            this._textBoxWinner.Multiline = true;
            this._textBoxWinner.Name = "_textBoxWinner";
            this._textBoxWinner.Size = new System.Drawing.Size(142, 74);
            this._textBoxWinner.TabIndex = 10;
            // 
            // NewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Poker.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this._textBoxWinner);
            this.Controls.Add(this._textBoxCards2);
            this.Controls.Add(this._cardPictureBox5);
            this.Controls.Add(this._cardPictureBox4);
            this.Controls.Add(this._cardPictureBox3);
            this.Controls.Add(this._cardPictureBox2);
            this.Controls.Add(this._cardPictureBox1);
            this.Controls.Add(this._showCardsButton);
            this.Controls.Add(this._textBoxCards);
            this.Controls.Add(this._backButton);
            this.Controls.Add(this._gameLabel);
            this.Name = "NewGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewGame";
            ((System.ComponentModel.ISupportInitialize)(this._cardPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cardPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cardPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cardPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cardPictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _gameLabel;
        private System.Windows.Forms.Button _backButton;
        private System.Windows.Forms.TextBox _textBoxCards;
        private System.Windows.Forms.Button _showCardsButton;
        private Pack _pack = new Pack(1, 4, 13);
        private System.Windows.Forms.PictureBox _cardPictureBox1;
        private System.Windows.Forms.PictureBox _cardPictureBox2;
        private System.Windows.Forms.PictureBox _cardPictureBox3;
        private System.Windows.Forms.PictureBox _cardPictureBox4;
        private System.Windows.Forms.PictureBox _cardPictureBox5;
        private List<Card> _hand = new List<Card>();//new FullHouse()
        private List<PokerHand> _handRanking = new List<PokerHand> {new HighCard(), new Pair(), new TwoPairs(), new ThreeOfAKind(), new Straight(), new Flush(), new FullHouse(), new FourOfAKind(),new StraightFlush(), new RoyalFlush()};
        private System.Windows.Forms.Timer _timerChatBox;
        private System.Windows.Forms.TextBox _textBoxCards2;
        private System.Windows.Forms.TextBox _textBoxWinner;
    }
}