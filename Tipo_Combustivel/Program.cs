﻿using System;

namespace Tipo_Combustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            int tipo = 0;
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            while(tipo != 4)
            {
                tipo = int.Parse(Console.ReadLine());

                if (tipo == 1)
                    alcool += 1;
                else if (tipo == 2)
                    gasolina += 1;
                else if (tipo == 3)
                    diesel += 1;
            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}
