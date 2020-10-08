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
        public (int sim,int nao,int homemnao,int mulhersim) Exercicio2_03((int sexo,int gostou)[] entrevistados)
        {
          //Um certa empresa fez uma pesquisa para saber se as
          // pessoas gostaram ou não de um novo
         // produto lançado no mercado. Para isso, ,
         //forneceu-se o sexo do entrevistado e a sua resposta
         // (sim ou não). Sabendo-se que foram entrevistadas 10 pessoas, 
         //fazer um algoritmo que calcule e
         // escreva:
         // • O número de pessoas que responderam sim;
         // • O número de pessoas que responderam não;
         // • A percentagem de pessoas do sexo feminino que responderam sim;
         // • A percentagem de pessoas do sexo masculino que responderam não;
          (int homens,int sim,int nao) homens = (0,0,0);
         (int mulheres,int sim,int nao) mulheres = (0,0,0);
         var sim = 0;
         var nao = 0;
         var mulhersim = 0;
         var homemnao = 0;
          foreach (var item in entrevistados)

          {
          
          
           if (item.sexo == 1)
           {

           homens.homens++;
           if ( item.gostou == 1)
           {
             homens.sim++;
           }
           else{
             homens.nao++;
           }  
           }
           else
           {
             mulheres.mulheres++;
             if (item.gostou == 1)
             {
               mulheres.sim++;
             }
             else
             {
               mulheres.nao++;
             }
           }
          }
          sim = (homens.sim + mulheres.sim);
          nao = (homens.nao + mulheres.nao);
          homemnao = homens.nao;
          mulhersim = mulheres.sim;
          return (sim, nao,homemnao,mulhersim);          

        }
        public int Exercicio2_04(int[] a)
        {
          //Desenvolver um programa que efetue a leitura de cinco elementos de uma matriz 
          // A do tipo vetor. No final, apresente o total da soma de todos os elementos 
          // que sejam impares.
          var sum = 0;
          for (int i = 0; i < a.Length; i++)
          {
              if (a[i] % 2 == 1)
              {
                sum += a[i];
              }
          }
                return sum;
        }
        public int exercicio2_05(double[] a)
        {
          //Contar quantos valores de um vetor de 10 posições são positivos.
          var positive = 0;
          for (int i = 0; i < a.Length; i++)
          {
              if ( a[i] > 0)
              {
                positive ++;
              }
          }
          return positive;
        }
        public (double maior,int posicao) exercicio2_06(double[] a)
        {
            //Ler um vetor de 10 posições 
            //Escrever a seguir o valor do maior elemento de Q 
            //e a respectiva posição que ele ocupa no vetor.
            (double great,int position)greatnumber = (0.0,0);
            var maior =0.0;
            var posicao =0;
            for (int i = 0; i < a.Length; i++)
            {
                
               if (a[i] > greatnumber.great)
               {
                 greatnumber.great = a[i];
                 greatnumber.position = i;
               }
            }
             maior = greatnumber.great;
             posicao = greatnumber.position;
            return (maior,posicao);

        }
        public int exercicio2_07(int[] a)
        {
         //Crie e popule um vetor A e imprima na tela o número de vezes que existe 
         //um número residindo na mesma posição do vetor que seu valor numérico.
          var match = 0;
           for (int i = 0; i < a.Length; i++)
           {
               if ( a[i] == i)
               {
                 match++;
               }
           }
           return match;
        }
        public int exercicio2_08(string[] a)
        {
          //Crie um vetor de strings de 10 posições onde cada posição
          //recebe uma letra do alfabeto. No final, imprima quantas destas são vogais.
          var letras = 0;
          for (int i = 0; i < a.Length; i++)
          {
            if (a[i] == "a" || a[i] == "e" || a[i] == "i" || a[i] == "o" || a[i] == "u")
            {
              letras ++;
            }  
          }
          return letras;
        }
        public string exercicio2_09(string[] a)
        {

        //Crie um vetor de strings de 10 posições onde cada posição recebe uma letra do alfabeto. 
        //No final, imprima a string resultante da soma das strings que residem em índices pares.
         var palavra = "";
         for (int i = 0; i < a.Length; i++)
         {
             if ( i % 2 == 0)
             {
              palavra += a[i];
             }
         }
         return palavra;
        }
    }
}