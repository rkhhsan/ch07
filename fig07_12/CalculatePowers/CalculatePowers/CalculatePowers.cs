// Fig. 7.12: Power.vb
// Optional argument demonstration with method Power.
using System;
//using MathNet.Numerics;
//using MathNet.Numerics.LinearAlgebra;

class CalculatePowers
{
   // call Power with and without optional arguments
   public static void Main(string[] args)
   {
      double a = 3.347;
      Console.WriteLine("Power(10) = {0}", Power(10));
      Console.WriteLine("Power(" + Convert.ToString(a) + " ; 10) = {0}", Power(a, 10));

      // Evaluate a special function
      /*Console.WriteLine(SpecialFunctions.Erf(0.5));

      // Solve a random linear equation system with 500 unknowns
      var A = Matrix<double>.Build.Random(60, 60);
      var b = Vector<double>.Build.Random(60);
      var x = A.Solve(b);
      Console.WriteLine(A);
      Console.WriteLine(b);
      Console.WriteLine(x);*/
      
      Console.WriteLine("\nTecle qualquer tecla para finalizar...");
      Console.ReadKey();
   } // end Main

   // use iteration to calculate power
   public static double Power(double baseValue, int exponentValue = 2)
   {
      double result = 1; // initialize total 

      for (int i = 1; i <= exponentValue; i++)
         result *= baseValue;

      return result;
   } // end method Power
} // end class CalculatePowers


/**************************************************************************
 * (C) Copyright 1992-2014 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 *************************************************************************/
