using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Sesi : Escola
    {
        public override void CalcularMedia()
        {
            Console.WriteLine("Digite a primeira nota do aluno");
            double nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota do aluno");
            double nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota do aluno");
            double nota3 = Convert.ToDouble(Console.ReadLine());

            double media = (nota1 + nota2 + nota3) / 3;

            if (media >= 7)
            {
                Console.WriteLine("Aluno aprovado");
            }
            else if (media >= 4)
            {
                Console.WriteLine("Aluno em recuperação");
            }
            else
            {
                Console.WriteLine("Aluno reprovado");
            }
        }
    }
}

