using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AN4126068_practice_5_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            startPanel.Controls.Add(startButton);
            startPanel.Visible = true;
            this.Controls.Add(chooseCharacterPanel);
            this.Controls.Add(gamePanel);

            chooseCharacterPanel.Visible = false;
            characterListBox.Items.Add("Cardigan");
            characterListBox.Items.Add("Myrtle");
            characterListBox.Items.Add("Melantha");

            gamePanel.Visible = false;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startPanel.Hide();
            chooseCharacterPanel.Visible = true;
        }

        private void characterListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string character;
            try
            {
                character = characterListBox.SelectedItem.ToString();
            }
            catch
            {
                return;
            }
            selectedCharacterListBox.Items.Add(character);
            characterListBox.Items.Remove(character);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string character;
            try
            {
                character = selectedCharacterListBox.SelectedItem.ToString();

            }
            catch
            {
                return;
            }
            characterListBox.Items.Add(character);
            selectedCharacterListBox.Items.Remove(character);
        }

        private void fightButton_Click(object sender, EventArgs e)
        {
            chooseCharacterPanel.Hide();
            gamePanel.Visible = true;
            gamePanel.BringToFront();
            gamePanel.BackColor = chooseCharacterPanel.BackColor;
            List<string> characters = new List<string>();
            foreach (string character in selectedCharacterListBox.Items)
            {
                characters.Add(character);
                if (character == "Cardigan")
                {
                    CardiganTextBox.Visible = true;
                }
                else if (character == "Myrtle")
                {
                    MyrtleTextBox.Visible = true;
                }
                else if (character == "Melantha")
                {
                    MelanthaTextBox.Visible = true;
                }
            }
            initBattleField();
            Game game = new Game(battleField, characters);
            game.start();
        }

        private void initBattleField()
        {
            int cols = 11;
            int rows = 3;

            // 計算每個單元格的大小，根據窗體寬度和高度選擇最小值
            int cellSize = Math.Min(
                (int)(this.ClientSize.Width * 0.9 / cols),
                (int)(this.ClientSize.Height * 0.9 / rows)
            );

            TableLayoutPanel bf = battleField;
            bf.BackColor = Color.White;
            bf.RowCount = rows;
            bf.ColumnCount = cols;

            // 設置 TableLayoutPanel 的總大小（寬度：單元格大小 * 列數，高度：單元格大小 * 行數）
            bf.Size = new Size(cellSize * cols, cellSize * rows);

            // 設置 TableLayoutPanel 的位置，使其居中
            bf.Location = new Point(
                (this.ClientSize.Width - bf.Width) / 2,  // 計算水平居中位置
                (this.ClientSize.Height - bf.Height) / 3 // 計算垂直居中位置
            );

            bf.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            bf.RowStyles.Clear();
            bf.ColumnStyles.Clear();

            // 設定每列和每行的樣式，使每個單元格是正方形
            for (int i = 0; i < cols; i++)
            {
                bf.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, cellSize));
            }

            for (int i = 0; i < rows; i++)
            {
                bf.RowStyles.Add(new RowStyle(SizeType.Absolute, cellSize));
            }
        }



        private void gamePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void battleFeild_Click(object sender, EventArgs e)
        {

        }

        private void battleFeild_Paint(object sender, PaintEventArgs e)
        {

        }

        private void army_Paint(object sender, PaintEventArgs e)
        {

        }
    }

    public class Game
    {
        public TableLayoutPanel bf;
        public TableLayoutPanel army;

        public int money = 30;
        public int enemyCount = 5;

        public Game(TableLayoutPanel battleField, List<string> characters)
        {
            foreach (string character in characters)
            {
            }
            this.bf = battleField;
        }
        private void placeOnBF(TableLayoutPanel battleField, PictureBox box, int col, int row)
        {
            col -= 1;
            row -= 1;
            if (col < battleField.ColumnCount && row < battleField.RowCount)
            {
                battleField.Controls.Add(box, col, row);
            }
        }

        private void opponent_attack(Opponent o)
        {
            PictureBox enemy = o.generateEnemy();

            Control parentContainer = bf.Parent;

            // 如果 o 的父容器和 enemy 的父容器不同，則計算坐標的轉換
            Point relativeLocation = parentContainer.PointToClient(o.Parent.PointToScreen(o.Location));

            // 設置 enemy 的初始位置為相對於父容器的坐標
            enemy.Location = relativeLocation;

            bf.Parent.Controls.Add(enemy);

            enemy.BringToFront();

            o.StartMovingEnemy(enemy);
        }


        public void start()
        {
            Opponent opponent = new Opponent();
            Player player = new Player();

            placeOnBF(bf, opponent, 1, 2);
            placeOnBF(bf, player, 11, 2);

            opponent_attack(opponent);
        }

    }
    public class Cardigan : PictureBox
    {
        public string name = "Cardigan";
        public int hp = 2130;
        public int atk = 305;
        public int def = 475;
        public int cost = 18;
        public int cd = 20;

        public Cardigan()
        {
        }

        private void skill()
        {
            this.hp += (int)(2130 * 0.4);
        }
    }
    public class Myrtle : PictureBox
    {
        public string name = "Myrtle";
        private Game game;
        public Myrtle(Game game)
        {
            this.game = game;
        }
        public int hp = 1565;
        public int atk = 520;
        public int def = 300;
        public int cost = 10;
        public int cd = 22;

        private void skill()
        {
            game.money += 14;
        }
    }

    public class Melantha : PictureBox
    {
        public string name = "Melantha";
        public int hp = 2745;
        public int atk = 738;
        public int def = 155;
        public int cost = 15;
        public int cd = 40;
        public Melantha()
        {
        }
        private void skill()
        {
        }
    }

    public class Opponent : PictureBox
    {
        public int hp = 15000;
        public int atk = 600;
        public int def = 300;
        public int cd = 5;
        private Timer moveTimer;
        private int speed = 2;
        public Opponent()
        {
            this.BackColor = Color.Red;
        }
        public PictureBox generateEnemy()
        {
            PictureBox enemy = new PictureBox();
            enemy.Size = new Size(this.Size.Width, this.Size.Height);
            enemy.BackColor = Color.Orange;
            return enemy;
        }
        public void StartMovingEnemy(PictureBox enemy)
        {
            // 創建一個定時器，每 50 毫秒觸發一次
            moveTimer = new Timer();
            moveTimer.Interval = 50;
            moveTimer.Tick += (s, e) => MoveEnemyStep(enemy);  // 使用 Lambda 來傳遞 enemy
            moveTimer.Start();
        }


        private void MoveEnemyStep(PictureBox enemy)
        {
            // 檢查是否已超出視窗邊界
            if (enemy.Left + enemy.Width >= this.Parent.ClientSize.Width)
            {
                // 停止移動並關閉定時器
                moveTimer.Stop();
                return;
            }
            // 向右移動 enemy
            enemy.Left += speed;
        }
    }
    public class Player : PictureBox
    {
        public Player()
        {
            this.BackColor = Color.Blue;
        }
    }
}
