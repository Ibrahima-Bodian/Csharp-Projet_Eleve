using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_eleve
{
    class HeureMinute
    {
        private int heure;
        private int minute;
        private void memoriser(int h , int m )
        {
            if (h >= 0 && h < 24 && m >= 0 && m < 60)
            {
                this.heure = h;
                this.minute = m;
            }
            else
            {
                this.heure = h / 0;
            }
        }

        public HeureMinute(int h, int m)
        {
            this.memoriser(h, m);
        }
        public HeureMinute(int nbminutes)
        {
            this.memoriser(nbminutes / 60, nbminutes % 60);
        }
        public int enMinutes()
        {
                return (this.heure * 60 + this.minute);
        }
        public float enHeures()
        {
            return (this.heure + this.minute / 60f);
        }
        public HeureMinute ajouter(HeureMinute H)
        {
            HeureMinute Res;
            Res = new HeureMinute(this.enMinutes() + H.enMinutes());
            return Res;
        }
        public HeureMinute soustraire(HeureMinute H )
        {
            HeureMinute Res;
            Res = new HeureMinute(this.enMinutes() - H.enMinutes());
            return Res;
        }
        public bool estInferieur(HeureMinute H )
        {
            return this.enMinutes() < H.enMinutes();
        }
        public String enChaine()
        {
            return (this.heure + ":" + this.minute);
        }
    }
}
