using market.enumaration;
using market.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace market.dao
{
   public class Repository
   {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        int returnvalue;
        List<LoginTable> loginTablesList;
        


        public Repository()
        {
            con = new SqlConnection(@"Data Source=DESKTOP-DO7C2A8\SQLEXPRESS;Initial Catalog=Market;User ID=sa;password=1");
           
        }
        public void baglantıyıAyarla()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
            
        }
        public User login(string kullaniciAdi, string sifre)
        {
            con.Open();
            cmd = new SqlCommand("select * from loginTable where  kullaniciAdi=@kulAd and sifre=@sifre", con);
            cmd.Parameters.AddWithValue("@kulAd", kullaniciAdi);
            cmd.Parameters.AddWithValue("@sifre", sifre);
            dr=cmd.ExecuteReader();
            if (dr.Read())
            {
                User user = new User();
                user.id = int.Parse(dr["id"].ToString());
                user.kullaniciAdi = dr["kullaniciAdi"].ToString();
                user.sifre = dr["sifre"].ToString();
                user.yetki = dr["yetki"].ToString();
                user.emailAdres = dr["emailAdres"].ToString();
                user.guvenlikSorusu = dr["guvenlikSorusu"].ToString();
                user.guvenlikCevabı = dr["guvenlikCevabı"].ToString();
                user.status = LoginStatus.basarili;
                return user;
                con.Close();
            }
            
           
            else
            {
                User user = new User();
                user.status = LoginStatus.basarisiz;
                return user;
            }
            
            
        }
        public List<LoginTable> getLoginTable()
        {
            loginTablesList = new List<LoginTable>();
            con.Open();
            cmd = new SqlCommand("logintableGetir_sp", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                LoginTable logintable = new LoginTable();
                logintable.id = int.Parse(dr["id"].ToString());
                logintable.kullaniciAdi= dr["kullaniciAdi"].ToString();
                logintable.sifre = dr["sifre"].ToString();
                logintable.yetki = dr["yetki"].ToString();
                logintable.bolge = dr["bolge"].ToString();
                logintable.emailAdres = dr["emailAdres"].ToString();
                logintable.guvenlikSorusu = dr["guvenlikSorusu"].ToString();
                logintable.guvenlikCevabı = dr["guvenlikCevabı"].ToString();
                loginTablesList.Add(logintable);     
            }
            con.Close();
            return loginTablesList;
           
        } 

        public LoginStatus doAuthentication(string kullaniciAdi,string guvenlikSorusu,string guvenlıkCevabı)
        {
            con.Open();
            cmd = new SqlCommand("select count(*) from loginTable where kullaniciAdi=@kulAdi and guvenlikSorusu=@guvSorusu and guvenlikCevabı=@guvcevabi", con);
            cmd.Parameters.AddWithValue("@kulAdi", kullaniciAdi);
            cmd.Parameters.AddWithValue("@guvSorusu", guvenlikSorusu);
            cmd.Parameters.AddWithValue("@guvcevabi", guvenlıkCevabı);
            returnvalue = (int)cmd.ExecuteScalar();
            con.Close();
            if (returnvalue == 1)
            {
                return LoginStatus.basarili;
            }
            else
            {
                return LoginStatus.basarisiz;
            }
        }
        public LoginStatus changePassword(string kullaniciAdi, string sifre)
        {
            con.Open();
            cmd = new SqlCommand("sifreGuncelle_sp", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
            cmd.Parameters.AddWithValue("@sifre", sifre);
            returnvalue = cmd.ExecuteNonQuery();
            con.Close();
            return LoginStatus.basarili;
        }
        public Urun urunGetir(string barkod )
        {
            Urun urun = new Urun();
            con.Open();
            cmd = new SqlCommand("select * from urun where barkodKod=@barkod", con);
            cmd.Parameters.AddWithValue("@barkod", barkod);
            dr=cmd.ExecuteReader();
            while(dr.Read())
            {
                
                urun.id = dr["id"].ToString();
                urun.qrkod = dr["qrkod"].ToString();
                urun.barkodKod = dr["barkodKod"].ToString();  
                urun.urunIsim = dr["urunIsim"].ToString();
                urun.kilo = int.Parse(dr["kilo"].ToString());
                urun.fiyat = int.Parse(dr["fiyat"].ToString());         
            }
            con.Close();
            return urun;
           
        }
        public LoginStatus kayıtEkle(User User)
        {
            con.Open();
            cmd = new SqlCommand("sp_kullaniciEkle", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@kullaniciAdi", User.kullaniciAdi);
            cmd.Parameters.AddWithValue("@sifre", User.sifre);
            cmd.Parameters.AddWithValue("@yetki", User.yetki);
            cmd.Parameters.AddWithValue("@bolge", User.bolge);
            cmd.Parameters.AddWithValue("@emailAdres",User.emailAdres);
            cmd.Parameters.AddWithValue("@guvenlikSorusu", User.guvenlikSorusu);
            cmd.Parameters.AddWithValue("@guvenlikCevabı", User.guvenlikCevabı);
            int returnvalue = cmd.ExecuteNonQuery();
            con.Close();
            if (returnvalue == 1)
            {
                return LoginStatus.basarili;
            }
            else
            {
                return LoginStatus.basarisiz;
            }

            

        }
        public LoginStatus kullaniciGuncelle(User user)
        {
            con.Open();
            cmd = new SqlCommand("sp_kullaniciGüncelle",con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", user.id);
            cmd.Parameters.AddWithValue("@kullaniciAdi",user.kullaniciAdi);
            cmd.Parameters.AddWithValue("@sifre",user.sifre);
            cmd.Parameters.AddWithValue("@yetki",user.yetki);
            cmd.Parameters.AddWithValue("@bolge",user.bolge);
            cmd.Parameters.AddWithValue("@emailAdres",user.emailAdres);
            cmd.Parameters.AddWithValue("@guvenlikSorusu",user.guvenlikSorusu);
            cmd.Parameters.AddWithValue("@guvenlıkCevabı",user.guvenlikCevabı);
            int returnvalue =cmd.ExecuteNonQuery();
            con.Close();
            if (returnvalue == 1)
            {
                return LoginStatus.basarili;
            }
            else
            {
                return LoginStatus.basarisiz;
            }
        }
        public LoginStatus kullaniciSil(int id)
        {
            con.Open();
            cmd = new SqlCommand("delete from loginTable where id=@id", con);
            cmd.Parameters.AddWithValue("@id", id);
            int returnvalue = cmd.ExecuteNonQuery();
            con.Close();
            if (returnvalue == 1)
            {
                return LoginStatus.basarili;
            }
            else
            {
                return LoginStatus.basarisiz;
            }
        }
        public List<Urun> tumUrunleriGetir()
        {
            List<Urun> urunList = new List<Urun>();
            con.Open();
            cmd = new SqlCommand("select * from urun", con);
            dr=cmd.ExecuteReader();
            while (dr.Read())
            {
                Urun urun = new Urun();
                urun.id = dr["id"].ToString();
                urun.qrkod = dr["qrkod"].ToString();
                urun.barkodKod = dr["barkodKod"].ToString();
                urun.olusturmaTarih = DateTime.Parse(dr["olusturulma_Tarih"].ToString());
                if (!string.IsNullOrEmpty(dr["guncellenme_Tarih"].ToString()))
                {
                    urun.güncellemeTarih = DateTime.Parse(dr["guncellenme_Tarih"].ToString());
                }
                urun.urunIsim = dr["urunIsim"].ToString();
                urun.kilo = int.Parse(dr["kilo"].ToString());
                urun.fiyat = int.Parse(dr["fiyat"].ToString());
                urun.ciro = int.Parse(dr["ciro"].ToString());
                urunList.Add(urun);
            }
            con.Close();
            return urunList;
        }
        public LoginStatus urunekle(Urun urun)
        {
            con.Open();
            cmd = new SqlCommand("sp_urunEkle", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", urun.id);
            cmd.Parameters.AddWithValue("@qrkod", urun.qrkod);
            cmd.Parameters.AddWithValue("@barkodKod", urun.barkodKod);
            cmd.Parameters.AddWithValue("@olusturulma_Tarih", urun.olusturmaTarih);
            cmd.Parameters.AddWithValue("@guncellenme_Tarih", urun.güncellemeTarih);
            cmd.Parameters.AddWithValue("@urunIsim", urun.urunIsim);
            cmd.Parameters.AddWithValue("@kilo", urun.kilo);
            cmd.Parameters.AddWithValue("@fiyat", urun.fiyat);
            cmd.Parameters.AddWithValue("@ciro", urun.ciro);
            returnvalue = cmd.ExecuteNonQuery();
            con.Close();
            if (returnvalue == 1)
            {
                return LoginStatus.basarili;
            }
            else
            {
                return LoginStatus.basarisiz;
            }
        }
        public LoginStatus urunGuncelle(Urun urun)
        {
            con.Open();
            cmd = new SqlCommand("sp_urunGuncelle", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", urun.id);
            cmd.Parameters.AddWithValue("@qrkod", urun.qrkod);
            cmd.Parameters.AddWithValue("@barkodKod", urun.barkodKod);
            cmd.Parameters.AddWithValue("@olusturulma_Tarih", urun.olusturmaTarih);
            cmd.Parameters.AddWithValue("@guncellenme_Tarih", urun.güncellemeTarih);
            cmd.Parameters.AddWithValue("@urunIsim", urun.urunIsim);
            cmd.Parameters.AddWithValue("@kilo", urun.kilo);
            cmd.Parameters.AddWithValue("@fiyat", urun.fiyat);
            cmd.Parameters.AddWithValue("@ciro", urun.ciro);
            returnvalue = cmd.ExecuteNonQuery();
            con.Close();
            if (returnvalue == 1)
            {
                return LoginStatus.basarili;
            }
            else
            {
                return LoginStatus.basarisiz;
            }
        }
        public LoginStatus urunSil(string id)
        {
            con.Open();
            cmd = new SqlCommand("delete from urun where id=@id",con);
            cmd.Parameters.Add("@id", id);
            returnvalue = cmd.ExecuteNonQuery();
            con.Close();
            if (returnvalue == 1)
            {
                return LoginStatus.basarili;
            }
            else
            {
                return LoginStatus.basarisiz;
            }
        }


   }
}
