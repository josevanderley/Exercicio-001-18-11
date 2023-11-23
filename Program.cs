using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_001_18_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nota1 = 0;
            int nota2 = 0;
            int nota3 = 0;
            int nota4 = 0;
            decimal media = 0;

            Console.WriteLine("Digite a nota 1");
            nota1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota 2");
            nota2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota 3");

            nota3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota 4");
            nota4 = int.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            Console.WriteLine("Media do aluno e " + media.ToString());

            if (media >= 6)
            {
                Console.WriteLine("Aluno aprovado!");
            }
            else
            {
                if (media >= 4)
                {
                    Console.WriteLine("Aluno em recuperação.");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                }
                {
                    Console.ReadKey();
                }
            }
        }
    }
}







    


