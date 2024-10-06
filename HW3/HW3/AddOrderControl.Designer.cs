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
            this.title = new System.Windows.Forms.TextBox();
            this.penguinButton = new System.Windows.Forms.Button();
            this.porkButton = new System.Windows.Forms.Button();
            this.shrimpButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.countTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.title.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.title.Location = new System.Drawing.Point(67, 35);
            this.title.Margin = new System.Windows.Forms.Padding(2);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(391, 22);
            this.title.TabIndex = 0;
            this.title.Text = "輸入完數量後，點選對應的商品按鈕，並點擊送出。";
            this.title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.title.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // penguinButton
            // 
            this.penguinButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.penguinButton.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.penguinButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.penguinButton.Location = new System.Drawing.Point(67, 141);
            this.penguinButton.Margin = new System.Windows.Forms.Padding(2);
            this.penguinButton.Name = "penguinButton";
            this.penguinButton.Size = new System.Drawing.Size(77, 54);
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
            this.porkButton.Location = new System.Drawing.Point(226, 141);
            this.porkButton.Margin = new System.Windows.Forms.Padding(2);
            this.porkButton.Name = "porkButton";
            this.porkButton.Size = new System.Drawing.Size(77, 54);
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
            this.shrimpButton.Location = new System.Drawing.Point(381, 141);
            this.shrimpButton.Margin = new System.Windows.Forms.Padding(2);
            this.shrimpButton.Name = "shrimpButton";
            this.shrimpButton.Size = new System.Drawing.Size(77, 54);
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
            this.submitButton.Location = new System.Drawing.Point(204, 211);
            this.submitButton.Margin = new System.Windows.Forms.Padding(2);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(129, 54);
            this.submitButton.TabIndex = 4;
            this.submitButton.Text = "送出訂單";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // countTextBox
            // 
            this.countTextBox.Location = new System.Drawing.Point(254, 87);
            this.countTextBox.Name = "countTextBox";
            this.countTextBox.Size = new System.Drawing.Size(100, 22);
            this.countTextBox.TabIndex = 5;
            this.countTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(183, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "請輸入數量";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AddOrderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.countTextBox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.shrimpButton);
            this.Controls.Add(this.porkButton);
            this.Controls.Add(this.penguinButton);
            this.Controls.Add(this.title);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddOrderControl";
            this.Size = new System.Drawing.Size(516, 402);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Button penguinButton;
        private System.Windows.Forms.Button porkButton;
        private System.Windows.Forms.Button shrimpButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox countTextBox;
        private System.Windows.Forms.Label label1;
    }
}
