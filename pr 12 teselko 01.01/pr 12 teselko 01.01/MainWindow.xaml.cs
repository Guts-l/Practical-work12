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
using System.Windows.Threading;

namespace pr_12_teselko_01._01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer;
        ThreeDigitNumber threeDigit = new();
        Coordinates coordinates = new();

        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Tick += Timer_Tick;
            timer.Interval = new TimeSpan(0, 0, 0, 0, 1);
            timer.IsEnabled = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            time.Content = d.ToString("HH:mm");
            date.Content = d.ToString("dd.MM.yyyy");
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void firstTabItem_GotFocus(object sender, RoutedEventArgs e)
        {
            if (firstTabItem.IsFocused)
                taskNumber.Content = firstTabItem.Header;
        }

        private void secondTabItem_GotFocus(object sender, RoutedEventArgs e)
        {
            if (secondTabItem.IsFocused)
                taskNumber.Content = secondTabItem.Header;
        }

        private void inputXY_TextChanged(object sender, TextChangedEventArgs e)
        {
            outputDistance.Clear();
        }

        private void inputDigit_TextChanged(object sender, TextChangedEventArgs e)
        {
            outputFirstNumber.Clear();
        }

        private void getDistance_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double x1 = Convert.ToInt32(inputX1.Text);
                double y1 = Convert.ToInt32(inputY1.Text);
                double x2 = Convert.ToInt32(inputX2.Text);
                double y2 = Convert.ToInt32(inputY2.Text);
                outputDistance.Text = coordinates.GetDistance(x1, y1, x2, y2).ToString();
            }
            catch
            {
                MessageBox.Show("Проверьте введенные данные", "Ошибка");
            }
        }

        private void about_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Практическая работа №12\n" +
                "Теселько Максим ИСП-34\n" +
                "Реализовать расчет задачи:\n" +
                "Найти расстояние между двумя точками с заданными координатами (x1, y1) и (x2, y2) на плоскости.\n" +
                "Дано трехзначное число. Используя одну операцию деления нацело, вывести первую цифру данного числа(сотни).", "О программе", MessageBoxButton.OK);
        }

        private void getProduct_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int number = Int32.Parse(inputNumber.Text);
                outputFirstNumber.Text = threeDigit.GetFirstNumber(number).ToString();
            }
            catch
            {
                MessageBox.Show("Проверьте введенные данные", "Ошибка");
            }
        }
    }
}
