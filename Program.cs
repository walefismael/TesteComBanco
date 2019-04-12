using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaDAO
{
    class Program
    {
        static void Main(string[] args)
        {
            Cadastro teste = new Cadastro("walef");
            Console.WriteLine(teste.Mensagem);
            Console.ReadKey();

        }
    }
}
