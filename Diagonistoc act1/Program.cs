using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagonistoc_act1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el numero correspondiente a la actividad que desee revisar");
            int caso = int.Parse(Console.ReadLine());
            switch (caso)
            {

                case 1:
                    int Num = 0;
                    while (Num <= 49)
                    {
                        Num++;
                        Console.WriteLine(Num);
                    }

                    break;
            }


            Console.ReadKey();
        }
    }

    }
