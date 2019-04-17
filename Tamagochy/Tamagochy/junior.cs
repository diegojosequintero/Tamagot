using System;
using System.Collections.Generic;
using System.Text;


namespace Tamagochy
{
    class junior
    {
        

            int estadoFisico = 80;
            int estadoHambre = 10;
            int estadoSalud = 80;
            int estadoAnimo = 80;
            int tiempo = 0;

            internal void Corre()
            {
                estadoFisico -= 3;
                estadoHambre -= 20;
                estadoAnimo -= 2;
                tiempo += 1;
            }
            internal void Come()
            {
                estadoAnimo += 5;
                estadoHambre -= 20;
                estadoFisico -= 3;
                tiempo += 1;
            }
            internal void Duerme()
            {
                estadoAnimo += 3;
                estadoHambre += 30;
                estadoFisico = estadoFisico -2;
                tiempo += 3;
            }
            internal void Ejercita()
            {
                estadoAnimo += 3;
                estadoHambre += 30;
                estadoFisico += 2;
                tiempo += 1;
            }
            internal void Canta()
            {
                estadoAnimo += 4;
                estadoHambre += 10;
                estadoFisico += 1;
                tiempo += 1;
            }
            internal void Baila()
            {
                estadoAnimo += 2;
                estadoHambre += 20;
                estadoFisico += 5;
                tiempo += 1;
            }
            internal void Curar()
            {
                estadoAnimo = estadoAnimo - 5;
                estadoHambre += 10;
                estadoFisico -= 0;
                tiempo += 1;
            }

        internal void estadoJunior()
        {
            Console.WriteLine("Estado Fisico: "+estadoFisico +"\n"+
                              "Estado de Ánimo: "+estadoAnimo +"\n"+
                              "Estado de Salud: " + estadoSalud + "\n" +
                              "Estado de Hambre: " + estadoHambre );
        }



        
    }
}
