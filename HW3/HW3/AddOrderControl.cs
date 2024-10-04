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

        private void penguinButton_Click(object sender, EventArgs e)
        {
            handleClick("penguin");
        }

        private void handleClick(string item)
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
            handleClick("pork");
        }

        private void shrimpButton_Click(object sender, EventArgs e)
        {
            handleClick("shrimp");
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls) c.Hide();
            foreach (Control c in Parent.Controls) c.Show();
        }
    }
}
