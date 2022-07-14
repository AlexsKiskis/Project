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

namespace workingversion
{
    /// <summary>
    /// Логика взаимодействия для WindowTest.xaml
    /// </summary>
    public partial class WindowTest : Window
    {
        public WindowTest()
        {
            InitializeComponent();
        }
        private void ExitButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void MinButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void MaxButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Maximized;
        }

        private void NormalButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Normal;
        }
        private void ToolBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void LogoContainer_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int point = 0;

            if (rb1.IsChecked == true) point++;
            if (rb6.IsChecked == true) point++;
            if (rb8.IsChecked == true) point++;
            if (rb12.IsChecked == true) point++;
            if (rb13.IsChecked == true) point++;

            Result.Text = $"Ваш результат: {point}";
        }

        private void Back_Categories(object sender, RoutedEventArgs e)
        {
            
                WindowCategories windowCategories = new WindowCategories();
                windowCategories.Show();
                this.Close();

            
        }
    }
}
