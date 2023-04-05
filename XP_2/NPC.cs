using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XP_2
{
   public class NPC : HerniPostava
    {

        public bool sila = false;
        public int prace = 0;
        enum Prace
        {
            obchodník,
            nepřítel,
            obyvatel
        }
        public NPC(string jmeno, int prace, bool sila) : base(jmeno)
        {
            this.prace = prace;
            this.sila = sila;
        }
        public NPC(string jmeno, int prace) : base(jmeno)
        {
            sila = false;
        }

        public override sealed int ZmenaPozice1()
        {
           return poziceX = 50;
        }
        public override sealed int ZmenaPozice2()
        {
            return poziceY = 50;
        }
        public override string ToString()
        {
            string pracevypis;
            if (prace == 0) pracevypis = Prace.obchodník.ToString();
            else if (prace == 1) pracevypis = Prace.nepřítel.ToString();
            else pracevypis = Prace.obyvatel.ToString();
            if (sila) return base.ToString() + string.Format(", práce: {0} a je boss", pracevypis);
            else return base.ToString() + string.Format(" práce: {0} a není boss", pracevypis);
        }
    }
}