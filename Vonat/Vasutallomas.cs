using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vonat
{
    public class Vasutallomas
    {
        private bool keso;
        private int indulo;
        private int erkezo;
        private int vonatokszamaazallomason;

        public Vasutallomas(bool keso, int indulo, int erkezo, int vonatokszamaazallomason)
        {
            this.keso = keso;
            this.indulo = indulo;
            this.erkezo = erkezo;
            this.vonatokszamaazallomason = vonatokszamaazallomason;
        }
        public Vasutallomas(bool indulo)
        {
            this.keso = false;
            this.indulo = 1;
            this.erkezo = 1;
            this.vonatokszamaazallomason = 1;
        }

        public bool KesovonatokazallomasonvannakE()
        {
            if (keso == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool tobbErkezoMintIndulo()
        {
            if (erkezo > indulo)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool tobbAzAtlagaErkezoInduloMintAllomasonlevoErkezoAtlaga()
        {
            if ((erkezo + indulo) / 2 > (erkezo + vonatokszamaazallomason) / 2)
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