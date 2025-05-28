using System;
using System.Collections.Generic;
using System.Linq;
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
            if (r <= 500)
            {
                if (c >= 0)
                {
                    Console.WriteLine("Realizando operación. Espere un momento...");
                    Console.WriteLine("Su retiro ha sido realizado con éxito");
                    Console.WriteLine("Retiro con comisión de S/ 8.00: " + c);
                }
                else
                {
                    Console.WriteLine("Monto insuficiente");
                }
                monto = c;
            }
            else
            {
                Console.WriteLine("La operación no puede ser mayor a S/500");
            }
            if (r < 0)
            {
                Console.WriteLine("El monto ingresado no es valido");
            }
            else
            {
                c = monto - (r + 8);
                Console.WriteLine("Realizando operación. Espere un momento...");
                Console.WriteLine("Su retiro ha sido realizado con éxito");
                Console.WriteLine("Retiro con comisión de S/ 8.00: " + c);
            }
        }
        public void saldo()
        {
            Console.WriteLine("El monto actual es:" + monto);
        }
        public void deposito()
        {
            Console.WriteLine("Ingrese el monto a depositar (Costo de la comision S/.2)");
            d = int.Parse(Console.ReadLine());

            if (d <= 1000)
            {
                a = monto + (d - 2);
                Console.WriteLine("Se ha depositado: " + d + " menos 2 soles de comisión");
                Console.WriteLine("El monto actual es: " + a);
            }
            else
            {
                Console.WriteLine("La operación no puede ser mayor a S/1000");
            }
        }
    }
}
