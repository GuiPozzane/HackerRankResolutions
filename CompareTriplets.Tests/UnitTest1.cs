using System;
using System.Collections.Generic;
using Xunit;

namespace CompareTriplets.Tests
{
    public class UnitTest1
    {
        public static IEnumerable<object[]> Dados_Compare_Os_Valores_Sucesso() =>
           new List<object[]>
           {
            new object[] { new List<int>() { 5, 2, 1 }, new List<int>() { 4, 1, 3 }, new List<int>() { 2,1 } },
           };

        [Theory]
        [MemberData(nameof(Dados_Compare_Os_Valores_Sucesso))]
        
        public void Compare_Os_Valores_Sucesso(List<int> listaAlice, List<int> listaBob, List<int> resultadoEsperado)
        {


            //act
            var resultadoObtido = Program.CompareTriplets(listaAlice,listaBob);
            //assert
            Assert.Equal(resultadoEsperado, resultadoObtido);
        }



        public static IEnumerable<object[]> Dados_Compare_Os_Valores_Falha() =>
         new List<object[]>
         {
            new object[] { new List<int>() {3, 5, 2 }, new List<int>() { 7, 6, 4 }, new List<int>() { 3,0 } },
         };
        [Theory]
        [MemberData(nameof(Dados_Compare_Os_Valores_Falha))]

        public void Compare_Os_Valores_Falha(List<int> listaAlice, List<int> listaBob, List<int> resultadoEsperado)
        {


            //act
            var resultadoObtido = Program.CompareTriplets(listaAlice, listaBob);
            //assert
            Assert.NotEqual(resultadoEsperado, resultadoObtido);
        }
        //[Theory]
        //[InlineData(new int[] { 1, 2, 3, 4, 10, 11 }, 32)]
        //[InlineData(new int[] { 1, 2, 3 }, 32)]
        //public void Soma_Dos_Array_Falha(int[] array, int resultadoEsperado)
        //{
        //    //act
        //    var resultadoObtido = Program.SimpleArraySum(array);
        //    //assert
        //    Assert.NotEqual(resultadoEsperado, resultadoObtido);

        //}
    }
}
