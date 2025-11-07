using System;
using System.Windows.Forms;
namespace FirsovaHW12
{
    public partial class Form1 : Form
    {
        private int clicks = 0;
        private int timer = 10;
        private System.Windows.Forms.Timer gameTimer;
        public Form1()
        {
            InitializeComponent();
            InitializeTimer();
            UpdateUI();
        }
        private void InitializeTimer()
        {
            gameTimer = new System.Windows.Forms.Timer();
            gameTimer.Interval = 1000;
            gameTimer.Tick += GameTimer_Tick;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!gameTimer.Enabled)
            {
                gameTimer.Start();
            }

            clicks++;
            UpdateUI();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResetGame();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void ResetGame()
        {
            gameTimer.Stop();
            clicks = 0;
            timer = 10;
            button1.Enabled = true;
            UpdateUI();
        }

        private void UpdateUI()
        {
            label1.Text = $"Время: {timer}";
            label2.Text = $"Нажатий: {clicks}";
        }
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            timer--;

            if (timer <= 0)
            {
                gameTimer.Stop();
                button1.Enabled = false;
            }

            UpdateUI();
        }
    }
}
