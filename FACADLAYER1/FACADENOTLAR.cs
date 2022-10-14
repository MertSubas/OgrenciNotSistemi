using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITIYLAYER;
using System.Data.SqlClient;
using System.Data;
using FACADLAYER1;



namespace FACADLAYER1
{
    public class FACADENOTLAR
    {
        public static bool GUNCELLE(ENTITYNOTLAR deger)
        {
            SqlCommand komut = new SqlCommand("NOTGUNCELLE", SQLBAGLANTISI.baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("SINAV1", deger.SINAV1);
            komut.Parameters.AddWithValue("SINAV2", deger.SINAV2);
            komut.Parameters.AddWithValue("SINAV3", deger.SINAV3);
            komut.Parameters.AddWithValue("PROJE", deger.PROJE);
            komut.Parameters.AddWithValue("ORTALAMA", deger.ORTALAMA);
            komut.Parameters.AddWithValue("DURUM", deger.DURUM);
            komut.Parameters.AddWithValue("OGRID", deger.OGRENCIID);
            return komut.ExecuteNonQuery() > 0;

        }
        public static List<ENTITYNOTLAR> NOTLISTESI()
        {
            List<ENTITYNOTLAR> degerler = new List<ENTITYNOTLAR>();
            SqlCommand komut = new SqlCommand("NOTLISTESI", SQLBAGLANTISI.baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr=komut.ExecuteReader();
            while (dr.Read())
            {
                ENTITYNOTLAR ent=new ENTITYNOTLAR();
                ent.OGRENCIID = Convert.ToInt16(dr["OGRID"]);
                ent.AD=dr["AD"].ToString();
                ent.SOYAD = dr["SOYAD"].ToString();
                ent.SINAV1 = Convert.ToInt16(dr["SINAV1"]);
                ent.SINAV2 = Convert.ToInt16(dr["SINAV2"]);
                ent.SINAV3 = Convert.ToInt16(dr["SINAV3"]);
                ent.PROJE = Convert.ToInt16(dr["PROJE"]);
                ent.ORTALAMA = Convert.ToDouble(dr["ORTALAMA"]);
                ent.DURUM = dr["DURUM"].ToString();
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;

        }
    }
}
