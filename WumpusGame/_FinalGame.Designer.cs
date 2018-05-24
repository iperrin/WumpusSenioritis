namespace WumpusGame
{
    partial class _FinalGame
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
            this.background = new System.Windows.Forms.PictureBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.cave1 = new System.Windows.Forms.Button();
            this.cave2 = new System.Windows.Forms.Button();
            this.cave3 = new System.Windows.Forms.Button();
            this.cave4 = new System.Windows.Forms.Button();
            this.cave5 = new System.Windows.Forms.Button();
            this.MainMenu = new System.Windows.Forms.Button();
            this.Turns = new System.Windows.Forms.Label();
            this.Coins = new System.Windows.Forms.Label();
            this.Arrows = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.ScoreBoard = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(1900, 1025);
            this.background.TabIndex = 0;
            this.background.TabStop = false;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(860, 600);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(200, 100);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // cave1
            // 
            this.cave1.Location = new System.Drawing.Point(158, 817);
            this.cave1.Name = "cave1";
            this.cave1.Size = new System.Drawing.Size(120, 60);
            this.cave1.TabIndex = 2;
            this.cave1.Text = "Cave 1";
            this.cave1.UseVisualStyleBackColor = true;
            this.cave1.Click += new System.EventHandler(this.cave1_Click);
            // 
            // cave2
            // 
            this.cave2.Location = new System.Drawing.Point(508, 817);
            this.cave2.Name = "cave2";
            this.cave2.Size = new System.Drawing.Size(120, 60);
            this.cave2.TabIndex = 3;
            this.cave2.Text = "Cave 2";
            this.cave2.UseVisualStyleBackColor = true;
            this.cave2.Click += new System.EventHandler(this.cave2_Click);
            // 
            // cave3
            // 
            this.cave3.Location = new System.Drawing.Point(890, 817);
            this.cave3.Name = "cave3";
            this.cave3.Size = new System.Drawing.Size(120, 60);
            this.cave3.TabIndex = 4;
            this.cave3.Text = "Cave 3";
            this.cave3.UseVisualStyleBackColor = true;
            this.cave3.Click += new System.EventHandler(this.cave3_Click);
            // 
            // cave4
            // 
            this.cave4.Location = new System.Drawing.Point(1252, 817);
            this.cave4.Name = "cave4";
            this.cave4.Size = new System.Drawing.Size(120, 60);
            this.cave4.TabIndex = 5;
            this.cave4.Text = "Cave 4";
            this.cave4.UseVisualStyleBackColor = true;
            this.cave4.Click += new System.EventHandler(this.cave4_Click);
            // 
            // cave5
            // 
            this.cave5.Location = new System.Drawing.Point(1636, 817);
            this.cave5.Name = "cave5";
            this.cave5.Size = new System.Drawing.Size(120, 60);
            this.cave5.TabIndex = 6;
            this.cave5.Text = "Cave 5";
            this.cave5.UseVisualStyleBackColor = true;
            this.cave5.Click += new System.EventHandler(this.cave5_Click);
            // 
            // MainMenu
            // 
            this.MainMenu.Location = new System.Drawing.Point(12, 12);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(63, 52);
            this.MainMenu.TabIndex = 7;
            this.MainMenu.Text = "Main Menu";
            this.MainMenu.UseVisualStyleBackColor = true;
            this.MainMenu.Click += new System.EventHandler(this.MainMenu_Click);
            // 
            // Turns
            // 
            this.Turns.AutoSize = true;
            this.Turns.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Turns.Location = new System.Drawing.Point(472, 651);
            this.Turns.Name = "Turns";
            this.Turns.Size = new System.Drawing.Size(51, 55);
            this.Turns.TabIndex = 14;
            this.Turns.Text = "0";
            // 
            // Coins
            // 
            this.Coins.AutoSize = true;
            this.Coins.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Coins.Location = new System.Drawing.Point(472, 782);
            this.Coins.Name = "Coins";
            this.Coins.Size = new System.Drawing.Size(51, 55);
            this.Coins.TabIndex = 15;
            this.Coins.Text = "0";
            // 
            // Arrows
            // 
            this.Arrows.AutoSize = true;
            this.Arrows.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Arrows.Location = new System.Drawing.Point(472, 911);
            this.Arrows.Name = "Arrows";
            this.Arrows.Size = new System.Drawing.Size(51, 55);
            this.Arrows.TabIndex = 16;
            this.Arrows.Text = "0";
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(1808, 962);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(80, 51);
            this.Exit.TabIndex = 19;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // ScoreBoard
            // 
            this.ScoreBoard.Location = new System.Drawing.Point(87, 191);
            this.ScoreBoard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ScoreBoard.Multiline = true;
            this.ScoreBoard.Name = "ScoreBoard";
            this.ScoreBoard.ReadOnly = true;
            this.ScoreBoard.Size = new System.Drawing.Size(1178, 242);
            this.ScoreBoard.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1397, 172);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 160);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(1397, 514);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 160);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // _FinalGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1025);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ScoreBoard);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Arrows);
            this.Controls.Add(this.Coins);
            this.Controls.Add(this.Turns);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.cave5);
            this.Controls.Add(this.cave4);
            this.Controls.Add(this.cave3);
            this.Controls.Add(this.cave2);
            this.Controls.Add(this.cave1);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.background);
            this.Name = "_FinalGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wumpus - Senioritis";
            this.Load += new System.EventHandler(this._FinalGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button cave1;
        private System.Windows.Forms.Button cave2;
        private System.Windows.Forms.Button cave3;
        private System.Windows.Forms.Button cave4;
        private System.Windows.Forms.Button cave5;
        private System.Windows.Forms.Button MainMenu;
        private System.Windows.Forms.Label Turns;
        private System.Windows.Forms.Label Coins;
        private System.Windows.Forms.Label Arrows;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox ScoreBoard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}