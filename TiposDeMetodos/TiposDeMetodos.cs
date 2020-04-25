using System;
namespace Tipos_de_Metodos
{
   class TiposDeMetodos
   {
      static void Main(string[] args)
      {
         int i = 10, j = 20;
         Console.WriteLine("Result: {0}", SumOfNumbers(i, j));
         TiposDeMetodos p = new TiposDeMetodos();
         Console.WriteLine(p.GetUserDetails("Suresh Dasari", 31));
         GetUserDetails();
         Console.WriteLine("Press Enter Key to Exit..");
         Console.ReadLine();
      }//end Main

      /// <summary>
      /// Método estático. Soma dois inteiros 
      /// </summary>
      /// <param name="a">int</param>
      /// <param name="b">int</param>
      /// <returns>int x = a+b</returns>      
      public static int SumOfNumbers(int a, int b)
      {
         int x = a + b;
         return x;
      }

      /// <summary>
      /// Método de classe que retorna o nome e a idade da pessoa
      /// </summary>
      /// <param name="name">string</param>
      /// <param name="age">int</param>
      /// <returns>string info</returns> 
      public string GetUserDetails(string name, int age)
      {
         string info = string.Format("Name: {0}, Age: {1}", name, age);
         return info;
      }

      /// <summary>
      /// Método estático, sem parâmetros(tipo void) e sem retorno(tipo void)
      /// </summary>
      public static void GetUserDetails()
      {
         string name = "Maria Mashal";
         int age = 59;
         Console.WriteLine("Name: {0}, Age: {1}", name, age);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="a"></param>
      public static void Multiplication(int a)
      {
         a *= a;
         Console.WriteLine("Variable Value Inside the Method: {0}", a);
      }

   }// end Class 
}
