using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Biblio;

namespace T2_Yes
{
    class Program
    {
        static void Main(string[] args)
        {

            Class1 Cajero = new Class1();
            int opcion;
            do
            {
                Console.Clear(); //Limpia los valores de la consola
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("--- MENU CAJERO AUTOMÁTICO ---");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("1. Retirar");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("2. Depositar");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("3. Consultar Saldo");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("4. Salir");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());
                opcion = int.Parse(Console.ReadLine());



                switch (opcion)



                {



                    case 0:



                        Console.WriteLine("saliendo....");



                        break;



                    case 1:



                        Cajero.retiro(); ;



                        break;



                    case 2:

                        Cajero.saldo();
                        break;
                    case 3:
                        Cajero.deposito();
                        break;
                    default:
                        Console.WriteLine("opcion no valida");
                        break;
                }        
            }
            while (opcion !=0);
        }
    }
    
}
