using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationSystem.Domain
{
    public class Musteri
    {
        private string kimlikNo , ad , soyad , telNo;

        public Musteri(string gKimlikNo , string gAd , string gSoyad , string gTelNo)
        {
            this.kimlikNo = gKimlikNo;
            this.ad = gAd;
            this.soyad = gSoyad;
            this.telNo = gTelNo;
        }

        public Musteri(string gKimlikNo)
        {
            this.kimlikNo = gKimlikNo;
        }

        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }

        public string Soyad
        {
            get { return soyad; }
            set { soyad = value; }
        }

        public string KimlikNo
        {
            get { return kimlikNo; }
            set { kimlikNo = value; }
        }

        public string TelNo
        {
            get { return telNo; }
            set { telNo = value; }
        }

        public override string ToString()
        {
            return KimlikNo;
        }
    }
}
