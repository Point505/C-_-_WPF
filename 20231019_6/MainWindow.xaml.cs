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

namespace _20231019_6
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Grid grid = new Grid();
            //this.Content = grid;


            //TextBlock tbx1 = new TextBlock();
            //tbx1.Text = "Hello WPF!";
            //tbx1.FontSize = 15;

            //grid.Children.Add(tbx1);

            //Button btn1 = new Button();
            //btn1.Content = "Click";
            //btn1.Height = 100;
            //btn1.Width = 100;
            //btn1.FontSize = 15;

            //grid.Children.Add(btn1);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
