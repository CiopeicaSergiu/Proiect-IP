using Poker.Interfaces;
using System.Media;
using WMPLib;
namespace Poker
{
    partial class StartMenu
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
            this._startMenuLabel = new System.Windows.Forms.Label();
            this._newGameButton = new System.Windows.Forms.Button();
            this._rulesButton = new System.Windows.Forms.Button();
            this._optionsButton = new System.Windows.Forms.Button();
            this._emblemPictureBox = new System.Windows.Forms.PictureBox();
            this._timerMusicBackground = new System.Windows.Forms.Timer(this.components);
            this._exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._emblemPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // _startMenuLabel
            // 
            this._startMenuLabel.AutoSize = true;
            this._startMenuLabel.BackColor = System.Drawing.Color.Transparent;
            this._startMenuLabel.Font = new System.Drawing.Font("Mongolian Baiti", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._startMenuLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this._startMenuLabel.Location = new System.Drawing.Point(256, 9);
            this._startMenuLabel.Name = "_startMenuLabel";
            this._startMenuLabel.Size = new System.Drawing.Size(305, 100);
            this._startMenuLabel.TabIndex = 0;
            this._startMenuLabel.Text = "Poker\r\n5-Cards Draw\r\n";
            this._startMenuLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // _newGameButton
            // 
            this._newGameButton.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._newGameButton.Location = new System.Drawing.Point(55, 137);
            this._newGameButton.Name = "_newGameButton";
            this._newGameButton.Size = new System.Drawing.Size(130, 50);
            this._newGameButton.TabIndex = 1;
            this._newGameButton.Text = "New Game";
            this._newGameButton.UseVisualStyleBackColor = true;
            this._newGameButton.Click += new System.EventHandler(this.NewGame);
            // 
            // _rulesButton
            // 
            this._rulesButton.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._rulesButton.Location = new System.Drawing.Point(55, 243);
            this._rulesButton.Name = "_rulesButton";
            this._rulesButton.Size = new System.Drawing.Size(130, 50);
            this._rulesButton.TabIndex = 2;
            this._rulesButton.Text = "Rules";
            this._rulesButton.UseVisualStyleBackColor = true;
            this._rulesButton.Click += new System.EventHandler(this.Rules);
            // 
            // _optionsButton
            // 
            this._optionsButton.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._optionsButton.Location = new System.Drawing.Point(55, 354);
            this._optionsButton.Name = "_optionsButton";
            this._optionsButton.Size = new System.Drawing.Size(130, 50);
            this._optionsButton.TabIndex = 3;
            this._optionsButton.Text = "Options";
            this._optionsButton.UseVisualStyleBackColor = true;
            this._optionsButton.Click += new System.EventHandler(this.Options);
            // 
            // _emblemPictureBox
            // 
            this._emblemPictureBox.BackColor = System.Drawing.Color.Transparent;
            this._emblemPictureBox.Image = global::Poker.Properties.Resources.Emblem;
            this._emblemPictureBox.Location = new System.Drawing.Point(265, 173);
            this._emblemPictureBox.Name = "_emblemPictureBox";
            this._emblemPictureBox.Size = new System.Drawing.Size(354, 267);
            this._emblemPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._emblemPictureBox.TabIndex = 4;
            this._emblemPictureBox.TabStop = false;
            // 
            // _timerMusicBackground
            // 
            this._timerMusicBackground.Enabled = true;
            this._timerMusicBackground.Interval = 300000;
            this._timerMusicBackground.Tick += new System.EventHandler(this.PlayBackgroundMusic);
            // 
            // _exitButton
            // 
            this._exitButton.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._exitButton.ForeColor = System.Drawing.Color.Black;
            this._exitButton.Location = new System.Drawing.Point(55, 449);
            this._exitButton.Name = "_exitButton";
            this._exitButton.Size = new System.Drawing.Size(130, 50);
            this._exitButton.TabIndex = 5;
            this._exitButton.Text = "Exit";
            this._exitButton.UseVisualStyleBackColor = true;
            this._exitButton.Click += new System.EventHandler(this.ExitGame);
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Poker.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this._exitButton);
            this.Controls.Add(this._emblemPictureBox);
            this.Controls.Add(this._optionsButton);
            this.Controls.Add(this._rulesButton);
            this.Controls.Add(this._newGameButton);
            this.Controls.Add(this._startMenuLabel);
            this.Name = "StartMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartMenu";
            ((System.ComponentModel.ISupportInitialize)(this._emblemPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _startMenuLabel;
        private System.Windows.Forms.Button _newGameButton;
        private System.Windows.Forms.Button _rulesButton;
        private System.Windows.Forms.Button _optionsButton;
        private System.Windows.Forms.PictureBox _emblemPictureBox;
        private IGameStatesFactory _gameStatesFactory= new GameStatesFactory();
        private static WindowsMediaPlayer _windowsMediaPlayer = new WindowsMediaPlayer();
        private System.Windows.Forms.Timer _timerMusicBackground;
        private System.Windows.Forms.Button _exitButton;
    }
}