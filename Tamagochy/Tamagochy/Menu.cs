using System;
using System.Collections.Generic;
using System.Text;

namespace Tamagochy
{
    class Menu
    {
    junior accion = new junior();
    Amo trabajo = new Amo();
        internal void Inicio()
        {
            MenuInicio:
            Console.WriteLine(" ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄\n " +
                               "█                        TAMAGOCHY                    █\n " +
                               "▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄\n " +
                               "█                      1.INICIAR                      █\n " +
                               "█                      2.INSTRUCCIONES                █\n " +
                               "█                      3.CREDITOS                     █\n " +
                               "▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄");

            string n = Console.ReadLine();
            bool init = Int32.TryParse(n, out int opcion);
            while (!init) ;
            while (opcion < 1 && opcion > 4 && opcion != 0) ;
            switch (opcion)
            {

                case 1:
                    MenuAmoMascota:
                    Console.Clear();
                    Console.WriteLine(" ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄\n " +
                                   "█         ELIGE ACCIÓN A MASCOTA O AMO                █\n " +
                                   "▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄\n " +
                                   "█                      1.MASCOTA                      █\n " +
                                   "█                      2.AMO                          █\n " +
                                   "█                      3.VUELVE                       █\n " +
                                   "█                                                     █\n " +
                                   "█                                                     █\n " +
                                   "█                                                     █\n " +
                                   "█                                                     █\n " +
                                   "▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄");

                    accion.estadoJunior();

                    string a = Console.ReadLine();
                    bool init2 = Int32.TryParse(a, out int opcion2);
                    while (!init2) ;
                    while (opcion2 < 1 && opcion2 > 4 && opcion2 != 0) ;
                    switch (opcion2)
                    {
                        case 1:
                            MenuMascota:
                            Console.Clear();
                            Console.WriteLine(" ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄\n " +
                                              "█         ¿Qué quieres hacer con tu mascota?          █\n " +
                                              "▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄\n " +
                                              "█                      1.CORRE                        █\n " +
                                              "█                      2.COME                         █\n " +
                                              "█                      3.DUERME                       █\n " +
                                              "█                      4.EJERCITA                     █\n " +
                                              "█                      5.CANTA                        █\n " +
                                              "█                      6.BAILA                        █\n " +
                                              "█                      7.CURAR                        █\n " +
                                               "█                      8.VUELVE                        █\n " +
                                              "▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄");
                            accion.estadoJunior();

                            string b = Console.ReadLine();
                            bool init3 = Int32.TryParse(b, out int opcion3);
                            while (!init3) ;
                            while (opcion3 < 1 && opcion3 > 9 && opcion3 != 0) ;
                            switch (opcion3)
                            {
                                case 1:
                                    accion.Corre();
                                    goto MenuAmoMascota;
                                   
                                case 2:
                                    accion.Come();
                                    goto MenuAmoMascota;
                                case 3:
                                    accion.Duerme();
                                    goto MenuAmoMascota;
                                case 4:
                                    accion.Ejercita();
                                    goto MenuAmoMascota;
                                case 5:
                                    accion.Canta();
                                    goto MenuAmoMascota;
                                case 6:
                                    accion.Baila();
                                    goto MenuAmoMascota;
                                case 7:
                                    accion.Curar();
                                    goto MenuAmoMascota;
                                case 8:
                                    goto MenuAmoMascota;
                            }
                            break;
                        case 2:
                            MenuAmo:
                            Console.Clear();
                            Console.WriteLine(" ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄\n " +
                                              "█                 ¿Qué necesitas hacer?               █\n " +
                                              "▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄\n " +
                                              "█               1.TRABAJAR  MEDIA JORNADA             █\n " +
                                              "█               2.TRABAJAR UNA JORNADA                █\n " +
                                              "█               3.BUSCAR PAREJA                       █\n " +
                                              "█               4.DONAR A TU MASCOTA                  █\n " +
                                              "█               5.VUELVE                              █\n " +
                                              "█                                                     █\n " +
                                              "█                                                     █\n " +
                                              "▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄");
                            accion.estadoJunior();
                            string c = Console.ReadLine();
                            bool init4 = Int32.TryParse(c, out int opcion4);
                            while (!init4) ;
                            while (opcion4 < 1 && opcion4 > 6 && opcion4 != 0) ;
                            switch (opcion4)
                            {
                                case 1:

                                    break;
                                case 2:
                                    break;
                                case 3:
                                    break;
                                case 4:
                                    break;
                                case 5:
                                    goto MenuAmoMascota;
                            }
                            break;
                        case 3:
                            Console.Clear();
                            goto MenuInicio;

                    }

                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine(" ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄\n " +
                                           "█                    INSTRUCCIONES                    █\n " +
                                           "▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄\n " +
                                           "█          Elige entre las opciones disponibles       █\n " +
                                           "█          en pantalla para mantener sano a tu        █\n " +
                                           "█          mascota, sólo debes mantenerlo sano        █\n " +
                                           "█          y también debes tomar tu tiempo para       █\n " +
                                           "█          trabajar y generar los ingresos para       █\n " +
                                           "█          realizar algunas actividades  que          █\n " +
                                           "█          requieran algún gasto monetario.           █\n " +
                                           "▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine(" ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄\n " +
                                           "█                    INSTRUCCIONES                    █\n " +
                                           "▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄\n " +
                                           "█                                                     █\n " +
                                           "█                                                     █\n " +
                                           "█                                                     █\n " +
                                           "█                                                     █\n " +
                                           "█                                                     █\n " +
                                           "█                                                     █\n " +
                                           "█                                                     █\n " +
                                           "▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄");
                    Console.Clear();
                    goto MenuInicio;
                case 3:
                    Console.Clear();
                    Console.WriteLine(" ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄\n " +
                                           "█                    CRÉDITOS                         █\n " +
                                           "▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄\n " +
                                           "█               DIEGO JOSE                            █\n " +
                                           "█               QUINTERO NOGUERA                      █\n " +
                                           "█                                                     █\n " +
                                           "█               SI PLAGIAS MI TAMAGOTCHY              █\n " +
                                           "█               TE DEMANDO              >:V           █\n " +
                                           "█                                                     █\n " +
                                           "█                                                     █\n " +
                                           "▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄");
                    Console.ReadLine();
                    Console.Clear();
                    goto MenuInicio;
            }
        }

    }
}
