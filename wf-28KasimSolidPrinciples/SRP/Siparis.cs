using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_28KasimSolidPrinciples.SRP
{
    public class SiparisItem
    {
        public int UrunId { get; set; }
        public int Adet { get; set; }
    }
    public class Urun
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Fiyat { get; set; }
    }
    public class Musteri
    {
        public string AdiSoyadi { get; set; }
        public string Mail { get; set; }
        public string Telefon { get; set; }
    }
    public class MesajServisi
    {
        public void EPostaGonder(string musteriMail, string mesaj)
        {

        }
        public void SMSGonder(string musteriNo, string mesaj)
        {

        }
    }
    public class SatinAlma
    {
        public void SatinAl(List<SiparisItem> sepet, string musteri)
        {

        }
    }
    public static class KodOlusturucu
    {
        public static string SiparisKoduOlustur()
        {
            return "srsrsr32dsdsa";
        }
        public static string IslemTakipKoduOlustur()
        {
            return "213123123";
        }
        public static string UrunKoduOlustur()
        {
            return "sadıqhwduqh12";
        }
    }
    public class Sepet
    {
        public List<SiparisItem> Sepettekiler { get; set; }
    }
    public class Siparis
    {
        MesajServisi _mesajServisi;
        SatinAlma _satinAlma;
        public Siparis()
        {
            _mesajServisi = new MesajServisi();
            _satinAlma = new SatinAlma();
        }
        public void SiparisVer(Sepet sepet, Musteri ms)
        {
            string siparisKodu = KodOlusturucu.SiparisKoduOlustur();
            _satinAlma.SatinAl(sepet.Sepettekiler, ms.AdiSoyadi);
            _mesajServisi.EPostaGonder(ms.Mail, "Siparişiniz oluşturuldu.");
        }
    }

    #region KotuSenaryo
    class Siparis
    {
        private string SiparisKoduUret()
        {
            return "XAD42121CA";
        }
        public void SiparisVer(List<SiparisItem> sepet, string musteri)
        {
            //Sipariş kodları
            string kod = SiparisKoduUret();
            SatinAl(sepet, musteri);
            MesajAt();
        }
        public void MesajAt()
        {

        }
        private void SatinAl(List<SiparisItem> sepet, string musteri)
        {
            //Satınalma kodları
        } 
        #endregion
    }
}
