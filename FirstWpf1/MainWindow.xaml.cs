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

namespace FirstWpf1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Grid _grid;
        private Grid AktifGrid
        {
            get { return _grid; }
            set
            {
                if (_grid != null)
                {
                    _grid.Visibility = Visibility.Hidden;
                }
                _grid = AktifGrid;
                AktifGrid.Visibility = Visibility.Visible;
            }
        }
        public MainWindow()
        {
            InitializeComponent();
        }

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

        private void PencereyiAl(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void MenuKullan(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            if (b.Content.ToString() == "Hesap Ekle")
            {
                AktifGrid = HesapEkle;
            }
            else if (b.Content.ToString() == "Hesap Bul")
            {
                AktifGrid = HesapBul;
            }
        }

        private void Hesap_Olustur(object sender, RoutedEventArgs e)
        {

        }

        private void Listbox_ChangedSelection(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
