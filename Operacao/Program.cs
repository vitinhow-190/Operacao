using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operacao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o primeiro número: ");
            int Num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int Num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Selecione a operação desejada (+, -, *, /): ");
            string op = Console.ReadLine();

            if (op == "+")
            {
                Num1 = Num1 + Num2;

                Console.WriteLine("O resultado é: " + Num1);

            }
            else if (op == "-")
            {
                Num1 = Num1 - Num2;

                Console.WriteLine("O resultado é: " + Num1);
            }
            else if (op == "*")
            {
                Num1 = Num1 * Num2;

                Console.WriteLine("O resultado é: " + Num1);
            }
            else if (op == "/")
            {
                Num1 = Num1 / Num2;

                Console.WriteLine("O resultado é: " + Num1);
            }
            else if (op != "+, -, *, /")
            {
                Console.WriteLine("Operação inexistente");
            }
            Console.ReadKey();








        }
    }
}
