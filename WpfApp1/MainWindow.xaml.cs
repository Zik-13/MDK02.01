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

namespace WpfApp1
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
            int num1 = Convert.ToInt32(first.Text);
            int num2 = Convert.ToInt32(second.Text);
            int num3 = Convert.ToInt32(frist.Text);
            
            if (num1 <= 0 || num2 <= 0 || num3 <= 0)
            {
                // неверные стороны треугольника
                MessageBox.Show("Вы ввели не правильные данные / неверные стороны треугольника");
                result.Text = "ERROR";
            }
            else if ( num1+num2 < num3 || num1+num3 < num2 || num2 + num3 < num1)
            {
                // неверные стороны треугольника
                MessageBox.Show("Вы ввели не правильные данные / неверные стороны треугольника");
                result.Text = "ERROR";
            }
            else
            {
                // все четко
                if (num1 == num2 && num1 == num3 && num2 == num3)
                {
                    // равносторонний треугольник
                    result.Text = "равносторонний";
                }
                else if (num1 == num2 || num1 == num3 || num2 == num3)
                {
                    // Равнобедренный
                    result.Text = "равнобедренный";
                }
                else
                {
                    // Разносторнний
                    result.Text = "разносторнний";
                }
            }


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Hide();
            
        }
    }
}
