using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITIYLAYER;
using FACADLAYER1;


namespace BUSINESSLOGICLAYER
{
    public class BLLKULUP
    {
        public static int EKLE(ENTITYKULUP deger)
        {
            if(deger.KULUPAD != null)
            {
                return FACADKULUP.EKLE(deger);
            }
            return -1;
        }
        public static bool GUNCELLE(ENTITYKULUP deger)
        {
            if(deger.KULUPAD !=null && deger.KULUPID >0)
            {
                return FACADKULUP.GUNCELLE(deger);
            }
            return false;
        }
        public static bool SIL(int deger)
        {
            if (deger >0)
            {
                return FACADKULUP.SIL(deger);
            }
            return false;

        }
        public static List<ENTITYKULUP> LISTELE ()
        {
            return FACADKULUP.KULUPLISTESI();
        }
    }
}
