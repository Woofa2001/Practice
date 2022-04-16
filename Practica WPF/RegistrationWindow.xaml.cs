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
using System.Text.RegularExpressions;

namespace Practica_WPF
{
    /// <summary>
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        private Data.PracticEntities Database;
        public RegistrationWindow(Data.PracticEntities Database)
        {
            InitializeComponent();
            this.Database = Database;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            if (SourceCore.DB.Users.Any(P => P.login == LoginTextBox.Text))
            {
                MessageBox.Show("Логин занят", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning, MessageBoxResult.None);
            }
            else
            {
                var input = PasswordTextBox.Text == "" ? PasswordPasswordBox.Password : PasswordTextBox.Text;
                var Number = new Regex(@"[0-9]+");
                var UpperChar = new Regex(@"[A-Z|А-Я]+");
                var SpecialSymbol = new Regex(@"(?=.*[\W])");
                var Min8Chars = new Regex(@".{8,}");
                if (Number.IsMatch(input) && UpperChar.IsMatch(input) && SpecialSymbol.IsMatch(input) && Min8Chars.IsMatch(input))
                {
                    // Создание и инициализация нового пользователя системы
                    Data.Users User = new Data.Users();
                    User.login = LoginTextBox.Text;
                    User.password = PasswordPasswordBox.Password != "" ? PasswordPasswordBox.Password : PasswordTextBox.Text;
                    User.name_user = "tr";
                    // Добавление его в базу данных
                    Database.Users.Add(User);
                    // Сохранение изменений
                    Database.SaveChanges();
                    Close();
                }
                else
                {
                    MessageBox.Show("Введен не соотвествующий пароль.", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning, MessageBoxResult.None);
                }
            }
        }

        private void PasswordButton_Click(object sender, RoutedEventArgs e)
        {
            String Password = PasswordPasswordBox.Password;
            Visibility Visibility = PasswordPasswordBox.Visibility;
            double Width = PasswordPasswordBox.ActualWidth;
            // Изменение подписи на кнопке
            PasswordButton.Content = Visibility == Visibility.Visible ? "Скрыть" : "Показать";
            // Переброска информации из TextBox'а в PasswordBox
            PasswordPasswordBox.Password = PasswordTextBox.Text;
            PasswordPasswordBox.Visibility = PasswordTextBox.Visibility;
            PasswordPasswordBox.Width = PasswordTextBox.Width;
            // Возврат информации из временных буферов в TextBox
            PasswordTextBox.Text = Password;
            PasswordTextBox.Visibility = Visibility;
            PasswordTextBox.Width = Width;
        }
    }
}
