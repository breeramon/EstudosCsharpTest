using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteGit
{
    class Veiculo
    {
        public int Rodas { get; set; }
        public int Portas { get; set; }
        public string Cor { get; set; }

        public Veiculo(int rodas, int portas, string cor)
        {
            Rodas = rodas;
            Portas = portas;
            Cor = cor;
        }

        virtual public void ExibirInfo()
        {
            Console.WriteLine("Veículo Qualquer:");
            Console.WriteLine("Rodas do veículo = {0}", Rodas);
            Console.WriteLine("Portas do veículo = {0}", Portas);
            Console.WriteLine("Cor do veículo = {0}", Cor);
        }
    }
}
