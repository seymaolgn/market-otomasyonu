using market.dao;
using market.enumaration;
using market.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace market.controller
{
    public class Controller
    {
        
        Repository repository;
        public Controller()
        {
            repository = new Repository();
        }

        public User login(string kullaniciAdi, string sifre)
        {
            
            if(!string.IsNullOrEmpty(kullaniciAdi)&& !string.IsNullOrEmpty(sifre))
            {

               User result= repository.login(kullaniciAdi, sifre);
               return result;
                
            }
            else
            {
                User user = new User();
                user.status = LoginStatus.eksikParametre;
                return user;
            }
        }
        public List<LoginTable> getLoginTable()
        {
            List<LoginTable> loginTableLıst =repository.getLoginTable();
            return loginTableLıst;

        }
        public LoginStatus doAuthentication(string kullaniciAdi, string guvenlikSorusu, string guvenlıkCevabı)
        {
            if(!string.IsNullOrEmpty(kullaniciAdi)&& !string.IsNullOrEmpty(guvenlikSorusu) && !string.IsNullOrEmpty(guvenlıkCevabı))
            {
                LoginStatus result=repository.doAuthentication(kullaniciAdi, guvenlikSorusu, guvenlıkCevabı);
                if (result == LoginStatus.basarili)
                {
                    return result;
                }
                else
                {
                    return LoginStatus.basarisiz;
                }
            }
            else
            {
                return LoginStatus.eksikParametre;
            }
        }
        public LoginStatus changePassword(string kullaniciAdi, string sifre)
        {
            if (!string.IsNullOrEmpty(sifre))
            {
                return repository.changePassword(kullaniciAdi, sifre);
            }
            else
            {
                return LoginStatus.eksikParametre;
            }
        }
        public Urun urunGetir(string barkod)
        {
            if (!string.IsNullOrEmpty(barkod))
            {
                return repository.urunGetir(barkod);
            }
            else
            {
                return null;
            }
        }
        public LoginStatus kayıtEkle(User User)
        {
            if (!string.IsNullOrEmpty(User.kullaniciAdi) && !string.IsNullOrEmpty(User.sifre) && !string.IsNullOrEmpty(User.yetki) && !string.IsNullOrEmpty(User.emailAdres) && !string.IsNullOrEmpty(User.guvenlikSorusu) && !string.IsNullOrEmpty(User.guvenlikCevabı))
            {
                LoginStatus result=repository.kayıtEkle(User);
                return result;
            }

            else
            {
                return LoginStatus.eksikParametre;
            }
        }
        public LoginStatus kullaniciGuncelle(User user)
        {
             return repository.kullaniciGuncelle(user);
        }
        public LoginStatus kullaniciSil(int id)
        {
            if (!string.IsNullOrEmpty(id.ToString()))
            {
                return repository.kullaniciSil(id);
            }
            else
            {
                return LoginStatus.eksikParametre;
            }
           
        }
        public List<Urun> tumUrunleriGetir()
        {
            return repository.tumUrunleriGetir();
        }
        public LoginStatus urunekle(Urun urun)
        {
            if(!string.IsNullOrEmpty(urun.id)&& !string.IsNullOrEmpty(urun.barkodKod) && !string.IsNullOrEmpty(urun.urunIsim))
            {
                return repository.urunekle(urun);
            }
            else
            {
                return LoginStatus.eksikParametre;
            }
        }
        public LoginStatus urunGuncelle(Urun urun)
        {
            if (!string.IsNullOrEmpty(urun.id) && !string.IsNullOrEmpty(urun.barkodKod) && !string.IsNullOrEmpty(urun.urunIsim))
            {
                return repository.urunGuncelle(urun);
            }
            else
            {
                return LoginStatus.eksikParametre;
            }
        }
        public LoginStatus urunSil(string id)
        {
            if (!string.IsNullOrEmpty(id))
            {
                return  repository.urunSil(id);
            }
            else
            {
                return LoginStatus.eksikParametre;
            }
        }
    }

}
