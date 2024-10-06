using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW3
{
    public partial class Dashboard : BaseForm
    {
        static string username;
        private AddOrderControl addOrderControl;
        private Register register;
        public Dashboard(string name)
        {
            username = name;
            InitializeComponent();
            title.Text = "歡迎登入！" + name;
            addOrderControl = new AddOrderControl(username, this);
            addOrderControl.Dock = DockStyle.Fill;
            register = new Register(this);
            register.Dock = DockStyle.Fill;
        }


        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void title_TextChanged(object sender, EventArgs e)
        {

        }

        private void addOrder_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls) c.Hide();
            if (!this.Controls.Contains(addOrderControl)) this.Controls.Add(addOrderControl);
            addOrderControl.Reset();
            addOrderControl.BringToFront();
            addOrderControl.Visible = true;
        }

        private void listOrder_Click(object sender, EventArgs e)
        {
            orderList.Items.Clear();  // 顯示訂單前先清除現有項目
            for (int i = 1000; i < Login.orderID; i++)
            {
                var (count, item, user) = Login.orderHistory[i];
                orderList.Items.Add($"訂單編號 {i}: 購買了 {count} 個 {item}，此訂單由 {user} 新增\n");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls) c.Hide();
            if (!this.Controls.Contains(register)) this.Controls.Add(register);
            register.BringToFront();
            register.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Login login = new Login()) {
                this.Hide();
                login.autoLogin();
                login.ShowDialog();
            }
        }
    }
}
