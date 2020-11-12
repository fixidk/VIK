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

namespace VikingRejse
{
    /// <summary>
    /// Interaction logic for KunderListe.xaml
    /// </summary>
    public partial class KunderListe : Window
    {

        VKDBEntities _db = new VKDBEntities();
        public static DataGrid datagrid;

        public KunderListe()
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {
            myDataGridKunder.ItemsSource = _db.Kunder.ToList();
            datagrid = myDataGridKunder;
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            KunderInsertPage KunderIpage = new KunderInsertPage();
            KunderIpage.ShowDialog();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            int Id = (myDataGridKunder.SelectedItem as Kunder).Kunde_ID;
            KunderUpdatePage KunderUpage = new KunderUpdatePage(Id);
            KunderUpage.ShowDialog();

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            int Id = (myDataGridKunder.SelectedItem as Kunder).Kunde_ID;
            var deleteKunde = _db.Kunder.Where(m => m.Kunde_ID == Id).Single();
            _db.Kunder.Remove(deleteKunde);
            _db.SaveChanges();
            myDataGridKunder.ItemsSource = _db.Kunder.ToList();
        }
    }
}
