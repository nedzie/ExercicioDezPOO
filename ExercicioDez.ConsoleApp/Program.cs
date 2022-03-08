using System;

namespace ExercicioDez.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno marcos = new Aluno();
            Console.Write("Informe a nota da 1ª prova: \n> ");
            marcos.notasProvas[0] = double.Parse(Console.ReadLine());
            Console.Write("Informe o peso da 1ª prova: \n> ");
            marcos.pesoProvas[0] = double.Parse(Console.ReadLine());

            Console.Write("Informe a nota da 2ª prova: \n> ");
            marcos.notasProvas[1] = double.Parse(Console.ReadLine());
            Console.Write("Informe o peso da 2ª prova: \n> ");
            marcos.pesoProvas[1] = double.Parse(Console.ReadLine());

            marcos.mediaPonderada = marcos.ObterMediaPonderada(marcos.notasProvas, marcos.pesoProvas);

            Console.WriteLine("A média ponderada destas notas é de: " + marcos.mediaPonderada.ToString("#.##") + ".");
        }
    }
}