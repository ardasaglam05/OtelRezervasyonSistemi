using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelReservationSystem.Domain;
using MySql;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelReservationSystem.DataAccessLayer
{
    class rezervasyonDAO
    {
        public System.Collections.ArrayList rezervasyonOku()
        {
            ArrayList rezervasyonListesi = new ArrayList();
            MySqlDataReader rezervasyon = (new MySqlCommand("select * from Rezervasyon", (new dbBaglanti()).baglanti())).ExecuteReader();
            while (rezervasyon.Read())
            {
                rezervasyonListesi.Add(new Domain.Rezervasyon(Convert.ToInt32(rezervasyon[0]), Convert.ToInt32(rezervasyon[1]), rezervasyon[2].ToString(),  rezervasyon[3].ToString(), rezervasyon[4].ToString()));
            }
            return rezervasyonListesi;
        }

        public System.Collections.ArrayList ozelRezervasyonOku(string gKimlikNo)
        {
            ArrayList rezervasyonListesi = new ArrayList();
            MySqlDataReader rezervasyon = (new MySqlCommand("select * from Rezervasyon WHERE kimlikNo='" + gKimlikNo + "'", (new dbBaglanti()).baglanti())).ExecuteReader();
            while (rezervasyon.Read())
            {
                rezervasyonListesi.Add(new Domain.Rezervasyon(Convert.ToInt32(rezervasyon[0]), Convert.ToInt32(rezervasyon[1]) , rezervasyon[2].ToString(),  rezervasyon[3].ToString(), rezervasyon[4].ToString()));
            } 
            return rezervasyonListesi;
        }

        public System.Collections.ArrayList ozelOdaOku(string gOdaTuru)
        {
            ArrayList odaListesi = new ArrayList();
            MySqlDataReader oda = (new MySqlCommand("select odaID,odaTuru,odaDurumu from Oda WHERE odaTuru='" + gOdaTuru + "'", (new dbBaglanti()).baglanti())).ExecuteReader();
            while (oda.Read())
            {
                odaListesi.Add(new Domain.Oda(Convert.ToInt32(oda[0]), oda[1].ToString(), oda[2].ToString()));
            }
            return odaListesi;
        }

        public void rezervasyonOlustur(Domain.Rezervasyon gRezervasyon)
        {
            (new MySqlCommand("insert into Rezervasyon (kimlikNo,odaID,baslangic,bitis) values ('" + gRezervasyon.KimlikNo + "'," + gRezervasyon.OdaID + ",'" + gRezervasyon.Baslangic + "','" + gRezervasyon.Bitis + "')", (new dbBaglanti()).baglanti())).ExecuteNonQuery();
        }

        public void rezervasyonDuzenle(Domain.Rezervasyon gRezervasyon)
        {
            (new MySqlCommand("UPDATE Rezervasyon SET baslangic='" + gRezervasyon.Baslangic + "', bitis='" + gRezervasyon.Bitis + "' WHERE rezervasyonID = " + gRezervasyon.RezervasyonID + "" , (new dbBaglanti()).baglanti())).ExecuteNonQuery();
        }

        public void rezervasyonSil(Domain.Rezervasyon gRezervasyon)
        {
            (new MySqlCommand("DELETE FROM Rezervasyon WHERE rezervasyonID=" + gRezervasyon.RezervasyonID + "" , (new dbBaglanti()).baglanti())).ExecuteNonQuery();
        }
    }
}
