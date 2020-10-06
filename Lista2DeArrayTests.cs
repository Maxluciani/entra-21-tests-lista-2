
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
      [Theory]
      [InlineData(new int[5]{5,8,12,7,9},21)]
      public void Soma_dos_elementos_impares(int[] a, int sum)
      {
        var exercicios = new Lista2DeArray();
        var resultado = exercicios.Exercicio2_04(a);
        Assert.Equal(resultado,sum);
      }
      [Theory]
      [InlineData(new double[10]{5,8,-8,-3,4,1,7,-3,-6,11},6)]
      public void Quantidade_de_numeros_positivos_no_vetor(double[] a ,int positive)
      {
        var exercicios = new Lista2DeArray();
        var resultado = exercicios.exercicio2_05(a);
        Assert.Equal(resultado,positive);
      }
      [Theory]
      [InlineData(new int[10]{3,5,8,3,5,66,23,7,12,9},3)]
      public void Quantas_vezes_que_um_numero_reside_na_sua_mesma_posição(int[] a,int match)
      {
        var exercicios = new Lista2DeArray();
        var resultado = exercicios.exercicio2_07(a);
        Assert.Equal(resultado,match);
      }
      [Theory]
      [InlineData(new string[10]{"d","a","s","a","l","a","m","e","f","u"},5)]
      public void Quantidade_de_consoantes(string[] a,int consoantes)
      {
          var exercicios = new Lista2DeArray();
          var resultado = exercicios.exercicio2_08(a);
          Assert.Equal(resultado,consoantes);
      }
      [Theory]
      [InlineData(new string[10]{"t","f","r","h","u","t","c","w","o","y"},"truco")]
      [InlineData(new string[14]{"c","j","e","t","r","r","v","r","e","h","j","d","a","f"},"cerveja")]
      [InlineData(new string[12] {"s","d","a","h","l","w","a","k","m","g","e","t"},"salame")]
      [InlineData(new string[15]{"t","u","o","v","r","t","r","f","e","j","s","x","m","h","o"},"torresmo")]
      public void Formando_palavras_apenas_com_letras_em_posicoes_pares(string[] a,string letra)
      {
        var exercicios = new Lista2DeArray();
        var palavra = exercicios.exercicio2_09(a);
        Assert.Equal(palavra,letra);
      }
      [Fact]
      
      public void Quantas_pessoas_gostam_de_um_produto() 
      {
        var entrevistados = new (int sexo,int gostou)[5]{(1,1),(1,2),(2,2),(2,1),(1,2)};
        var exercicios = new Lista2DeArray();
        var resultado = exercicios.Exercicio2_03(entrevistados);
        Assert.Equal(2,resultado.sim);
        Assert.Equal(3,resultado.nao);
        Assert.Equal(2,resultado.homemnao);
        Assert.Equal(1,resultado.mulhersim);


      }
    }
}