using HotelReservationSystem.Domain;
using HotelReservationSystem.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationSystem
{
    public partial class Rezervasyon : Form
    {
        public Rezervasyon()
        {
            InitializeComponent();
        }

        void rezervasyonOku()
        {
            rezervasyonListesi.Items.Clear();
            foreach (Domain.Rezervasyon gRezervasyon in (new rezervasyonService()).reezervasyonOku())
            {
                string[] rezervasyonBilgileri = { gRezervasyon.RezervasyonID.ToString(), gRezervasyon.KimlikNo.ToString(), gRezervasyon.OdaID.ToString(), gRezervasyon.Baslangic.ToString(), gRezervasyon.Bitis.ToString() };
                ListViewItem rezervasyon = new ListViewItem(rezervasyonBilgileri);
                rezervasyonListesi.Items.Add(rezervasyon);
            }
        }

        void ozelRezervasyonOku(string gKimlikNo)
        {
            rezervasyonListesi.Items.Clear();
            foreach (Domain.Rezervasyon gRezervasyon in (new rezervasyonService()).ozelRezervasyonOku(gKimlikNo))
            {
                string[] rezervasyonBilgileri = { gRezervasyon.RezervasyonID.ToString(), gRezervasyon.KimlikNo, gRezervasyon.OdaID.ToString(), gRezervasyon.Baslangic.ToString(), gRezervasyon.Bitis.ToString() };
                ListViewItem rezervasyon = new ListViewItem(rezervasyonBilgileri);
                rezervasyonListesi.Items.Add(rezervasyon);
            }
        }

        private void Rezervasyon_Load(object sender, EventArgs e)
        {
            rezervasyonListesi.Columns.Add("Rezervasyon ID", 104);
            rezervasyonListesi.Columns.Add("Müşteri ID", 104);
            rezervasyonListesi.Columns.Add("Oda ID", 104);
            rezervasyonListesi.Columns.Add("Başlangıç ​​Tarihi", 104);
            rezervasyonListesi.Columns.Add("Bitiş Tarihi", 104);
            try
            {
                rezervasyonOku();
            }
            catch (Exception)
            {
                MessageBox.Show("Bağlantı Başarısız");
                throw;
            }
        }

        private void oda_Click(object sender, EventArgs e)
        {
            Oda oda = new Oda();
            this.Hide();
            oda.Show();
        }

        private void musteri_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();
            this.Hide();
            musteri.Show();
        }

        private void rezervasyonOlustur_Click(object sender, EventArgs e)
        {
            try
            {
                (new rezervasyonService()).rezervasyonOlustur(idText.Text, Convert.ToInt32(roomIDText.Text), startDatePicker.Value.Year + "-" + startDatePicker.Value.Month + "-" + startDatePicker.Value.Day, endDatePicker.Value.Year + "-" + endDatePicker.Value.Month + "-" + endDatePicker.Value.Day);
                MessageBox.Show("Rezervasyon başarıyla oluşturuldu.");
            }
            catch
            {
                MessageBox.Show("Rezervasyon oluşturulurken bir hatayla karşılaşıldı!");
            }
            try
            {
                rezervasyonOku();
            }
            catch (Exception)
            {
                MessageBox.Show("Bağlantı Başarısız");
                throw;
            }
        }

        private void rezervasyonDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                (new rezervasyonService()).rezervasyonDuzenle(Convert.ToInt32(reservationIDText.Text), editStartDatePicker.Value.Year + "-" + editStartDatePicker.Value.Month + "-" + editStartDatePicker.Value.Day, editEndDatePicker.Value.Year + "-" + editEndDatePicker.Value.Month + "-" + editEndDatePicker.Value.Day);
                MessageBox.Show("Rezervasyon başarıyla güncellendi.");
            }
            catch
            {
                MessageBox.Show("Rezervasyon güncellenirken bir hatayla karşılaşıldı!");
            }
            try
            {
                rezervasyonOku();
            }
            catch (Exception)
            {
                MessageBox.Show("Bağlantı Başarısız");
                throw;
            }
        }

        private void rezervasyonSil_Click(object sender, EventArgs e)
        {
            try
            {
                (new rezervasyonService()).rezervasyonSil(Convert.ToInt32(deleteReservationIDText.Text));
                MessageBox.Show("Rezervasyon başarıyla silindi.");
            }
            catch
            {
                MessageBox.Show("Rezervasyon silinirken bir hatayla karşılaşıldı!");
            }
            try
            {
                rezervasyonOku();
            }
            catch (Exception)
            {
                MessageBox.Show("Bağlantı Başarısız");
                throw;
            }
        }

        private void rezervasyonBul_Click(object sender, EventArgs e)
        {
            try
            {
                ozelRezervasyonOku(getCustomerIDText.Text);
                MessageBox.Show("Rezervasyon başarıyla bulundu.");
            }
            catch (Exception)
            {
                MessageBox.Show("Bağlantı Başarısız");
                throw;
            }
        }
    }
}
