using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_28KasimSolidPrinciples.OCP
{
    //BankaServisi değişime açık ama gelişime kapalıdır.
    //Çünkü her bir müşteri isteğinde veya yapılan işlem türüne göre kodda güncellemeye gidilecektir.
    public class MusteriBilgileri
    {
        public string KrediKartNo { get; set; }
        public string KartBitisSuresi { get; set; }
        public string CVC { get; set; }
        public string KartSahibi { get; set; }
        public string KartTipi { get; set; }
    }
    public abstract class BankaServisi
    {
        public abstract void OdemeYap(MusteriBilgileri ms);
    }
    public enum NakitOdemeTipi
    {
        KapıdaOdeme,
        EFT,
        Havale
    }
    public class NakitOdeme : BankaServisi
    {
        private NakitOdemeTipi _odemeTipi;
        public NakitOdeme(NakitOdemeTipi odemeTipi)
        {
            _odemeTipi = odemeTipi;
        }
        public override void OdemeYap(MusteriBilgileri ms)
        {
            //Nakit işlemler için gerekli düzenlemeler buraya yazılsın.
        }
    }
    public class KrediKartOdeme : BankaServisi
    {
        public override void OdemeYap(MusteriBilgileri ms)
        {
            throw new NotImplementedException();
        }
    }
    public class SanalKartOdeme : BankaServisi
    {
        public override void OdemeYap(MusteriBilgileri ms)
        {
            throw new NotImplementedException();
        }
    }
    #region BadScenario
    //    public void NakitSatinAl(MusteriBilgileri ms)
    //    {
    //        //Kapıda ödeme veya havale seçenekleri, para transferi (EFT gibi) kullanılabilir..
    //    }
    //    public void KrediKartıIleSatinAl(MusteriBilgileri ms)
    //    {
    //        switch (ms.KartTipi)
    //        {
    //            case "Visa":
    //                //Taksitlendirme senaryoları düşünülerek buraya farklı if-else blokları yazılabilir.
    //                break;
    //            case "Master":
    //                break;
    //            default:
    //                break;
    //        }
    //    }
    //    public void TelefonNumarasiUzerindenSatinAl(MusteriBilgileri ms)
    //    {
    //        //Telefon bankacılığı kullanmak gerekir ve telefon üzerinden hesap entegrasyonu gereklidir.
    //    }
    //    public void SanalKartIleSatinAl(MusteriBilgileri ms)
    //    {

    //    } 
    #endregion
}

