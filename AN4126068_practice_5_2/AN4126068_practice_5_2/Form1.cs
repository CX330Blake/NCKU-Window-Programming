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
        Game game;
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

        public void CardiganBack()
        {
            CardiganLabel.Visible = true;
        }

        public void MyrtleBack()
        {
            MyrtleLabel.Visible = true;
        }
        public void MelanthaBack()
        {
            MelanthaLabel.Visible = true;
        }

        public void updateView()
        {
            moneyLabel.Text = this.game.money.ToString();
            heart.Text = $"{this.game.heart.ToString()}/{Game.maxHeart.ToString()}";
            if (this.game.heart <= 0)
            {
                this.Controls.Clear();
                Label label = new Label();
                label.Text = "Game Over, You Lose";
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Font = new Font("Arial", 24);
                label.Dock = DockStyle.Fill;
                this.Controls.Add(label);
                this.game.end();
            }
            else if (this.game.enemyCount == 0)
            {
                this.Controls.Clear();
                Label label = new Label();
                label.Text = "Game Over, You Win";
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Font = new Font("Arial", 24);
                label.Dock = DockStyle.Fill;
                this.Controls.Add(label);
                this.game.end();
            }
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
                    CardiganLabel.Visible = true;
                    CardiganLabel.Enabled = true;
                    CardiganLabel.MouseDown += new MouseEventHandler(Label_MouseDown);
                }
                else if (character == "Myrtle")
                {
                    MyrtleLabel.Visible = true;
                    MyrtleLabel.Enabled = true;
                    MyrtleLabel.MouseDown += new MouseEventHandler(Label_MouseDown);
                }
                else if (character == "Melantha")
                {
                    MelanthaLabel.Visible = true;
                    MelanthaLabel.Enabled = true;
                    MelanthaLabel.MouseDown += new MouseEventHandler(Label_MouseDown);
                }
            }
            initBattleField();
            this.game = new Game(battleField, characters);
            updateView();
            this.game.start();
        }
        private void Label_MouseDown(object sender, MouseEventArgs e)
        {
            Label label = sender as Label;
            if (label != null)
            {
                // 開始拖放，將文本框的名字作為數據傳遞
                label.DoDragDrop(label.Text, DragDropEffects.Copy);
            }
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

            battleField.AllowDrop = true;
            battleField.DragEnter += new DragEventHandler(battleField_DragEnter);
            battleField.DragDrop += new DragEventHandler(battleField_DragDrop);

            battleField.Paint += new PaintEventHandler(battleField_Paint);
        }

        private void battleField_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen obstaclePen = new Pen(Color.Red, 2);  // 使用紅色繪制障礙物邊界

            // 遍歷每個障礙物，並在畫布上繪制其邊界
            foreach (Rectangle obstacle in Game.obstacles)
            {
                g.DrawRectangle(obstaclePen, obstacle);
            }

            obstaclePen.Dispose();  // 釋放筆資源
        }


        private void battleField_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void battleField_DragDrop(object sender, DragEventArgs e)
        {
            string characterName = (string)e.Data.GetData(DataFormats.Text);

            Label characterBox = null;

            if (characterName == "Cardigan")
            {
                characterBox = new Cardigan();  // 創建 Cardigan PictureBox
                if (game.money < Cardigan.cost)
                {
                    return;
                }
                game.money -= Cardigan.cost;
                CardiganLabel.Visible = false;
            }
            else if (characterName == "Myrtle")
            {
                characterBox = new Myrtle(null);  // 創建 Myrtle PictureBox
                if (game.money < Myrtle.cost)
                {
                    return;
                }
                game.money -= Myrtle.cost;
                MyrtleLabel.Visible = false;
            }
            else if (characterName == "Melantha")
            {
                characterBox = new Melantha();  // 創建 Melantha PictureBox
                if (game.money < Melantha.cost)
                {
                    return;
                }
                game.money -= Melantha.cost;
                MelanthaLabel.Visible = false;
            }

            if (characterBox != null)
            {
                characterBox.Size = new Size(50, 50);  // 設置大小
                characterBox.BackColor = Color.LightGray;  // 設置背景顏色

                // 設置 PictureBox 在 battleField 中的位置
                Point dropLocation = battleField.PointToClient(new Point(e.X, e.Y));

                int column = dropLocation.X / (battleField.Width / battleField.ColumnCount);
                int row = dropLocation.Y / (battleField.Height / battleField.RowCount);

                if (column < battleField.ColumnCount && row < battleField.RowCount)
                {
                    // 將角色添加到指定的行列位置
                    battleField.Controls.Add(characterBox, column, row);
                    Game.obstacles.Add(new Rectangle(
                        characterBox.Location.X,
                        characterBox.Location.Y,
                        characterBox.Width,
                        characterBox.Height
                    ));

                }
                updateView();
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

        private void CardiganTextBox_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

    public class Game
    {
        public TableLayoutPanel bf;
        public TableLayoutPanel army;
        public const int maxHeart = 3;
        public int heart = 3;
        public int money = 30;
        public int enemyCount = 5;


        public static List<Rectangle> obstacles = new List<Rectangle>();

        public Game(TableLayoutPanel battleField, List<string> characters)
        {
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

        public void opponent_attack(Opponent o)
        {
            Label enemy = o.generateEnemy();
            Control parentContainer = bf.Parent;

            // 如果 o 的父容器和 enemy 的父容器不同，則計算坐標的轉換
            Point relativeLocation = parentContainer.PointToClient(o.Parent.PointToScreen(o.Location));

            // 設置 enemy 的初始位置為相對於父容器的坐標
            enemy.Location = relativeLocation;

            bf.Parent.Controls.Add(enemy);

            enemy.BringToFront();

            o.StartMovingEnemy(enemy);
        }


        public void end()
        {
            foreach (Control control in bf.Controls)
            {
                if (control is Opponent opponent)
                {
                    opponent.StopMoving(); // 创建一个方法来停止敌人的定时器
                }
            }
            this.bf.Controls.Clear();  // 清理游戏界面控件
            obstacles.Clear();  // 清空障碍物列表
        }

        public void start()
        {

            Opponent opponent = new Opponent(bf, this);
            Player player = new Player();

            placeOnBF(bf, opponent, 1, 2);
            placeOnBF(bf, player, 11, 2);

            opponent_attack(opponent);
            enemyCount--;
        }



    }
    public class Cardigan : Label
    {
        public string name = "Cardigan";
        public int hp = 2130;
        public int maxHp = 2130;
        public int atk = 305;
        public int def = 475;
        public static int cost = 18;
        public int cd = 20;
        private Timer cdTimer;


        public Cardigan()
        {
            this.AutoSize = false;
            this.Size = new Size(50, 50);
            this.Text = $"{name}\n{hp}/{maxHp}\n{cd}";
            this.TextAlign = ContentAlignment.MiddleCenter;
            this.Font = new Font("Arial", 5);
            this.Click += Cardigan_Click;

            // CD
            this.Enabled = false;
            cdTimer = new Timer();
            cdTimer.Interval = 1000;  // 設定1秒觸發一次
            cdTimer.Tick += CdTimer_Tick;
            cdTimer.Start();  // 開始計時
        }

        private void Cardigan_Click(object sender, EventArgs e)
        {
            skill();
        }

        private void CdTimer_Tick(object sender, EventArgs e)
        {
            if (cd > 0)
            {
                cd--;  // 每秒減少 1
                UpdateDisplay();  // 更新顯示文字
            }
            else
            {
                cdTimer.Stop();  // 冷卻時間到達 0，停止計時器
            }
        }

        private void UpdateDisplay()
        {
            if (cd == 0)
            {
                this.BackColor = Color.Green;
                this.Enabled = true;
            }
            else
            {
                this.BackColor = Color.LightGray;
                this.Enabled = false;
            }
            this.Text = $"{name}\n{hp}/{maxHp}\n{cd}";
        }

        private void skill()
        {
            this.hp += (int)(maxHp * 0.4);
            if (this.hp > this.maxHp)
            {
                this.hp = this.maxHp;
            }
            cd = 20;
            cdTimer.Start();
            UpdateDisplay();
        }
    }

    public class Myrtle : Label
    {
        public string name = "Myrtle";
        private Game game;
        public int hp = 1565;
        public int maxHp = 1565;
        public int atk = 520;
        public int def = 300;
        public static int cost = 10;
        public int cd = 22;
        private Timer cdTimer;

        public Myrtle(Game game)
        {
            this.game = game;
            this.AutoSize = false;
            this.Size = new Size(50, 50);
            this.Text = $"{name}\n{hp}/{maxHp}\n{cd}";
            this.TextAlign = ContentAlignment.MiddleCenter;
            this.Font = new Font("Arial", 5);
            // CD
            this.Enabled = false;
            cdTimer = new Timer();
            cdTimer.Interval = 1000;  // 設定1秒觸發一次
            cdTimer.Tick += CdTimer_Tick;
            cdTimer.Start();  // 開始計時
        }


        private void CdTimer_Tick(object sender, EventArgs e)
        {
            if (cd > 0)
            {
                cd--;  // 每秒減少 1
                UpdateDisplay();  // 更新顯示文字
            }
            else
            {
                cdTimer.Stop();  // 冷卻時間到達 0，停止計時器
            }
        }

        private void UpdateDisplay()
        {
            if (cd == 0)
            {
                this.BackColor = Color.Green;
                this.Enabled = true;
            }
            else
            {
                this.BackColor = Color.LightGray;
                this.Enabled = false;
            }
            this.Text = $"{name}\n{hp}/{maxHp}\n{cd}";
        }
        private void skill()
        {
            game.money += 14;
        }
    }

    public class Melantha : Label
    {
        public string name = "Melantha";
        public int hp = 2745;
        public int maxHp = 2745;
        public int atk = 738;
        public int def = 155;
        public static int cost = 15;
        public int cd = 40;
        private Timer cdTimer;

        public Melantha()
        {
            this.AutoSize = false;
            this.Size = new Size(50, 50);
            this.Text = $"{name}\n{hp}/{maxHp}\n{cd}";
            this.TextAlign = ContentAlignment.MiddleCenter;
            this.Font = new Font("Arial", 5);

            // CD
            this.Enabled = false;
            cdTimer = new Timer();
            cdTimer.Interval = 1000;  // 設定1秒觸發一次
            cdTimer.Tick += CdTimer_Tick;
            cdTimer.Start();  // 開始計時
        }
        private void CdTimer_Tick(object sender, EventArgs e)
        {
            if (cd > 0)
            {
                cd--;  // 每秒減少 1
                UpdateDisplay();  // 更新顯示文字
            }
            else
            {
                cdTimer.Stop();  // 冷卻時間到達 0，停止計時器
            }
        }
        private void UpdateDisplay()
        {
            if (cd == 0)
            {
                this.BackColor = Color.Green;
                this.Enabled = true;
            }
            else
            {
                this.BackColor = Color.LightGray;
                this.Enabled = false;
            }
            this.Text = $"{name}\n{hp}/{maxHp}\n{cd}";
        }
        private void skill()
        {
        }
    }

    public class Opponent : PictureBox
    {
        TableLayoutPanel battleField;
        Game game;
        public int hp = 15000;
        public int atk = 600;
        public int def = 300;
        public int cd = 5;
        private Timer moveTimer;
        private int speed = 2;
        Label enemy;

        public Opponent(TableLayoutPanel battleField, Game game)
        {
            this.BackColor = Color.Red;
            this.game = game;
            this.battleField = battleField;
        }

        public void StopMoving()
        {
            if (moveTimer != null)
            {
                moveTimer.Stop();  // 停止敌人的移动定时器
            }
        }

        public Label generateEnemy()
        {
            Label enemy = new Label();
            enemy.Text = $"{hp}";
            enemy.TextAlign = ContentAlignment.MiddleCenter;
            enemy.Size = new Size(this.Size.Width, this.Size.Height);
            enemy.BackColor = Color.Orange;
            return enemy;
        }
        private Control HitObstacle(Label enemy)
        {
            // This is important!!!!!
            Point enemyLocationInBattleField = battleField.PointToClient(enemy.Parent.PointToScreen(enemy.Location));
            Rectangle enemyBounds = new Rectangle(enemyLocationInBattleField.X, enemyLocationInBattleField.Y, enemy.Width, enemy.Height);
            // Rectangle enemyBounds = new Rectangle(enemy.Location.X, enemy.Location.Y, enemy.Width, enemy.Height);
            foreach (Control control in battleField.Controls)
            {
                if (control is PictureBox || control is Label)  // 只檢查 PictureBox 或 Label
                {
                    Rectangle obstacleBounds = new Rectangle(control.Location.X, control.Location.Y, control.Width, control.Height);

                    if (enemyBounds.IntersectsWith(obstacleBounds))
                    {
                        return control;  // 返回碰到的對象
                    }
                }
            }
            return null;
        }

        private void updateView()
        {
            enemy.Text = $"{hp}";
        }

        public void StartMovingEnemy(Label enemy)
        {
            MessageBox.Show("TEST");
            if (moveTimer == null)
            {// 創建一個定時器，每 50 毫秒觸發一次
                moveTimer = new Timer();
                moveTimer.Interval = 50;
                moveTimer.Tick += (s, e) => MoveEnemyStep(enemy);  // 使用 Lambda 來傳遞 enemy
                moveTimer.Start();
            }
            else
            {
                moveTimer.Start();
            }

        }

        private void MoveEnemyStep(Label enemy)
        {
            this.enemy = enemy;
            // 檢查是否已超出視窗邊界
            if (this.enemy.Left + this.enemy.Width >= this.Parent.ClientSize.Width)
            {
                // 停止移動並關閉定時器
                moveTimer.Stop();
                this.enemy.Dispose();
                game.heart--;
                game.opponent_attack(this);
                Form1 form = (Form1)battleField.FindForm();
                form.updateView();
                return;
            }

            //Point enemyLocationInBattleField = battleField.PointToClient(enemy.Parent.PointToScreen(enemy.Location));

            //using (Graphics g = battleField.CreateGraphics())
            //{
            //    // 清除之前的矩形

            //    // 計算敵人的矩形
            //    Rectangle enemyBounds = new Rectangle(enemyLocationInBattleField.X, enemyLocationInBattleField.Y, enemy.Width, enemy.Height);
            //    g.DrawRectangle(Pens.Green, enemyBounds);

            //    // 繪製障礙物的矩形
            //    foreach (Rectangle obstacle in Game.obstacles)
            //    {
            //        g.DrawRectangle(Pens.Red, obstacle);
            //    }
            //}

            // 如果检测到障碍物
            Control target = HitObstacle(enemy);
            if (target != null && target is Label label)
            {
                // 停止移動並攻擊目標
                moveTimer.Stop();
                StartAttackingTarget(target);
                //return;
            }

            enemy.Left += speed;
        }

        private void StartAttackingTarget(Control target)
        {
            // 創建一個攻擊計時器
            Timer attackTimer = new Timer();
            attackTimer.Interval = 1000;  // 每秒攻擊一次
            attackTimer.Tick += (s, e) =>
            {
                AttackTarget(target, attackTimer);
            };
            attackTimer.Start();
        }

        private void AttackTarget(Control target, Timer attackTimer)
        {
            // 假設 target 是 Label 並有 hp 屬性
            if (target is Label label)
            {
                if (label is Cardigan cardigan)
                {
                    cardigan.hp -= atk;  // 減少 hp
                    this.hp -= cardigan.atk;  // 同時受到對方的攻擊
                    updateView();
                    if (this.hp <= 0)
                    {
                        attackTimer.Stop();
                        attackTimer.Dispose();
                        enemy.Dispose();
                        this.hp = 15000;
                    }
                    if (cardigan.hp <= 0)
                    {
                        cardigan.hp = 0;
                        target.Visible = false;  // 隱藏目標，表示被擊敗

                        Form1 form = (Form1)battleField.FindForm();
                        form.CardiganBack();
                        Game.obstacles.Remove(new Rectangle(target.Location.X, target.Location.Y, target.Width, target.Height));
                        attackTimer.Stop();
                        attackTimer.Dispose(); // 停止攻击计时器
                        StartMovingEnemy(this.enemy);  // 重新启动敌人移动
                        return;
                    }
                }
                else if (label is Myrtle myrtle)
                {
                    myrtle.hp -= atk;
                    this.hp -= myrtle.atk;  // 同時受到對方的攻擊
                    updateView();
                    if (this.hp <= 0)
                    {
                        attackTimer.Stop();
                        attackTimer.Dispose();
                        enemy.Dispose();
                        this.hp = 15000;
                    }
                    if (myrtle.hp <= 0)
                    {
                        myrtle.hp = 0;
                        target.Visible = false;

                        Form1 form = (Form1)battleField.FindForm();
                        form.MyrtleBack();
                        Game.obstacles.Remove(new Rectangle(target.Location.X, target.Location.Y, target.Width, target.Height));
                        attackTimer.Stop();
                        attackTimer.Dispose();  // 停止攻击计时器
                        StartMovingEnemy(this.enemy);  // 重新启动敌人移动
                        return;
                    }
                }
                else if (label is Melantha melantha)
                {
                    melantha.hp -= atk;
                    this.hp -= melantha.atk;  // 同時受到對方的攻擊
                    updateView();
                    if (this.hp <= 0)
                    {
                        attackTimer.Stop();
                        attackTimer.Dispose();
                        enemy.Dispose();
                        this.hp = 15000;
                    }
                    if (melantha.hp <= 0)
                    {
                        melantha.hp = 0;
                        target.Visible = false;

                        Form1 form = (Form1)battleField.FindForm();
                        form.MelanthaBack();
                        Game.obstacles.Remove(new Rectangle(target.Location.X, target.Location.Y, target.Width, target.Height));
                        attackTimer.Stop();
                        attackTimer.Dispose();  // 停止攻击计时器
                        StartMovingEnemy(this.enemy);  // 重新启动敌人移动
                        return;
                    }
                }
            }
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
