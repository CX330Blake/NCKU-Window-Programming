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
            this.registerButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
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
            this.title.Size = new System.Drawing.Size(604, 26);
            this.title.TabIndex = 0;
            this.title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.title.TextChanged += new System.EventHandler(this.title_TextChanged);
            // 
            // orderList
            // 
            this.orderList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.orderList.Font = new System.Drawing.Font("Arial", 12F);
            this.orderList.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.orderList.FormattingEnabled = true;
            this.orderList.ItemHeight = 18;
            this.orderList.Location = new System.Drawing.Point(118, 92);
            this.orderList.Margin = new System.Windows.Forms.Padding(2);
            this.orderList.Name = "orderList";
            this.orderList.Size = new System.Drawing.Size(604, 400);
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
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.registerButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.registerButton.Location = new System.Drawing.Point(26, 220);
            this.registerButton.Margin = new System.Windows.Forms.Padding(2);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(75, 47);
            this.registerButton.TabIndex = 4;
            this.registerButton.Text = "新增帳號資訊";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.logoutButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.logoutButton.Location = new System.Drawing.Point(26, 283);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(2);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 47);
            this.logoutButton.TabIndex = 5;
            this.logoutButton.Text = "登出";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.registerButton);
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
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button logoutButton;
    }
}