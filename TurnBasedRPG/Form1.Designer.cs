namespace TurnBasedRPG
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Dispose
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            labelP1Stats = new Label();
            labelP2Stats = new Label();
            labelTurnInfo = new Label();
            buttonAttack = new Button();
            buttonTaunt = new Button();
            buttonDefend = new Button();
            panelP1HPBar = new Panel();
            panelP2HPBar = new Panel();
            pictureBoxPlayer1 = new PictureBox();
            pictureBoxPlayer2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayer1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayer2).BeginInit();
            SuspendLayout();
            // 
            // labelP1Stats
            // 
            labelP1Stats.AutoSize = true;
            labelP1Stats.BackColor = Color.Transparent;
            labelP1Stats.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelP1Stats.ForeColor = Color.White;
            labelP1Stats.Location = new Point(30, 30);
            labelP1Stats.Name = "labelP1Stats";
            labelP1Stats.Size = new Size(134, 23);
            labelP1Stats.TabIndex = 0;
            labelP1Stats.Text = "Player 1 Stats...";
            // 
            // labelP2Stats
            // 
            labelP2Stats.AutoSize = true;
            labelP2Stats.BackColor = Color.Transparent;
            labelP2Stats.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelP2Stats.ForeColor = Color.White;
            labelP2Stats.Location = new Point(601, 30);
            labelP2Stats.Name = "labelP2Stats";
            labelP2Stats.Size = new Size(134, 23);
            labelP2Stats.TabIndex = 1;
            labelP2Stats.Text = "Player 2 Stats...";
            // 
            // labelTurnInfo
            // 
            labelTurnInfo.AutoSize = true;
            labelTurnInfo.BackColor = Color.Transparent;
            labelTurnInfo.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTurnInfo.ForeColor = Color.White;
            labelTurnInfo.Location = new Point(79, 333);
            labelTurnInfo.MaximumSize = new Size(500, 0);
            labelTurnInfo.Name = "labelTurnInfo";
            labelTurnInfo.Size = new Size(187, 21);
            labelTurnInfo.TabIndex = 2;
            labelTurnInfo.Text = "Turn information...";
            labelTurnInfo.Click += labelTurnInfo_Click;
            // 
            // buttonAttack
            // 
            buttonAttack.BackColor = Color.White;
            buttonAttack.BackgroundImage = Properties.Resources.AttackButton;
            buttonAttack.BackgroundImageLayout = ImageLayout.Zoom;
            buttonAttack.Font = new Font("Segoe UI", 10F);
            buttonAttack.Location = new Point(329, 437);
            buttonAttack.Name = "buttonAttack";
            buttonAttack.Size = new Size(176, 64);
            buttonAttack.TabIndex = 3;
            buttonAttack.UseVisualStyleBackColor = false;
            buttonAttack.Click += buttonAttack_Click;
            // 
            // buttonTaunt
            // 
            buttonTaunt.BackColor = Color.White;
            buttonTaunt.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonTaunt.ForeColor = Color.FromArgb(0, 192, 0);
            buttonTaunt.Location = new Point(160, 461);
            buttonTaunt.Name = "buttonTaunt";
            buttonTaunt.Size = new Size(100, 40);
            buttonTaunt.TabIndex = 4;
            buttonTaunt.Text = "Taunt";
            buttonTaunt.UseVisualStyleBackColor = false;
            buttonTaunt.Click += buttonTaunt_Click;
            // 
            // buttonDefend
            // 
            buttonDefend.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonDefend.ForeColor = Color.Blue;
            buttonDefend.Location = new Point(571, 461);
            buttonDefend.Name = "buttonDefend";
            buttonDefend.Size = new Size(100, 40);
            buttonDefend.TabIndex = 5;
            buttonDefend.Text = "Defend";
            buttonDefend.UseVisualStyleBackColor = true;
            buttonDefend.Click += buttonDefend_Click;
            // 
            // panelP1HPBar
            // 
            panelP1HPBar.BackColor = Color.Transparent;
            panelP1HPBar.Location = new Point(30, 52);
            panelP1HPBar.Name = "panelP1HPBar";
            panelP1HPBar.Size = new Size(200, 20);
            panelP1HPBar.TabIndex = 6;
            panelP1HPBar.Paint += panelP1HPBar_Paint;
            // 
            // panelP2HPBar
            // 
            panelP2HPBar.BackColor = Color.Transparent;
            panelP2HPBar.Location = new Point(601, 52);
            panelP2HPBar.Name = "panelP2HPBar";
            panelP2HPBar.Size = new Size(200, 20);
            panelP2HPBar.TabIndex = 7;
            panelP2HPBar.Paint += panelP2HPBar_Paint;
            // 
            // pictureBoxPlayer1
            // 
            pictureBoxPlayer1.AccessibleName = "pictureBoxPlayer1";
            pictureBoxPlayer1.BackColor = Color.Transparent;
            pictureBoxPlayer1.Location = new Point(30, 103);
            pictureBoxPlayer1.Name = "pictureBoxPlayer1";
            pictureBoxPlayer1.Size = new Size(230, 195);
            pictureBoxPlayer1.TabIndex = 8;
            pictureBoxPlayer1.TabStop = false;
            pictureBoxPlayer1.Click += pictureBox1_Click;
            // 
            // pictureBoxPlayer2
            // 
            pictureBoxPlayer2.AccessibleName = "pictureBoxPlayer2";
            pictureBoxPlayer2.BackColor = Color.Transparent;
            pictureBoxPlayer2.Location = new Point(571, 103);
            pictureBoxPlayer2.Name = "pictureBoxPlayer2";
            pictureBoxPlayer2.Size = new Size(230, 195);
            pictureBoxPlayer2.TabIndex = 9;
            pictureBoxPlayer2.TabStop = false;
            pictureBoxPlayer2.Click += pictureBoxPlayer2_Click;
            // 
            // Form1
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(838, 520);
            Controls.Add(pictureBoxPlayer2);
            Controls.Add(pictureBoxPlayer1);
            Controls.Add(panelP2HPBar);
            Controls.Add(panelP1HPBar);
            Controls.Add(buttonDefend);
            Controls.Add(buttonTaunt);
            Controls.Add(buttonAttack);
            Controls.Add(labelTurnInfo);
            Controls.Add(labelP2Stats);
            Controls.Add(labelP1Stats);
            Name = "Form1";
            Text = "Turn-Based RPG";
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayer1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayer2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelP1Stats;
        private System.Windows.Forms.Label labelP2Stats;
        private System.Windows.Forms.Label labelTurnInfo;
        private System.Windows.Forms.Button buttonAttack;
        private System.Windows.Forms.Button buttonTaunt;
        private System.Windows.Forms.Button buttonDefend;
        private Panel panelP1HPBar;
        private Panel panelP2HPBar;
        private PictureBox pictureBoxPlayer1;
        private PictureBox pictureBoxPlayer2;
    }
}
