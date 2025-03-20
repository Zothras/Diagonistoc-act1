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
                    int Num = 1;
                    while (Num <= 50)
                    {
                        Console.WriteLine(Num);
                        Num++;
 
                    }

                    break;

                case 2:
                    int Num2 = 1;
                    while (Num2<=50)
                    {
                        Console.WriteLine(Num2);
                        if (Num2 % 2 == 1)
                        {
                            Console.WriteLine("Este numero es par");
                        }
                        else
                        {
                            Num2++;
                        }
                        Num2++;     
                        

                    }

                    break;

                case 3:
                    int intinicial;
                    int fininter;
                    Console.WriteLine("Ingrese un intervalo de numeros, ¿Desde que numero te gustaria iniciar el intervalo?");
                    intinicial = int.Parse(Console.ReadLine());
                    Console.WriteLine("Hasta que numero?");
                    fininter = int.Parse(Console.ReadLine());
                    while (intinicial <=fininter)
                    {
                        Console.WriteLine(intinicial);
                        intinicial++;
                        

                    }

                    break;

                case 4:
                    for (int num3 = 1; num3 <= 50; num3++)
                    {
                        Console.WriteLine(num3);
                    }

                    break;

                case 5:
                    for (int Y = 0; Y <= 50; Y++)
                    {
                        Console.WriteLine(Y);
                        if (Y % 2 == 1)
                        {
                            Console.WriteLine(Y);
                            
                        }
                        else
                        {
                            Y++;
                        }
                    }


                    break;


                case 6:
                    int intinicial2;
                    int fininter2;
                    Console.WriteLine("Ingrese un intervalo de numeros, ¿Desde que numero te gustaria iniciar el intervalo?");
                    intinicial2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Hasta que numero?");
                    fininter2 = int.Parse(Console.ReadLine());
                    for (int num6 = intinicial2; num6 <= fininter2; num6++)
                    {
                        Console.WriteLine(num6);
                    }

                    break;

                case 7:
                    int dia;
                    do
                    {
                        Console.WriteLine("Ingrese un numero del 1 al 7, este le dira a que dia de la semana pertenece");
                        dia = int.Parse(Console.ReadLine());
                        if (dia == 1)
                        {
                            Console.WriteLine("DOMINGO");

                        }
                        else if (dia == 2)
                        {
                            Console.WriteLine("LUNES");

                        }
                        else if (dia == 3)
                        {
                            Console.WriteLine("MARTES");

                        }
                        else if (dia == 4)
                        {
                            Console.WriteLine("MIERCOLES");

                        }
                        else if (dia == 5)
                        {
                            Console.WriteLine("JUEVES");

                        }
                        else if (dia == 6)
                        {
                            Console.WriteLine("VIERNES");

                        }
                        else if (dia == 7)
                        {
                            Console.WriteLine("SABADO");

                        }
                        else
                        {
                            Console.WriteLine("LOL es el mejor juego (NUMERO INCORRECTO DUH)");
                        }

                    } while (dia != 8);
                    {
                        

         
                    }
                    break;

                case 8:
                    int mes;
                    do
                    {
                        
                        Console.WriteLine("Ingrese un numero del 1 al 12, este le dira a que mes del año le pertenece");
                        mes = int.Parse(Console.ReadLine());
                        
                            if (mes == 1)
                            {
                                Console.WriteLine("El mes seleccionado es: ENERO ");
                            }
                            else if (mes == 2)
                            {
                                Console.WriteLine("El mes seleccionado es: FEBRERO");
                            }
                            else if (mes == 3)
                            {
                                Console.WriteLine("El mes seleccionado es: MARZO");
                            }
                            else if (mes == 4)
                            {
                            Console.WriteLine("El mes seleccionado es: ABRIL");
                            }
                             else if (mes == 5)
                            {
                            Console.WriteLine("El mes seleccionado es: MAYO ");
                            }
                             else if (mes == 6)
                            {
                            Console.WriteLine("El mes seleccionado es: JUNIO");
                            }
                             else if (mes == 7)
                            {
                            Console.WriteLine("El mes seleccionado es: JULIO");
                            }
                             else if (mes == 8)
                            {
                            Console.WriteLine("El mes seleccionado es: AGOSTO");
                            }
                             else if (mes == 9)
                            {
                            Console.WriteLine("El mes seleccionado es: SEPTIEMBRE");
                            }
                             else if (mes == 10)
                            {
                            Console.WriteLine("El mes seleccionado es: NOVIEMBRE");
                            }
                             else if (mes == 11)
                            {
                            Console.WriteLine("El mes seleccionado es: OCTUBRE");
                            }
                             else if (mes == 12)
                            {
                            Console.WriteLine("El mes seleccionado es: DICIEMBRE");
                            }
                            else
                        {
                            Console.WriteLine("Este numero es incorrecto... ESPABILA QUE LA VIDA TE VA A COME'");
                            break;
                        }
                    } while (mes != 12);
                    {


                    }

                    break;

                case 9:
                    int paroimpar;
                    int guardado;
                    int continuar;
                    do
                    {
                        Console.WriteLine("Ingrese un numero");
                        paroimpar = int.Parse(Console.ReadLine());
                        guardado = paroimpar / 2;
                        if (guardado == 1)
                        {
                            Console.WriteLine("El numero que ingreso es impar.");
                        }
                        else
                        {
                            Console.WriteLine("El numero que ingreso es par");
                        }
                        Console.WriteLine("Si desea continuar presione 1, en caso contrario presione 2");
                        continuar = int.Parse(Console.ReadLine());

                    } while (continuar ==1);
                    break;


            }Console.ReadKey();


        }
    }

    }
