using System;
using Xunit;

namespace entra_21_tests_lista_2
{
    public class ExerciciosTests
    {
        [Theory]
        [InlineData(new int[10]{10,20,30,40,50,60,70,80,90,100},new int [10]{100,90,80,70,60,50,40,30,20,10})]
        public void Ordem_direta_e_indireta_de_um_array(int[] array10 , int[] expectativa)
        {
            var exercicio = new Exercicios();
            var resultado = exercicio.Exercicio02(array10);
            for (int i = 0; i < expectativa.Length; i++)
            {
                Assert.Equal(expectativa[i],resultado[i]);
            }
        }
    }
}
