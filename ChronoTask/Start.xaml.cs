using System;
using System.Windows;
using System.Windows.Threading;

namespace ChronoTask
{
    public partial class Start : Window
    {
        public Start()
        {
            InitializeComponent();

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(3);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
           
            DispatcherTimer timer = sender as DispatcherTimer;
            timer.Stop();

           
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();

            
            this.Close();
        }
    }
}
