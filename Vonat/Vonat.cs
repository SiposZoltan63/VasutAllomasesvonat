using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vonat
{
    public class SzemelyVonat
    {
        private string szallitmany;
        private bool gyors;
        private int hossz_m;
        private bool szemely1osztaly;
        private bool kocsik;
        private bool uresvonat;


        public SzemelyVonat(string szallitmany, int hossz_m)
        {
            this.szallitmany = szallitmany;
            //this.gyors = gyors;
            this.hossz_m = hossz_m;
            //this.szemely1osztaly = szemely1osztaly;
            //this.kocsik = kocsik;
        }
        public Vonat(string szallitmany)
        {
            this.gyors = false;
            this.hossz_m = 4;
            this.szallitmany = szallitmany;
            this.szemely1osztaly= false;
            this.kocsik = true;
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
            if (szallitmany == "Teher" || gyors == false)
            {
                return szemely1osztaly = false;
            }
            else
            {
                return szemely1osztaly = true;
            }
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

}
