namespace HW4_1
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.button1 = new System.Windows.Forms.Button();
            this.kaiteTextBox = new System.Windows.Forms.TextBox();
            this.listBoxKaite = new System.Windows.Forms.ListBox();
            this.listBoxDouge = new System.Windows.Forms.ListBox();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBoxKaite);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.kaiteTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(750, 374);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "楷特";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listBoxDouge);
            this.tabPage1.Controls.Add(this.submitButton);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(750, 374);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "斗哥";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(12, 327);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(642, 29);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // submitButton
            // 
            this.submitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitButton.Enabled = false;
            this.submitButton.Location = new System.Drawing.Point(660, 327);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 29);
            this.submitButton.TabIndex = 1;
            this.submitButton.Text = "送出";
            this.submitButton.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Location = new System.Drawing.Point(12, 12);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(758, 406);
            this.tabControl2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(662, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "送出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kaiteTextBox
            // 
            this.kaiteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kaiteTextBox.Location = new System.Drawing.Point(14, 325);
            this.kaiteTextBox.Name = "kaiteTextBox";
            this.kaiteTextBox.Size = new System.Drawing.Size(642, 29);
            this.kaiteTextBox.TabIndex = 2;
            // 
            // listBoxKaite
            // 
            this.listBoxKaite.FormattingEnabled = true;
            this.listBoxKaite.ItemHeight = 18;
            this.listBoxKaite.Location = new System.Drawing.Point(14, 14);
            this.listBoxKaite.Name = "listBoxKaite";
            this.listBoxKaite.Size = new System.Drawing.Size(723, 292);
            this.listBoxKaite.TabIndex = 4;
            // 
            // listBoxDouge
            // 
            this.listBoxDouge.FormattingEnabled = true;
            this.listBoxDouge.ItemHeight = 18;
            this.listBoxDouge.Location = new System.Drawing.Point(12, 16);
            this.listBoxDouge.Name = "listBoxDouge";
            this.listBoxDouge.Size = new System.Drawing.Size(723, 292);
            this.listBoxDouge.TabIndex = 5;
            this.listBoxDouge.SelectedIndexChanged += new System.EventHandler(this.listBoxDouge_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox kaiteTextBox;
        private System.Windows.Forms.ListBox listBoxKaite;
        private System.Windows.Forms.ListBox listBoxDouge;
    }
}

