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
    class odaDAO
    {
        public System.Collections.ArrayList odaOku()
        {
            ArrayList odaListesi = new ArrayList();
            MySqlDataReader oda = (new MySqlCommand("select * from Oda", (new dbBaglanti()).baglanti())).ExecuteReader();
            while (oda.Read())
            {
                odaListesi.Add(new Domain.Oda(Convert.ToInt32(oda[0]), oda[1].ToString(), Convert.ToDouble(oda[2]), oda[3].ToString()));
            }
            return odaListesi;
        }

        public void odaOlustur(Domain.Oda gOda)
        {
            (new MySqlCommand("insert into Oda (odaTuru,fiyat,odaDurumu) values ('" + gOda.OdaTuru + "'," + gOda.Fiyat + ",'" + gOda.OdaDurumu + "')" , (new dbBaglanti()).baglanti())).ExecuteNonQuery();
        }

        public void odaDuzenle(Domain.Oda gOda)
        {
            (new MySqlCommand("UPDATE Oda SET odaTuru='" + gOda.OdaTuru + "', fiyat=" + gOda.Fiyat + " WHERE odaID=" + gOda.OdaID + "" , (new dbBaglanti()).baglanti())).ExecuteNonQuery();
        }

        public void odaSil(Domain.Oda gOda)
        {
            (new MySqlCommand("DELETE FROM Oda WHERE odaID=" + gOda.OdaID + ""  , (new dbBaglanti()).baglanti())).ExecuteNonQuery();
        }

        public void girisYap(Domain.Oda gOda)
        {
            (new MySqlCommand("UPDATE Oda SET odaDurumu='" + gOda.OdaDurumu + "' WHERE odaID=" + gOda.OdaID + "", (new dbBaglanti()).baglanti())).ExecuteNonQuery();
        }

        public void cikisYap(Domain.Oda gOda) 
        {
            (new MySqlCommand("UPDATE Oda SET odaDurumu='" + gOda.OdaDurumu + "' WHERE odaID=" + gOda.OdaID + "", (new dbBaglanti()).baglanti())).ExecuteNonQuery();
        }  
    }
}
