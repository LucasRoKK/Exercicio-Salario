using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----Empresa Zé dos Noias-----");
            Console.WriteLine();

            double porc;
            Funcionario func = new Funcionario();
            Console.Write("Nome: ");
            func.nome = Console.ReadLine();
            Console.Write("Salario bruto: ");
            func.salarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Desconto: ");
            func.desconto = double.Parse(Console.ReadLine());
            Console.WriteLine();

            func.Imprime();

            Console.Write("Deseja aumetar o salário em qual porcentagem? ");
            porc = double.Parse(Console.ReadLine());
            func.AumentarSalario(porc);

            func.Imprime();
        }
    }
}
