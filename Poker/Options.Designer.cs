using System.Collections.Generic;
using System.Windows.Forms;

namespace Poker
{
    partial class Options
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
            this._listBoxResolution = new System.Windows.Forms.ListBox();
            this._optionsLabel = new System.Windows.Forms.Label();
            this._soundTrackBar = new System.Windows.Forms.TrackBar();
            this._soundVolumeLabel = new System.Windows.Forms.Label();
            this._backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._soundTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // _listBoxResolution
            // 
            this._listBoxResolution.BackColor = System.Drawing.Color.DarkRed;
            this._listBoxResolution.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._listBoxResolution.ForeColor = System.Drawing.SystemColors.Menu;
            this._listBoxResolution.FormattingEnabled = true;
            this._listBoxResolution.ItemHeight = 29;
            this._listBoxResolution.Location = new System.Drawing.Point(78, 127);
            this._listBoxResolution.Name = "_listBoxResolution";
            this._listBoxResolution.Size = new System.Drawing.Size(229, 207);
            this._listBoxResolution.TabIndex = 1;
            this._listBoxResolution.SelectedIndexChanged += new System.EventHandler(this.ResolutionChanged);
            // 
            // _optionsLabel
            // 
            this._optionsLabel.AutoSize = true;
            this._optionsLabel.BackColor = System.Drawing.Color.Transparent;
            this._optionsLabel.Font = new System.Drawing.Font("Mongolian Baiti", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._optionsLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this._optionsLabel.Location = new System.Drawing.Point(302, 23);
            this._optionsLabel.Name = "_optionsLabel";
            this._optionsLabel.Size = new System.Drawing.Size(181, 50);
            this._optionsLabel.TabIndex = 2;
            this._optionsLabel.Text = "Options";
            // 
            // _soundTrackBar
            // 
            this._soundTrackBar.BackColor = System.Drawing.Color.DarkRed;
            this._soundTrackBar.Location = new System.Drawing.Point(418, 174);
            this._soundTrackBar.Maximum = 100;
            this._soundTrackBar.Name = "_soundTrackBar";
            this._soundTrackBar.Size = new System.Drawing.Size(200, 45);
            this._soundTrackBar.SmallChange = 10;
            this._soundTrackBar.TabIndex = 3;
            this._soundTrackBar.Value = 50;
            this._soundTrackBar.Scroll += new System.EventHandler(this.ChangeVolume);
            // 
            // _soundVolumeLabel
            // 
            this._soundVolumeLabel.AutoSize = true;
            this._soundVolumeLabel.BackColor = System.Drawing.Color.Transparent;
            this._soundVolumeLabel.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._soundVolumeLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this._soundVolumeLabel.Location = new System.Drawing.Point(424, 127);
            this._soundVolumeLabel.Name = "_soundVolumeLabel";
            this._soundVolumeLabel.Size = new System.Drawing.Size(179, 29);
            this._soundVolumeLabel.TabIndex = 4;
            this._soundVolumeLabel.Text = "Sound Volume\r\n";
            // 
            // _backButton
            // 
            this._backButton.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._backButton.Location = new System.Drawing.Point(78, 452);
            this._backButton.Name = "_backButton";
            this._backButton.Size = new System.Drawing.Size(130, 50);
            this._backButton.TabIndex = 5;
            this._backButton.Text = "Back";
            this._backButton.UseVisualStyleBackColor = true;
            this._backButton.Click += new System.EventHandler(this.Back);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Poker.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this._backButton);
            this.Controls.Add(this._soundVolumeLabel);
            this.Controls.Add(this._soundTrackBar);
            this.Controls.Add(this._optionsLabel);
            this.Controls.Add(this._listBoxResolution);
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            ((System.ComponentModel.ISupportInitialize)(this._soundTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private bool _fullScreenFlag=false;
        private List<string> _screenSizes = new List<string> {"800x600", "1280x720"};
        private ListBox _listBoxResolution;
        private Label _optionsLabel;
        private TrackBar _soundTrackBar;
        private Label _soundVolumeLabel;
        private Button _backButton;
    }
}

