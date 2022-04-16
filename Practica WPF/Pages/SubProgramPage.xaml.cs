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
    /// Логика взаимодействия для SubProgramPage.xaml
    /// </summary>
    public partial class SubProgramPage : Page
    {
        string name_program;
        string name_sub;
        public SubProgramPage()
        {
            InitializeComponent();
            DataGridSub.ItemsSource = SourceCore.DB.Subprograms.ToList();
            ProgramsComboBox.ItemsSource = SourceCore.DB.Programs.ToList();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            // Первоначальная настройка фильтра данных для быстрого поиска,
            // при этом из фильтрации нужно исключить столбец "Управление"
            // Создание собствнного списка заголовков столбцов
            List<String> Columns = new List<string>();
            // Перебор и добавление в новый список только необходимых заголовков
            // Исключен столбец 4
            for (int I = 0; I < 2; I++)
            {
                Columns.Add(DataGridSub.Columns[I].Header.ToString());
            }
            AreasFilterComboBox.ItemsSource = Columns;
            AreasFilterComboBox.SelectedIndex = 0;
            // Запрет на управление сортировкой щелчком по заголовку столбца
            foreach (DataGridColumn Column in DataGridSub.Columns)
            {
                Column.CanUserSort = false;
            }
        }

        private void AreasFilterTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textbox = sender as TextBox;
            switch (AreasFilterComboBox.SelectedIndex)
            {
                case 0:
                    DataGridSub.ItemsSource = SourceCore.DB.Subprograms.Where(filtercase => filtercase.Programs.name.Contains(textbox.Text)).ToList();
                    break;
                case 1:
                    DataGridSub.ItemsSource = SourceCore.DB.Subprograms.Where(filtercase => filtercase.name.Contains(textbox.Text)).ToList();
                    break;
            }
        }

        private void CopySubProgram_Click(object sender, RoutedEventArgs e)
        {
            if (ChangeColumn.Width.Value == 0)
            {
                ChangeColumn.Width = new GridLength(250);
                SplitterColumn.Width = GridLength.Auto;
                DataGridSub.Focus();
                DataGridSub.IsHitTestVisible = false;
                AreasFilterComboBox.IsHitTestVisible = false;
                AreasFilterTextBox.IsHitTestVisible = false;
                if ((sender as Button).Content.ToString() == "Добавить")
                {
                    DataGridSub.SelectedItem = null;
                }
                if (((sender as Button).Content.ToString() == "Копировать") && (DataGridSub.SelectedItem != null))
                {
                    name_program = ProgramsComboBox.Text;
                    name_sub = Area1TypeTextBox.Text;
                    DataGridSub.SelectedItem = null;
                    Area1TypeTextBox.Text = name_sub;
                    ProgramsComboBox.Text = name_program;
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
                    Data.Subprograms DeletingAreas = (Data.Subprograms)DataGridSub.SelectedItem;
                    // Определение ссылки, на которую должен перейти указатель после удаления
                    if (DataGridSub.SelectedIndex < DataGridSub.Items.Count - 1)
                    {
                        DataGridSub.SelectedIndex++;
                    }
                    else
                    {
                        if (DataGridSub.SelectedIndex > 0)
                        {
                            DataGridSub.SelectedIndex--;
                        }
                    }
                    Data.Subprograms SelectingArea = (Data.Subprograms)DataGridSub.SelectedItem;
                    DataGridSub.SelectedItem = DeletingAreas;
                    SourceCore.DB.Subprograms.Remove(DeletingAreas);
                    SourceCore.DB.SaveChanges();
                    UpdateGrid(SelectingArea);
                }
                catch
                {
                    MessageBox.Show("Невозможно удалить запись, так как она используется в других справочниках базы данных.",
                    "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning, MessageBoxResult.None);
                }
                DataGridSub.Focus();
            }
        }

        private void AreasFilterComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CommitButtonClick(object sender, RoutedEventArgs e)
        {

            if (Area1TypeTextBox.Text != "")
            {
                var A = new Data.Subprograms();
                A.Programs = (Data.Programs)ProgramsComboBox.SelectedItem;
                A.name = Area1TypeTextBox.Text;
                if (DataGridSub.SelectedItem == null)
                {
                    SourceCore.DB.Subprograms.Add(A);
                }
                SourceCore.DB.SaveChanges();
                CloseEdChangeClick(sender, e);
                UpdateGrid(A);
                DataGridSub.Focus();
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
            DataGridSub.IsHitTestVisible = true;
            AreasFilterComboBox.IsHitTestVisible = true;
            AreasFilterTextBox.IsHitTestVisible = true;
        }

        public void UpdateGrid(Data.Subprograms Areas)
        {
            if ((Areas == null) && (DataGridSub.ItemsSource != null))
            {
                Areas = (Data.Subprograms)DataGridSub.SelectedItem;
            }
            DataGridSub.ItemsSource = SourceCore.DB.Subprograms.ToList();
            DataGridSub.SelectedItem = Areas;
        }
    }
}
