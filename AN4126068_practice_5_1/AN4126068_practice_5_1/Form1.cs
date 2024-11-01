using System;
using System.Drawing;
using System.Windows.Forms;

namespace HW5_1
{
    public partial class Form1 : Form
    {
        private bool keyLeft = false;
        private bool keyRight = false;
        private Timer moveTimer;
        private Timer dropTimer;
        private Random random;
        private int catched;
        private int notCatched;

        public Form1()
        {
            InitializeComponent();
            random = new Random();
            this.KeyPreview = true;  // 確保表單可以接收鍵盤輸入
            startPanel.Visible = true;
            gamePanel.Visible = false;

            // 初始化 Timer
            moveTimer = new Timer();
            moveTimer.Interval = 30;  // 每30毫秒觸發一次
            moveTimer.Tick += MoveTimer_Tick;

            // Drop Timer
            dropTimer = new Timer();
            dropTimer.Interval = 50;
            dropTimer.Tick += DropTimer_Tick;
            dropTimer.Start();
        }

        private void startButton_Click_1(object sender, EventArgs e)
        {
            startPanel.Visible = false;
            gamePanel.Visible = true;
            gameStart();
            genFruit();
        }

        private void gameStart()
        {
            fruit.Visible = false;
            this.KeyPreview = true;  // 確保表單可以接收鍵盤輸入
            plate.Location = new Point(this.ClientSize.Width / 2 - plate.Width / 2, this.ClientSize.Height - 50);
            gamePanel.Controls.Add(plate);

            // 開始計時器，用於控制盤子的持續移動
            moveTimer.Start();

            // 綁定 KeyDown 和 KeyUp 事件
            this.KeyDown -= OnKeyDown;
            this.KeyDown += OnKeyDown;
            this.KeyUp -= OnKeyUp;
            this.KeyUp += OnKeyUp;
        }

        // 處理按鍵狀態，移動盤子
        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                keyLeft = true;
            }
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                keyRight = true;
            }
        }

        private void OnKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                keyLeft = false;
            }
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                keyRight = false;
            }
        }

        private void MoveTimer_Tick(object sender, EventArgs e)
        {
            int speed = 10;

            // 檢查 Shift 鍵是否按下
            if (Control.ModifierKeys == Keys.Shift)
            {
                speed = 30;  // 按住 Shift 時加速
            }

            if (keyLeft)
            {
                plateMoveLeft(speed);
            }
            if (keyRight)
            {
                plateMoveRight(speed);
            }
        }

        private void plateMoveRight(int speed)
        {
            if (plate.Left + plate.Width < this.ClientSize.Width)
            {
                plate.Left += speed;
            }
        }

        private void plateMoveLeft(int speed)
        {
            if (plate.Left > 0)
            {
                plate.Left -= speed;
            }
        }

        private void genFruit()
        {
            PictureBox fruit = new PictureBox();
            fruit.Size = new Size(50, 50);  // 設定水果的大小
            fruit.BackColor = Color.Green;  // 設定水果的顏色 (你可以換成圖片)
            fruit.Tag = "fruit";            // 使用 Tag 標記這是水果物件

            // 隨機生成 X 軸位置
            int randomX = random.Next(0, this.ClientSize.Width - fruit.Width);
            fruit.Location = new Point(randomX, 0);  // 從頂部開始掉落
            fruit.Visible = true;
            // 將水果添加到表單中
            gamePanel.Controls.Add(fruit);

        }

        private void DropTimer_Tick(object sender, EventArgs e)
        {
            int speed = 10;

            foreach (Control control in gamePanel.Controls)
            {
                if (control is PictureBox && control.Tag == "fruit")
                {
                    PictureBox fruit = (PictureBox)control;
                    fruit.Top += speed;  // 每次下落 5 像素

                    // 當水果到達底部，將其移除
                    if (fruit.Top > this.ClientSize.Height)
                    {
                        this.Controls.Remove(fruit);
                        notCatched += 1;
                        fruit.Dispose();
                    }
                    else
                    {
                        if (IsCaught(fruit))
                        {
                            gamePanel.Controls.Remove(fruit);
                            fruit.Dispose();
                            catched += 1;
                            // 可在此處增加得分或處理邏輯
                        }
                    }
                    score.Text = catched.ToString() + " / " + notCatched.ToString();
                }
            }
            if (random.Next(0, 100) < 10)
            {
                genFruit();
            }
        }

        private bool IsCaught(PictureBox fruit)
        {
            // 檢查是否捕獲
            if (fruit.Bounds.IntersectsWith(plate.Bounds))
            {
                return true;
            }
            return false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gamePanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
