namespace TurnBasedRPG
{
    partial class NameInputForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label label1;
        private TextBox textBoxPlayer1;
        private Label label2;
        private TextBox textBoxPlayer2;
        private Button buttonSelectCharacter;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NameInputForm));
            label1 = new Label();
            textBoxPlayer1 = new TextBox();
            label2 = new Label();
            textBoxPlayer2 = new TextBox();
            buttonSelectCharacter = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(101, 99);
            label1.Name = "label1";
            label1.Size = new Size(124, 23);
            label1.TabIndex = 0;
            label1.Text = "Player 1 Name:";
            label1.Click += label1_Click;
            // 
            // textBoxPlayer1
            // 
            textBoxPlayer1.BackColor = Color.FromArgb(192, 255, 255);
            textBoxPlayer1.Location = new Point(101, 122);
            textBoxPlayer1.Name = "textBoxPlayer1";
            textBoxPlayer1.Size = new Size(150, 27);
            textBoxPlayer1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(472, 99);
            label2.Name = "label2";
            label2.Size = new Size(126, 23);
            label2.TabIndex = 2;
            label2.Text = "Player 2 Name:";
            label2.Click += label2_Click;
            // 
            // textBoxPlayer2
            // 
            textBoxPlayer2.BackColor = Color.FromArgb(192, 255, 255);
            textBoxPlayer2.Location = new Point(472, 122);
            textBoxPlayer2.Name = "textBoxPlayer2";
            textBoxPlayer2.Size = new Size(150, 27);
            textBoxPlayer2.TabIndex = 3;
            textBoxPlayer2.TextChanged += textBoxPlayer2_TextChanged;
            // 
            // buttonSelectCharacter
            // 
            buttonSelectCharacter.BackColor = Color.FromArgb(128, 255, 128);
            buttonSelectCharacter.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSelectCharacter.Location = new Point(274, 179);
            buttonSelectCharacter.Name = "buttonSelectCharacter";
            buttonSelectCharacter.Size = new Size(168, 71);
            buttonSelectCharacter.TabIndex = 4;
            buttonSelectCharacter.Text = "Select Character";
            buttonSelectCharacter.UseVisualStyleBackColor = false;
            buttonSelectCharacter.Click += buttonSelectCharacter_Click;
            // 
            // NameInputForm
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(721, 275);
            Controls.Add(label1);
            Controls.Add(textBoxPlayer1);
            Controls.Add(label2);
            Controls.Add(textBoxPlayer2);
            Controls.Add(buttonSelectCharacter);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "NameInputForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Enter Player Names";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
