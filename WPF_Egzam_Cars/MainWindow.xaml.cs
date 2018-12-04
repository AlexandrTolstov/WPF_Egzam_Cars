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

namespace WPF_Egzam_Cars
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public static class ColorsMenu
    {
        public static SolidColorBrush YellowColor = new SolidColorBrush(Color.FromRgb(251, 187, 0));
        public static SolidColorBrush GrayColor = new SolidColorBrush(Color.FromRgb(61, 61, 61));
        public static SolidColorBrush OrangeColor = new SolidColorBrush(Color.FromRgb(255, 128, 0));
    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        #region События кнопки Главное
        private void ButtonGlav_MouseEnter(object sender, MouseEventArgs e)
        {
            BorderHome.Background = ColorsMenu.YellowColor;
            BorderHome1.Background = ColorsMenu.YellowColor;
            ImageHome.Source = new BitmapImage(new Uri(@"Menu_png\i.png", UriKind.RelativeOrAbsolute));
        }
        private void ButtonGlav_MouseLeave(object sender, MouseEventArgs e)
        {
            BorderHome.Background = ColorsMenu.GrayColor;
            BorderHome1.Background = ColorsMenu.GrayColor;
            ImageHome.Source = new BitmapImage(new Uri(@"Menu_png\Home.png", UriKind.RelativeOrAbsolute));
        }
        private void ButtonGlav_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            BorderHome.Background = ColorsMenu.OrangeColor;
            BorderHome1.Background = ColorsMenu.OrangeColor;
        }
        private void ButtonGlav_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            BorderHome.Background = ColorsMenu.YellowColor;
            BorderHome1.Background = ColorsMenu.YellowColor;
        }
        #endregion
    }
}
