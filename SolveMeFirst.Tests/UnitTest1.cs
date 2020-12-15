using AutoFixture;
using SolveMeFirst.Tests.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace SolveMeFirst.Tests
{
    public class UnitTest1
    {
        public static IEnumerable<object[]> Dados_Para_Teste_Soma_Sucesso() =>
        new List<object[]>
        {
            new object[] { new SolveMeFirstModel(2, 3, 5) },
            new object[] { new SolveMeFirstModel(100, 1000, 1100), },
            
        };

        [Theory]
        [MemberData(nameof(Dados_Para_Teste_Soma_Sucesso))]
        public void Soma_De_Dois_Numeros_Sucesso(SolveMeFirstModel parameter)
        {
            
            // Act
            var resultadoObtido = Program.SolveMeFirst(parameter.N1, parameter.N2);
            // Assert
            Assert.Equal(parameter.ResultadoEsperado, resultadoObtido);
        }

        public static IEnumerable<object[]> Dados_Para_Teste_Soma_Falha() =>
        new List<object[]>
        {
            new object[] { new SolveMeFirstModel(2, 3, 6) },
            new object[] { new SolveMeFirstModel(100, 1000, 4544), },

        };

        [Theory]
        [MemberData(nameof(Dados_Para_Teste_Soma_Falha))]
        public void Soma_De_Dois_Numeros_Falha(SolveMeFirstModel parameter)
        {

            // Act
            var resultadoObtido = Program.SolveMeFirst(parameter.N1, parameter.N2);
            // Assert
            Assert.NotEqual(parameter.ResultadoEsperado, resultadoObtido);
        }

    }
}
