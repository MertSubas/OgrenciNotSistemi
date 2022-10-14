using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIYLAYER
{
    public class ENTITIYOGRENCI
    {
        int _ID;
        public int ID { get => _ID; set => _ID = value; }

        string _AD;

        public string AD
        {
            get { return _AD; }
            set { _AD = value; }
        }
        string _SOYAD;
        public string SOYAD
        {
            get { return _SOYAD; }
            set { _SOYAD = value; }
        }
        string _FOTOGRAF;
        public string FOTOGRAF
        {
            get { return _FOTOGRAF; }
            set { _FOTOGRAF = value; }
        }
        int _KULUPID;
        public int KULUPID
        {
            get { return _KULUPID; }
            set { _KULUPID = value; }
        }

        
    }
}