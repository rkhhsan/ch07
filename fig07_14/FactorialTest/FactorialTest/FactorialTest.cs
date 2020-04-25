// Fig. 7.14: FactorialTest.cs
// Recursive Factorial method.
using System;
using Meta.Numerics;
using Meta.Numerics.Functions;

public class FactorialTest
{
   public static void Main(string[] args)
   {
      // calculate the factorials of 0 through 10
      for (long counter = 0; counter <= 10; ++counter)
         Console.WriteLine("{0}! = {1}", counter, Factorial(counter));
     
      // Compute the value x at which erf(x) is just 10^{-15} from 1.
      double x = AdvancedMath.InverseErfc(1.0E-15);
      Console.WriteLine("\n{0}",x);

      // The Gamma function at 1/2 is sqrt(pi)
      double y = AdvancedMath.Gamma(0.5);
      Console.WriteLine("\nThe Gamma function at 1/2 is sqrt(pi) = {0}", y);

      // Compute a Coulomb Wave Function in the quantum tunneling region
      SolutionPair s = AdvancedMath.Coulomb(2, 4.5, 3.0);
      Console.WriteLine("\nCompute a Coulomb Wave Function in the quantum tunneling region = {0}", s);

      // Compute the Reimann Zeta function at a complex value
      Complex z = AdvancedComplexMath.RiemannZeta(new Complex(0.75, 6.0));
      Console.WriteLine("\nCompute the Reimann Zeta function at a complex value = {0}", z);

      // Compute the 100th central binomial coefficient
      double c = AdvancedIntegerMath.BinomialCoefficient(5, 2);
      Console.WriteLine("\n{0}", c);

      Console.WriteLine("\nTecle qualquer tecla para finalizar...");
      Console.ReadKey();

   } // end Main

   // recursive declaration of method Factorial  
   public static long Factorial(long number)
   {
      // base case                               
      if (number <= 1)
         return 1;
      // recursion step                          
      else
         return number * Factorial(number - 1);
   } // end method Factorial                     
} // end class FactorialTest


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
