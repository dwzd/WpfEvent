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

namespace WpfEvent
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DispatcherTimer timer1 = new DispatcherTimer();
            timer1.Interval = TimeSpan.FromSeconds(1);
            timer1.Tick += Timer1_Tick; //触发一个事件
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

            TimeTextBox.Text = DateTime.Now.ToString();
            GreetingText.Text = DateTime.Now.Hour < 12 ? "Good Morning!" : "Good Afternoon!";
        }

        private void TimeTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
