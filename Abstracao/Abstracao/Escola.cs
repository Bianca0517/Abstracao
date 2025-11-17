using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public abstract class Escola
    {
        public abstract void CalcularMedia();

        public void DescobrirNome()
        {
            Console.WriteLine("Digite o nome da escola");
            string nomeEscola = Console.ReadLine().ToUpper();
            Console.WriteLine("Digite a cidade");
            string cidade = Console.ReadLine().ToUpper();
            Console.WriteLine("Digite o estado");
            string estado = Console.ReadLine();
            Console.WriteLine("Digite a série que estuda");
            string serie = Console.ReadLine();

            if (nomeEscola == "SESISENAI" && cidade == "GARÇA")
            {
                Console.WriteLine("Aluno Sesi/Senai.");
            }
            else
            {
                Console.WriteLine($"Aluno da escola {nomeEscola} da cidade {cidade}.");
            }
        }
    }
}

