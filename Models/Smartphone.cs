using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;


namespace Desafio_de_Projeto_3.Models
{
    public abstract class Smartphone
    {
        public Smartphone(int numero, string modelo, string imei, int memoria) {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }
        
        public int Numero {get; set;}
        private string Modelo;
        private string IMEI;
        private int Memoria;

        public void Ligar() {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao() {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nome);
    }
}