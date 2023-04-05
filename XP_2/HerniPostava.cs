using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XP_2
{
   public class HerniPostava
    {
        protected string jmeno;
        protected int poziceX = 0;
        protected int poziceY = 0;
        protected int level = 1;
        int PoziceX
        {
            get
            {
                return poziceX;
            }
        }
        int PoziceY
        {
            get
            {
                return poziceY;
            }
        }
        string Jmeno
        {
            get
            {
                return jmeno;
            }
            set
            {
                if (value.Length > 10) MessageBox.Show("Příliš dlouhé jméno!");
                else jmeno = value;
            }
        }

        public string Vratjmeno()
        {
            return jmeno;
        }
        public HerniPostava()
        {
            jmeno = "Tonda";
        }
        public HerniPostava(string jmeno)
        {
            this.Jmeno = jmeno;
        }
        public virtual int ZmenaPozice1()
        {
           return poziceX += 10;
        }
        public virtual int ZmenaPozice2()
        {
           return poziceY += 10;
        }
        public override string ToString()
        {
            return string.Format("{0}, level {1}, pozice X {2}, pozice Y: {3} ,", Jmeno, level, PoziceX, PoziceY);
        }

    }
}