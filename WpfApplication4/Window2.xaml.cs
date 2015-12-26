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
using MahApps.Metro.Controls;
using Kurs.Model;

namespace WpfApplication4
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : MetroWindow
    {
        private Kurs.Repository.IRepository repository;
        private DataGrid Table;

        public Window2()
        {
            InitializeComponent();            
        }

        public Window2(Kurs.Repository.IRepository repository, DataGrid Table)
        {
            // TODO: Complete member initialization
            this.repository = repository;
            this.Table = Table;
            InitializeComponent();
            if (Table.SelectedItem == null) return;
            ProductModel prod = ((ProductModel)Table.SelectedItem);
            Id.Text = prod.Id.ToString();
            Name.Text = prod.Name.ToString();
            Code.Text = prod.Code.ToString();
            Count.Text = prod.Count.ToString();
            Producer.Text = prod.Producer.ToString();

            //MessageBox.Show(Table.SelectedIndex.ToString());
        }




        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int id, code, count;
            if (int.TryParse(Id.Text, out id) && int.TryParse(Code.Text, out code) && int.TryParse(Count.Text, out count))
            {
                repository.Change((ProductModel)Table.SelectedItem, new ProductModel(id , Name.Text, code, count, Producer.Text));
            }
            Table.Items.Refresh();
            Win2.Close();
            

        }

    }
}
