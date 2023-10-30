using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restorant_Otomasyonu
{
    public partial class Form1 : Form
    {
        private List<Masa> Masalar = new List<Masa>();
        private List<Urun> Urunler = new List<Urun>();  
        private List<UrunHareketi> UrunHareketleri = new List<UrunHareketi>();
        private string secilenMasa;
        public Form1()
        {
            InitializeComponent();
            Urunler.Add(new Urun 
            {
                Id = 1,
                UrunKodu = "1",
                UrunAdi = "Çorba",
                Birimi = "Porsiyon",
                Fiyat = 25,

            });
            Urunler.Add(new Urun
            {
                Id = 2,
                UrunKodu = "2",
                UrunAdi = "İskender",
                Birimi = "Porsiyon",
                Fiyat = 150,

            });
            Urunler.Add(new Urun
            {
                Id = 3,
                UrunKodu = "3",
                UrunAdi = "Adana Kebabı",
                Birimi = "Porsiyon",
                Fiyat = 200,

            });
            Urunler.Add(new Urun
            {
                Id = 4,
                UrunKodu = "4",
                UrunAdi = "Urfa Kebabı",
                Birimi = "Porsiyon",
                Fiyat = 200,

            });
            Urunler.Add(new Urun
            {
                Id = 5,
                UrunKodu = "5",
                UrunAdi = "Fıstıklı Baklava",
                Birimi = "Kilo",
                Fiyat = 250,

            });


            Masalar.Add(new Masa
            {
                Id = 1,
                MasaKodu = "1",
                MasaAdi = "Masa-1",
                
            });
            Masalar.Add(new Masa
            {
                Id = 2,
                MasaKodu = "2",
                MasaAdi = "Masa-2",

            });
            Masalar.Add(new Masa
            {
                Id = 3,
                MasaKodu = "3",
                MasaAdi = "Masa-3",

            });
            Masalar.Add(new Masa
            {
                Id = 4,
                MasaKodu = "4",
                MasaAdi = "Masa-4",

            });
            ButonOlustur();
            gridControl1.DataSource = UrunHareketleri;
        }

        private void ButonOlustur()
        {
            foreach (var masa in Masalar)
            {
                SimpleButton masaButon = new SimpleButton
                {
                    Name = masa.MasaKodu,
                    Text = masa.MasaAdi,
                    Height = 80,
                    Width = 80,
                    ButtonStyle = BorderStyles.Flat,
                    Appearance = {BackColor = Color.Orange}
                };
                flowMasa.Controls.Add(masaButon);
                masaButon.Click += Masa_Click;

            }
            foreach (var urun in Urunler)
            {
                SimpleButton urunButon = new SimpleButton
                {
                    Name = urun.UrunKodu,
                    Text = urun.UrunAdi,
                    Height = 80,
                    Width = 80

                };
                flowUrunler.Controls.Add(urunButon);
                urunButon.Click += Urun_Click;

            }
        }

        private void Urun_Click(object sender, EventArgs e)
        {
            SimpleButton buton = (SimpleButton)sender;
            Urun urun = Urunler.SingleOrDefault(c => c.UrunKodu == buton.Name);
            var masa = Masalar.SingleOrDefault(c => c.MasaKodu == secilenMasa);

            if (masa != null && urun != null)
            {
                UrunHareketi urunHareketi = new UrunHareketi
                {
                    UrunKodu = urun.UrunKodu,
                    UrunAdi = urun.UrunAdi,
                    Birimi = urun.Birimi,
                    Fiyat = urun.Fiyat,
                    Miktar = 1,
                };

                masa.Hareketler.Add(urunHareketi);
                gridView1.RefreshData();
                SimpleButton butonMasa = (SimpleButton)flowMasa.Controls.Find(secilenMasa, true).SingleOrDefault();
                butonMasa.Appearance.BackColor = Color.Gray;
                txtToplam.Value = Convert.ToDecimal(colToplam.SummaryItem.SummaryValue);
            }
        }

        private void Masa_Click(object sender, EventArgs e)
        {
            SimpleButton buton = (SimpleButton)sender;
            var masa = Masalar.SingleOrDefault(c => c.MasaKodu == buton.Name);

            if (masa != null)
            {
                if (masa.Hareketler == null)
                {
                    masa.Hareketler = new List<UrunHareketi>();
                }

                secilenMasa = masa.MasaKodu;
                gridControl1.DataSource = masa.Hareketler;
                txtToplam.Value = Convert.ToDecimal(colToplam.SummaryItem.SummaryValue);
            }
        }

        private void btnOde_Click(object sender, EventArgs e)
        {
            SimpleButton butonMasa = (SimpleButton)flowMasa.Controls.Find(secilenMasa, true).SingleOrDefault();
            butonMasa.Appearance.BackColor= Color.Green;
            var masa = Masalar.SingleOrDefault(c => c.MasaKodu == butonMasa.Name);
            masa.Hareketler = new List<UrunHareketi>();
            gridControl1.DataSource= masa.Hareketler;
            txtToplam.Value = 0;
        }
    }
}
