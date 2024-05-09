using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Desafio_.NET_Developer___POO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string  Modelo { get; init; }
        public string IMEI { get; init; }
        public int Memoria { get; init; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            System.Console.WriteLine("\nLigando");

            for (int i = 0; i < 10; i++)
            {
                System.Console.Write(" . ");
                Thread.Sleep(500);
            }

            System.Console.WriteLine("\nLigação concluída!");
        }
        
        public void ReceberLigacao()
        {
            System.Console.WriteLine("\nRecebendo ligação");

            for (int i = 0; i < 10; i++)
            {
                System.Console.Write(" . ");
                Thread.Sleep(500);
            }
            
            System.Console.WriteLine("\nLigação concluída!");
        }

        public abstract void InstalarAplicativo(string nome);

    }
}