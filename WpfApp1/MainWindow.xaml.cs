using System;
using System.Windows;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            try
            {
                num1 = Convert.ToInt32(first.Text);
                num2 = Convert.ToInt32(second.Text);
                num3 = Convert.ToInt32(frist.Text);
            }
            catch (FormatException) { MessageBox.Show("Вы ввели не правильные данные"); }


            Treygolnik treygolnik = new Treygolnik();
            result.Text = treygolnik.Info(num1, num2, num3);
            if (treygolnik.Info(num1, num2, num3) == "ERROR")
            {
                MessageBox.Show("Вы ввели не правильные стороны треугольника");
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
