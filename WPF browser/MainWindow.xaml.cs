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

namespace WPF_browser
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

        private void btnsearch_Click(object sender, RoutedEventArgs e)
        {
            myWebBrowser.Navigate(txtsearch.Text);
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            myWebBrowser.GoBack();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            myWebBrowser.GoForward();
        }
    }
}
