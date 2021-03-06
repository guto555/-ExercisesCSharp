﻿using System;
using System.Diagnostics.Contracts;
using System.Globalization;
using GeneratorC.Entities;
using GeneratorC.Services;
namespace GeneratorC
{
    class Program
    {
        public static DateTimeStyles Culture { get; private set; }

        static void Main(string[] args)
        {
            Console.Write("Recebe numero: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Recebe Data: ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy",CultureInfo.InvariantCulture);
            Console.Write("Recebe Valor contrato: ");
            double value = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Recebe quantidade parcelas: ");
            int months = int.Parse(Console.ReadLine());

            Contractt document = new Contractt(number, date, value);
            //criei so para carregar os dados
           // DateTime t1 = date.AddMonths(1);
            Processing process = new Processing(new PaypalService());
            //criei paracaregar o processamento e informar o tipo de sistema de juros usado.
            process.ProcessContract(document, months);

            Console.WriteLine(document);





        }
    }
}
