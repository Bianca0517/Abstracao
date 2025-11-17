using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Senai : Escola
    {
        public override void CalcularMedia()
        {
            Console.WriteLine("Digite a primeira nota do aluno");
            double nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota do aluno");
            double nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota do aluno");
            double nota3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a quarta nota do aluno");
            double nota4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a frequência do aluno");
            int frequencia = Convert.ToInt32(Console.ReadLine());

            while (nota1 < 0 || nota1 > 10 || nota2 < 0 || nota2 > 10 || nota3 < 0 || nota3 > 10 || nota4 < 0 || nota4 > 10 || frequencia < 0 || frequencia > 100)
            {
                Console.WriteLine("Digite a primeira nota do aluno");
                nota1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite a segunda nota do aluno");
                nota2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite a terceira nota do aluno");
                nota3 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite a quarta nota do aluno");
                nota4 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite a frequência do aluno");
                frequencia = Convert.ToInt32(Console.ReadLine());
            }

            double media = (nota1 + nota2 + nota3 + nota4) / 4;

            if (frequencia >= 90 && media >= 7)
            {
                Console.WriteLine("Parabéns, você foi aprovado no curso técnico do Senai!");
            }
            else if (frequencia >= 90 && media < 7)
            {
                Console.WriteLine("Você precisa fazer trabalho de recuperação.");
            }
            else if (frequencia < 90 && media >= 7)
            {
                Console.WriteLine("Você foi reprovado por faltas.");
            }
            else
            {
                Console.WriteLine("Aluno reprovado.");
            }


        }

    }
}
