﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIYLAYER
{
    public class ENTITYNOTLAR
    {
        int _OGRENCIID;
        public int OGRENCIID
        {
            get { return _OGRENCIID; }
            set { _OGRENCIID = value; }
        }

        int _SINAV1;

        public int SINAV1
        {
            get { return _SINAV1; }
            set { _SINAV1 = value; }

        }

        int _SINAV2;
        public int SINAV2
        {
            get { return _SINAV2; }
            set { _SINAV2 = value; }

        }

        int _SINAV3;

        public int SINAV3
        {
            get { return _SINAV3; }
            set { _SINAV3 = value; }
        }
        int _PROJE;

        public int PROJE
        {
            get { return _PROJE; }
            set { _PROJE = value; }
        }

        Double _ORTALAMA;

        public Double ORTALAMA
        {
            get { return _ORTALAMA; }
            set { _ORTALAMA = value; }
        }

        string _DURUM;

        public string DURUM
        {
            get { return _DURUM; }
            set { _DURUM = value; }
        }
        private string _AD;
        public string AD
        {
            get { return _AD; }
            set { _AD = value; }
        }

        private string _SOYAD;
        public String SOYAD
        {
            get { return _SOYAD;}
            set { _SOYAD = value; }
        }




    }
}