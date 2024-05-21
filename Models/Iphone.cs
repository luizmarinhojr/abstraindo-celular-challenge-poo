using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_de_Projeto_3.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(int numero, string modelo, string imei, int memoria) : base (numero, modelo, imei, memoria) {}

        public override void InstalarAplicativo(string nome) {
            Console.WriteLine($"Instalando o aplicativo {nome} no Iphone");
        }
    }
}