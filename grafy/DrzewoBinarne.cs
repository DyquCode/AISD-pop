using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grafy
{
    internal class DrzewoBinarne
    {
        public Wezel3 korzen;
        public int iloscWezlow;
        public DrzewoBinarne(int liczba)
        {
            this.korzen = new Wezel3(liczba);
            this.iloscWezlow = 1;
        }

        public void Add(int liczba)
        {
            var rodzic = this.ZnajdzRodzica(liczba);
            rodzic.DodajDziecko(liczba);
        }

        Wezel3 ZnajdzRodzica(int liczba)
        {
            var w = this.korzen;
            while (w != null)
            {
                if ((w.leweDziecko != null && w.leweDziecko.wartosc == liczba) ||
                    (w.praweDziecko != null && w.praweDziecko.wartosc == liczba))
                {
                    return w;
                }

                if (liczba < w.wartosc)
                {
                    w = w.leweDziecko;
                }
                else
                {
                    w = w.praweDziecko;
                }
            }
            return null;
        }
    }
}
