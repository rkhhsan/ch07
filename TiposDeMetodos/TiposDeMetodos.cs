using System;
namespace Tipos_de_Metodos
{
   class TiposDeMetodos
   {
      static void Main(string[] args)
      {
         int i = 10, j = 20, x = 10;
         Console.WriteLine("Result: {0}", SumOfNumbers(i, j));
         TiposDeMetodos p = new TiposDeMetodos();

         // Exemplo de método não estático e estático e método "void" e não "void"          
         Console.WriteLine(p.GetUserDetails("Suresh Dasari", 31));
         GetUserDetails();

         // Exemplo de método com passagem por valor 
         Console.WriteLine("\nVariable Value Before Calling the Method: {0}", x);
         Multiplication(x);
         Console.WriteLine("Variable Value After Calling the Method: {0}", x);

         // Exemplo de método com passagem por referência
         Console.WriteLine("\nVariable Value Before Calling the Method: {0}", x);
         Multiplication(ref x);
         Console.WriteLine("Variable Value After Calling the Method: {0}", x);

         // Exemplo de método com passagem usando out
         Console.WriteLine("\nVariable Value Before Calling the Method: x={0}", x);
         Console.WriteLine("Variable Value Before Calling the Method: j={0}", j);
         Multiplication(out x, j);
         Console.WriteLine("Variable Value After Calling the Method: x={0}", x);
         Console.WriteLine("Variable Value After Calling the Method: j={0}", j);

         Console.WriteLine();
         ParamsMethod(1, 2, 3, 4, 5, 6);
         Console.WriteLine();
         ParamsMethod(1, 2, "suresh", "rohini", "trishika", 10.26);

         Console.WriteLine("\n\nPress Enter Key to Exit..");
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
      /// Método estático, passagem do parâmetro por valor
      /// </summary>
      /// <param name="a"></param>
      public static void Multiplication(int a)
      {
         a = a * a;
         Console.WriteLine("Variable Value Inside the Method: {0}", a);
      }
      /// <summary>
      /// Procedimento estático e privado, passagem do parâmetro por referência
      /// </summary>
      /// <param name="a">int ref</param>
      private static void Multiplication(ref int a)
      {
         a = a * a;
         Console.WriteLine("Variable Value Inside the Method: {0}", a);
      }

      /// <summary>
      /// Procedimento estático, público, parâmetro a(tipo out, int ), b(tipo int, por valor)
      /// </summary>
      /// <param name="a"> out,int </param>
      /// <param name="b"> int </param>
      public static void Multiplication(out int a, int b)
      {
         a = 10;
         b = 2 * b;
         int c = a * b;
         Console.WriteLine("Variable Value Inside the Method: a={0}", a);
         Console.WriteLine("Variable Value Inside the Method: b={0}", b);
         Console.WriteLine("Variable Value Inside the Method: a*b ={0}", c);
      }

      /// <summary>
      /// In c#, params keyword is useful to specify a method parameter that takes a variable number 
      /// of arguments. The params keyword is useful when we are not sure about the number of arguments to 
      /// send as a parameter. In c#, during method declaration only one params keyword is allowed and 
      /// no additional parameters are permitted after the params keyword in a method declaration. We can 
      /// send arguments of the specified type as a comma-separated list or an array to the declared parameter.
      /// In case, if we are not sending any arguments to the defined parameter, then the length of params list
      /// will become a zero.
      /// </summary>
      /// <param name="arr">params int[]</param>
      public static void ParamsMethod(params int[] arr)
      {
         for (int i = 0; i < arr.Length; i++)
         {
            Console.Write(arr[i] + (i < arr.Length - 1 ? ", " : ""));
         }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="arr">params object[]</param>
      public static void ParamsMethod(params object[] arr)
      {
         for (int i = 0; i < arr.Length; i++)
         {
            Console.Write(arr[i] + (i < arr.Length - 1 ? ", " : ""));
         }

      }

   }// end Class 
}// end namespace
