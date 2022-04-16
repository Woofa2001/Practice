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

namespace Practica_WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            PracticAgencyFrame.Navigate(new Pages.Vedomstva());
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            PracticAgencyFrame.Navigate(new Pages.ProgramPage());
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            PracticAgencyFrame.Navigate(new Pages.SubProgramPage());
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            PracticAgencyFrame.Navigate(new Pages.Co());
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            AutoritizationWindow window = new AutoritizationWindow();
            window.Show();
            Close();
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            PracticAgencyFrame.Navigate(new Pages.master_datails());
        }
    }
}
