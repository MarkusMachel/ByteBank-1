using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ByteBank.ConsoleApp
{
    public class LeitorDeArquivos
    {
        public string Arquivo { get; }

        public LeitorDeArquivos(string arquivo)
        {
            Arquivo = arquivo;
            Console.WriteLine("Abrindo arquivo: " + arquivo);
        }

        public string LerProximaLinha()
        {
            Console.WriteLine("Lendo linha. . .");
            return "Linha do arquivo";
        }
    }
}