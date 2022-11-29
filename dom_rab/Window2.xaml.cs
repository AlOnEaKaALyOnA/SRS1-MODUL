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
using System.Windows.Shapes;

namespace dom_rab
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow back_2 = new MainWindow();
            this.Hide();
            back_2.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var text = txt_1.Text.Split(new[] { ',', '.', ' ', ';', ':', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
            txt_2.Text = (string.Join(" ", text.Reverse()));
        }
    }
}
