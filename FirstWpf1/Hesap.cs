using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWpf1
{
   public class Hesap
    {
        public Hesap()
        {
            string HesapNo = "";
            Random rnd = new Random();
            for (int i = 0; i < 7; i++)
                HesapNo += rnd.Next(0,9);
            this.HesapNo = HesapNo;
        }
        public string HesapNo { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string TC { get; set; }
        public string NIC { get; set; }
        public string Net { get; set; }
        public string Tel { get; set; }
        public string Mail { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Cinsiyet { get; set; }
        public string Ulke { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string Adres { get; set; }
        public int Limit { get; set; }

        public override string ToString()
        {
            return this.HesapNo;
        }
    }
}
