using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vonat
{
    public class SzemelyVonat
    {
        
        private bool gyors;
        private int hossz_m;
        private bool szemely1osztaly;
        
        public SzemelyVonat(int hossz_m,bool gyors,bool szemely1osztaly)
        {
            this.gyors = gyors;
            this.hossz_m = hossz_m;
            this.szemely1osztaly = szemely1osztaly;
        }
        public SzemelyVonat(bool szemely1osztaly)
        {
            this.gyors = false;
            this.hossz_m = 4;
            this.szemely1osztaly= false;
        }
        public bool GyorsE()
        {
            if (gyors == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool SzemelyIC_e()
        {
            if (gyors == false)
            {
                return szemely1osztaly = false;
            }
            else
            {
                return szemely1osztaly = true;
            }
        }

        public bool hosszuvonate()
        {
            if (hossz_m > 15)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
    public class Tehervonat()
    {
        private string szallitmany;
        private bool kocsik;

        
        public Tehervonat(bool kocsik,string szallitmany)
        {
            this.szallitmany = "Tégla";
            this.kocsik = true;
        }

        public Tehervonat(bool kocsik,string szallitmany)
        {
            this.szallitmany = szallitmany;
            this.kocsik = kocsik;
        }

        public bool Szallitmany()
        {
            if (kocsik == true)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }

}
