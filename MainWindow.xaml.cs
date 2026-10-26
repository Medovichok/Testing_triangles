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

namespace Testing_triangles
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

        private void btnResult_Click(object sender, RoutedEventArgs e)
        {
            int sideA, sideB, sideC;
            string result;

            if (!int.TryParse(tbSideA.Text, out sideA))
            {
                MessageBox.Show("Первое число введено неверно", "Контроль над вводом", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (!int.TryParse(tbSideB.Text, out sideB))
            {
                MessageBox.Show("Второе число введено неверно", "Контроль над вводом", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (!int.TryParse(tbSideC.Text, out sideC))
            {
                MessageBox.Show("Третье число введено неверно", "Контроль над вводом", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                MessageBox.Show("Длины должны быть больше 0", "Контроль над вводом", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
            {
                MessageBox.Show("Это не треугольник", "Результат", MessageBoxButton.OK, MessageBoxImage.Information);
                tbSideA.Clear();
                tbSideB.Clear();
                tbSideC.Clear();
                return;
            }

            if (sideA == sideB && sideB == sideC)
            {
                result = "Равносторонний";
            }
            else if (sideA == sideB || sideA == sideC || sideB == sideC)
            {
                result = "Равнобедренный";
            }
            else
            {
                result = "Разносторонний";
            }

            MessageBox.Show($"Треугольник {result}", "Результат", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
