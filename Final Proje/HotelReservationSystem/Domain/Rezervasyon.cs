using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HotelReservationSystem.Domain
{
    public class Rezervasyon
    {
        private int rezervasyonID , odaID;
        private string kimlikNo , baslangic, bitis;

        public Rezervasyon(int gRezervasyonID , int gOdaID , string gKimlikNo , string gBaslangic , string gBitis)
        {
            this.rezervasyonID = gRezervasyonID;
            this.odaID = gOdaID;
            this.kimlikNo = gKimlikNo;
            this.baslangic = gBaslangic;
            this.bitis = gBitis;
        }

        public Rezervasyon(string gKimlikNo , int gOdaID , string gBaslangic , string gBitis)
        {
            this.kimlikNo = gKimlikNo;
            this.odaID = gOdaID;
            this.baslangic = gBaslangic;
            this.bitis = gBitis;
        }

        public Rezervasyon(int gRezervasyonID , string gBaslangic , string gBitis)
        {
            this.rezervasyonID = gRezervasyonID;
            this.baslangic = gBaslangic;
            this.bitis = gBitis;

        }

        public Rezervasyon(int reservationIDInput)
        {
            this.rezervasyonID = reservationIDInput;
        }

        public int RezervasyonID
        {
            get { return rezervasyonID; }
        }

        public string KimlikNo
        {
            get { return kimlikNo; }
            set { kimlikNo = value; }
        }

        public int OdaID
        {
            get { return odaID; }
            set { odaID = value; }
        }

        public string Baslangic
        {
            get { return baslangic; }
            set { baslangic = value; }
        }

        public string Bitis
        {
            get { return bitis; }
            set { bitis = value; }
        }
    }
}
