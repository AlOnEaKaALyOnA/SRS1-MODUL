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

namespace dom_rab
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 question_1 = new Window1();
            this.Hide();
            question_1.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window2 question_2 = new Window2();
            this.Hide();
            question_2.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Window3 question_3 = new Window3();
            this.Hide();
            question_3.ShowDialog();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Window4 question_4 = new Window4();
            this.Hide();
            question_4.ShowDialog();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Window5 question_5 = new Window5();
            this.Hide();
            question_5.ShowDialog();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
