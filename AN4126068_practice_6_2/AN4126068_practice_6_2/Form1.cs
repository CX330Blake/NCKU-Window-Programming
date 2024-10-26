using System;
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

            gamePanel.Visible = false;
            gamePanel.AutoScroll = true;
            gamePanel.Padding = new Padding(0);
            gamePanel.Margin = new Padding(0);

            rockSelected.Visible = false;
            mudSelected.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startPanel.Visible = false;
            gamePanel.Visible = true;
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
}
