using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XP_2
{
   public class Hrac : HerniPostava
    {
        public int XP = 0;
        string specializace;
        int oblicej = 0;
        public int pridanyxp = 0;
        int vlasy = 0;
        int barvavlasu = 0;

        enum Oblicej
        {
            velkýnos,
            ušoplesk,
            makeup
        }
        enum Vlasy
        {
            drdol,
            culík,
            pleška
        }
        enum Barvavlasu
        {
            kaštanová,
            blond,
            červená
        }
        public string Specializace
        {
            get
            {
                return specializace;
            }
            set
            {
                if (value == "Kouzelník" || value == "Berserker" || value == "Inženýr" || value == "Cizák")
                {
                    specializace = value;
                }
            }
        }
        public Hrac(string jmeno, int oblicej, int vlasy, int barvavlasu) : base(jmeno)
        {
            this.oblicej = oblicej;
            this.vlasy = vlasy;
            this.barvavlasu = barvavlasu;
        }
        public Hrac()
        {
            specializace = "Berserker";
        }

        public int PridejXp(int hodnota)
        {
            pridanyxp = hodnota;
            XP += hodnota;
            if (XP >= level * 100)
            {
                level += 1;
                XP = 0;
            }
            return XP;
        }
        public override string ToString()
        {
            string oblicejvypis;
            string vlasyvypis;
            string barva;
            if (oblicej == 0) oblicejvypis = Oblicej.velkýnos.ToString();
            else if (oblicej == 1) oblicejvypis = Oblicej.ušoplesk.ToString();
            else oblicejvypis = Oblicej.makeup.ToString();
            if (oblicej == 0) vlasyvypis = Vlasy.drdol.ToString();
            else if (oblicej == 1) vlasyvypis = Vlasy.culík.ToString();
            else vlasyvypis = Vlasy.pleška.ToString();
            if (barvavlasu == 0) barva = Barvavlasu.kaštanová.ToString();
            else if (barvavlasu == 1) barva = Barvavlasu.blond.ToString();
            else barva = Barvavlasu.červená.ToString();
            return base.ToString() + "XP: " + XP + ", obličej: " + oblicejvypis + ",\nvlasy: " + vlasyvypis + ", barva vlasů: " + barva;
        }

    }
}