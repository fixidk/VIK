using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for KunderUpdatePage.xaml
    /// </summary>
    public partial class KunderUpdatePage : Window
    {

        VKDBEntities _db = new VKDBEntities();
        int Id;

        public KunderUpdatePage(int KundeID)
        {
            InitializeComponent();
            Id = KundeID;
        }
        private void btnUpdateKunde_Click(object sender, RoutedEventArgs e)
        {
            Kunder updateMember = (from m in _db.Kunder where m.Kunde_ID == Id select m).Single();
            updateMember.Kunde_Navn = txtBoxNavn.Text;
            updateMember.Kunde_Adresse = txtBoxAdresse.Text;
            updateMember.Kunde_Telefon = Int32.Parse(txtBoxTelefon.Text);

            //Gemmer indholdet til databassen
            _db.SaveChanges();
            KunderListe.datagrid.ItemsSource = _db.Kunder.ToList();
            this.Hide();
        }

        private void btnClearData_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
