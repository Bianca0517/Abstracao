using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class GerenteTI : Colaborador
    {
        public override void CalcularHorasExtras()
        {
            Console.WriteLine("Qual a quantidade total de horas extras feitas no mês?");
            double totalHoras = Convert.ToDouble(Console.ReadLine());

            if (totalHoras > 100)
            {
                double calculoSalario = (totalHoras / 2) * 200 + 500;
                double calculoDescanso = (totalHoras / 2) / 8;

                Console.WriteLine($"O seu valor a receber é de {calculoSalario} e os seus dias de descanso é {calculoDescanso}  ");
            }
            else
            {
                double valor = totalHoras * 400;

                Console.WriteLine($"O seu novo valor a receber é de {valor}");
            }
        }
    }
}
