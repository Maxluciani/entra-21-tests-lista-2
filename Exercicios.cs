namespace entra_21_tests_lista_2
{
    public class Exercicios
    {
        
        public double[] Exercicio01(double[] arraya,double[] arrayb)
        {
            //Leia dois arrays A e B com 15 elementos. Construir um array C, onde cada 
           //elemento de C é a subtração do elemento correspondente de A com B.
           var resultado = new double [10];
            for (int i = 0; i < arrayb.Length; i++)
            {
                resultado[i] = arraya[i] - arrayb[i];
            }
            return resultado;
        }
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
        public string Exercicio03(double[] array,double numero)
        {
            //Leia 10 elementos e armazene em um array A. Em seguida, solicite pelo 
         //teclado um número qualquer e pesquise no array se o número existe.
             var resultado = "O numero não existe no array";
             for (int i = 0; i < array.Length; i++)
             {
                 if(array[i] == numero)
                 {
                     resultado = "O numero existe no array";
                     return resultado;
                 }
             }
                 return resultado;

        }
    }
}