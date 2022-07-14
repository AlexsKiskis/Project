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

namespace workingversion
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AppContext db;
        public MainWindow()
        {
            InitializeComponent();
            db = new AppContext();
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

        private void CheckBox_Checked2(object sender, RoutedEventArgs e)
        {

        }

        private void Tgb_Checked2(object sender, RoutedEventArgs e)
        {

        }

        public bool CheckRegistrationFields()
        {
            if (tb1.Text == string.Empty || tb2.Password == string.Empty || tb4.Text == string.Empty)
            {
                MessageBox.Show("Полностью заполните поля регистарции");
                return false;
            }
            else return true;
        }

        public bool CheckPassword()
        {
            if (tb2.Password == tb3.Password) return true;
            else
            {
                MessageBox.Show("Пароли не сорвпадают");
                return false;
            }
        }
        public bool CheckReRegistration()
        {
            AppContext tb;
            tb = new AppContext();
            List<Table> tables = tb.Tables.ToList();
            bool flag = false;
            foreach(var scan in tables)
            {
                if (scan.Email == tb1.Text || scan.Login == tb4.Text)
                {
                    flag = false;
                    MessageBox.Show("Такой ползователь уже зарегестрирован");
                    break;
                }
                else flag = true;
            }
            return flag;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WindowInput winIn = new WindowInput();
            Table tb = new Table(tb1.Text, tb4.Text, tb2.Password);
            if(CheckRegistrationFields() && CheckPassword() && CheckReRegistration())
            {
                db.Tables.Add(tb);
                db.SaveChanges();
                MessageBox.Show("Регистрация прошла успещно");
                winIn.Show();
                this.Close();
            }

            List<Table> tables = db.Tables.ToList();
            foreach(var scan in tables)
            {
                MessageBox.Show($"{scan.Login}, {scan.Email}, {scan.Password}");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            WindowInput winIn = new WindowInput();
            winIn.Show();
            this.Close();
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
            if (tb3.Password.Length > 0)
            {
                Watermark1.Visibility = Visibility.Collapsed;
            }
            else
            {
                Watermark1.Visibility = Visibility.Visible;
            }
        }
    }
}
