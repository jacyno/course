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
using Kurs.Repository;
namespace WpfApplication4
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : MetroWindow
    {
        private IRepository repository;
        private DataGrid Table;
        public Window1()
        {
            InitializeComponent();
        }

        public Window1(IRepository repository, DataGrid Table)
        {
            // TODO: Complete member initialization
            this.repository = repository;
            this.Table = Table;
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int id, code, count;
            if (int.TryParse(Id.Text, out id) && int.TryParse(Code.Text, out code) && int.TryParse(Count.Text, out count))
            {
                repository.Add(new ProductModel(id , Name.Text, code, count, Producer.Text));
            }
            Table.Items.Refresh();
        }
    }
}
