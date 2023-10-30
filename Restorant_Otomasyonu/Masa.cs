using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restorant_Otomasyonu
{
    public class Masa
    {
        public int Id { get; set; }
        public string MasaKodu { get; set; }
        public string MasaAdi { get; set; }
        public List<UrunHareketi> Hareketler { get; set;}
    }
}
