using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Desenvolvedor : Colaborador
    {
        public override void CalcularHorasExtras()
        {
            Console.WriteLine("Escolha a sua modalidade de trabalho: \n --- Modalidades --- \n A - PRESENCIAL \n B - HÍBRIDO \n C - REMOTO");
            string opcao = Console.ReadLine().ToUpper();

            if (opcao == "A")
            {
                Console.WriteLine("Qual a quantidade de horas extras?");
                double horaExtra = Convert.ToDouble(Console.ReadLine());

                double totalHora = horaExtra * 100;

                Console.WriteLine($"Esse é o total das horas extras: {totalHora} ");
            }
            else if (opcao == "B")
            {
                Console.WriteLine("Qual a quantidade de horas extras?");
                double horaExtra = Convert.ToDouble(Console.ReadLine());

                double totalHora = horaExtra * 50;

                Console.WriteLine($"Esse é o total das horas extras: {totalHora} ");
            }
            else if (opcao == "C")
            {
                Console.WriteLine("Seu horário é flexível, não há horas extras.");
            }
            else
            {
                Console.WriteLine("Opção inválida.");
            }
        }
    }
}

