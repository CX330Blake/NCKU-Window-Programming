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
    public partial class ChooseColor : Form
    {
        private Random random;
        private Form lastForm ;

        public ChooseColor(Form form)
        {
            InitializeComponent();
            random = new Random();
            lastForm = form;
        }

        private void chooseColor_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lastForm.BackColor = this.BackColor;
            this.Close();
        }
    }
}
