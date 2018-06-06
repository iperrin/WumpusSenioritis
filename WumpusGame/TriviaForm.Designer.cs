namespace WumpusTest
{
  partial class TriviaForm
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
            this.ConstructorButton = new System.Windows.Forms.Button();
            this.nextfact = new System.Windows.Forms.Button();
            this.nextanswer = new System.Windows.Forms.Button();
            this.correctanswer = new System.Windows.Forms.Button();
            this.secret = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ConstructorButton
            // 
            this.ConstructorButton.Location = new System.Drawing.Point(37, 34);
            this.ConstructorButton.Name = "ConstructorButton";
            this.ConstructorButton.Size = new System.Drawing.Size(130, 35);
            this.ConstructorButton.TabIndex = 0;
            this.ConstructorButton.Text = "ConstructorButton";
            this.ConstructorButton.UseVisualStyleBackColor = true;
            this.ConstructorButton.Click += new System.EventHandler(this.constructor);
            // 
            // nextfact
            // 
            this.nextfact.Location = new System.Drawing.Point(37, 76);
            this.nextfact.Name = "nextfact";
            this.nextfact.Size = new System.Drawing.Size(130, 23);
            this.nextfact.TabIndex = 1;
            this.nextfact.Text = "GetNextFact";
            this.nextfact.UseVisualStyleBackColor = true;
            this.nextfact.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // nextanswer
            // 
            this.nextanswer.Location = new System.Drawing.Point(37, 106);
            this.nextanswer.Name = "nextanswer";
            this.nextanswer.Size = new System.Drawing.Size(130, 23);
            this.nextanswer.TabIndex = 2;
            this.nextanswer.Text = "GetNextQuestion";
            this.nextanswer.UseVisualStyleBackColor = true;
            this.nextanswer.Click += new System.EventHandler(this.button2_Click);
            // 
            // correctanswer
            // 
            this.correctanswer.Location = new System.Drawing.Point(37, 136);
            this.correctanswer.Name = "correctanswer";
            this.correctanswer.Size = new System.Drawing.Size(130, 23);
            this.correctanswer.TabIndex = 3;
            this.correctanswer.Text = "CorrectAnswer";
            this.correctanswer.UseVisualStyleBackColor = true;
            this.correctanswer.Click += new System.EventHandler(this.button3_Click);
            // 
            // secret
            // 
            this.secret.Location = new System.Drawing.Point(37, 166);
            this.secret.Name = "secret";
            this.secret.Size = new System.Drawing.Size(130, 23);
            this.secret.TabIndex = 4;
            this.secret.Text = "GetSecret";
            this.secret.UseVisualStyleBackColor = true;
            this.secret.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(174, 137);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(71, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(177, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "label5";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(37, 224);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "IsWrongAnswersEmpty";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(177, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "label7";
            // 
            // TriviaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 261);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.secret);
            this.Controls.Add(this.correctanswer);
            this.Controls.Add(this.nextanswer);
            this.Controls.Add(this.nextfact);
            this.Controls.Add(this.ConstructorButton);
            this.Name = "TriviaForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button ConstructorButton;
    private System.Windows.Forms.Button nextfact;
    private System.Windows.Forms.Button nextanswer;
    private System.Windows.Forms.Button correctanswer;
    private System.Windows.Forms.Button secret;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Label label7;
  }
}

