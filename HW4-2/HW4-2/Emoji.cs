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
    public partial class Emoji : Form
    {
        ListView listViewCat;
        ListView listViewDog;
        string sender;
        Image selection;
        public Emoji(ListView listViewCat, ListView listViewDog, string sender)
        {
            InitializeComponent();
            this.listViewCat = listViewCat;
            this.listViewDog = listViewDog;
            this.sender = sender;
        }

        private void emoji_Load(object sender, EventArgs e)
        {

        }

        private void emoji_Load_1(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            selection = button2.BackgroundImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selection = button1.BackgroundImage;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            selection = button3.BackgroundImage;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            selection = button6.BackgroundImage;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            selection = button5.BackgroundImage;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            selection = button4.BackgroundImage;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ListViewItem listItem;
            if (selection == null) return;

            if (this.sender == "dog")
            {
                listItem = new ListViewItem("斗哥: ");
                listItem.ImageKey = "dog";
            }
            else
            {
                listItem = new ListViewItem("楷特: ");
                listItem.ImageKey = "cat";
            }
            string emojiKey = "emoji_" + listViewCat.LargeImageList.Images.Count;

            listViewCat.LargeImageList.Images.Add(emojiKey, selection);
            listViewDog.LargeImageList.Images.Add(emojiKey, selection);
            
            ListViewItem emojiItem = new ListViewItem("");  // 空文字項目
            emojiItem.ImageKey = emojiKey;
            listViewCat.Items.Add(listItem);
            listViewDog.Items.Add((ListViewItem)listItem.Clone());
            listViewCat.Items.Add(emojiItem);
            listViewDog.Items.Add((ListViewItem)emojiItem.Clone());

            this.Close();
        }
    }
}
