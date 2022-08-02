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

namespace VkSMMDesign_edition
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

        private void OpenBtn_Click(object sender, RoutedEventArgs e)
        {
            SettingMenu.Visibility = Visibility.Visible;
            ScrollingMenu.Visibility = Visibility.Visible;
            OpenBtn.Visibility = Visibility.Hidden;
            CloseMenuBtn.Visibility = Visibility.Visible;

        }

        private void CloseMenuBtn_Click(object sender, RoutedEventArgs e)
        {
            SettingMenu.Visibility = Visibility.Hidden;
            ScrollingMenu.Visibility = Visibility.Hidden;
            OpenBtn.Visibility = Visibility.Visible;
            CloseMenuBtn.Visibility = Visibility.Hidden;
        }
    }
}
