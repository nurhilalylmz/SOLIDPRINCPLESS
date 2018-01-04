using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_28KasimSolidPrinciples.ISP
{
    #region BadScenario
    public interface ISifreleme
    {
        string Sifrele(string sifrelenecekMetin);
        string SifreCoz(string cozulecekMetin);
    }
    public class Asifreleme : ISifreleme
    {
        public string SifreCoz(string cozulecekMetin)
        {
            throw new NotImplementedException();
        }

        public string Sifrele(string sifrelenecekMetin)
        {
            return "ASDASDA";
        }
        public class BSifreleme : ISifreleme
        {
            public string SifreCoz(string cozulecekMetin)
            {
                throw new NotImplementedException();
            }

            public string Sifrele(string sifrelenecekMetin)
            {
                throw new NotImplementedException();
            }
        }
    } 
    #endregion

    public interface ISifreCoz
    {
        string Coz(string sifre);
    }
    public interface ISifrele
    {
        string Sifrele(string duzMetin);
    }
    public class B : ISifrele, ISifreCoz
    {
        public string Coz(string sifre)
        {
            throw new NotImplementedException();
        }

        public string Sifrele(string duzMetin)
        {
            throw new NotImplementedException();
        }
    }
    public class A : ISifrele
    {
        public string Sifrele(string duzMetin)
        {
            throw new NotImplementedException();
        }
    }
}
