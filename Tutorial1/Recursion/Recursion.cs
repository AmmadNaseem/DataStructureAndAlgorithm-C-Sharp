using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial1.Recursion
{
    public class Recursion
    {
        public int RecurstiveFactorial(int num)
        {
            if (num == 0)
            {
                return 1;
            }
            return num * RecurstiveFactorial(num - 1);
        }


        public int IterativeFactorialOfNum(int num)
        {
            if (num == 0)
            {
                return 1;
            }
            int factorial = 1;
            for (int i = 0; i <= num; i++)
            {
                factorial = factorial * i;
            }

            return factorial;
            //1 x 1
            //1 x 2
            //1 x 2 x 3
            //1 x 2 x 3 x 4
        }
                
        public void MinusByOne(int n)
        {
            //Base case if going to prevent a stack overflow.
            if (n != 0)
            {
                // it will poping on the stack but not actually executing.
                MinusByOne(n - 1);
            }
            //All these function are going to execute,store state, thenthey are going minus.
            Console.WriteLine("Call : " + n);
        }


        public bool partfunation()
        {
            var val = Guid.NewGuid;//random number generation
            return true;
        }

    }
}
