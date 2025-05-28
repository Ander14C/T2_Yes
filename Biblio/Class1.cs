using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Biblio
{
    public class Class1
    {
        int r, c, d, a;
        int monto = 1000;

        public void retiro()
        {
            Console.WriteLine("Ingrese el monto a retirar: ");
            int r = int.Parse(Console.ReadLine());
            if (r >= 0)
            {
                if (r <= 500)
                {
                    c = monto - (r + 8);
                    if (c >= 0)
                    {
                        Console.WriteLine("Realizando operación. Espere un momento...");
                        Console.WriteLine("Su retiro ha sido realizado con éxito");
                        Console.WriteLine("Retiro con comisión de S/ 8.00: " + c);
                        monto = c;
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Monto insuficiente");
                    }
                }
                else
                {
                    Console.WriteLine("La operación no puede ser mayor a S/500");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("No se puede realizar la operación solicitada");
            }
        }
        public void saldo()
        {
            Console.WriteLine("El monto actual es:" + monto);
            Console.WriteLine();
        }

        public void deposito()
        {
            Console.WriteLine("Ingrese el monto a depositar: ");
            d = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (d >= 0)
            {
                if (d <= 1000)
                {
                    a = monto + (d - 2);
                    Console.WriteLine("Realizando operación. Espere un momento...");
                    Console.WriteLine("Su retiro ha sido realizado con éxito");
                    Console.WriteLine("Retiro con comisión de S/ 2.00: " + a);
                    Console.WriteLine();
                    monto = a;
                }
                else
                {
                    Console.WriteLine("La operación no puede ser mayor a S/1000");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("No se puede realizar la operación solicitada");
            }
        }
    }
}
