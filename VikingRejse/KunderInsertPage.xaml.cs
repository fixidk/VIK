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
    /// Interaction logic for KunderInsertPage.xaml
    /// </summary>
    public partial class KunderInsertPage : Window
    {


        VKDBEntities _db = new VKDBEntities();
        public KunderInsertPage()
        {
            InitializeComponent();
            Clear();
        }
        private void btnAddKunde_Click(object sender, RoutedEventArgs e)
        {
            Kunder nyKunde = new Kunder()
            {
                Kunde_Navn = txtBoxNavn.Text,
                Kunde_Adresse = txtBoxAdresse.Text,
                Kunde_Telefon = Int32.Parse(txtBoxTelefon.Text),
            };

            _db.Kunder.Add(nyKunde);
            _db.SaveChanges();
            KunderListe.datagrid.ItemsSource = _db.Kunder.ToList();
            this.Hide();

        }

        void Clear()
        {
            //Ryder data
            txtBoxNavn.Text = txtBoxAdresse.Text = txtBoxTelefon.Text = "";

        }

        private void btnClearData_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}