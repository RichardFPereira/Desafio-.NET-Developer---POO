using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_.NET_Developer___POO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }
        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"\nInstalando aplicativo {nome} no Iphone...");
            
            for (int i = 0; i < 10; i++)
            {
                System.Console.Write(" . ");
                Thread.Sleep(500);
            }

            Console.WriteLine("\nInstalação Concluída!");
        }
    }
}