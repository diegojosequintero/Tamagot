using System;
using System.Collections.Generic;
using System.Text;

namespace Tamagochy
{
    class Amo
    {
        int dinero = 100;
        int energia = 100;

        internal void Trabajo()
        {
            dinero += 30;
            energia -= 20;
        }

        internal void Correa()
        {
            dinero -= 0;
            energia -= 10;
        }
        internal void Comea()
        {
            dinero -= 10;
            energia += 10;
        }
        internal void Duermea()
        {
            dinero += 0;
            energia += 20;
        }
        internal void Ejercitaa()
        {
            dinero += 0;
            energia -= 20;
        }
        internal void Cantaa()
        {
            dinero += 0;
            energia -= 10;
        }
        internal void Bailaa()
        {
            dinero += 0;
            energia -= 15;
        }
        internal void Curara()
        {
            dinero -= 40;
            energia -= 20;
        }
    }

}

