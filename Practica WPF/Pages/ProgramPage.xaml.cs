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
    /// Логика взаимодействия для ProgramPage.xaml
    /// </summary>
    public partial class ProgramPage : Page
    {
        string name_program;
        string name_user;
        string datestart;
        string dateend;
        public ProgramPage()
        {
            InitializeComponent();
            DataGridProgram.ItemsSource = SourceCore.DB.Programs.ToList();
            ProgramsComboBox.ItemsSource = SourceCore.DB.Users.ToList();
        }

        private void CopySubProgram_Click(object sender, RoutedEventArgs e)
        {
            if (ChangeColumn.Width.Value == 0)
            {
                ChangeColumn.Width = new GridLength(250);
                SplitterColumn.Width = GridLength.Auto;
                DataGridProgram.Focus();
                DataGridProgram.IsHitTestVisible = false;
                AreasFilterComboBox.IsHitTestVisible = false;
                AreasFilterTextBox.IsHitTestVisible = false;
                if ((sender as Button).Content.ToString() == "Добавить")
                {
                    DataGridProgram.SelectedItem = null;
                }
                if (((sender as Button).Content.ToString() == "Копировать") && (DataGridProgram.SelectedItem != null))
                {
                    name_user = ProgramsComboBox.Text;
                    name_program = AreaTypeTextBox.Text;
                    datestart = Area1TypeTextBox.Text;
                    dateend = Area2TypeTextBox.Text;
                    DataGridProgram.SelectedItem = null;
                    Area1TypeTextBox.Text = name_program;
                    ProgramsComboBox.Text = name_user;
                    Area1TypeTextBox.Text = datestart;
                    Area2TypeTextBox.Text = dateend;
                }
            }
            else
            {
                ChangeColumn.Width = new GridLength(0);
                SplitterColumn.Width = new GridLength(0);
            }
        }

        private void DeleteSubProgram_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Удалить запись?", "Внимание!", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
            {
                try
                {
                    // Ссылка на удаляемую книгу
                    Data.Programs DeletingAreas = (Data.Programs)DataGridProgram.SelectedItem;
                    // Определение ссылки, на которую должен перейти указатель после удаления
                    if (DataGridProgram.SelectedIndex < DataGridProgram.Items.Count - 1)
                    {
                        DataGridProgram.SelectedIndex++;
                    }
                    else
                    {
                        if (DataGridProgram.SelectedIndex > 0)
                        {
                            DataGridProgram.SelectedIndex--;
                        }
                    }
                    Data.Programs SelectingArea = (Data.Programs)DataGridProgram.SelectedItem;
                    DataGridProgram.SelectedItem = DeletingAreas;
                    SourceCore.DB.Programs.Remove(DeletingAreas);
                    SourceCore.DB.SaveChanges();
                    UpdateGrid(SelectingArea);
                }
                catch
                {
                    MessageBox.Show("Невозможно удалить запись, так как она используется в других справочниках базы данных.",
                    "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning, MessageBoxResult.None);
                }
                DataGridProgram.Focus();
            }
        }

        private void AreasFilterComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AreasFilterTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textbox = sender as TextBox;
            switch (AreasFilterComboBox.SelectedIndex)
            {
                case 0:
                    DataGridProgram.ItemsSource = SourceCore.DB.Programs.Where(filtercase => filtercase.name.Contains(textbox.Text)).ToList();
                    break;
                case 1:
                    DataGridProgram.ItemsSource = SourceCore.DB.Programs.Where(filtercase => filtercase.Users.name_user.Contains(textbox.Text)).ToList();
                    break;
                case 2:
                    DataGridProgram.ItemsSource = SourceCore.DB.Programs.Where(filtercase => filtercase.start_date.ToString().Contains(textbox.Text)).ToList();
                    break;
                case 3:
                    DataGridProgram.ItemsSource = SourceCore.DB.Programs.Where(filtercase => filtercase.end_date.ToString().Contains(textbox.Text)).ToList();
                    break;
            }
        }

        private void CloseEdChangeClick(object sender, RoutedEventArgs e)
        {
            ChangeColumn.Width = new GridLength(0);
            SplitterColumn.Width = new GridLength(0);
            DataGridProgram.IsHitTestVisible = true;
            AreasFilterComboBox.IsHitTestVisible = true;
            AreasFilterTextBox.IsHitTestVisible = true;
        }

        private void CommitButtonClick(object sender, RoutedEventArgs e)
        {

            if (Area1TypeTextBox.Text != "")
            {
                var A = new Data.Programs();
                A.Users = (Data.Users)ProgramsComboBox.SelectedItem;
                A.name = AreaTypeTextBox.Text;
                A.start_date = Int32.Parse(Area1TypeTextBox.Text);
                A.end_date = Int32.Parse(Area2TypeTextBox.Text);
                if (DataGridProgram.SelectedItem == null)
                {
                    SourceCore.DB.Programs.Add(A);
                }
                SourceCore.DB.SaveChanges();
                CloseEdChangeClick(sender, e);
                UpdateGrid(A);
                DataGridProgram.Focus();
            }
            else
            {
                MessageBox.Show("Введите Район",
                "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning, MessageBoxResult.None);
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

            // Первоначальная настройка фильтра данных для быстрого поиска,
            // при этом из фильтрации нужно исключить столбец "Управление"
            // Создание собствнного списка заголовков столбцов
            List<String> Columns = new List<string>();
            // Перебор и добавление в новый список только необходимых заголовков
            // Исключен столбец 4
            for (int I = 0; I < 4; I++)
            {
                Columns.Add(DataGridProgram.Columns[I].Header.ToString());
            }
            AreasFilterComboBox.ItemsSource = Columns;
            AreasFilterComboBox.SelectedIndex = 0;
            // Запрет на управление сортировкой щелчком по заголовку столбца
            foreach (DataGridColumn Column in DataGridProgram.Columns)
            {
                Column.CanUserSort = false;
            }
        }

        public void UpdateGrid(Data.Programs Areas)
        {
            if ((Areas == null) && (DataGridProgram.ItemsSource != null))
            {
                Areas = (Data.Programs)DataGridProgram.SelectedItem;
            }
            DataGridProgram.ItemsSource = SourceCore.DB.Programs.ToList();
            DataGridProgram.SelectedItem = Areas;
        }
    }
}
