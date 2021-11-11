using System;

namespace HoroscopoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá! Vamos descobrir qual o seu signo...");
            Console.WriteLine("Primeiro, qual o seu nome?");
            var nome = Console.ReadLine();
            Console.WriteLine("E em que dia você nasceu?");
            var dia = Console.ReadLine();
            Console.WriteLine("Em qual mês você nasceu?");
            var mes =  Console.ReadLine();
        
            CalculadoraSigno signo = new CalculadoraSigno(int.Parse(dia), int.Parse(mes));
            var resposta = signo.CalcularSigno(int.Parse(dia), int.Parse(mes));

            Console.WriteLine($"{nome}, seu signo é {resposta}.");

        }
    }
}
