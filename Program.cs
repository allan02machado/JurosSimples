using System;

namespace JurosSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor;
            int meses;
            double juros;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Calcule o juros final de um investimento");
            Console.ResetColor();
            Console.WriteLine("Pressione uma tecla para continuar...");
            Console.WriteLine();
            Console.ReadKey();

            Console.Write("Entre com o valor do capital R$: ");
            valor = double.Parse(Console.ReadLine());

            Console.Write("Insira a quantidade de meses: ");
            meses = int.Parse(Console.ReadLine());

            Console.Write("Insira a taxa de juros: ");
            juros = double.Parse(Console.ReadLine());
            Console.WriteLine();

            double total2 = (valor * juros) * meses / 100;
            Console.WriteLine($"Juros: {total2:C}");

            double total = valor + ((meses * (juros / 100)) * valor);
            Console.WriteLine($"Montante: {total:C}");
        }
    }
}
