using System.Globalization;

namespace ConversorDeMoeda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é a cotação do dólar?");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantos dólares você vai comprar?");
            Conversor.valorCompra = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double cotDolar = Conversor.ConversorMoeda(cotacao);

            Console.WriteLine("Valor a ser pago em reais= " + cotDolar.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}