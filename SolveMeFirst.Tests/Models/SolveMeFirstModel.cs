using System;
using System.Collections.Generic;
using System.Text;

namespace SolveMeFirst.Tests.Models
{
    public class SolveMeFirstModel
    {
        public SolveMeFirstModel(int n1, int n2, int resultado)
        {
            N1 = n1;
            N2 = n2;
            ResultadoEsperado = resultado;
        }

        public int N1 { get; set; }
        public int N2 { get; set; }
        public int ResultadoEsperado { get; set; }
    }
}
