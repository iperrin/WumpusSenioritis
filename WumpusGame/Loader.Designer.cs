namespace WumpusGame.bin
{
    partial class Loader
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
            this.RunGame = new System.Windows.Forms.Button();
            this.GameControlTester = new System.Windows.Forms.Button();
            this.TriviaTester = new System.Windows.Forms.Button();
            this.CaveTester = new System.Windows.Forms.Button();
            this.HighScoreTester = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RunGame
            // 
            this.RunGame.Location = new System.Drawing.Point(40, 39);
            this.RunGame.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RunGame.Name = "RunGame";
            this.RunGame.Size = new System.Drawing.Size(108, 50);
            this.RunGame.TabIndex = 0;
            this.RunGame.Text = "Run Game";
            this.RunGame.UseVisualStyleBackColor = true;
            this.RunGame.Click += new System.EventHandler(this.button1_Click);
            // 
            // GameControlTester
            // 
            this.GameControlTester.Location = new System.Drawing.Point(40, 117);
            this.GameControlTester.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GameControlTester.Name = "GameControlTester";
            this.GameControlTester.Size = new System.Drawing.Size(108, 50);
            this.GameControlTester.TabIndex = 1;
            this.GameControlTester.Text = "Game Control Test Form";
            this.GameControlTester.UseVisualStyleBackColor = true;
            this.GameControlTester.Click += new System.EventHandler(this.GameControlTester_Click);
            // 
            // TriviaTester
            // 
            this.TriviaTester.Location = new System.Drawing.Point(40, 195);
            this.TriviaTester.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TriviaTester.Name = "TriviaTester";
            this.TriviaTester.Size = new System.Drawing.Size(108, 50);
            this.TriviaTester.TabIndex = 2;
            this.TriviaTester.Text = "Trivia Test Form";
            this.TriviaTester.UseVisualStyleBackColor = true;
            this.TriviaTester.Click += new System.EventHandler(this.TriviaTester_Click);
            // 
            // CaveTester
            // 
            this.CaveTester.Location = new System.Drawing.Point(40, 273);
            this.CaveTester.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CaveTester.Name = "CaveTester";
            this.CaveTester.Size = new System.Drawing.Size(108, 50);
            this.CaveTester.TabIndex = 3;
            this.CaveTester.Text = "Cave Test Form";
            this.CaveTester.UseVisualStyleBackColor = true;
            this.CaveTester.Click += new System.EventHandler(this.CaveTester_Click);
            // 
            // HighScoreTester
            // 
            this.HighScoreTester.Location = new System.Drawing.Point(40, 350);
            this.HighScoreTester.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HighScoreTester.Name = "HighScoreTester";
            this.HighScoreTester.Size = new System.Drawing.Size(108, 50);
            this.HighScoreTester.TabIndex = 5;
            this.HighScoreTester.Text = "High Score Test Form";
            this.HighScoreTester.UseVisualStyleBackColor = true;
            this.HighScoreTester.Click += new System.EventHandler(this.PlayerTester_Click);
            // 
            // Loader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 438);
            this.Controls.Add(this.HighScoreTester);
            this.Controls.Add(this.CaveTester);
            this.Controls.Add(this.TriviaTester);
            this.Controls.Add(this.GameControlTester);
            this.Controls.Add(this.RunGame);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Loader";
            this.Text = "Loader";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RunGame;
        private System.Windows.Forms.Button GameControlTester;
        private System.Windows.Forms.Button TriviaTester;
        private System.Windows.Forms.Button CaveTester;
        private System.Windows.Forms.Button HighScoreTester;
    }
}