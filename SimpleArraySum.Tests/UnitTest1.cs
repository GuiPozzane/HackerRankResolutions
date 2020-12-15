using System;
using Xunit;

namespace SimpleArraySum.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 1,2,3,4,10,11 },31)]
        [InlineData(new int[] { 1,2,3 },6)]
        public void Soma_Dos_Array_Sucesso(int[] array,int resultadoEsperado)
        {


            //act
            var resultadoObtido = Program.SimpleArraySum(array);
            //assert
            Assert.Equal(resultadoEsperado, resultadoObtido);
        }
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 10, 11 }, 32)]
        [InlineData(new int[] { 1, 2, 3 }, 32)]
        public void Soma_Dos_Array_Falha(int[] array, int resultadoEsperado)
        {
            //act
            var resultadoObtido = Program.SimpleArraySum(array);
            //assert
            Assert.NotEqual(resultadoEsperado, resultadoObtido);

        }
    }
}
