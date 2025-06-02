namespace TurnBasedRPG
{
    partial class CharacterCustomizationForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelCurrentPlayer;
        private System.Windows.Forms.PictureBox pictureBoxPlayer1;
        private System.Windows.Forms.PictureBox pictureBoxPlayer2;
        private System.Windows.Forms.Button buttonPrevVariant;
        private System.Windows.Forms.Button buttonNextVariant;
        private System.Windows.Forms.Button buttonNextPlayer;
        private System.Windows.Forms.Label labelPlayer1Name;
        private System.Windows.Forms.Label labelPlayer2Name;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterCustomizationForm));
            labelTitle = new Label();
            labelCurrentPlayer = new Label();
            pictureBoxPlayer1 = new PictureBox();
            pictureBoxPlayer2 = new PictureBox();
            buttonPrevVariant = new Button();
            buttonNextVariant = new Button();
            buttonNextPlayer = new Button();
            labelPlayer1Name = new Label();
            labelPlayer2Name = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayer1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayer2).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = Color.FromArgb(192, 255, 192);
            labelTitle.Location = new Point(0, 10);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(800, 40);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Customize Your Character";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelCurrentPlayer
            // 
            labelCurrentPlayer.BackColor = Color.Transparent;
            labelCurrentPlayer.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelCurrentPlayer.ForeColor = Color.White;
            labelCurrentPlayer.Location = new Point(0, 50);
            labelCurrentPlayer.Name = "labelCurrentPlayer";
            labelCurrentPlayer.Size = new Size(800, 30);
            labelCurrentPlayer.TabIndex = 1;
            labelCurrentPlayer.Text = "Current: Player1";
            labelCurrentPlayer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBoxPlayer1
            // 
            pictureBoxPlayer1.BackColor = Color.Transparent;
            pictureBoxPlayer1.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxPlayer1.Location = new Point(100, 110);
            pictureBoxPlayer1.Name = "pictureBoxPlayer1";
            pictureBoxPlayer1.Size = new Size(200, 300);
            pictureBoxPlayer1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPlayer1.TabIndex = 4;
            pictureBoxPlayer1.TabStop = false;
            // 
            // pictureBoxPlayer2
            // 
            pictureBoxPlayer2.BackColor = Color.Transparent;
            pictureBoxPlayer2.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxPlayer2.Location = new Point(500, 110);
            pictureBoxPlayer2.Name = "pictureBoxPlayer2";
            pictureBoxPlayer2.Size = new Size(200, 300);
            pictureBoxPlayer2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPlayer2.TabIndex = 5;
            pictureBoxPlayer2.TabStop = false;
            // 
            // buttonPrevVariant
            // 
            buttonPrevVariant.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonPrevVariant.Location = new Point(250, 430);
            buttonPrevVariant.Name = "buttonPrevVariant";
            buttonPrevVariant.Size = new Size(75, 40);
            buttonPrevVariant.TabIndex = 6;
            buttonPrevVariant.Text = "◀";
            buttonPrevVariant.Click += buttonPrevVariant_Click;
            // 
            // buttonNextVariant
            // 
            buttonNextVariant.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonNextVariant.Location = new Point(475, 430);
            buttonNextVariant.Name = "buttonNextVariant";
            buttonNextVariant.Size = new Size(75, 40);
            buttonNextVariant.TabIndex = 7;
            buttonNextVariant.Text = "▶";
            buttonNextVariant.Click += buttonNextVariant_Click;
            // 
            // buttonNextPlayer
            // 
            buttonNextPlayer.BackColor = Color.FromArgb(128, 255, 128);
            buttonNextPlayer.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonNextPlayer.ForeColor = Color.Green;
            buttonNextPlayer.Location = new Point(292, 493);
            buttonNextPlayer.Name = "buttonNextPlayer";
            buttonNextPlayer.Size = new Size(209, 45);
            buttonNextPlayer.TabIndex = 8;
            buttonNextPlayer.Text = "Next Player";
            buttonNextPlayer.UseVisualStyleBackColor = false;
            buttonNextPlayer.Click += buttonNextPlayer_Click;
            // 
            // labelPlayer1Name
            // 
            labelPlayer1Name.BackColor = Color.Transparent;
            labelPlayer1Name.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPlayer1Name.ForeColor = Color.White;
            labelPlayer1Name.Location = new Point(150, 80);
            labelPlayer1Name.Name = "labelPlayer1Name";
            labelPlayer1Name.Size = new Size(100, 20);
            labelPlayer1Name.TabIndex = 2;
            labelPlayer1Name.Text = "Player 1";
            labelPlayer1Name.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelPlayer2Name
            // 
            labelPlayer2Name.BackColor = Color.Transparent;
            labelPlayer2Name.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPlayer2Name.ForeColor = Color.White;
            labelPlayer2Name.Location = new Point(550, 80);
            labelPlayer2Name.Name = "labelPlayer2Name";
            labelPlayer2Name.Size = new Size(100, 20);
            labelPlayer2Name.TabIndex = 3;
            labelPlayer2Name.Text = "Player 2";
            labelPlayer2Name.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CharacterCustomizationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 550);
            Controls.Add(labelTitle);
            Controls.Add(labelCurrentPlayer);
            Controls.Add(labelPlayer1Name);
            Controls.Add(labelPlayer2Name);
            Controls.Add(pictureBoxPlayer1);
            Controls.Add(pictureBoxPlayer2);
            Controls.Add(buttonPrevVariant);
            Controls.Add(buttonNextVariant);
            Controls.Add(buttonNextPlayer);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "CharacterCustomizationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Character Customization";
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayer1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayer2).EndInit();
            ResumeLayout(false);
        }
    }
}