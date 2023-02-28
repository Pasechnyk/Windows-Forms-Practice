using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Task - Create Shulte table with difficulty meter and time restrictions.

namespace ShulteTable
{
    public partial class Form1 : Form
    {
        private static Random random = new Random();
        private int timeInterval;
        private int secondsPassed;
        private int index = 1;

        public Form1()
        {
            InitializeComponent();
        }

        // timer method
        private void GameTimerTick(object sender, EventArgs e)
        {
            secondsPassed++;
            timeInterval--;
            timeTextBox.Text = secondsPassed.ToString();

            if (timeInterval == 0)
            {
                gameTimer.Stop();
                gameTrackBar.Value = 0;
                MessageBox.Show($"You lost!\n" +
                    $"You failed to finish on time.");
            }
        }

        // difficulty settings
        private void ChangeDifficulty(int value)
        {
            switch (value)
            {
                case 0:
                    timeInterval = 30;
                    break;
                case 1:
                    timeInterval = 20;
                    break;
                case 2:
                    timeInterval = 15;
                    break;
                case 3:
                    timeInterval = 10;
                    break;
                default:
                    break;
            }
        }
        private void GameTrackBarValueChanged(object sender, EventArgs e)
        {
            ChangeDifficulty(gameTrackBar.Value);
        }

        // give random numbers
        public static void ShuffleNumbers<T>(IList<T> values)
        {
            for (int i = values.Count - 1; i > 0; i--)
            {
                int k = random.Next(i + 1);
                T value = values[k];
                values[k] = values[i];
                values[i] = value;
            }
        }

        // first button click
        private void StartBtnClick(object sender, EventArgs e)
        {
            gameTimer.Start();

            List<int> num = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            ShuffleNumbers(num);

            int counter = 0;
            foreach (Button item in panel1.Controls.OfType<Button>())
            {
                item.BackColor = Color.LightGray;
                item.Text = num[counter].ToString();
                counter++;
            }
        }

        // main game function 
        private void RandomBtnClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            progressBar.Value = index;

            if (index == 9)
            {
                gameTimer.Stop();
                MessageBox.Show($"Congrats!\n Time: {secondsPassed}s.");
                index = 1;
            }
            else if (button.Text == index.ToString())
            {
                button.BackColor = Color.AliceBlue;
                index++;
            }
        }
    }
}
