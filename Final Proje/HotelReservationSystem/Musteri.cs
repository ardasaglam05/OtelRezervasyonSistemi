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
    public partial class Musteri : Form
    {
        public Musteri()
        {
            InitializeComponent();
        }

        void musteriOku()
        {
            musteriListesi.Items.Clear();
            foreach (Domain.Musteri gMusteri in (new musteriService()).musteriOku())
            {
                string[] musteriBilgileri = { gMusteri.KimlikNo, gMusteri.Ad, gMusteri.Soyad, gMusteri.TelNo };
                ListViewItem musteri = new ListViewItem(musteriBilgileri);
                musteriListesi.Items.Add(musteri);
            }
        }

        void ozelMusteriOku(string gMusteriID)
        {
            musteriListesi.Items.Clear();
            foreach (Domain.Musteri gMusteri in (new musteriService()).ozelMusteriOku(gMusteriID))
            {
                string[] musteriBilgileri = { gMusteri.KimlikNo, gMusteri.Ad, gMusteri.Soyad, gMusteri.TelNo };
                ListViewItem musteri = new ListViewItem(musteriBilgileri);
                musteriListesi.Items.Add(musteri);
            }
        }

        private void Musteri_Load(object sender, EventArgs e)
        {
            musteriListesi.Columns.Add("Kimlik No", 130);
            musteriListesi.Columns.Add("Adı", 130);
            musteriListesi.Columns.Add("Soyadı", 130);
            musteriListesi.Columns.Add("Telefon Numarası", 130);
            try
            {
                musteriOku();
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

        private void oda_Click(object sender, EventArgs e)
        {
            Oda oda = new Oda();
            this.Hide();
            oda.Show();
        }
        private void musteriOlustur_Click(object sender, EventArgs e)
        {
            try
            {
                (new musteriService()).musteriOlustur(idText.Text, nameText.Text, surnameText.Text, phoneNumberText.Text);
                MessageBox.Show("Müşteri başarıyla oluşturuldu.");
            }
            catch (Exception)
            {
                MessageBox.Show("Müşteri oluşturulurken bir hatayla karşılaşıldı!");
            }
            try
            {
                musteriOku();
            }
            catch (Exception)
            {
                MessageBox.Show("Bağlantı Başarısız");
                throw;
            }
        }

        private void musteriDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                (new musteriService()).musteriDuzenle(editCustomerIDText.Text, editNameText.Text, editSurnameText.Text, editPhoneNumberText.Text);
                MessageBox.Show("Müşteri başarıyla güncellendi.");
            }
            catch
            {
                MessageBox.Show("Müşteri güncellenirken bir hatayla karşılaşıldı!");
            }
            try
            {
                musteriOku();
            }
            catch (Exception)
            {
                MessageBox.Show("Bağlantı Başarısız");
                throw;
            }
        }

        private void musteriSil_Click(object sender, EventArgs e)
        {
            try
            {
                (new musteriService()).musteriSil(deletedCustomerIDText.Text);
                MessageBox.Show("Müşteri başarıyla silindi.");
            }
            catch
            {
                MessageBox.Show("Müşteri silinirken bir hatayla karşılaşıldı!");
            }
            try
            {
                musteriOku();
            }
            catch (Exception)
            {
                MessageBox.Show("Bağlantı Başarısız");
                throw;
            }
        }

        private void musteriBul_Click(object sender, EventArgs e)
        {
            try
            {
                ozelMusteriOku(getCustomerIDText.Text);
                MessageBox.Show("Müşteri başarıyla bulundu.");
            }
            catch (Exception)
            {
                MessageBox.Show("Bağlantı Başarısız");
                throw;
            }
        }

        private void musteriListesi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
