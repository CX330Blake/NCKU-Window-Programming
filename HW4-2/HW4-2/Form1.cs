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

namespace HW4_1
{
    public partial class Form1 : Form
    {
        ImageList images = new ImageList();
        Boolean inGame = false;

        public Form1()
        {
            InitializeComponent();
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            images.Images.Add("cat", Image.FromFile(System.IO.Path.Combine(basePath, "Images", "cat.png")));
            images.Images.Add("dog", Image.FromFile(System.IO.Path.Combine(basePath, "Images", "dog.png")));

            listViewCat.LargeImageList = images;
            listViewCat.View = View.Tile;
            listViewCat.TileSize = new Size(250, 25);  // 寬250像素，高50像素
            listViewDog.LargeImageList = images;
            listViewDog.View = View.Tile;
            listViewDog.TileSize = new Size(250, 25);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            using (ChooseColor color = new ChooseColor(this))
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
            string text = catTextBox.Text;
            if (string.IsNullOrEmpty(text)) return;

            ListViewItem catMsg = new ListViewItem("楷特: "+text);
            catMsg.ImageKey = "cat";
            listViewCat.Items.Add(catMsg);
            listViewDog.Items.Add((ListViewItem)catMsg.Clone());
            if (text == "喵！") {
                ListViewItem dogReply = new ListViewItem("斗哥: 汪！");
                dogReply.ImageKey = "dog";  // 為斗哥的項目設置圖片
                listViewCat.Items.Add(dogReply);
                listViewDog.Items.Add((ListViewItem)dogReply.Clone());
            }
            catTextBox.Text = "";
        }

        private void listBoxDouge_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listViewDog_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dogSubmit_Click(object sender, EventArgs e)
        {
            if (inGame) {
                string dogChoice = dogTextBox.Text;
                ListViewItem dogChoiceMsg = new ListViewItem("斗哥: " + dogChoice);
                dogChoiceMsg.ImageKey = "dog";
                listViewDog.Items.Add(dogChoiceMsg);
                listViewCat.Items.Add((ListViewItem)dogChoiceMsg.Clone());
                game(dogChoice);
                dogTextBox.Text = "";
                return; 
            }
            string text = dogTextBox.Text;
            if (string.IsNullOrEmpty(text)) return;

            ListViewItem dogMsg = new ListViewItem("斗哥: " + text);
            dogMsg.ImageKey = "dog";
            listViewDog.Items.Add(dogMsg);
            listViewCat.Items.Add((ListViewItem)dogMsg.Clone());
            if (text == "汪！")
            {
                ListViewItem catReply = new ListViewItem("楷特: 喵！");
                catReply.ImageKey = "cat";  // 為斗哥的項目設置圖片
                listViewDog.Items.Add(catReply);
                listViewCat.Items.Add((ListViewItem)catReply.Clone());
            }else if (text == "猜拳")
            {
                catSubmit.Enabled = false;
                ListViewItem catReply = new ListViewItem("楷特: 遊戲開始");
                catReply.ImageKey = "cat";
                listViewDog.Items.Add(catReply);
                listViewCat.Items.Add((ListViewItem)catReply.Clone());
                inGame = true;
            }
            dogTextBox.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (Emoji emoji = new Emoji(listViewCat, listViewDog, "dog" )) {
                emoji.ShowDialog();
            }
        }

        private void catEmoji_Click(object sender, EventArgs e)
        {
            using (Emoji emoji = new Emoji(listViewCat, listViewDog, "cat"))
            {
                emoji.ShowDialog();
            }
        }
        private void game(string dogChoice)
        {
            string catReplyText = "";
            switch (dogChoice) {
                case "剪刀":
                    catReplyText = "楷特: 布";
                    break;
                case "石頭":
                    catReplyText = "楷特: 剪刀";
                    break;
                case "布":
                    catReplyText = "楷特: 石頭";
                    break;
                default: break;
            }
            ListViewItem catReply = new ListViewItem(catReplyText);
            catReply.ImageKey = "cat";  // 設定頭像圖片

            // 添加到 ListViewDog 和 ListViewCat
            listViewDog.Items.Add(catReply);
            listViewCat.Items.Add((ListViewItem)catReply.Clone());
            catSubmit.Enabled = true;
            inGame = false; 
        }  
    }
}
