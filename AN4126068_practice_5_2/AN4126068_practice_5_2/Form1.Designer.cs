namespace AN4126068_practice_5_2
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
            this.chooseCharacterPanel = new System.Windows.Forms.Panel();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.heart = new System.Windows.Forms.Label();
            this.MelanthaLabel = new System.Windows.Forms.Label();
            this.MyrtleLabel = new System.Windows.Forms.Label();
            this.CardiganLabel = new System.Windows.Forms.Label();
            this.battleField = new System.Windows.Forms.TableLayoutPanel();
            this.fightButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.selectedCharacterListBox = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.characterListBox = new System.Windows.Forms.ListBox();
            this.startButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.startPanel.SuspendLayout();
            this.chooseCharacterPanel.SuspendLayout();
            this.gamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // startPanel
            // 
            this.startPanel.Controls.Add(this.chooseCharacterPanel);
            this.startPanel.Controls.Add(this.startButton);
            this.startPanel.Location = new System.Drawing.Point(0, 0);
            this.startPanel.Name = "startPanel";
            this.startPanel.Size = new System.Drawing.Size(801, 452);
            this.startPanel.TabIndex = 0;
            // 
            // chooseCharacterPanel
            // 
            this.chooseCharacterPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.chooseCharacterPanel.Controls.Add(this.gamePanel);
            this.chooseCharacterPanel.Controls.Add(this.fightButton);
            this.chooseCharacterPanel.Controls.Add(this.deleteButton);
            this.chooseCharacterPanel.Controls.Add(this.selectedCharacterListBox);
            this.chooseCharacterPanel.Controls.Add(this.addButton);
            this.chooseCharacterPanel.Controls.Add(this.characterListBox);
            this.chooseCharacterPanel.Location = new System.Drawing.Point(-1, 0);
            this.chooseCharacterPanel.Name = "chooseCharacterPanel";
            this.chooseCharacterPanel.Size = new System.Drawing.Size(801, 452);
            this.chooseCharacterPanel.TabIndex = 1;
            // 
            // gamePanel
            // 
            this.gamePanel.Controls.Add(this.infoLabel);
            this.gamePanel.Controls.Add(this.moneyLabel);
            this.gamePanel.Controls.Add(this.heart);
            this.gamePanel.Controls.Add(this.MelanthaLabel);
            this.gamePanel.Controls.Add(this.MyrtleLabel);
            this.gamePanel.Controls.Add(this.CardiganLabel);
            this.gamePanel.Controls.Add(this.battleField);
            this.gamePanel.Location = new System.Drawing.Point(0, 3);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(801, 451);
            this.gamePanel.TabIndex = 5;
            this.gamePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.gamePanel_Paint);
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Location = new System.Drawing.Point(710, 304);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(43, 18);
            this.moneyLabel.TabIndex = 8;
            this.moneyLabel.Text = "haert";
            this.moneyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // heart
            // 
            this.heart.AutoSize = true;
            this.heart.Location = new System.Drawing.Point(50, 304);
            this.heart.Name = "heart";
            this.heart.Size = new System.Drawing.Size(43, 18);
            this.heart.TabIndex = 7;
            this.heart.Text = "haert";
            this.heart.Click += new System.EventHandler(this.label1_Click);
            // 
            // MelanthaLabel
            // 
            this.MelanthaLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.MelanthaLabel.Location = new System.Drawing.Point(703, 344);
            this.MelanthaLabel.Name = "MelanthaLabel";
            this.MelanthaLabel.Size = new System.Drawing.Size(50, 50);
            this.MelanthaLabel.TabIndex = 6;
            this.MelanthaLabel.Text = "Melantha";
            this.MelanthaLabel.Visible = false;
            // 
            // MyrtleLabel
            // 
            this.MyrtleLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.MyrtleLabel.Location = new System.Drawing.Point(390, 344);
            this.MyrtleLabel.Name = "MyrtleLabel";
            this.MyrtleLabel.Size = new System.Drawing.Size(50, 50);
            this.MyrtleLabel.TabIndex = 5;
            this.MyrtleLabel.Text = "Myrtle";
            this.MyrtleLabel.Visible = false;
            this.MyrtleLabel.Click += new System.EventHandler(this.MyrtleLabel_Click);
            // 
            // CardiganLabel
            // 
            this.CardiganLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CardiganLabel.Location = new System.Drawing.Point(50, 344);
            this.CardiganLabel.Name = "CardiganLabel";
            this.CardiganLabel.Size = new System.Drawing.Size(50, 50);
            this.CardiganLabel.TabIndex = 4;
            this.CardiganLabel.Text = "Cardigan";
            this.CardiganLabel.Visible = false;
            // 
            // battleField
            // 
            this.battleField.AutoSize = true;
            this.battleField.ColumnCount = 7;
            this.battleField.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.battleField.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.battleField.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.battleField.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.battleField.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.battleField.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.battleField.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.battleField.Location = new System.Drawing.Point(53, 78);
            this.battleField.Name = "battleField";
            this.battleField.RowCount = 2;
            this.battleField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.battleField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.battleField.Size = new System.Drawing.Size(700, 200);
            this.battleField.TabIndex = 0;
            // 
            // fightButton
            // 
            this.fightButton.Location = new System.Drawing.Point(446, 307);
            this.fightButton.Name = "fightButton";
            this.fightButton.Size = new System.Drawing.Size(307, 66);
            this.fightButton.TabIndex = 4;
            this.fightButton.Text = "FIGHT!!!";
            this.fightButton.UseVisualStyleBackColor = true;
            this.fightButton.Click += new System.EventHandler(this.fightButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(365, 248);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 77);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "<";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // selectedCharacterListBox
            // 
            this.selectedCharacterListBox.FormattingEnabled = true;
            this.selectedCharacterListBox.ItemHeight = 18;
            this.selectedCharacterListBox.Location = new System.Drawing.Point(446, 81);
            this.selectedCharacterListBox.Name = "selectedCharacterListBox";
            this.selectedCharacterListBox.Size = new System.Drawing.Size(307, 220);
            this.selectedCharacterListBox.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(365, 127);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 77);
            this.addButton.TabIndex = 2;
            this.addButton.Text = ">";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // characterListBox
            // 
            this.characterListBox.FormattingEnabled = true;
            this.characterListBox.ItemHeight = 18;
            this.characterListBox.Location = new System.Drawing.Point(50, 81);
            this.characterListBox.Name = "characterListBox";
            this.characterListBox.Size = new System.Drawing.Size(307, 292);
            this.characterListBox.TabIndex = 0;
            this.characterListBox.SelectedIndexChanged += new System.EventHandler(this.characterListBox_SelectedIndexChanged);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(245, 169);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(295, 110);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(243, 42);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(325, 18);
            this.infoLabel.TabIndex = 9;
            this.infoLabel.Text = "Hover On Character On Board Show The Info";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.chooseCharacterPanel.ResumeLayout(false);
            this.gamePanel.ResumeLayout(false);
            this.gamePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel startPanel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Panel chooseCharacterPanel;
        private System.Windows.Forms.ListBox selectedCharacterListBox;
        private System.Windows.Forms.ListBox characterListBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button fightButton;
        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.TableLayoutPanel battleField;
        private System.Windows.Forms.Label MelanthaLabel;
        private System.Windows.Forms.Label MyrtleLabel;
        private System.Windows.Forms.Label CardiganLabel;
        private System.Windows.Forms.Label heart;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.Label infoLabel;
    }
}

