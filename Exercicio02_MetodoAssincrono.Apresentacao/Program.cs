using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercicio02_MetodoAssincrono.Apresentacao
{
    public class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine(BuscaAlunoAsync().Result);
            Console.ReadKey();
        }

        private static async Task<string> BuscaAlunoAsync()
        {
            var aluno = string.Empty;
            await Task.Run(() =>
            {
                Loading();                
                aluno = "Aluno: Samir Turquetto Melo \nR.A.: 290";
            });

            return aluno;
        }

        private static void Loading()
        {
            Console.WriteLine("Buscando aluno...");
            for (int i = 10; i > 0; i--)
            {
                Thread.Sleep(1000);
                Console.WriteLine(i);
            }
            Console.WriteLine("Aluno encontrado!");
        }
    }
}
