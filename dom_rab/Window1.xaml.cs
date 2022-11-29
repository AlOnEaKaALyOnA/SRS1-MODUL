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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {         
            int n = int.Parse(TextBox1.Text);
            int b = 1;
            for (int i = 1; i <= n; i++)
            {
                if (n <= 100)
                
                    b *= i;
                else //if(n > 100)
                {
                        TextBox2.Text = "Число больше 100";
                    
                }
            }
            b = b * 2;
            TextBox2.Text = b.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow back = new MainWindow();
            this.Hide();
            back.ShowDialog();
        }
    }
}
