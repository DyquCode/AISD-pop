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
            Wezel3 rodzic = this.ZnajdzRodzica(liczba);
            rodzic.Add(liczba);
        }

        public Wezel3 ZnajdzRodzica(int liczba)
        {
            var w = this.korzen;
            while (true)
            {
                if (liczba < w.wartosc)
                {
                    if(w.leweDziecko == null)
                    {
                        return w;
                    }else
                    {
                        w = w.leweDziecko;
                    }
                }
                else
                {
                    if (w.praweDziecko == null)
                    {
                        return w;
                    }
                    else
                    {
                        w = w.praweDziecko;
                    }
                }
            }
        }

        Wezel3 Znajdz(int liczba)
        {
            //W oparciu o ZnajdzRodzic, jeżeli jest równe
        }

        Wezel3 ZnajdzMin(Wezel3 w)
        {
            //Tak długo w dół dopóki leweDziekco nie jest null'em
        }

        Wezel3 ZnajdzMax(Wezel3 w)
        {
            //Tak długo w dół dopóki praweDziekco nie jest null'em
        }

        Wezel3 Nastepnik(Wezel3 w)
        {
            //Wartosc wieksza, albo przynajmniej nie mniejsza
            //a) Jeżeli jest prawe dziecko, to ZnajdzMin(w.praweDziecko) <- następnik
            //b) Jeżeli nie ma prawego dziecka, to idź do góry, tak długo, aż wyjdziesz w rodziców jako leweDziecko, Nastepnik to rodzic w którym wyszedłeś.
            //C) Jeżeli nie ma prawego dziecka i nie zachodzi (b) i nie mogę iść w górę, to nie ma następnika.
        }

        Wezel3 Poprzednik(Wezel3 w)
        {

        }
    }
}
