namespace HW3
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
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.maskedTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.maskedTextBox1.Location = new System.Drawing.Point(170, 109);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.ReadOnly = true;
            this.maskedTextBox1.Size = new System.Drawing.Size(440, 36);
            this.maskedTextBox1.TabIndex = 0;
            this.maskedTextBox1.Text = "歡迎來到角落生物商店！";
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.button1.Location = new System.Drawing.Point(282, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 66);
            this.button1.TabIndex = 1;
            this.button1.Text = "開店！";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(782, 491);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.maskedTextBox1);
            this.Font = new System.Drawing.Font("PMingLiU", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button button1;
    }
}

