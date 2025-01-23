using HotelReservationSystem.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql;
using MySql.Data.MySqlClient;
using System.Collections;

namespace HotelReservationSystem.DataAccessLayer
{
    public class musteriDAO
    {
        public System.Collections.ArrayList musteriOku()
        {
            ArrayList musteriListesi = new ArrayList();
            MySqlDataReader musteri = (new MySqlCommand("select * from Musteri", (new dbBaglanti()).baglanti())).ExecuteReader();
            while (musteri.Read())
            {
                musteriListesi.Add(new Domain.Musteri(musteri[0].ToString(), musteri[1].ToString(), musteri[2].ToString(), musteri[3].ToString()));
            }
            return musteriListesi;
        }

        public System.Collections.ArrayList ozelMusteriOku(string gMusteriID)
        {
            ArrayList musteriListesi = new ArrayList();
            MySqlDataReader musteri = (new MySqlCommand("select * from Musteri WHERE kimlikNo='" + gMusteriID + "'", (new dbBaglanti()).baglanti())).ExecuteReader();
            while (musteri.Read())
            {
                musteriListesi.Add(new Domain.Musteri(musteri[0].ToString(), musteri[1].ToString(), musteri[2].ToString(), musteri[3].ToString()));
            }
            return musteriListesi;
        }

        public void musteriOlustur(Domain.Musteri gMusteri)
        {
            (new MySqlCommand("insert into Musteri (kimlikNo,ad,soyad,telNo) values ('" + gMusteri.KimlikNo + "','" + gMusteri.Ad + "','" + gMusteri.Soyad + "','" + gMusteri.TelNo + "')", (new dbBaglanti()).baglanti())).ExecuteNonQuery();
        }

        public void musteriDuzenle(Domain.Musteri gMusteri)
        {
            (new MySqlCommand("UPDATE Musteri SET ad='" + gMusteri.Ad + "', soyad='" + gMusteri.Soyad + "', telNo='" + gMusteri.TelNo + "' WHERE kimlikNo='" + gMusteri.KimlikNo + "'" , (new dbBaglanti()).baglanti())).ExecuteNonQuery();
        }

        public void musteriSil(Domain.Musteri gMusteri)
        {
            (new MySqlCommand("DELETE FROM Musteri WHERE kimlikNo=" + gMusteri.KimlikNo + "", (new dbBaglanti()).baglanti())).ExecuteNonQuery();
        }
    }
}
