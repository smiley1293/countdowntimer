using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace CountdownTimer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer countdownTimer;
        private int countdownValue;
        private int pausedCountdownValue;
        private int initialCountdownValue;

        public MainWindow()
        {
            InitializeComponent();
            MouseDoubleClick += (o, args) => StartCountdown();
        }

        private void StartCountdown()
        {
            if (countdownTimer != null && countdownTimer.IsEnabled)
            {
                // Đếm ngược đang chạy, không thực hiện lại
                return;
            }

            if (int.TryParse(CountdownInputTextBox.Text, out int inputSeconds))
            {
                countdownValue = inputSeconds;
                initialCountdownValue = inputSeconds;
                countdownTimer = new DispatcherTimer();
                countdownTimer.Interval = TimeSpan.FromSeconds(1);
                countdownTimer.Tick += CountdownTimer_Tick;
                countdownTimer.Start();
            }
        }

        private void StopCountdown()
        {
            if (countdownTimer != null && countdownTimer.IsEnabled)
            {
                countdownTimer.Stop();
            }
        }

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            if (countdownValue > 0)
            {
                countdownValue--;
                CountdownDisplay.Text = countdownValue.ToString();
            }
            else
            {
                StopCountdown();
                MessageBox.Show("Time's up!");
            }
        }

        private void CountdownReset()
        {
            countdownValue = 0;
            CountdownDisplay.Text = countdownValue.ToString();
            StopCountdown();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            StartCountdown();
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            StopCountdown();
        }

        private void PauseCountdown()
        {
            if (countdownTimer != null && countdownTimer.IsEnabled)
            {
                pausedCountdownValue = countdownValue; // Lưu trữ thời gian còn lại
                countdownTimer.Stop();
            }
        }

        private void ContinueCountdown()
        {
            if (pausedCountdownValue > 0)
            {
                countdownValue = pausedCountdownValue; // Gán thời gian còn lại cho countdownValue
                countdownTimer = new DispatcherTimer();
                countdownTimer.Interval = TimeSpan.FromSeconds(1);
                countdownTimer.Tick += CountdownTimer_Tick;
                countdownTimer.Start();
            }
        }

        private void PauseButton_Click(object sender, RoutedEventArgs e)
        {
            PauseCountdown();
        }

        private void ContinueButton_Click(object sender, RoutedEventArgs e)
        {
            ContinueCountdown();
        }

        private void ResetCountdown()
        {
            countdownValue = initialCountdownValue; // Reset thời gian về 0
            CountdownDisplay.Text = countdownValue.ToString(); // Cập nhật giao diện
            pausedCountdownValue = 0; // Reset thời gian dừng về 0
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            ResetCountdown();
        }
    }
}
