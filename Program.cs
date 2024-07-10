using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC205HW2_Part3
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Initialize a double variable 'count' to 0.0
            double count = 0.0;
            // Define a small tolerance level
            double tolerance = 0.000001;

            /*
            // Loop continues until 'count' equals 1.0
            while (count != 1.0)
            {
                // Increment 'count' by 0.1 in each iteration
                count = count + 0.1;


                // Print the current value of 'count' with "R" format specifier
                Console.Write("{0:R}", count);

                // Wait for user to press Enter before proceeding to the next iteration
                Console.ReadLine();
            }
            */

            // Note: You will have to press the Enter or Return key for each iteration of the loop.
            // You will have to use Ctrl-C or close the window to stop the program.

            // 1. Why does it not stop when count reaches 1.0?
            /* The loop does not stop when count reaches 1.0 because
             * of inherent precision issues in floating-point arithmetic.
             * Numbers like 0.1 cannot be represented exactly in binary
             * floating-point format, leading to small approximation errors
             * each time 0.1 is added to count. These accumulated errors
             * prevent count from ever being exactly equal to 1.0,
             * so the loop continues iterating indefinitely. */

            // 2. How can you alter it to do so?
            /* To ensure that the loop stops when count reaches exactly 1.0,
             * despite the precision issues in floating-point arithmetic,
             * you can modify the loop condition to check if count is
             * very close to 1.0 within a certain tolerance */

            // Loop continues until count is within tolerance of 1.0
            while (Math.Abs(count - 1.0) > tolerance)
            {
                count = count + 0.1;
                Console.WriteLine("{0:R}", count);
                Console.ReadLine();
            }

            // After loop, count should be approximately 1.0
            Console.WriteLine("Count has reached 1.0.");
        }
    }
}
