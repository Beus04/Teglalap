using System;
using System.Collections.Generic;
using System.Text;

namespace Teglalap
{
    public class Teglalap   
    {
        private int a = 0;
        private int b = 0;

        public Teglalap()
        {
            Random random = new Random();

            a = random.Next(1, 100);
            b = random.Next(1, 100);
        }

        public bool NegyzetE()
        {
            return a == b;       
        }

        public override string ToString()
        {
            string negyzete = NegyzetE() ? "Ez a téglalap egyben négyzet is." : "Ez a téglalap nem négyzet.";
            return $"A téglalap szélessége: {a} {Environment.NewLine}A téglalap magassága: {b}{Environment.NewLine}{negyzete} "; 
        }

    }



}
