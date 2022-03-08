using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDez.ConsoleApp
{
    internal class Aluno
    {
        public double[] notasProvas = new double[2];
        public double[] pesoProvas = new double[2];
        public double mediaPonderada;

        public double ObterMediaPonderada(double[] notasProvas, double[] pesoProvas)
        {
            double somaNotasProvas = 0;
            double somaPesos = 0;
            for (int i = 0; i < 2; i++)
            {
                somaNotasProvas += notasProvas[i] * pesoProvas[i];
                somaPesos += pesoProvas[i];
            }
            mediaPonderada = somaNotasProvas / somaPesos;
            return mediaPonderada;
        }
    }
}