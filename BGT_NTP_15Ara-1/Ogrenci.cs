using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGT_NTP_15Ara_1
{
    class Ogrenci
    {
        string _AdSoyad;
        int _ogrNo;

        public string ADSOYAD
        {
            get { return _AdSoyad; }
            set { _AdSoyad = value; }
        }
        public int OGRNO
        {
            get { return _ogrNo; }
            set { _ogrNo = value; }
        }
    }
}
