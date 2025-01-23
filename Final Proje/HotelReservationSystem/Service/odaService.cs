using HotelReservationSystem.DataAccessLayer;
using HotelReservationSystem.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationSystem.Service
{
    class odaService
    {
        public System.Collections.ArrayList odaOku()
        {
            return (new odaDAO()).odaOku();
        }

        public void odaOlustur(string gOdaTuru , double gFiyat)
        {
            (new odaDAO()).odaOlustur(new Domain.Oda(gOdaTuru, gFiyat, "Boş"));
        }

        public void odaDuzenle(int gOdaID ,string gOdaTuru , double gFiyat)
        {
            (new odaDAO()).odaDuzenle(new Domain.Oda(gOdaID, gOdaTuru, gFiyat));
        }

        public void odaSil(int gOdaID)
        {
            (new odaDAO()).odaSil(new Domain.Oda(gOdaID));
        }

        public void girisYap(int gOdaID)
        {
            (new odaDAO()).girisYap(new Domain.Oda(gOdaID, "Dolu"));
        }

        public void cikisYap(int gOdaID)
        {
            (new odaDAO()).cikisYap(new Domain.Oda(gOdaID, "Boş"));
        }  
    }
}
