using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW4_1
{
    public partial class Form1 : Form
    {
        List<string> messages = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            using (chooseColor color = new chooseColor(this))
            {
                color.ShowDialog();
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (kaiteTextBox.Text != "")
            {
                string text = "楷特: " + kaiteTextBox.Text;
                kaiteTextBox.Text = "";
                messages.Add(text);
                listBoxKaite.Items.Add(text);
                listBoxDouge.Items.Add(text);
                messages.Add("斗哥: 汪！");
                listBoxKaite.Items.Add("斗哥: 汪！");
                listBoxDouge.Items.Add("斗哥: 汪！");
            }
            else
            {
                return;
            }
        }

        private void listBoxDouge_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
