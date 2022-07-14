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
    /// Логика взаимодействия для WindowInput.xaml
    /// </summary>
    public partial class WindowInput : Window
    {
        public WindowInput()
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

        private void tb1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Tgb_Checked(object sender, RoutedEventArgs e)
        {

        }
        private void OnPasswordChanged(object sender, RoutedEventArgs e)
        {
            if (tb2.Password.Length > 0)
            {
                Watermark.Visibility = Visibility.Collapsed;
            }
            else
            {
                Watermark.Visibility = Visibility.Visible;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var mainWin = new MainWindow();
            mainWin.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AppContext db = new AppContext();
            List<Table> tables = db.Tables.ToList();
            bool flag = false;
            foreach(var scan in tables)
            {

                if (scan.Login == tb1.Text && scan.Password == tb2.Password)
                {
                    WindowLanguages winLang = new WindowLanguages();
                    winLang.Show();
                    this.Close();
                    flag = false;
                    break;
                }
                else flag = true;
            }
            if(flag) MessageBox.Show("Введён неверный логин или пароль");
        }
    }
}