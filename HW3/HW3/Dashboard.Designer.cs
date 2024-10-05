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
            this.list = new System.Windows.Forms.ListBox();
            this.addOrder = new System.Windows.Forms.Button();
            this.listOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.title.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.title.Location = new System.Drawing.Point(144, 78);
            this.title.Name = "title";
            this.title.ReadOnly = true;
            this.title.Size = new System.Drawing.Size(581, 35);
            this.title.TabIndex = 0;
            this.title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.title.TextChanged += new System.EventHandler(this.title_TextChanged);
            // 
            // list
            // 
            this.list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.list.FormattingEnabled = true;
            this.list.ItemHeight = 27;
            this.list.Location = new System.Drawing.Point(144, 138);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(581, 355);
            this.list.TabIndex = 1;
            this.list.SelectedIndexChanged += new System.EventHandler(this.list_SelectedIndexChanged);
            // 
            // addOrder
            // 
            this.addOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.addOrder.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addOrder.Location = new System.Drawing.Point(41, 138);
            this.addOrder.Name = "addOrder";
            this.addOrder.Size = new System.Drawing.Size(75, 118);
            this.addOrder.TabIndex = 2;
            this.addOrder.Text = "新增訂單";
            this.addOrder.UseVisualStyleBackColor = false;
            this.addOrder.Click += new System.EventHandler(this.addOrder_Click);
            // 
            // listOrder
            // 
            this.listOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.listOrder.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.listOrder.Location = new System.Drawing.Point(41, 280);
            this.listOrder.Name = "listOrder";
            this.listOrder.Size = new System.Drawing.Size(75, 118);
            this.listOrder.TabIndex = 3;
            this.listOrder.Text = "列出所有訂單";
            this.listOrder.UseVisualStyleBackColor = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.listOrder);
            this.Controls.Add(this.addOrder);
            this.Controls.Add(this.list);
            this.Controls.Add(this.title);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.ListBox list;
        private System.Windows.Forms.Button addOrder;
        private System.Windows.Forms.Button listOrder;
    }
}