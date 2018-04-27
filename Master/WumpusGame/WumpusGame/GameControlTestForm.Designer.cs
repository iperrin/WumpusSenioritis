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
            this.LoadRoom1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Door1
            // 
            this.Door1.Location = new System.Drawing.Point(1317, 467);
            this.Door1.Name = "Door1";
            this.Door1.Size = new System.Drawing.Size(120, 53);
            this.Door1.TabIndex = 5;
            this.Door1.Text = "Door1";
            this.Door1.UseVisualStyleBackColor = true;
            this.Door1.Click += new System.EventHandler(this.Door1_Click);
            // 
            // Door2
            // 
            this.Door2.Location = new System.Drawing.Point(1317, 687);
            this.Door2.Name = "Door2";
            this.Door2.Size = new System.Drawing.Size(120, 53);
            this.Door2.TabIndex = 6;
            this.Door2.Text = "Door2";
            this.Door2.UseVisualStyleBackColor = true;
            this.Door2.Click += new System.EventHandler(this.Door2_Click);
            // 
            // Door3
            // 
            this.Door3.Location = new System.Drawing.Point(1074, 844);
            this.Door3.Name = "Door3";
            this.Door3.Size = new System.Drawing.Size(120, 53);
            this.Door3.TabIndex = 7;
            this.Door3.Text = "Door3";
            this.Door3.UseVisualStyleBackColor = true;
            this.Door3.Click += new System.EventHandler(this.Door3_Click);
            // 
            // Door5
            // 
            this.Door5.Location = new System.Drawing.Point(818, 467);
            this.Door5.Name = "Door5";
            this.Door5.Size = new System.Drawing.Size(120, 53);
            this.Door5.TabIndex = 8;
            this.Door5.Text = "Door5";
            this.Door5.UseVisualStyleBackColor = true;
            this.Door5.Click += new System.EventHandler(this.Door5_Click);
            // 
            // Door4
            // 
            this.Door4.Location = new System.Drawing.Point(818, 687);
            this.Door4.Name = "Door4";
            this.Door4.Size = new System.Drawing.Size(120, 53);
            this.Door4.TabIndex = 9;
            this.Door4.Text = "Door4";
            this.Door4.UseVisualStyleBackColor = true;
            this.Door4.Click += new System.EventHandler(this.Door4_Click);
            // 
            // Door0
            // 
            this.Door0.Location = new System.Drawing.Point(1074, 325);
            this.Door0.Name = "Door0";
            this.Door0.Size = new System.Drawing.Size(120, 53);
            this.Door0.TabIndex = 10;
            this.Door0.Text = "Door0";
            this.Door0.UseVisualStyleBackColor = true;
            this.Door0.Click += new System.EventHandler(this.Door0_Click);
            // 
            // LoadRoom1
            // 
            this.LoadRoom1.Location = new System.Drawing.Point(117, 76);
            this.LoadRoom1.Name = "LoadRoom1";
            this.LoadRoom1.Size = new System.Drawing.Size(142, 53);
            this.LoadRoom1.TabIndex = 11;
            this.LoadRoom1.Text = "Load Room 1";
            this.LoadRoom1.UseVisualStyleBackColor = true;
            this.LoadRoom1.Click += new System.EventHandler(this.LoadRoom1_Click);
            // 
            // GameControlTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1767, 1063);
            this.Controls.Add(this.LoadRoom1);
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

        }

        #endregion
        private System.Windows.Forms.Button Door1;
        private System.Windows.Forms.Button Door2;
        private System.Windows.Forms.Button Door3;
        private System.Windows.Forms.Button Door5;
        private System.Windows.Forms.Button Door4;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button Door0;
        private System.Windows.Forms.Button LoadRoom1;
    }
}