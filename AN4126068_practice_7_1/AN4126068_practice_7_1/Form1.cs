using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AN4126068_practice_6_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 結束ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose(); 
        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm("", false);
            editForm.ShowDialog();
        }

        private void 開啟舊檔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog {Filter = "Text Files (*.txt)|*.txt|Custom Text Files (*.mytxt)|*.mytxt" };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // 讀取選取的文件內容
                string filePath = openFileDialog.FileName;
                string content = System.IO.File.ReadAllText(filePath);
                EditForm editForm;
                if (filePath.EndsWith(".txt"))
                {
                     editForm = new EditForm(content, false);
                }
                else
                {
                     editForm = new EditForm(content, true);
                }

                editForm.Text = filePath;
                editForm.ShowDialog();
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
