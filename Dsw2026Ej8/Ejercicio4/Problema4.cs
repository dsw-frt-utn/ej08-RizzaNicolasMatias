using System;
using System.Collections.Generic;
using System.Linq;

namespace EJ08_RizzaNicolasMatias.Problema4
{
    public class Problema4
    {
        public double CalcularPromedio(double? nota1, double? nota2, double? nota3)
        {
            // Creacion de una lista para guardar solo las notas válidas
            List<double> notasValidas = new List<double>();

            if (nota1.HasValue && nota1.Value >= 0 && nota1.Value <= 10)
                notasValidas.Add(nota1.Value);

            if (nota2.HasValue && nota2.Value >= 0 && nota2.Value <= 10)
                notasValidas.Add(nota2.Value);

            if (nota3.HasValue && nota3.Value >= 0 && nota3.Value <= 10)
                notasValidas.Add(nota3.Value);

            if (notasValidas.Count == 0)
                return 0;

            return notasValidas.Average();
        }
    }
}