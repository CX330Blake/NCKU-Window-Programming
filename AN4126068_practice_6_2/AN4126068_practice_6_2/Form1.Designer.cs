namespace AN4126068_practice_6_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.startPanel = new System.Windows.Forms.Panel();
            this.pausePanel = new System.Windows.Forms.Panel();
            this.oldGameButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.resumeButton = new System.Windows.Forms.Button();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.selectPanel = new System.Windows.Forms.Panel();
            this.rockPicBox = new System.Windows.Forms.PictureBox();
            this.mudPicBox = new System.Windows.Forms.PictureBox();
            this.mudSelected = new System.Windows.Forms.PictureBox();
            this.rockSelected = new System.Windows.Forms.PictureBox();
            this.selectBar = new System.Windows.Forms.PictureBox();
            this.startPanel.SuspendLayout();
            this.pausePanel.SuspendLayout();
            this.selectPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rockPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mudPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mudSelected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rockSelected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectBar)).BeginInit();
            this.SuspendLayout();
            // 
            // startPanel
            // 
            this.startPanel.Controls.Add(this.selectPanel);
            this.startPanel.Controls.Add(this.pausePanel);
            this.startPanel.Controls.Add(this.gamePanel);
            this.startPanel.Location = new System.Drawing.Point(-3, -4);
            this.startPanel.Name = "startPanel";
            this.startPanel.Size = new System.Drawing.Size(803, 456);
            this.startPanel.TabIndex = 0;
            this.startPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pausePanel
            // 
            this.pausePanel.BackColor = System.Drawing.SystemColors.Control;
            this.pausePanel.Controls.Add(this.oldGameButton);
            this.pausePanel.Controls.Add(this.exitButton);
            this.pausePanel.Controls.Add(this.startButton);
            this.pausePanel.Controls.Add(this.saveButton);
            this.pausePanel.Controls.Add(this.homeButton);
            this.pausePanel.Controls.Add(this.resumeButton);
            this.pausePanel.Location = new System.Drawing.Point(3, 3);
            this.pausePanel.Name = "pausePanel";
            this.pausePanel.Size = new System.Drawing.Size(803, 453);
            this.pausePanel.TabIndex = 6;
            this.pausePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // oldGameButton
            // 
            this.oldGameButton.Location = new System.Drawing.Point(270, 49);
            this.oldGameButton.Name = "oldGameButton";
            this.oldGameButton.Size = new System.Drawing.Size(265, 85);
            this.oldGameButton.TabIndex = 5;
            this.oldGameButton.Text = "START PREVIOUS";
            this.oldGameButton.UseVisualStyleBackColor = true;
            this.oldGameButton.Click += new System.EventHandler(this.oldGameButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(268, 315);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(265, 85);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "LEAVE";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(269, 184);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(265, 85);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "START NEW";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(270, 316);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(264, 85);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // homeButton
            // 
            this.homeButton.Location = new System.Drawing.Point(269, 184);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(264, 85);
            this.homeButton.TabIndex = 2;
            this.homeButton.Text = "HOME";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // resumeButton
            // 
            this.resumeButton.Location = new System.Drawing.Point(270, 49);
            this.resumeButton.Name = "resumeButton";
            this.resumeButton.Size = new System.Drawing.Size(264, 85);
            this.resumeButton.TabIndex = 1;
            this.resumeButton.Text = "RESUME";
            this.resumeButton.UseVisualStyleBackColor = true;
            this.resumeButton.Click += new System.EventHandler(this.resumeButton_Click);
            // 
            // gamePanel
            // 
            this.gamePanel.BackColor = System.Drawing.SystemColors.Control;
            this.gamePanel.Location = new System.Drawing.Point(3, 3);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(800, 453);
            this.gamePanel.TabIndex = 1;
            this.gamePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.gamePanel_Paint);
            this.gamePanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gamePanel_MouseClick);
            // 
            // selectPanel
            // 
            this.selectPanel.BackColor = System.Drawing.Color.Transparent;
            this.selectPanel.Controls.Add(this.rockPicBox);
            this.selectPanel.Controls.Add(this.mudPicBox);
            this.selectPanel.Controls.Add(this.mudSelected);
            this.selectPanel.Controls.Add(this.rockSelected);
            this.selectPanel.Controls.Add(this.selectBar);
            this.selectPanel.Location = new System.Drawing.Point(106, 340);
            this.selectPanel.Name = "selectPanel";
            this.selectPanel.Size = new System.Drawing.Size(599, 72);
            this.selectPanel.TabIndex = 5;
            // 
            // rockPicBox
            // 
            this.rockPicBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rockPicBox.BackgroundImage")));
            this.rockPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rockPicBox.Location = new System.Drawing.Point(86, 10);
            this.rockPicBox.Name = "rockPicBox";
            this.rockPicBox.Size = new System.Drawing.Size(50, 50);
            this.rockPicBox.TabIndex = 2;
            this.rockPicBox.TabStop = false;
            this.rockPicBox.Click += new System.EventHandler(this.rockPicBox_Click);
            // 
            // mudPicBox
            // 
            this.mudPicBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mudPicBox.BackgroundImage")));
            this.mudPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mudPicBox.Location = new System.Drawing.Point(15, 10);
            this.mudPicBox.Name = "mudPicBox";
            this.mudPicBox.Size = new System.Drawing.Size(50, 50);
            this.mudPicBox.TabIndex = 1;
            this.mudPicBox.TabStop = false;
            this.mudPicBox.Click += new System.EventHandler(this.mudPicBox_Click);
            // 
            // mudSelected
            // 
            this.mudSelected.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mudSelected.BackgroundImage")));
            this.mudSelected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mudSelected.Location = new System.Drawing.Point(0, -5);
            this.mudSelected.Name = "mudSelected";
            this.mudSelected.Size = new System.Drawing.Size(81, 82);
            this.mudSelected.TabIndex = 3;
            this.mudSelected.TabStop = false;
            // 
            // rockSelected
            // 
            this.rockSelected.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rockSelected.BackgroundImage")));
            this.rockSelected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rockSelected.Location = new System.Drawing.Point(71, -5);
            this.rockSelected.Name = "rockSelected";
            this.rockSelected.Size = new System.Drawing.Size(81, 82);
            this.rockSelected.TabIndex = 4;
            this.rockSelected.TabStop = false;
            // 
            // selectBar
            // 
            this.selectBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("selectBar.BackgroundImage")));
            this.selectBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.selectBar.Location = new System.Drawing.Point(0, -1);
            this.selectBar.Name = "selectBar";
            this.selectBar.Size = new System.Drawing.Size(598, 76);
            this.selectBar.TabIndex = 0;
            this.selectBar.TabStop = false;
            this.selectBar.Click += new System.EventHandler(this.selectBar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.startPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.startPanel.ResumeLayout(false);
            this.pausePanel.ResumeLayout(false);
            this.selectPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rockPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mudPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mudSelected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rockSelected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel startPanel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.PictureBox rockPicBox;
        private System.Windows.Forms.PictureBox mudPicBox;
        private System.Windows.Forms.PictureBox mudSelected;
        private System.Windows.Forms.PictureBox rockSelected;
        private System.Windows.Forms.PictureBox selectBar;
        private System.Windows.Forms.Panel selectPanel;
        private System.Windows.Forms.Panel pausePanel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button resumeButton;
        private System.Windows.Forms.Button oldGameButton;
        private System.Windows.Forms.Button exitButton;
    }
}

