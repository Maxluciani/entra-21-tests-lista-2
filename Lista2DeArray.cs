namespace entra_21_tests_lista_2
{

    public class Lista2DeArray
    {

      public (double[] a,double[] b) Exercicio2_01(double[] a,double[] b)
      {
        //Popule dois vetores com 10 valores cada. 
        //Após esta operação, troque o conteúdo dos vetores.
         return(b,a);
      }
      public bool exercicio2_02(double[] a)
       {
          //Dado um vetor qualquer com 10 números, 
          //faça um programa que informa se há ou não números repetidos nesse vetor.
          var repeat = false;
          for (int i = 0; i < a.Length; i++)
          {
           for (int j = 0; j < a.Length; j++)
           {
             if ( i != j && a[i] == a[j])  
             {
                 repeat = true;
                 break;
             }
           } 
               if (repeat)
           
               {
                break;
               }
            
          }
          return repeat;
        }
    }
}