using System.Diagnostics;
using System.Windows;

namespace NightyNight
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void StartButton_OnClick(object sender, RoutedEventArgs e)
        {
            int timeInMinutes = 45;
            
            var time = int.TryParse(ShutdownTimeTextBox.Text, out timeInMinutes) ? (timeInMinutes * 60).ToString() : "2700";

            Process.Start("shutdown.exe", "-s -t " + time);
        }

        private void AbortButton_OnClick(object sender, RoutedEventArgs e)
        {
            Process.Start("shutdown.exe", "-a");
        }
    }
}
