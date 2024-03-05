using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Salario bruto: ");
                int bruto = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor recebido do vale alimentação: ");
                int alimentacao = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantos filhos possui: ");
                int filhos = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor por filho: ");
                int valorfilho = int.Parse(Console.ReadLine());

            Console.WriteLine("Número de horas extras: ");
                int hextra = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor por hora: ");
                int valorhora = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor o INSS: ");
                int inss = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor do IRPF: ");
                int irpf = int.Parse(Console.ReadLine());

            int bruto2 = bruto - inss - irpf;

            int liquido = bruto2 + alimentacao + (filhos * valorfilho) + (hextra * valorhora);

            Console.WriteLine("O seu salário liquido é: " + liquido);
            Console.ReadKey();
   

        }
    }
}
