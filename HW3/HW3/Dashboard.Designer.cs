namespace HW3
{
    partial class Dashboard
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
            this.title = new System.Windows.Forms.TextBox();
            this.orderList = new System.Windows.Forms.ListBox();
            this.addOrder = new System.Windows.Forms.Button();
            this.listOrder = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.title.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.title.Location = new System.Drawing.Point(118, 52);
            this.title.Margin = new System.Windows.Forms.Padding(2);
            this.title.Name = "title";
            this.title.ReadOnly = true;
            this.title.Size = new System.Drawing.Size(350, 26);
            this.title.TabIndex = 0;
            this.title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.title.TextChanged += new System.EventHandler(this.title_TextChanged);
            // 
            // orderList
            // 
            this.orderList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.orderList.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.orderList.FormattingEnabled = true;
            this.orderList.ItemHeight = 18;
            this.orderList.Location = new System.Drawing.Point(118, 92);
            this.orderList.Margin = new System.Windows.Forms.Padding(2);
            this.orderList.Name = "orderList";
            this.orderList.Size = new System.Drawing.Size(350, 238);
            this.orderList.TabIndex = 1;
            this.orderList.SelectedIndexChanged += new System.EventHandler(this.list_SelectedIndexChanged);
            // 
            // addOrder
            // 
            this.addOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.addOrder.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addOrder.Location = new System.Drawing.Point(26, 92);
            this.addOrder.Margin = new System.Windows.Forms.Padding(2);
            this.addOrder.Name = "addOrder";
            this.addOrder.Size = new System.Drawing.Size(75, 48);
            this.addOrder.TabIndex = 2;
            this.addOrder.Text = "新增一筆訂單";
            this.addOrder.UseVisualStyleBackColor = false;
            this.addOrder.Click += new System.EventHandler(this.addOrder_Click);
            // 
            // listOrder
            // 
            this.listOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.listOrder.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.listOrder.Location = new System.Drawing.Point(26, 156);
            this.listOrder.Margin = new System.Windows.Forms.Padding(2);
            this.listOrder.Name = "listOrder";
            this.listOrder.Size = new System.Drawing.Size(75, 47);
            this.listOrder.TabIndex = 3;
            this.listOrder.Text = "列出所有訂單";
            this.listOrder.UseVisualStyleBackColor = false;
            this.listOrder.Click += new System.EventHandler(this.listOrder_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(26, 220);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 47);
            this.button1.TabIndex = 4;
            this.button1.Text = "新增帳號資訊";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(26, 283);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 47);
            this.button2.TabIndex = 5;
            this.button2.Text = "登出";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 363);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listOrder);
            this.Controls.Add(this.addOrder);
            this.Controls.Add(this.orderList);
            this.Controls.Add(this.title);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.ListBox orderList;
        private System.Windows.Forms.Button addOrder;
        private System.Windows.Forms.Button listOrder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}