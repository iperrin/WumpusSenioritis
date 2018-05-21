﻿namespace WumpusGame.bin
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
            this.mapTester = new System.Windows.Forms.Button();
            this.PlayerTester = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RunGame
            // 
            this.RunGame.Location = new System.Drawing.Point(60, 60);
            this.RunGame.Name = "RunGame";
            this.RunGame.Size = new System.Drawing.Size(162, 77);
            this.RunGame.TabIndex = 0;
            this.RunGame.Text = "Run Game";
            this.RunGame.UseVisualStyleBackColor = true;
            this.RunGame.Click += new System.EventHandler(this.button1_Click);
            // 
            // GameControlTester
            // 
            this.GameControlTester.Location = new System.Drawing.Point(60, 180);
            this.GameControlTester.Name = "GameControlTester";
            this.GameControlTester.Size = new System.Drawing.Size(162, 77);
            this.GameControlTester.TabIndex = 1;
            this.GameControlTester.Text = "Game Control Test Form";
            this.GameControlTester.UseVisualStyleBackColor = true;
            this.GameControlTester.Click += new System.EventHandler(this.GameControlTester_Click);
            // 
            // TriviaTester
            // 
            this.TriviaTester.Location = new System.Drawing.Point(60, 300);
            this.TriviaTester.Name = "TriviaTester";
            this.TriviaTester.Size = new System.Drawing.Size(162, 77);
            this.TriviaTester.TabIndex = 2;
            this.TriviaTester.Text = "Trivia Test Form";
            this.TriviaTester.UseVisualStyleBackColor = true;
            this.TriviaTester.Click += new System.EventHandler(this.TriviaTester_Click);
            // 
            // CaveTester
            // 
            this.CaveTester.Location = new System.Drawing.Point(60, 420);
            this.CaveTester.Name = "CaveTester";
            this.CaveTester.Size = new System.Drawing.Size(162, 77);
            this.CaveTester.TabIndex = 3;
            this.CaveTester.Text = "Cave Test Form";
            this.CaveTester.UseVisualStyleBackColor = true;
            this.CaveTester.Click += new System.EventHandler(this.CaveTester_Click);
            // 
            // mapTester
            // 
            this.mapTester.Location = new System.Drawing.Point(60, 540);
            this.mapTester.Name = "mapTester";
            this.mapTester.Size = new System.Drawing.Size(162, 77);
            this.mapTester.TabIndex = 4;
            this.mapTester.Text = "Map Test Form";
            this.mapTester.UseVisualStyleBackColor = true;
            this.mapTester.Click += new System.EventHandler(this.mapTester_Click);
            // 
            // PlayerTester
            // 
            this.PlayerTester.Location = new System.Drawing.Point(60, 660);
            this.PlayerTester.Name = "PlayerTester";
            this.PlayerTester.Size = new System.Drawing.Size(162, 77);
            this.PlayerTester.TabIndex = 5;
            this.PlayerTester.Text = "Player Test Form";
            this.PlayerTester.UseVisualStyleBackColor = true;
            this.PlayerTester.Click += new System.EventHandler(this.PlayerTester_Click);
            // 
            // Loader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 842);
            this.Controls.Add(this.PlayerTester);
            this.Controls.Add(this.mapTester);
            this.Controls.Add(this.CaveTester);
            this.Controls.Add(this.TriviaTester);
            this.Controls.Add(this.GameControlTester);
            this.Controls.Add(this.RunGame);
            this.Name = "Loader";
            this.Text = "Loader";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RunGame;
        private System.Windows.Forms.Button GameControlTester;
        private System.Windows.Forms.Button TriviaTester;
        private System.Windows.Forms.Button CaveTester;
        private System.Windows.Forms.Button mapTester;
        private System.Windows.Forms.Button PlayerTester;
    }
}