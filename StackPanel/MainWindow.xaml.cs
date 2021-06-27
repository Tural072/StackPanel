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

namespace StackPanel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random random = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            Color randomColor = Color.FromRgb((byte)random.Next(256), (byte)random.Next(256), (byte)random.Next(256));
            var btn = sender as Button;
            SolidColorBrush brush = new SolidColorBrush(randomColor);
            btn.Background = brush;
            MessageBox.Show($@"I am button.
My name is {btn.Content}.");
        }

        private void Btn_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            var btn = sender as Button;
            SP123.Children.Remove(btn);
            SP456.Children.Remove(btn);
            this.Title = (string)btn.Content;
        }
    }
}
