using System;

namespace Licao2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2) Faca um programa para ler o valar do raio de um circulo, e depois mostrar o valor da\n" +
                " area deste circulo com quatro casas decimais comforme exemplos.\n" +
                " Formula da area: area = π. raio²\n" +
                " considere o valor π = 3.14159");
            Console.WriteLine();
            Console.WriteLine("Digite um numero para calcular o raio do circulo");
            Console.WriteLine();
            double pi = 3.14159;
            double raio1 = 2.00;
            double raio2 = 100.64;
            double raio3 = 150.00;
            double area1 = (raio1 * raio1) * pi;
            Console.WriteLine("(A) Area de numero 1 e " + area1.ToString("f4"));
            double area2 = (raio2 * raio2) * pi;
            Console.WriteLine("(B) Area do numero 2 e " + area2.ToString("f4"));
            double area3 = (raio3 * raio3) * pi;
            Console.WriteLine("(C) Area de numero 3 e " + area3.ToString("f4"));

        }
    }
}
