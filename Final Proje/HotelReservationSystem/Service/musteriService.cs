using HotelReservationSystem.DataAccessLayer;
using HotelReservationSystem.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationSystem.Service
{
    class musteriService
    {
        public System.Collections.ArrayList musteriOku()
        {
            return (new musteriDAO()).musteriOku();
        }

        public System.Collections.ArrayList ozelMusteriOku(string gMusteriID)
        {
            return (new musteriDAO()).ozelMusteriOku(gMusteriID);
        }

        public void musteriOlustur(string gKimlikNo , string gAd , string gSoyad , string gTelNo)
        {
            (new musteriDAO()).musteriOlustur(new Domain.Musteri(gKimlikNo, gAd, gSoyad, gTelNo));
        }

        public void musteriDuzenle(string gKimlikNo, string gAd, string gSoyad, string gTelNo)
        {
            (new musteriDAO()).musteriDuzenle(new Domain.Musteri(gKimlikNo, gAd, gSoyad, gTelNo));
        }

        public void musteriSil(string gKimlikNo)
        {
            (new musteriDAO()).musteriSil(new Domain.Musteri(gKimlikNo));
        }
    }
}
