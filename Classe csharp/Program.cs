using static System.Console;

namespace Projeto_Classe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Bem vindo!");
            WriteLine("Para listar nossos veículos digite 1");
            WriteLine("Para sair digite 0");
            int opUser = int.Parse(ReadLine());


            Carro Supra = new Carro("Supra MK3", "2JZ Turbo", "Toyota", "1997");
            Carro GTR34 = new Carro("Skyline GTR34", "RB26 Turbo", "Nissan", "2000");
            Carro RX7 = new Carro("RX7", "13B-REW", "Mazda", "1997");
            Carro Impreza = new Carro("Impreza WRX STI", "EJ255", "Subaru", "2000");

            WriteLine(Supra.ToString());
            WriteLine(GTR34.ToString());
            WriteLine(RX7.ToString());
            WriteLine(Impreza.ToString());
            WriteLine("\nAplicativo finalizado\n");
        }
    }
}