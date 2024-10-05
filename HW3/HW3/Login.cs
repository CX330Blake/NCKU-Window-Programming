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
    public partial class Login : BaseForm
    {
        public static Dictionary<string, string> userAuth = new Dictionary<string, string>();   

                
        public Login()
        {
            InitializeComponent();
            userAuth.Add("admin", "admin");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearButton(openShopButton);
            title.Text = "歡迎光臨！請登入！";
            loginButton.Visible = true;
            usernameInput.Visible = true;
            usernameLabel.Visible = true;
            passwordInput.Visible = true;
            passwordLabel.Visible = true;
        }
        private void clearButton(Button button)
        {
            button.Hide();
        }
        private void login()
        {
            string username = usernameInput.Text;
            string password = passwordInput.Text;
            if (!userAuth.ContainsKey(username))
            {
                title.Text = "帳號不存在，請先註冊";
            }
            else
            {
                if (userAuth[username] != password)
                {
                    title.Text = "帳號密碼錯誤，請重新輸入";
                    usernameInput.Text = "";
                    passwordInput.Text = "";
                }
                else
                {
                    title.Text = "登入成功";
                    using (Dashboard dashboard = new Dashboard(username))
                    {
                        this.Hide();
                        dashboard.ShowDialog();
                    }
                    this.Close();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            login();
        }
    }
}
