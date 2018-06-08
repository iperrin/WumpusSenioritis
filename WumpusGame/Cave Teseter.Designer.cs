namespace WumpusTest
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // ConstructorButton
            // 
            this.ConstructorButton.AccessibleName = "ConstructorButton";
            this.ConstructorButton.Location = new System.Drawing.Point(38, 65);
            this.ConstructorButton.Name = "ConstructorButton";
            this.ConstructorButton.Size = new System.Drawing.Size(108, 42);
            this.ConstructorButton.TabIndex = 0;
            this.ConstructorButton.Text = "ConstructorButton";
            this.ConstructorButton.UseVisualStyleBackColor = true;
            this.ConstructorButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 297);
            this.Controls.Add(this.ConstructorButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ConstructorButton;
    }
}

