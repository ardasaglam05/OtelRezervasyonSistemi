using HotelReservationSystem.DataAccessLayer;
using HotelReservationSystem.Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationSystem.Service
{
    class rezervasyonService
    {
        public System.Collections.ArrayList reezervasyonOku()
        {
            return (new rezervasyonDAO()).rezervasyonOku();
        }

        public System.Collections.ArrayList ozelRezervasyonOku(string gKimlikNo)
        {
            return (new rezervasyonDAO()).ozelRezervasyonOku(gKimlikNo);
        }

        public System.Collections.ArrayList ozelOdaGoster(string gOdaTuru)
        {
            return (new rezervasyonDAO()).ozelOdaOku(gOdaTuru);
        }

        public void rezervasyonOlustur(string gKimlikNo,int gOdaID, string gBaslangic, string gBitis)
        {
            (new rezervasyonDAO()).rezervasyonOlustur(new Domain.Rezervasyon(gKimlikNo,gOdaID, gBaslangic, gBitis));
        }

        public void rezervasyonDuzenle(int gRezervasyonID, string gBaslangic, string gBitis)
        {
            (new rezervasyonDAO()).rezervasyonDuzenle(new Domain.Rezervasyon(gRezervasyonID, gBaslangic, gBitis));
        }

        public void rezervasyonSil(int gRezervasyonID)
        {
            (new rezervasyonDAO()).rezervasyonSil(new Domain.Rezervasyon(gRezervasyonID));
        }
    }
}
