using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using System.Windows.Threading;

namespace ButtonChaser
{
    public partial class MainPage : PhoneApplicationPage
    {
        Random random;
        int aWidth;
        int aHeight;
        int score;
        bool isDifficultLevelSelected = false;
        DispatcherTimer timer;
        DispatcherTimer gameTime;

        // Constructor
        public MainPage()
        {
            InitializeComponent();
            
            
        }

        public void setDifficulty(string level)
        {
            isDifficultLevelSelected = true;
            int seconds = 1000;
            random = new Random();
            timer = new DispatcherTimer();
            switch (level)
            {
                case "easy": seconds = 1000; break;
                case "medium": seconds = 100; break;
                case "hard": seconds = 10; break;
            }

            timer.Interval = new TimeSpan(0, 0, 0, 0, seconds);
            timer.Tick += new EventHandler(timer_Tick);
        }

        void timer_Tick(object sender, EventArgs e)
        {
            int x = random.Next(aWidth) - (int)button1.ActualWidth;
            int y = random.Next(aHeight) - (int)button1.ActualHeight;
            if (x < 10)
                x = 10;
            if (y < 10)
                y = 10;
            button1.Margin = new Thickness(x, y, 0, 0);
        }

        void gameTime_Tick(object sender, EventArgs e)
        {

            GameTime.Text = "Time Elapsed: " + 
                gameTime.Interval.Seconds.ToString();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            score += 1;
            ScoreTextBlock.Text = "Score: " + score;

        }

        private void ContentPanel_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            aWidth = (int)e.NewSize.Width;
            aHeight = (int)e.NewSize.Height;
        }

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            gameTime = new DispatcherTimer();
            gameTime.Interval = new TimeSpan(0, 0, 30);
            gameTime.Tick += new EventHandler(gameTime_Tick);
            gameTime.Start();
            timer.Start();
            
        }

        private void stopButton_Click(object sender, RoutedEventArgs e)
        {
            isDifficultLevelSelected = false;
            timer.Stop();

        }

        private void easyButton_Click(object sender, RoutedEventArgs e)
        {
            if (isDifficultLevelSelected)
                setDifficulty("easy");
            else
                MessageBox.Show("Please select a dificult level first.");
        }

        private void mediumButton_Click(object sender, RoutedEventArgs e)
        {
            if (isDifficultLevelSelected)
                setDifficulty("medium");
            else
                MessageBox.Show("Please select a dificult level first.");
        }

        private void hardButton_Click(object sender, RoutedEventArgs e)
        {
            if (isDifficultLevelSelected)
                setDifficulty("hard");
            else
                MessageBox.Show("Please select a dificult level first.");
        }
    }
}