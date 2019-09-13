﻿using System;
using System.Globalization;

namespace _5_MembrosEstaticos_pt1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Raio: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi: "+ Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
            {

            }
        }

       
    }
}
