using HotelReservationSystem.Domain;
using HotelReservationSystem.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationSystem
{
    public partial class Oda : Form
    {
        public Oda()
        {
            InitializeComponent();
        }

        void odaOku()
        {
            odaListesi.Items.Clear();
            foreach (Domain.Oda gOda in (new odaService()).odaOku())
            {
                string[] odaBilgileri = { gOda.OdaID.ToString(), gOda.OdaTuru, gOda.Fiyat.ToString(), gOda.OdaDurumu };
                ListViewItem oda = new ListViewItem(odaBilgileri);
                odaListesi.Items.Add(oda);
            }
        }

        private void Oda_Load(object sender, EventArgs e)
        {
            odaListesi.Columns.Add("Oda ID", 130);
            odaListesi.Columns.Add("Oda Tipi", 130);
            odaListesi.Columns.Add("Fiyat", 130);
            odaListesi.Columns.Add("Oda Durumu", 130);
            try
            {
                odaOku();
            }
            catch (Exception)
            {
                MessageBox.Show("Bağlantı Başarısız");
                throw;
            }
        }

        private void rezervasyon_Click(object sender, EventArgs e)
        {
            Rezervasyon rezervasyon = new Rezervasyon();
            this.Hide();
            rezervasyon.Show();
        }

        private void musteri_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();
            this.Hide();
            musteri.Show();
        }

        private void odaOlustur_Click(object sender, EventArgs e)
        {
            try
            {
                (new odaService()).odaOlustur(roomTypeText.Text, Convert.ToDouble(priceText.Text));
                MessageBox.Show("Oda başarıyla oluşturuldu.");
            }
            catch
            {
                MessageBox.Show("Oda oluşturulurken bir hatayla karşılaşıldı!");
            }
            try
            {
                odaOku();
            }
            catch (Exception)
            {
                MessageBox.Show("Bağlantı Başarısız");
                throw;
            }
        }

        private void odaDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                (new odaService()).odaDuzenle(Convert.ToInt32(roomIDText.Text),editRoomTypeText.Text, Convert.ToDouble(editPriceText.Text));
                MessageBox.Show("Oda başarıyla güncellendi.");
            }
            catch
            {
                MessageBox.Show("Oda güncellenirken bir hatayla karşılaşıldı!");
            }
            try
            {
                odaOku();
            }
            catch (Exception)
            {
                MessageBox.Show("Bağlantı Başarısız");
                throw;
            }
        }

        private void odaSil_Click(object sender, EventArgs e)
        {
            try
            {
                (new odaService()).odaSil(Convert.ToInt32(deletedRoomIDText.Text));
                MessageBox.Show("Oda başarıyla silindi.");
            }
            catch
            {
                MessageBox.Show("Oda silinirken bir hatayla karşılaşıldı!");
            }
            try
            {
                odaOku();
            }
            catch (Exception)
            {
                MessageBox.Show("Bağlantı Başarısız");
                throw;
            }
        }

        private void girisYap_Click(object sender, EventArgs e)
        {
            try
            {
                (new odaService()).girisYap(Convert.ToInt32(entryExitRoomIDText.Text));
                MessageBox.Show("Odaya giriş başarıyla gerçekleşti.");
            }
            catch
            {
                MessageBox.Show("Odaya giriş esnasında bir hatayla karşılaşıldı!");
            }
            try
            {
                odaOku();
            }
            catch (Exception)
            {
                MessageBox.Show("Bağlantı Başarısız");
                throw;
            }
        }

        private void cikisYap_Click(object sender, EventArgs e)
        {
            try
            {
                (new odaService()).cikisYap(Convert.ToInt32(entryExitRoomIDText.Text));
                MessageBox.Show("Odadan çıkış başarıyla gerçekleşti.");
            }
            catch
            {
                MessageBox.Show("Odadan çıkış esnasında bir hatayla karşılaşıldı!");
            }
            try
            {
                odaOku();
            }
            catch (Exception)
            {
                MessageBox.Show("Bağlantı Başarısız");
                throw;
            }
        } 
    }
}
