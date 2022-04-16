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

namespace Practica_WPF.Pages
{
    /// <summary>
    /// Логика взаимодействия для Vedomstva.xaml
    /// </summary>
    public partial class Vedomstva : Page
    {
        string name_user;
        public Vedomstva()
        {
            InitializeComponent();
            DataGridVedomstvo.ItemsSource = SourceCore.DB.Users.ToList();
        }

        private void VedomstvaFilterComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void VedomstvaFilterTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textbox = sender as TextBox;
            switch (AreasFilterComboBox.SelectedIndex)
            {
                case 0:
                    DataGridVedomstvo.ItemsSource = SourceCore.DB.Users.Where(filtercase => filtercase.name_user.Contains(textbox.Text)).ToList();
                    break;
            }
        }

        private void ShowButtonVedomstva(object sender, RoutedEventArgs e)
        {
            if (ChangeColumn.Width.Value == 0)
            {
                ChangeColumn.Width = new GridLength(250);
                SplitterColumn.Width = GridLength.Auto;
                DataGridVedomstvo.Focus();
                DataGridVedomstvo.IsHitTestVisible = false;
                AreasFilterComboBox.IsHitTestVisible = false;
                AreasFilterTextBox.IsHitTestVisible = false;
                if ((sender as Button).Content.ToString() == "Добавить")
                {
                    DataGridVedomstvo.SelectedItem = null;
                }
                if (((sender as Button).Content.ToString() == "Копировать") && (DataGridVedomstvo.SelectedItem != null))
                {
                    name_user = AreaTypeTextBox.Text;
                    DataGridVedomstvo.SelectedItem = null;
                    AreaTypeTextBox.Text = name_user;
                }
            }
            else
            {
                ChangeColumn.Width = new GridLength(0);
                SplitterColumn.Width = new GridLength(0);
            }
        }

        private void CommitButtonVedomstva(object sender, RoutedEventArgs e)
        {
            if (AreaTypeTextBox.Text != "")
            {
                var A = new Data.Users();
                A.name_user = AreaTypeTextBox.Text;
                if (DataGridVedomstvo.SelectedItem == null)
                {
                    SourceCore.DB.Users.Add(A);
                }
                SourceCore.DB.SaveChanges();
                CloseEdChangeClick(sender, e);
                UpdateGrid(A);
                DataGridVedomstvo.Focus();
            }
            else
            {
                MessageBox.Show("Введите Район",
                "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning, MessageBoxResult.None);
            }
        }

        private void CloseEdChangeClick(object sender, RoutedEventArgs e)
        {
            ChangeColumn.Width = new GridLength(0);
            SplitterColumn.Width = new GridLength(0);
            DataGridVedomstvo.IsHitTestVisible = true;
            AreasFilterComboBox.IsHitTestVisible = true;
            AreasFilterTextBox.IsHitTestVisible = true;
        }

        private void DeleteButtonVedomstva(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Удалить запись?", "Внимание!", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
            {
                try
                {
                    // Ссылка на удаляемую книгу
                    Data.Users DeletingAreas = (Data.Users)DataGridVedomstvo.SelectedItem;
                    // Определение ссылки, на которую должен перейти указатель после удаления
                    if (DataGridVedomstvo.SelectedIndex < DataGridVedomstvo.Items.Count - 1)
                    {
                        DataGridVedomstvo.SelectedIndex++;
                    }
                    else
                    {
                        if (DataGridVedomstvo.SelectedIndex > 0)
                        {
                            DataGridVedomstvo.SelectedIndex--;
                        }
                    }
                    Data.Users SelectingArea = (Data.Users)DataGridVedomstvo.SelectedItem;
                    DataGridVedomstvo.SelectedItem = DeletingAreas;
                    SourceCore.DB.Users.Remove(DeletingAreas);
                    SourceCore.DB.SaveChanges();
                    UpdateGrid(SelectingArea);
                }
                catch
                {
                    MessageBox.Show("Невозможно удалить запись, так как она используется в других справочниках базы данных.",
                    "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning, MessageBoxResult.None);
                }
                DataGridVedomstvo.Focus();
            }
        }
        public void UpdateGrid(Data.Users Areas)
        {
            if ((Areas == null) && (DataGridVedomstvo.ItemsSource != null))
            {
                Areas = (Data.Users)DataGridVedomstvo.SelectedItem;
            }
            DataGridVedomstvo.ItemsSource = SourceCore.DB.Users.ToList();
            DataGridVedomstvo.SelectedItem = Areas;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

            // Первоначальная настройка фильтра данных для быстрого поиска,
            // при этом из фильтрации нужно исключить столбец "Управление"
            // Создание собствнного списка заголовков столбцов
            List<String> Columns = new List<string>();
            // Перебор и добавление в новый список только необходимых заголовков
            // Исключен столбец 4
            for (int I = 0; I < 1; I++)
            {
                Columns.Add(DataGridVedomstvo.Columns[I].Header.ToString());
            }
            AreasFilterComboBox.ItemsSource = Columns;
            AreasFilterComboBox.SelectedIndex = 0;
            // Запрет на управление сортировкой щелчком по заголовку столбца
            foreach (DataGridColumn Column in DataGridVedomstvo.Columns)
            {
                Column.CanUserSort = false;
            }
        }
    }
}
