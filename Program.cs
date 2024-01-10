using System;
using DesafioPOO.Models;

namespace DesafioPOO
{
    class Program
    {
        static void Main()
        {
            Nokia cellNokia = new Nokia("88999989","Nokia C9","85954C8K2",128);
            RealizarOperacoes(cellNokia,"Nokia");

            Console.WriteLine();

            Iphone cellIphone = new Iphone("88997788","Iphone 14","5855998CF",256);
            RealizarOperacoes(cellIphone,"Iphone");
        }

         static void RealizarOperacoes(Smartphone smartphone, string tipoSmartphone)
        {
            Console.WriteLine($"{tipoSmartphone} - Número: {smartphone.Numero}, Modelo: {smartphone.Modelo}, IMEI: {smartphone.IMEI}, Memória: {smartphone.Memoria}GB");

            smartphone.Ligar();
            smartphone.ReceberLigacao();
            smartphone.InstalarAplicativo("AppTeste");

            Console.WriteLine();
        }

    }
}