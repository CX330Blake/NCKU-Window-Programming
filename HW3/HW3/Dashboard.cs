using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW3
{
    public partial class Dashboard : BaseForm
    {
        static string username;
        public Dashboard(string name)
        {
            username = name;
            InitializeComponent();
            title.Text = "歡迎登入！" + name;
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
            AddOrderControl addOrderControl = new AddOrderControl(username);
            addOrderControl.Dock = DockStyle.Fill;
            this.Controls.Add(addOrderControl);
        }
    }
}
