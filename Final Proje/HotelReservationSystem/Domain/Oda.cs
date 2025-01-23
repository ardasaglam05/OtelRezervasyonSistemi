using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HotelReservationSystem.Domain
{
    public class Oda
    {
        private int odaID;
        private string odaTuru , odaDurumu;
        private double fiyat;

        public Oda(int gOdaID,string gOdaTuru, double gFiyat, string gOdaDurumu)
        {
            this.odaID = gOdaID;
            this.odaTuru = gOdaTuru;
            this.fiyat = gFiyat;
            this.odaDurumu = gOdaDurumu;
        }

        public Oda(string gOdaTuru, double gFiyat , string gOdaDurumu)
        {
            this.odaTuru= gOdaTuru;
            this.fiyat= gFiyat;
            this.odaDurumu = gOdaDurumu;
        }

        public Oda(string gOdaID , string gOdaTuru , double gFiyat , string gOdaDurumu)
        {
            this.odaTuru = gOdaTuru;
            this.fiyat = gFiyat;
            this.odaDurumu = gOdaDurumu;
        }

        public Oda(int gOdaID ,string gOdaTuru, double gFiyat)
        {
            this.odaID = gOdaID;
            this.odaTuru = gOdaTuru;
            this.fiyat = gFiyat;
        }

        public Oda(int gOdaID, string gOdaTuru, string gOdaDurumu)
        {
            this.odaID = gOdaID;
            this.odaTuru = gOdaTuru;
            this.odaDurumu = gOdaDurumu;
        }

        public Oda(int gOdaID)
        {
            this.odaID = gOdaID;
        }

        public Oda(int gOdaID, string gOdaDurumu)
        {
            this.odaID = gOdaID;
            this.odaDurumu = gOdaDurumu;
        }

        public int OdaID
        {
            get { return odaID; }
        }

        public string OdaTuru
        {
            get { return odaTuru; }
            set { odaTuru = value; }
        }

        public string OdaDurumu
        {
            get { return odaDurumu; }
            set { odaDurumu = value; }
        }

        public double Fiyat
        {
            get { return fiyat; }
            set { fiyat = value; }
        }

        public override string ToString()
        {
            return odaID.ToString();
        }
    }
}
