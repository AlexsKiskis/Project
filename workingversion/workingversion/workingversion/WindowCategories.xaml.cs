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
    /// Логика взаимодействия для WindowCategories.xaml
    /// </summary>
    public partial class WindowCategories : Window
    {
        public WindowCategories()
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
            WindowTest winTest = new WindowTest();
            winTest.Show();
            this.Close();
        }

        private void Back_Languages(object sender, RoutedEventArgs e)
        {
            WindowLanguages windowLanguages = new WindowLanguages();
            windowLanguages.Show();
            this.Close();
        }
    }
}
