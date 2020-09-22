namespace entra_21_tests_lista_2
{
    public class Exercicios
    {
        
        public int[] Exercicio02(int[] array10)
        {
           // Ler um array com 10 inteiros e mostrar os números na ordem direta e 
             //inversa a que foram lidos.

             var resultado = new int [10];
             for (int i = 0; i < array10.Length; i++)
             {
                 resultado[array10.Length - (i + 1)] = array10[i];
             }
             return resultado;
        }
    }
}