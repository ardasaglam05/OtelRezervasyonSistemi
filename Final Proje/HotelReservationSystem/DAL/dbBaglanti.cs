using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql;
using MySql.Data.MySqlClient;

namespace HotelReservationSystem.DataAccessLayer
{
    class dbBaglanti
    {
        // Data Access Object for database connection.
        public MySqlConnection baglanti()
        {
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253; Database=25_132330031; Uid=25_132330031; Pwd=!nif.ogr31SA;");
            baglanti.Open();
            return baglanti;
        }
    }
}
