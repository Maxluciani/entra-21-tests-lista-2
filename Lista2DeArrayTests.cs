
using Xunit;

namespace entra_21_tests_lista_2
{

    public class Lista2DeArrayTests
    {
      [Theory]
      [InlineData(new double[5]{1,2,3,4,5},new double[]{5,6,7,8,9})]
      public void Deveria_trocar_os_valores_dos_arrays(double[] a,double[] b)
          {
            var exercicios = new Lista2DeArray();
            var resultado = exercicios.Exercicio2_01(a,b);
            Assert.Equal(b,resultado.a);
            Assert.Equal(a,resultado.b);
          }
      [Theory]
      [InlineData(new double[10]{1,2,3,4,55,6,7,8,9,55})]
      [InlineData(new double[10]{1,2,9,4,88,6,7,63,9,55})]
      public void Verificando_numeros_repetidos_no_array(double[] numero)
      {
        var exercicios = new Lista2DeArray();
        var resultado = exercicios.exercicio2_02(numero);
        Assert.True(resultado);
      }
    }
}