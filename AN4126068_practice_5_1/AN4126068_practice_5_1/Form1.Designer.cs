namespace HW5_1
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
            this.startPanel = new System.Windows.Forms.Panel();
            this.startButton = new System.Windows.Forms.Button();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.score = new System.Windows.Forms.Label();
            this.fruit = new System.Windows.Forms.PictureBox();
            this.plate = new System.Windows.Forms.PictureBox();
            this.startPanel.SuspendLayout();
            this.gamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fruit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plate)).BeginInit();
            this.SuspendLayout();
            // 
            // startPanel
            // 
            this.startPanel.Controls.Add(this.startButton);
            this.startPanel.Location = new System.Drawing.Point(10, 17);
            this.startPanel.Name = "startPanel";
            this.startPanel.Size = new System.Drawing.Size(772, 416);
            this.startPanel.TabIndex = 0;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(220, 164);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(326, 119);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start Game";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click_1);
            // 
            // gamePanel
            // 
            this.gamePanel.BackColor = System.Drawing.Color.Azure;
            this.gamePanel.Controls.Add(this.score);
            this.gamePanel.Controls.Add(this.fruit);
            this.gamePanel.Controls.Add(this.plate);
            this.gamePanel.Location = new System.Drawing.Point(0, 0);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(804, 455);
            this.gamePanel.TabIndex = 1;
            this.gamePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.gamePanel_Paint);
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Location = new System.Drawing.Point(29, 26);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(50, 18);
            this.score.TabIndex = 2;
            this.score.Text = "label1";
            this.score.Click += new System.EventHandler(this.label1_Click);
            // 
            // fruit
            // 
            this.fruit.BackColor = System.Drawing.Color.Gold;
            this.fruit.Location = new System.Drawing.Point(112, 53);
            this.fruit.Name = "fruit";
            this.fruit.Size = new System.Drawing.Size(80, 76);
            this.fruit.TabIndex = 1;
            this.fruit.TabStop = false;
            // 
            // plate
            // 
            this.plate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.plate.Location = new System.Drawing.Point(304, 381);
            this.plate.Name = "plate";
            this.plate.Size = new System.Drawing.Size(173, 11);
            this.plate.TabIndex = 0;
            this.plate.TabStop = false;
            this.plate.Click += new System.EventHandler(this.startButton_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.startPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.startPanel.ResumeLayout(false);
            this.gamePanel.ResumeLayout(false);
            this.gamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fruit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel startPanel;
        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.PictureBox plate;
        private System.Windows.Forms.PictureBox fruit;
        private System.Windows.Forms.Label score;
    }
}

