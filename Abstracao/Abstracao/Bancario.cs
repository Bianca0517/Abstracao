using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Bancario : Colaborador
    {
        public override void CalcularHorasExtras()
        {
            Console.WriteLine("Qual a quantidade total de horas extras feitas no mês?");
            double totalHoras = Convert.ToDouble(Console.ReadLine());

            double valorBruto = totalHoras * 250;

            if (valorBruto > 1000)
            {
                double imposto15 = totalHoras * 0.15;

                Console.WriteLine($"Esse é o novo valor com um imposto de 15%: {imposto15}");
            }
            else if (valorBruto > 500)
            {
                double imposto10 = totalHoras * 0.10;

                Console.WriteLine($"Esse é o novo valor com um imposto de 10%: {imposto10}");
            }
            else
            {
                Console.WriteLine($"O seu valor bruto de horas extras sem imposto é de: {valorBruto}");
            }

        }
    }
}
