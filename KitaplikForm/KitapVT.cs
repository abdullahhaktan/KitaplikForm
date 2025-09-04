using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Globalization;

namespace KitaplikForm
{

    public class KitapVT
    {
        SqlConnection conn = new SqlConnection(@"Data Source=ABDULLAH;Initial Catalog=KitaplikDB;Integrated Security=True;");

        public List<Kitap> Liste()
        {
            conn.Open();
            List<Kitap> ktp = new List<Kitap>();
            SqlCommand cmd = new SqlCommand("Select * from Kitaplar", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Kitap k = new Kitap();
                k.ID = Convert.ToInt32(dr[0]);
                k.AD = dr[1].ToString();
                k.YAZAR = dr[2].ToString();

                ktp.Add(k);
            }
            conn.Close();
            return ktp;
        }

        public void KitapEkle(Kitap k)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Insert into Kitaplar values(@P1,@P2)", conn);
            cmd.Parameters.AddWithValue("@P1", k.AD);
            cmd.Parameters.AddWithValue("@P2", k.YAZAR);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
