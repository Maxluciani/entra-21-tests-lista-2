
using Xunit;

namespace entra_21_tests_lista_2
{
    public class ExerciciosTests
    {
        [Theory]
        [InlineData(new double[10]{2,4,6,8,10,12,14,16,18,20},new double[10]{1,2,3,4,5,6,7,8,9,10},
        new double[10]{1,2,3,4,5,6,7,8,9,10})]
        public void array_c(double[] arraya,double[] arrayb,double[] arrayc)
        {
         var exercicio = new Exercicios();
         var resultado = exercicio.Exercicio01(arraya,arrayb);
         for (int i = 0; i < arrayc.Length; i++)
         {
             Assert.Equal(arrayc[i],resultado[i]);
         }
        }
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
