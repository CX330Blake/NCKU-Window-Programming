using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Newtonsoft.Json;



namespace AN4126068_practice_6_2
{
    public partial class Form1 : Form
    {
        string currentBlock = "mud";
        int blockWidth = 50;
        int blockHeight = 50;
        public Form1()
        {
            InitializeComponent();
            this.Controls.Add(gamePanel);
            this.Controls.Add(selectPanel);
            this.Controls.Add(pausePanel);
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(gamePanel_KeyDown);

            startPanel.Controls.Add(startButton);
            startPanel.Controls.Add(exitButton);
            startPanel.Controls.Add(oldGameButton);

            gamePanel.Visible = false;
            gamePanel.AutoScroll = true;
            gamePanel.Padding = new Padding(0);
            gamePanel.Margin = new Padding(0);

            gamePanel.TabIndex = 0;
            gamePanel.TabStop = true;
            gamePanel.KeyDown += new KeyEventHandler(gamePanel_KeyDown);

            pausePanel.Visible = false;
            pausePanel.Controls.Add(resumeButton);
            pausePanel.Controls.Add(homeButton);
            pausePanel.Controls.Add(saveButton);

            rockSelected.Visible = false;
            mudSelected.Visible = true;
        }

        private void LoadGame()
        {
            if (File.Exists("savefile.json"))
            {
                string json = File.ReadAllText("savefile.json");
                List<BlockState> blockStates = JsonConvert.DeserializeObject<List<BlockState>>(json);

                foreach (BlockState blockState in blockStates)
                {
                    Control block;
                    if (blockState.Type == "Mud")
                    {
                        block = new Mud(blockWidth, blockHeight);
                    }
                    else if (blockState.Type == "Rock")
                    {
                        block = new Rock(blockWidth, blockHeight);
                    }
                    else
                    {
                        continue;
                    }

                    block.Location = new Point(blockState.X, blockState.Y);
                    gamePanel.Controls.Add(block);
                }
            }

            createSteve(gamePanel);
        }


        private void gamePanel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                selectPanel.Visible = false;
                gamePanel.Visible = false;
                pausePanel.Visible = true;
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startPanel.Visible = false;
            gamePanel.Visible = true;


            // 刪除所有的 Mud 和 Rock 控件
            var controlsToRemove = gamePanel.Controls.OfType<Control>()
                .Where(control => control is Mud || control is Rock)
                .ToList();

            foreach (var control in controlsToRemove)
            {
                gamePanel.Controls.Remove(control);
                control.Dispose();
            }


            createMud(gamePanel);
            createSteve(gamePanel);

            selectPanel.Visible = true;
            selectPanel.BringToFront();
        }

        public void createSteve(Panel gamePanel)
        {
            Steve steve = new Steve(blockWidth, 2 * blockHeight);
            steve.Location = new Point(blockWidth, 2 * blockHeight);
            gamePanel.Controls.Add(steve);
        }
        public void createMud(Panel gamePanel)
        {
            int offsetY = 4 * blockHeight; // For the sky above

            // 設定行數和列數
            int rows = 15;
            int columns = 30;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Mud mud = new Mud(blockWidth, blockHeight);
                    mud.Location = new Point(j * blockWidth, i * blockHeight + offsetY);
                    gamePanel.Controls.Add(mud);
                }
            }
        }

        private void gamePanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void gamePanel_MouseClick(object sender, MouseEventArgs e)
        {
            int adjustedX = e.X - (e.X % blockWidth);
            int adjustedY = e.Y - (e.Y % blockHeight);

            if (e.Button == MouseButtons.Right)
            {
                if (currentBlock == "mud")
                {
                    Mud mud = new Mud(blockWidth, blockHeight);
                    gamePanel.Controls.Add(mud);
                    mud.Location = new Point(adjustedX, adjustedY);
                }
                else if (currentBlock == "rock")
                {
                    Rock rock = new Rock(blockWidth, blockHeight);
                    gamePanel.Controls.Add(rock);
                    rock.Location = new Point(adjustedX, adjustedY);
                }
            }
        }

        private void mudPicBox_Click(object sender, EventArgs e)
        {
            mudSelected.Visible = true;
            rockSelected.Visible = false;
            currentBlock = "mud";
        }

        private void rockPicBox_Click(object sender, EventArgs e)
        {
            rockSelected.Visible = true;
            mudSelected.Visible = false;
            currentBlock = "rock";
        }

        private void selectBar_Click(object sender, EventArgs e)
        {

        }

        private void selectPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<BlockState> blockStates = new List<BlockState>();

            foreach (Control control in gamePanel.Controls)
            {
                if (control is Mud || control is Rock)
                {
                    string blockType = control is Mud ? "Mud" : "Rock";

                    BlockState blockState = new BlockState
                    {
                        Type = blockType,
                        X = control.Location.X,
                        Y = control.Location.Y
                    };

                    blockStates.Add(blockState);
                }
            }

            // 將狀態序列化為 JSON 字符串
            string json = JsonConvert.SerializeObject(blockStates, Newtonsoft.Json.Formatting.Indented);

            // 保存到文件
            File.WriteAllText("savefile.json", json);

            pausePanel.Visible = false;
            startPanel.Visible = true;
        }


        private void resumeButton_Click(object sender, EventArgs e)
        {
            pausePanel.Visible = false;
            gamePanel.Visible = true;
            selectPanel.Visible = true;
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            pausePanel.Visible = false;
            gamePanel.Visible = false;
            startPanel.Visible = true;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void oldGameButton_Click(object sender, EventArgs e)
        {
            startPanel.Visible = false;
            gamePanel.Visible = true;
            selectPanel.Visible = true;

            LoadGame();
        }
    }
    public class Rock : PictureBox
    {
        private int _blockHeight;
        private int _blockWidth;
        public Rock(int width, int height)
        {
            this._blockHeight = height;
            this._blockWidth = width;
            this.BackgroundImage = Image.FromFile("img/block3.png");
            this.Height = _blockHeight;
            this.Width = _blockWidth;
            this.BackgroundImageLayout = ImageLayout.Zoom;
            this.MouseClick += Rock_MouseClick;
        }

        private void Rock_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Dispose();
            }
        }
    }

    public class Mud : PictureBox
    {
        private int _blockHeight;
        private int _blockWidth;
        public Mud(int width, int height)
        {
            this._blockHeight = height;
            this._blockWidth = width;
            this.BackgroundImage = Image.FromFile("img/block1.png");
            this.Height = _blockHeight;
            this.Width = _blockWidth;
            this.BackgroundImageLayout = ImageLayout.Zoom;
            this.MouseClick += Mud_MouseClick;
        }
        private void Mud_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Dispose();
            }
        }
    }
    public class Steve : PictureBox
    {
        private int _blockWidth;
        private int _blockHeight;
        public Steve(int width, int height)
        {
            this._blockWidth = width;
            this._blockHeight = height;
            this.BackgroundImage = Image.FromFile("img/steve.png");
            this.Height = _blockHeight;
            this.Width = _blockWidth;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }

    public class BlockState
    {
        public string Type { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    }

}
