namespace WumpusGame
{
    partial class GameControlTest
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
            this.GameConstructor = new System.Windows.Forms.Button();
            this.Difficulty = new System.Windows.Forms.TextBox();
            this.PlayerUpdate = new System.Windows.Forms.Button();
            this.PlayerInfo = new System.Windows.Forms.Label();
            this.DifTitle = new System.Windows.Forms.Label();
            this.SaveFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GameConstructor
            // 
            this.GameConstructor.Location = new System.Drawing.Point(76, 79);
            this.GameConstructor.Name = "GameConstructor";
            this.GameConstructor.Size = new System.Drawing.Size(149, 67);
            this.GameConstructor.TabIndex = 0;
            this.GameConstructor.Text = "GameConstructor";
            this.GameConstructor.UseVisualStyleBackColor = true;
            this.GameConstructor.Click += new System.EventHandler(this.GameConstructor_Click_1);
            // 
            // Difficulty
            // 
            this.Difficulty.Location = new System.Drawing.Point(270, 99);
            this.Difficulty.Name = "Difficulty";
            this.Difficulty.Size = new System.Drawing.Size(100, 26);
            this.Difficulty.TabIndex = 1;
            this.Difficulty.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PlayerUpdate
            // 
            this.PlayerUpdate.Location = new System.Drawing.Point(76, 192);
            this.PlayerUpdate.Name = "PlayerUpdate";
            this.PlayerUpdate.Size = new System.Drawing.Size(149, 72);
            this.PlayerUpdate.TabIndex = 2;
            this.PlayerUpdate.Text = "PlayerUpdate";
            this.PlayerUpdate.UseVisualStyleBackColor = true;
            this.PlayerUpdate.Click += new System.EventHandler(this.PlayerUpdate_Click);
            // 
            // PlayerInfo
            // 
            this.PlayerInfo.AutoSize = true;
            this.PlayerInfo.Location = new System.Drawing.Point(270, 218);
            this.PlayerInfo.Name = "PlayerInfo";
            this.PlayerInfo.Size = new System.Drawing.Size(84, 20);
            this.PlayerInfo.TabIndex = 3;
            this.PlayerInfo.Text = "Player Info";
            this.PlayerInfo.Click += new System.EventHandler(this.PlayerInfo_Click);
            // 
            // DifTitle
            // 
            this.DifTitle.AutoSize = true;
            this.DifTitle.Location = new System.Drawing.Point(270, 73);
            this.DifTitle.Name = "DifTitle";
            this.DifTitle.Size = new System.Drawing.Size(69, 20);
            this.DifTitle.TabIndex = 4;
            this.DifTitle.Text = "Difficulty";
            this.DifTitle.Click += new System.EventHandler(this.label2_Click);
            // 
            // SaveFile
            // 
            this.SaveFile.Location = new System.Drawing.Point(818, 451);
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(149, 72);
            this.SaveFile.TabIndex = 5;
            this.SaveFile.Text = "SaveFile";
            this.SaveFile.UseVisualStyleBackColor = true;
            this.SaveFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // AAGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 573);
            this.Controls.Add(this.SaveFile);
            this.Controls.Add(this.DifTitle);
            this.Controls.Add(this.PlayerInfo);
            this.Controls.Add(this.PlayerUpdate);
            this.Controls.Add(this.Difficulty);
            this.Controls.Add(this.GameConstructor);
            this.Name = "AAGame";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GameConstructor;
        private System.Windows.Forms.TextBox Difficulty;
        private System.Windows.Forms.Button PlayerUpdate;
        private System.Windows.Forms.Label PlayerInfo;
        private System.Windows.Forms.Label DifTitle;
        private System.Windows.Forms.Button SaveFile;
    }
}

