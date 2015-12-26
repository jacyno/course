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
using MahApps.Metro.Controls;
using Kurs.Repository;
using Kurs;
using System.Data;
using System.Collections;
using Kurs.Model;


namespace WpfApplication4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        IRepository repository = MemoryRepository.Instance;
        public MainWindow()
        {
            InitializeComponent();

            BoxFields.Items.Add("id");
            BoxFields.Items.Add("name");
            BoxFields.Items.Add("code");
            BoxFields.Items.Add("count");
            BoxFields.Items.Add("producer");

            repository.Add(new ProductModel(1, "Лаваш", 92321, 10, "ООО БЕЛЭКСПО"));
            repository.Add(new ProductModel(2, "Шалаш", 234211, 15, "ООО БЕЛЭКСПО"));
            repository.Add(new ProductModel(3, "Бондаж", 2331221, 20, "ООО БЕЛЭКСПО"));
            repository.Add(new ProductModel(4, "Шиномонтаж", 232121, 30, "ООО БЕЛЭКСПО"));
            repository.Add(new ProductModel(5, "Гараж", 232231, 40, "ООО БЕЛЭКСПО"));
            repository.Add(new ProductModel(6, "Балалайка", 8562321, 50, "ООО БЕЛЭКСПО"));
            repository.Update();
            repository = TextRepository.Instance;
            Table.ItemsSource = repository.GetAll();

        }


        private void RadioTxt_Click(object sender, RoutedEventArgs e)
        {
            BtnFile.IsEnabled = true;
            repository = TextRepository.Instance;
            Table.ItemsSource = repository.GetAll(); 
            Table.Items.Refresh();
        }

        private void RadioBin_Click(object sender, RoutedEventArgs e)
        {
            BtnFile.IsEnabled = true;
            repository = BinRepository.Instance;
            Table.ItemsSource = repository.GetAll();
            Table.Items.Refresh();
        }

        private void RadioMemory_Click(object sender, RoutedEventArgs e)
        {
            BtnFile.IsEnabled = false;
            repository = MemoryRepository.Instance;
            Table.ItemsSource = repository.GetAll();
            Table.Items.Refresh();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Window1 Add = new Window1(repository , Table);
            Add.Visibility = System.Windows.Visibility.Visible;
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Window1 Add = new Window1(repository, Table);
            Add.Visibility = System.Windows.Visibility.Visible;
            
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Window2 Change = new Window2(repository, Table);
            Change.Visibility = System.Windows.Visibility.Visible;

        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            if (Table.SelectedItem == null) return;
            repository.Del((ProductModel)Table.SelectedItem);
            //MessageBox.Show(Table.SelectedIndex.ToString());
            Table.Items.Refresh();
        }

        private void MetroWindow_Closed_1(object sender, EventArgs e)
        {
            repository.Update();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog ofd = new Microsoft.Win32.OpenFileDialog();
            ofd.Multiselect = false;
            ofd.Filter = "All Files|*.*";
            ofd.ShowDialog();
            if (ofd.SafeFileName != "")
            {
                repository.Refresh(ofd.SafeFileName);
            }
            Table.ItemsSource = repository.GetAll();
            Table.Items.Refresh();

        }



        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            if (Table.SelectedIndex != -1)
            {
                Window2 Change = new Window2(repository, Table);
                Change.Visibility = System.Windows.Visibility.Visible;
            }
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            if (Table.SelectedItem == null) return;
            repository.Del((ProductModel)Table.SelectedItem);
            Table.Items.Refresh();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Table.ItemsSource = repository.Filter((string)BoxFields.Items[BoxFields.SelectedIndex], TextSearch.Text);
            Table.Items.Refresh();
        }
    }
}
