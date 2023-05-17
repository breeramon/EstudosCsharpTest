using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo veiculo1 = new Veiculo(4, 4, "Preto", "Ford");
            veiculo1.ExibirInfo();

            Console.ReadKey();
        }
    }
}
