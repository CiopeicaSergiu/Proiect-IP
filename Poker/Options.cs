using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poker
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
            _listBoxResolution.Items.Add("800x600");
            _listBoxResolution.Items.Add("1280x720");
            _listBoxResolution.Items.Add("FullScreen");
        }

        private void GoFullscreen()
        {
            if (!_fullScreenFlag)
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.Bounds = Screen.PrimaryScreen.Bounds;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            }
            _fullScreenFlag = !_fullScreenFlag;
        }


        private void ResolutionChanged(object sender, EventArgs e)
        {
            Size oldSize;
            switch (_listBoxResolution.SelectedItem.ToString())
            {
                case "800x600":
                    if (_fullScreenFlag)
                        GoFullscreen();
                    oldSize = this.Size;
                    this.Size = new Size(800, 600);
                    ChangeElementsPositions(oldSize);
                    break;
                case "1280x720":
                    if (_fullScreenFlag)
                        GoFullscreen();
                    oldSize = this.Size;
                    this.Size = new Size(1280, 720);
                    ChangeElementsPositions(oldSize);
                    break;
                case "FullScreen":
                    oldSize = this.Size;
                    GoFullscreen();
                    ChangeElementsPositions(oldSize);
                    break;
                default:
                    if (_fullScreenFlag)
                        GoFullscreen();
                    oldSize = this.Size;
                    this.Size = new Size(800, 600);
                    ChangeElementsPositions(oldSize);
                    break;

            }

        }

        private void ChangeVolume(object sender, EventArgs e)
        {
            StartMenu.ChangeVolume(_soundTrackBar.Value);
        }

        public void ChangeElementsPositions(Size oldSize)
        {
            float widthPercent = (float)this.Width /(float) oldSize.Width;
            float heightPercent = (float)this.Height / (float)oldSize.Height;
            
            //Label Options
            int newX = (int)Math.Round(_optionsLabel.Location.X * widthPercent);
            int newY = (int)Math.Round(_optionsLabel.Location.Y * heightPercent);

            int newWidth = (int)Math.Round(_optionsLabel.Size.Width*widthPercent);
            int newHeight = (int)Math.Round(_optionsLabel.Size.Height * heightPercent);

            _optionsLabel.Size = new Size(newWidth, newHeight);
            _optionsLabel.Location = new Point(newX, newY);
            _optionsLabel.Font = new Font("Mongolian Baiti", heightPercent > widthPercent ? widthPercent * _optionsLabel.Font.Size : heightPercent * _optionsLabel.Font.Size);

            //Listbox Resolution
            newX = (int)Math.Round(_listBoxResolution.Location.X * widthPercent);
            newY = (int)Math.Round(_listBoxResolution.Location.Y * heightPercent);

            newWidth = (int)Math.Round(_listBoxResolution.Size.Width * widthPercent);
            newHeight = (int)Math.Round(_listBoxResolution.Size.Height * heightPercent);

            _listBoxResolution.Size = new Size(newWidth, newHeight);
            _listBoxResolution.Location = new Point(newX, newY);
            _listBoxResolution.Font = new Font("Mongolian Baiti", heightPercent > widthPercent ? widthPercent * _listBoxResolution.Font.Size : heightPercent * _listBoxResolution.Font.Size);

            //Label Sound Volume
            newX = (int)Math.Round(_soundVolumeLabel.Location.X * widthPercent);
            newY = (int)Math.Round(_soundVolumeLabel.Location.Y * heightPercent);

            newWidth = (int)Math.Round(_soundVolumeLabel.Size.Width * widthPercent);
            newHeight = (int)Math.Round(_soundVolumeLabel.Size.Height * heightPercent);

            _soundVolumeLabel.Size = new Size(newWidth, newHeight);
            _soundVolumeLabel.Location = new Point(newX, newY);
            _soundVolumeLabel.Font = new Font("Mongolian Baiti", heightPercent > widthPercent ? widthPercent * _soundVolumeLabel.Font.Size : heightPercent * _soundVolumeLabel.Font.Size);

            //Volume Tracker
            newX = (int)Math.Round(_soundTrackBar.Location.X * widthPercent);
            newY = (int)Math.Round(_soundTrackBar.Location.Y * heightPercent);

            newWidth = (int)Math.Round(_soundTrackBar.Size.Width * widthPercent);
            newHeight = (int)Math.Round(_soundTrackBar.Size.Height * heightPercent);

            _soundTrackBar.Size = new Size(newWidth, newHeight);
            _soundTrackBar.Location = new Point(newX, newY);

            //Back Button
            newX = (int)Math.Round(_backButton.Location.X * widthPercent);
            newY = (int)Math.Round(_backButton.Location.Y * heightPercent);

            newWidth = (int)Math.Round(_backButton.Size.Width * widthPercent);
            newHeight = (int)Math.Round(_backButton.Size.Height * heightPercent);

            _backButton.Size = new Size(newWidth, newHeight);
            _backButton.Location = new Point(newX, newY);
        }

        private void Back(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
