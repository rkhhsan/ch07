// Fig. 7.6: RandomIntegers.cs
// Shifted and scaled random integers.
using System;

public class RandomIntegers
{
   public static void Main(string[] args)
   {
      Random randomNumbers = new Random(); // random number generator
      int face; // stores each random integer generated
      int qt = 100;

      // loop 20 times
      Console.WriteLine("{0} random integers from 1 to 6:",qt);
      for (int counter = 1; counter <= 100; counter++)
      {
         // pick random integer from 1 to 6
         face = randomNumbers.Next(1, 7);

         Console.Write("{0}  ", face); // display generated value

         // if counter is divisible by 5, start a new line of output
         if (counter % 10 == 0)  Console.WriteLine();
      } // end for

      Random rnd = new Random();

      Console.WriteLine("\n{0} random integers from -100 to 100:", qt);
      for (int ctr = 1; ctr <= qt; ctr++)
      {
         Console.Write("{0,4}", rnd.Next(-100, 101));
         if (ctr % 10 == 0) Console.WriteLine();
      }

      Console.WriteLine("\n{0} random integers from 1000 to 10000:", qt);
      for (int ctr = 1; ctr <= qt; ctr++)
      {
         Console.Write("{0,6}", rnd.Next(1000, 10001));
         if (ctr % 10 == 0) Console.WriteLine();
      }

      Console.WriteLine("\n{0} random integers from 1 to 10:", qt);
      for (int ctr = 1; ctr <= qt; ctr++)
      {
         Console.Write("{0,3}", rnd.Next(1, 11));
         if (ctr % 10 == 0) Console.WriteLine();
      }

      // The example displays output similar to the following:
      //       20 random integers from -100 to 100:
      //           65   -95   -10    90   -35
      //          -83   -16   -15   -19    41
      //          -67   -93    40    12    62
      //          -80   -95    67   -81   -21
      //       
      //       20 random integers from 1000 to 10000:
      //           4857    9897    4405    6606    1277
      //           9238    9113    5151    8710    1187
      //           2728    9746    1719    3837    3736
      //           8191    6819    4923    2416    3028
      //       
      //       20 random integers from 1 to 10:
      //            9     8     5     9     9
      //            9     1     2     3     8
      //            1     4     8    10     5
      //            9     7     9    10     5

      Console.WriteLine("\nTecle qualquer tecla para finalizar...");
      Console.ReadKey();
   } // end Main
} // end class RandomIntegers


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
