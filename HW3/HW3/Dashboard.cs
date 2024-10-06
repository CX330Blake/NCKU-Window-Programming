using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        public Dashboard(string name)
        {
            username = name;
            InitializeComponent();
            title.Text = "歡迎登入！" + name;
            addOrderControl = new AddOrderControl(username);
            addOrderControl.Dock = DockStyle.Fill;
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
            for (int i = 1000; i < addOrderControl.orderID; i++)
            {
                var (count, item) = addOrderControl.orderHistory[i];
                orderList.Items.Add($"訂單編號 {i}: 購買了 {count} 個 {item}\n");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
