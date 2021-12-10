using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace FirstWpf1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Hesap> Hesaplar;
        private Grid _grid;
        private Grid AktifGrid
        {
            get { return _grid; }
            set
            {
                if (_grid != null)
                    _grid.Visibility = Visibility.Hidden;

                _grid = value;
                AktifGrid.Visibility = Visibility.Visible;
            }
        }
        public MainWindow()
        {
            InitializeComponent();
            Hesaplar = new ObservableCollection<Hesap>();
        }
        public Hesap HesapOlustur(string isim, string soyisim, string TC, string NIC, string Net, string Tel, string Mail, DateTime? Dg, char cinsiyet = '0', string Ulke = "", string il = "", string ilce = "")
            => new Hesap()
            {
                Isim = isim,
                Soyisim = soyisim,
                TC = TC,
                NIC = NIC,
                Net = Net,
                Tel = Tel,
                Mail = Mail,
                DogumTarihi = Dg,
                Cinsiyet = cinsiyet,
                Ulke = Ulke,
                Il = il,
                Ilce = ilce
            };

        private void PencereKapat(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
        private void PencereKucult(object sender, MouseButtonEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
            {
                WindowState = WindowState.Normal;
            }
        }
        private void PencereIndir(object sender, MouseButtonEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        //private void PencereyiAl(object sender, MouseButtonEventArgs e)
        //{
        //    if (true)
        //    {
        //        this.DragMove();
        //    }
        //}

        private void MenuKullan(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            if (b.Content.ToString() == "Hesap Ekle")
                AktifGrid = HesapEklePanel;

            else if (b.Content.ToString() == "Hesap Bul")
                AktifGrid = HesapBulPanel;

        }

        private void Hesap_Olustur(object sender, RoutedEventArgs e)
        {
            char cinsiyet = 'D';
            if (rdBtnCinsiyetE.IsChecked.Value && rdBtnCinsiyetE.IsChecked.HasValue)
            {
                cinsiyet = 'E';
            }
            else if (rdBtnCinsiyetK.IsChecked.Value && rdBtnCinsiyetK.IsChecked.HasValue)
            {
                cinsiyet = 'K';
            }
            else
            {
                return;
            }

            if (!string.IsNullOrEmpty(txtisim.Text) && !string.IsNullOrEmpty(txtSoyisim.Text) &&
                !string.IsNullOrEmpty(txtTc.Text) && !string.IsNullOrEmpty(txtNIC.Text) && !string.IsNullOrEmpty(txtNet.Text) && !string.IsNullOrEmpty(txtNumara.Text) && !string.IsNullOrEmpty(txtEmail.Text) && datepickerDg.SelectedDate.Value != null)
            {
                Hesap h = HesapOlustur(txtisim.Text, txtSoyisim.Text, txtTc.Text, txtNIC.Text, txtNet.Text, txtNumara.Text, txtEmail.Text, datepickerDg.SelectedDate.Value, cinsiyet);

                Hesaplar.Add(h);
                lstHesap.Items.Add(h);
            }
        }
        public void HesapGoster(Hesap hesap)
        {
            //txtisim.Text = hesap.Isim;
            //txtSoyisim.Text = hesap.Soyisim;
            //txtTc.Text = hesap.TC;
            //txtNIC.Text = hesap.NIC;
            //txtNet.Text = hesap.Net;
            //datepickerDg.Text = hesap.DogumTarihi.ToString();
            //if (hesap.Cinsiyet=='E') 
            //     rdBtnCinsiyetE
            //txt
        }
        private void Listbox_ChangedSelection(object sender, SelectionChangedEventArgs e)
        {

        }

        private void HesapBulFnc(object sender, TextChangedEventArgs e)
        {

        }
    }
}
