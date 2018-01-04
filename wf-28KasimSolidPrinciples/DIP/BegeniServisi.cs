using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_28KasimSolidPrinciples.DIP
{
    public class Begeni
    {
        public string Begenen { get; set; }
        public string Begenilen { get; set; }
    }
    public static class BegeniBaglanti
    {
        public static BegeniDatabaseIslemi Baglan()
        {
            return new BegeniDatabaseIslemi();
        }
    }
    //BegeniServis üzerinden bir profil beğeniliyor ya da beğeni kaldırılıyor.
    //Yalnız bu işlemi yapabilmek için beğenilecek olan beğeni işlemleri için bu servis database ile çalışmalı ve bu sayede bu işlemi yapmalıdır.
    public class BegeniServisi
    {
        public void Begen(Begeni begeni)
        {
            //BegeniDatabaseIslemi veriIslemleri = new BegeniDatabaseIslemi();
            BegeniDatabaseIslemi veriIslemleri = BegeniBaglanti.Baglan();
            //Bir sınıfın içinde başka bir sınıftan doğrudan instance almamalıyız. Bunun yerine bir aracı kullanmalıyız.
            if (veriIslemleri.BegeniVarMi())
            {
                veriIslemleri.BegeniSil(begeni);
            }
            else
            {
                veriIslemleri.Begen(begeni);
            }
        }
    }
    public class BegeniDatabaseIslemi
    {
        public bool BegeniVarMi()
        {
            return false;
        }
        public void Begen(Begeni b)
        {

        }
        public void BegeniSil(Begeni b)
        {

        }
    }
}
