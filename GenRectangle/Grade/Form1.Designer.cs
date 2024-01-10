namespace Grade
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
            this.label1 = new System.Windows.Forms.Label();
            this.midterm = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.finalu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input Midterm Score";
            // 
            // midterm
            // 
            this.midterm.Location = new System.Drawing.Point(172, 40);
            this.midterm.Name = "midterm";
            this.midterm.Size = new System.Drawing.Size(131, 22);
            this.midterm.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Your Grade";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // finalu
            // 
            this.finalu.Location = new System.Drawing.Point(172, 81);
            this.finalu.Name = "finalu";
            this.finalu.Size = new System.Drawing.Size(131, 22);
            this.finalu.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Input Final Score";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 170);
            this.Controls.Add(this.finalu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.midterm);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox midterm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox finalu;
        private System.Windows.Forms.Label label2;
    }
}

