using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2
{
    class Funcionario
    {
        public string nome;
        public double salarioBruto;
        public double desconto;

        public double SalarioLiquido()
        {
            return salarioBruto - desconto;
        }

        public void AumentarSalario(double porc)
        {
            double val;
            val = salarioBruto * (porc/100);
            salarioBruto = salarioBruto + val;
        }

        public void Imprime()
        {
            Console.WriteLine("Dados do funcionário: {0}, {1}", this.nome, this.SalarioLiquido());
            Console.ReadLine();
        }
    }
}
