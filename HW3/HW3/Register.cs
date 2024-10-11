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
    public partial class Register : UserControl
    {
        private Form _mainForm;
        public Register(Form form)
        {
            InitializeComponent();
            _mainForm = form;
            this.Size = new Size(form.ClientSize.Width, form.ClientSize.Height);
            this.MinimumSize = new Size(0, 0);  // 移除最小大小限制
            this.MaximumSize = new Size(form.ClientSize.Width, form.ClientSize.Height);  // 設置最大大小
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string user = userTextBox.Text;
            string password = passwordTextBox.Text;
            if (Login.userAuth.ContainsKey(user))
            {
                title.Text = "此使用者已存在";
                return;
            }
            if (user == "" || password == "")
            {
                title.Text = "帳號密碼不可為空白";
                return;
            }
            Login.userAuth.Add(user, password);
            using (Dashboard dashboard = new Dashboard(user))
            {
                Parent.Hide();
                dashboard.ShowDialog();
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
