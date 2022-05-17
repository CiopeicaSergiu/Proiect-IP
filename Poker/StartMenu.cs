using System;
using System.Drawing;
using System.Windows.Forms;
using Poker.Interfaces;

namespace Poker
{
    public partial class StartMenu : Form
    {
        public StartMenu()
        {
            InitializeComponent();

            //_soundPlayer.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "Sounds\\BackgroundMusic.wav";
            //_soundPlayer.Play();


            ChangeVolume(50);
            _windowsMediaPlayer.URL = AppDomain.CurrentDomain.BaseDirectory + "Sounds\\BackgroundMusic2.mp3";
            _windowsMediaPlayer.settings.setMode("loop", true);
            _windowsMediaPlayer.controls.play();
        }

        private void NewGame(object sender, EventArgs e)
        {
            var newGame = _gameStatesFactory.GetGameState("NewGame");
            newGame.Location = this.Location;
            newGame.Size = this.Size;
            Size auxiliarSize = new Size(800, 600);
            ((NewGame)newGame).ChangeElementsPositions(auxiliarSize);
            newGame.StartPosition = FormStartPosition.Manual;
            newGame.FormClosing += delegate { if (this.Size != newGame.Size) 
                                            { Size oldSize = this.Size; this.Size = newGame.Size; ChangeElementsPositions(oldSize); }
                                              this.Location = newGame.Location; this.Show();};
            newGame.Show();
            this.Hide();
        }

        private void Rules(object sender, EventArgs e)
        {
            
        }

        private void Options(object sender, EventArgs e)
        {
            var options = _gameStatesFactory.GetGameState("Options");
            options.Location = this.Location;
            options.Size = this.Size;
            Size auxiliarSize = new Size(800, 600);
            ((Options)options).ChangeElementsPositions(auxiliarSize);
            options.StartPosition = FormStartPosition.Manual;
            options.FormClosing += delegate {
                if (this.Size != options.Size)
                { Size oldSize = this.Size; this.Size =options.Size; ChangeElementsPositions(oldSize); }
                this.Location = options.Location; this.Show();  };
            options.Show();
            this.Hide();
        }

        private void PlayBackgroundMusic(object sender, EventArgs e)
        {
            _windowsMediaPlayer.controls.fastReverse();
        }

        public static void ChangeVolume(int volume)
        {
            _windowsMediaPlayer.settings.volume = volume;//(int)Math.Round(volume / 100.0f);
        }

        private void ChangeElementsPositions(Size oldSize)
        {
            float widthPercent = (float)this.Width / (float)oldSize.Width;
            float heightPercent = (float)this.Height / (float)oldSize.Height;

            //Start Menu Label
            int newX = (int)Math.Round(_startMenuLabel.Location.X * widthPercent);
            int newY = (int)Math.Round(_startMenuLabel.Location.Y * heightPercent);
            
            int newWidth = (int)Math.Round(_startMenuLabel.Size.Width * widthPercent);
            int newHeight = (int)Math.Round(_startMenuLabel.Size.Height * heightPercent);

            _startMenuLabel.Size = new Size(newWidth, newHeight);
            _startMenuLabel.Location = new Point(newX, newY);
            _startMenuLabel.Font = new Font("Mongolian Baiti", heightPercent > widthPercent ? widthPercent * _startMenuLabel.Font.Size : heightPercent * _startMenuLabel.Font.Size);

            //Emblem Picture Box
            newX = (int)Math.Round(_emblemPictureBox.Location.X * widthPercent);
            newY = (int)Math.Round(_emblemPictureBox.Location.Y * heightPercent);

            newWidth = (int)Math.Round(_emblemPictureBox.Size.Width * widthPercent);
            newHeight = (int)Math.Round(_emblemPictureBox.Size.Height * heightPercent);

           _emblemPictureBox.Size = new Size(newWidth, newHeight);
           _emblemPictureBox.Location = new Point(newX, newY);

            //New Game Button
            newX = (int)Math.Round(_newGameButton.Location.X * widthPercent);
            newY = (int)Math.Round(_newGameButton.Location.Y * heightPercent);

            newWidth = (int)Math.Round(_newGameButton.Size.Width * widthPercent);
            newHeight = (int)Math.Round(_newGameButton.Size.Height * heightPercent);

            _newGameButton.Size = new Size(newWidth, newHeight);
            _newGameButton.Location = new Point(newX, newY);
            _newGameButton.Font = new Font("Mongolian Baiti", heightPercent > widthPercent ? widthPercent * _newGameButton.Font.Size : heightPercent * _newGameButton.Font.Size);

            //Rules Button
            newX = (int)Math.Round(_rulesButton.Location.X * widthPercent);
            newY = (int)Math.Round(_rulesButton.Location.Y * heightPercent);

            newWidth = (int)Math.Round(_rulesButton.Size.Width * widthPercent);
            newHeight = (int)Math.Round(_rulesButton.Size.Height * heightPercent);

            _rulesButton.Size = new Size(newWidth, newHeight);
            _rulesButton.Location = new Point(newX, newY);
            _rulesButton.Font = new Font("Mongolian Baiti", heightPercent > widthPercent ? widthPercent * _rulesButton.Font.Size : heightPercent * _rulesButton.Font.Size);

            //Options Button
            newX = (int)Math.Round(_optionsButton.Location.X * widthPercent);
            newY = (int)Math.Round(_optionsButton.Location.Y * heightPercent);

            newWidth = (int)Math.Round(_optionsButton.Size.Width * widthPercent);
            newHeight = (int)Math.Round(_optionsButton.Size.Height * heightPercent);

            _optionsButton.Size = new Size(newWidth, newHeight);
            _optionsButton.Location = new Point(newX, newY);
            _optionsButton.Font = new Font("Mongolian Baiti", heightPercent > widthPercent ? widthPercent * _optionsButton.Font.Size : heightPercent * _optionsButton.Font.Size);

            //Back Button
            newX = (int)Math.Round(_exitButton.Location.X * widthPercent);
            newY = (int)Math.Round(_exitButton.Location.Y * heightPercent);

            newWidth = (int)Math.Round(_exitButton.Size.Width * widthPercent);
            newHeight = (int)Math.Round(_exitButton.Size.Height * heightPercent);

            _exitButton.Size = new Size(newWidth, newHeight);
            _exitButton.Location = new Point(newX, newY);
            _exitButton.Font = new Font("Mongolian Baiti", heightPercent > widthPercent ? widthPercent * _exitButton.Font.Size : heightPercent * _exitButton.Font.Size);
        }

        private void ExitGame(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
