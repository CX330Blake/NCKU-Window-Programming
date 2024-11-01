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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listViewCat = new System.Windows.Forms.ListView();
            this.catSubmit = new System.Windows.Forms.Button();
            this.catTextBox = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listViewDog = new System.Windows.Forms.ListView();
            this.dogSubmit = new System.Windows.Forms.Button();
            this.dogTextBox = new System.Windows.Forms.TextBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dogEmoji = new System.Windows.Forms.Button();
            this.catEmoji = new System.Windows.Forms.Button();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.catEmoji);
            this.tabPage2.Controls.Add(this.listViewCat);
            this.tabPage2.Controls.Add(this.catSubmit);
            this.tabPage2.Controls.Add(this.catTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(750, 374);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "楷特";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // listViewCat
            // 
            this.listViewCat.HideSelection = false;
            this.listViewCat.Location = new System.Drawing.Point(14, 14);
            this.listViewCat.Name = "listViewCat";
            this.listViewCat.Size = new System.Drawing.Size(722, 298);
            this.listViewCat.TabIndex = 4;
            this.listViewCat.UseCompatibleStateImageBehavior = false;
            // 
            // catSubmit
            // 
            this.catSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.catSubmit.Location = new System.Drawing.Point(662, 325);
            this.catSubmit.Name = "catSubmit";
            this.catSubmit.Size = new System.Drawing.Size(75, 29);
            this.catSubmit.TabIndex = 3;
            this.catSubmit.Text = "送出";
            this.catSubmit.UseVisualStyleBackColor = true;
            this.catSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // catTextBox
            // 
            this.catTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.catTextBox.Location = new System.Drawing.Point(14, 325);
            this.catTextBox.Name = "catTextBox";
            this.catTextBox.Size = new System.Drawing.Size(606, 29);
            this.catTextBox.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dogEmoji);
            this.tabPage1.Controls.Add(this.listViewDog);
            this.tabPage1.Controls.Add(this.dogSubmit);
            this.tabPage1.Controls.Add(this.dogTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(750, 374);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "斗哥";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // listViewDog
            // 
            this.listViewDog.HideSelection = false;
            this.listViewDog.Location = new System.Drawing.Point(12, 14);
            this.listViewDog.Name = "listViewDog";
            this.listViewDog.Size = new System.Drawing.Size(722, 298);
            this.listViewDog.TabIndex = 5;
            this.listViewDog.UseCompatibleStateImageBehavior = false;
            this.listViewDog.SelectedIndexChanged += new System.EventHandler(this.listViewDog_SelectedIndexChanged);
            // 
            // dogSubmit
            // 
            this.dogSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dogSubmit.Location = new System.Drawing.Point(660, 327);
            this.dogSubmit.Name = "dogSubmit";
            this.dogSubmit.Size = new System.Drawing.Size(75, 29);
            this.dogSubmit.TabIndex = 1;
            this.dogSubmit.Text = "送出";
            this.dogSubmit.UseVisualStyleBackColor = true;
            this.dogSubmit.Click += new System.EventHandler(this.dogSubmit_Click);
            // 
            // dogTextBox
            // 
            this.dogTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dogTextBox.Location = new System.Drawing.Point(12, 327);
            this.dogTextBox.Name = "dogTextBox";
            this.dogTextBox.Size = new System.Drawing.Size(606, 29);
            this.dogTextBox.TabIndex = 0;
            this.dogTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // dogEmoji
            // 
            this.dogEmoji.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dogEmoji.BackgroundImage")));
            this.dogEmoji.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.dogEmoji.Location = new System.Drawing.Point(624, 327);
            this.dogEmoji.Name = "dogEmoji";
            this.dogEmoji.Size = new System.Drawing.Size(30, 29);
            this.dogEmoji.TabIndex = 6;
            this.dogEmoji.UseVisualStyleBackColor = true;
            this.dogEmoji.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // catEmoji
            // 
            this.catEmoji.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("catEmoji.BackgroundImage")));
            this.catEmoji.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.catEmoji.Location = new System.Drawing.Point(626, 325);
            this.catEmoji.Name = "catEmoji";
            this.catEmoji.Size = new System.Drawing.Size(30, 29);
            this.catEmoji.TabIndex = 7;
            this.catEmoji.UseVisualStyleBackColor = true;
            this.catEmoji.Click += new System.EventHandler(this.catEmoji_Click);
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
        private System.Windows.Forms.Button dogSubmit;
        private System.Windows.Forms.TextBox dogTextBox;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.Button catSubmit;
        private System.Windows.Forms.TextBox catTextBox;
        private System.Windows.Forms.ListView listViewCat;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView listViewDog;
        private System.Windows.Forms.Button dogEmoji;
        private System.Windows.Forms.Button catEmoji;
    }
}

