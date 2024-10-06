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
    public partial class AddOrderControl : UserControl
    {
        string username ;
        string selectedItem = "";
        string lastSelectItem = "";
        Dictionary<string, Button> name2But = new Dictionary<string, Button>();
        Dictionary<Button, string> but2Name = new Dictionary<Button, string>();
        public Dictionary<int, Tuple<int, string>> orderHistory = new Dictionary<int, Tuple<int, string>>();
        public int orderID = 1000;
        private int count = 0;


        public AddOrderControl(string name)
        {
            InitializeComponent();
            username = name;
            name2But.Add("penguin", penguinButton);
            name2But.Add("pork", porkButton);
            name2But.Add("shrimp", shrimpButton);
            but2Name.Add(penguinButton, "企鵝");
            but2Name.Add(porkButton, "炸豬排");
            but2Name.Add(shrimpButton, "炸蝦");
        }

        public void Reset()
        {
            selectedItem = "";
            lastSelectItem = "";
            count = 0; // 重置數量
            countTextBox.Text = ""; // 清空文本框
            title.Text = "輸入完數量後，點選對應的商品按鈕，並按下送出"; // 清空標題
                             // 其他控件狀態重置
            foreach (var button in name2But.Values)
            {
                button.Text = but2Name[button]; // 恢復按鈕文本
            }
        }

        private void penguinButton_Click(object sender, EventArgs e)
        {
            handleChoose("penguin");
        }

        private void handleChoose(string item)
        {
            selectedItem = item;
            Button button = name2But[item];
            string name = but2Name[button];
            button.Text = name + "(已選擇)";
            if (lastSelectItem != "" && lastSelectItem != item)
            {
                button = name2But[lastSelectItem];
                name = but2Name[button];
                button.Text = name;
            }
            lastSelectItem = item;
        }

        private void porkButton_Click(object sender, EventArgs e)
        {
            handleChoose("pork");
        }

        private void shrimpButton_Click(object sender, EventArgs e)
        {
            handleChoose("shrimp");
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                count = int.Parse(countTextBox.Text);
                if (selectedItem == "")
                {
                    title.Text = "請選擇商品";
                    return;
                }
                if (count <= 0)
                {
                    title.Text = "商品數量必須是正整數";
                    return;
                }
            }
            catch
            {
                title.Text = "商品數量必須是正整數";
                return;
            }
            string name;
            if (selectedItem == "penguin")
            {
                name = "企鵝";
            }else if (selectedItem == "pork")
            {
                name = "炸豬排";
            }
            else
            {
                name = "炸蝦";
            }
            orderHistory.Add(orderID, new Tuple<int, string>(count, name));
            orderID++;
            //foreach (Control c in this.Controls) c.Hide();
            foreach (Control c in Parent.Controls) c.Show();
            this.Visible = false;
            Parent.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
