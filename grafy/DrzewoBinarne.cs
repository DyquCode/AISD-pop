﻿using System;
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

        public Wezel3 Znajdz(int liczba)
        {
            var w = this.korzen;
            while (w != null)
            {
                if (liczba == w.wartosc)
                {
                    return w;
                }
                else if (liczba < w.wartosc)
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

        public Wezel3 ZnajdzMin(Wezel3 w)
        {
            while (w.leweDziecko != null)
            {
                w = w.leweDziecko;
            }
            return w;
        }

        public Wezel3 ZnajdzMax(Wezel3 w)
        {
            while (w.praweDziecko != null)
            {
                w = w.praweDziecko;
            }
            return w;
        }

        public Wezel3 Nastepnik(Wezel3 w)
        {
            if (w.praweDziecko != null)
            {
                return ZnajdzMin(w.praweDziecko);
            }

            Wezel3 rodzic = w.rodzic;
            while (rodzic != null && w == rodzic.praweDziecko)
            {
                w = rodzic;
                rodzic = rodzic.rodzic;
            }
            return rodzic;
        }

        public Wezel3 Nastepnik2(Wezel3 w)
        {
            if (w.praweDziecko != null)
                return ZnajdzMin(w.praweDziecko);

            while(w.rodzic != null)
            {
                if (w.rodzic.leweDziecko == w)
                    return w.rodzic;
                w = w.rodzic;
            }
            return null;
        }

        public Wezel3 Poprzednik(Wezel3 w)
        {
            if (w.leweDziecko != null)
            {
                return ZnajdzMax(w.leweDziecko);
            }

            Wezel3 rodzic = w.rodzic;
            while (rodzic != null && w == rodzic.leweDziecko)
            {
                w = rodzic;
                rodzic = rodzic.rodzic;
            }
            return rodzic;
        }

        public Wezel3 Usun(Wezel3 w)
        {
            //Jeżeli nie ma dzieci, to usuwamy;
            //Jeżeli ma 1 dziecko, to dziecko wchodzi na miejsce usuwanej wartości (Zamieniamy w z dzieckiem)
            //Jeżeli ma 2 dzieci, to rekurencyjnie losujemy poprzednik albo następnik (tylko poprzedniki, albo następniki)
        }
    }
}
