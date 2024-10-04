namespace HW3
{
    partial class AddOrderControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.penguinButton = new System.Windows.Forms.Button();
            this.porkButton = new System.Windows.Forms.Button();
            this.shrimpButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox1.Location = new System.Drawing.Point(100, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(585, 29);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "輸入完數量後，點選對應的商品按鈕，並點擊送出。";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // penguinButton
            // 
            this.penguinButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.penguinButton.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.penguinButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.penguinButton.Location = new System.Drawing.Point(100, 137);
            this.penguinButton.Name = "penguinButton";
            this.penguinButton.Size = new System.Drawing.Size(115, 81);
            this.penguinButton.TabIndex = 1;
            this.penguinButton.Text = "企鵝";
            this.penguinButton.UseVisualStyleBackColor = false;
            this.penguinButton.Click += new System.EventHandler(this.penguinButton_Click);
            // 
            // porkButton
            // 
            this.porkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.porkButton.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.porkButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.porkButton.Location = new System.Drawing.Point(340, 137);
            this.porkButton.Name = "porkButton";
            this.porkButton.Size = new System.Drawing.Size(115, 81);
            this.porkButton.TabIndex = 2;
            this.porkButton.Text = "炸豬排";
            this.porkButton.UseVisualStyleBackColor = false;
            this.porkButton.Click += new System.EventHandler(this.porkButton_Click);
            // 
            // shrimpButton
            // 
            this.shrimpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.shrimpButton.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.shrimpButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.shrimpButton.Location = new System.Drawing.Point(570, 137);
            this.shrimpButton.Name = "shrimpButton";
            this.shrimpButton.Size = new System.Drawing.Size(115, 81);
            this.shrimpButton.TabIndex = 3;
            this.shrimpButton.Text = "炸蝦";
            this.shrimpButton.UseVisualStyleBackColor = false;
            this.shrimpButton.Click += new System.EventHandler(this.shrimpButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.submitButton.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.submitButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.submitButton.Location = new System.Drawing.Point(302, 276);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(193, 81);
            this.submitButton.TabIndex = 4;
            this.submitButton.Text = "送出訂單";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // AddOrderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.shrimpButton);
            this.Controls.Add(this.porkButton);
            this.Controls.Add(this.penguinButton);
            this.Controls.Add(this.textBox1);
            this.Name = "AddOrderControl";
            this.Size = new System.Drawing.Size(790, 442);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button penguinButton;
        private System.Windows.Forms.Button porkButton;
        private System.Windows.Forms.Button shrimpButton;
        private System.Windows.Forms.Button submitButton;
    }
}
