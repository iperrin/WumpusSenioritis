namespace WumpusGame
{
    partial class GameControlTestForm
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
            this.components = new System.ComponentModel.Container();
            this.Door1 = new System.Windows.Forms.Button();
            this.Door2 = new System.Windows.Forms.Button();
            this.Door3 = new System.Windows.Forms.Button();
            this.Door5 = new System.Windows.Forms.Button();
            this.Door4 = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Door0 = new System.Windows.Forms.Button();
            this.RoomNumber = new System.Windows.Forms.Label();
            this.Question = new System.Windows.Forms.Label();
            this.GetQuestion = new System.Windows.Forms.Button();
            this.GetFact = new System.Windows.Forms.Button();
            this.Fact = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Door1
            // 
            this.Door1.Location = new System.Drawing.Point(1121, 326);
            this.Door1.Name = "Door1";
            this.Door1.Size = new System.Drawing.Size(120, 53);
            this.Door1.TabIndex = 5;
            this.Door1.Text = "Door1";
            this.Door1.UseVisualStyleBackColor = true;
            this.Door1.Click += new System.EventHandler(this.Door1_Click);
            // 
            // Door2
            // 
            this.Door2.Location = new System.Drawing.Point(1121, 529);
            this.Door2.Name = "Door2";
            this.Door2.Size = new System.Drawing.Size(120, 53);
            this.Door2.TabIndex = 6;
            this.Door2.Text = "Door2";
            this.Door2.UseVisualStyleBackColor = true;
            this.Door2.Click += new System.EventHandler(this.Door2_Click);
            // 
            // Door3
            // 
            this.Door3.Location = new System.Drawing.Point(913, 675);
            this.Door3.Name = "Door3";
            this.Door3.Size = new System.Drawing.Size(120, 53);
            this.Door3.TabIndex = 7;
            this.Door3.Text = "Door3";
            this.Door3.UseVisualStyleBackColor = true;
            this.Door3.Click += new System.EventHandler(this.Door3_Click);
            // 
            // Door5
            // 
            this.Door5.Location = new System.Drawing.Point(642, 288);
            this.Door5.Name = "Door5";
            this.Door5.Size = new System.Drawing.Size(120, 53);
            this.Door5.TabIndex = 8;
            this.Door5.Text = "Door5";
            this.Door5.UseVisualStyleBackColor = true;
            this.Door5.Click += new System.EventHandler(this.Door5_Click);
            // 
            // Door4
            // 
            this.Door4.Location = new System.Drawing.Point(642, 529);
            this.Door4.Name = "Door4";
            this.Door4.Size = new System.Drawing.Size(120, 53);
            this.Door4.TabIndex = 9;
            this.Door4.Text = "Door4";
            this.Door4.UseVisualStyleBackColor = true;
            this.Door4.Click += new System.EventHandler(this.Door4_Click);
            // 
            // Door0
            // 
            this.Door0.Location = new System.Drawing.Point(904, 170);
            this.Door0.Name = "Door0";
            this.Door0.Size = new System.Drawing.Size(120, 53);
            this.Door0.TabIndex = 10;
            this.Door0.Text = "Door0";
            this.Door0.UseVisualStyleBackColor = true;
            this.Door0.Click += new System.EventHandler(this.Door0_Click);
            // 
            // RoomNumber
            // 
            this.RoomNumber.AutoSize = true;
            this.RoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.RoomNumber.Location = new System.Drawing.Point(792, 417);
            this.RoomNumber.Name = "RoomNumber";
            this.RoomNumber.Size = new System.Drawing.Size(286, 37);
            this.RoomNumber.TabIndex = 11;
            this.RoomNumber.Text = "Current Room: null";
            this.RoomNumber.Click += new System.EventHandler(this.label1_Click);
            // 
            // Question
            // 
            this.Question.AutoSize = true;
            this.Question.Location = new System.Drawing.Point(120, 308);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(73, 20);
            this.Question.TabIndex = 13;
            this.Question.Text = "Question";
            this.Question.Click += new System.EventHandler(this.Question_Click);
            // 
            // GetQuestion
            // 
            this.GetQuestion.Location = new System.Drawing.Point(124, 222);
            this.GetQuestion.Name = "GetQuestion";
            this.GetQuestion.Size = new System.Drawing.Size(137, 55);
            this.GetQuestion.TabIndex = 14;
            this.GetQuestion.Text = "Get Question";
            this.GetQuestion.UseVisualStyleBackColor = true;
            this.GetQuestion.Click += new System.EventHandler(this.GetQuestion_Click);
            // 
            // GetFact
            // 
            this.GetFact.Location = new System.Drawing.Point(124, 375);
            this.GetFact.Name = "GetFact";
            this.GetFact.Size = new System.Drawing.Size(137, 55);
            this.GetFact.TabIndex = 16;
            this.GetFact.Text = "Get Fact";
            this.GetFact.UseVisualStyleBackColor = true;
            this.GetFact.Click += new System.EventHandler(this.GetFact_Click);
            // 
            // Fact
            // 
            this.Fact.AutoSize = true;
            this.Fact.Location = new System.Drawing.Point(120, 461);
            this.Fact.Name = "Fact";
            this.Fact.Size = new System.Drawing.Size(41, 20);
            this.Fact.TabIndex = 15;
            this.Fact.Text = "Fact";
            this.Fact.Click += new System.EventHandler(this.Fact_Click);
            // 
            // GameControlTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 1063);
            this.Controls.Add(this.GetFact);
            this.Controls.Add(this.Fact);
            this.Controls.Add(this.GetQuestion);
            this.Controls.Add(this.Question);
            this.Controls.Add(this.RoomNumber);
            this.Controls.Add(this.Door0);
            this.Controls.Add(this.Door4);
            this.Controls.Add(this.Door5);
            this.Controls.Add(this.Door3);
            this.Controls.Add(this.Door2);
            this.Controls.Add(this.Door1);
            this.Name = "GameControlTestForm";
            this.Text = "GameControlTestForm";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Door1;
        private System.Windows.Forms.Button Door2;
        private System.Windows.Forms.Button Door3;
        private System.Windows.Forms.Button Door5;
        private System.Windows.Forms.Button Door4;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button Door0;
        private System.Windows.Forms.Label RoomNumber;
        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.Button GetQuestion;
        private System.Windows.Forms.Button GetFact;
        private System.Windows.Forms.Label Fact;
    }
}