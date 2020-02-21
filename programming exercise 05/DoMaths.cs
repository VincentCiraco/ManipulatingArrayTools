using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programming_exercise_05
{
    class DoMaths
    {

            public int count { get; set; }
            public int average { get; set; }
            public int[] userinput { get; set; }
            public int sum { get; set; }
            public DoMaths(int[] a)
            {
                userinput = a;
                count = userinput.Length;
            }


            public void sumOfInput()
            {

                for (int i = 0; i < userinput.Length; i++)
                {
                    sum += userinput[i];
                }
                Console.WriteLine($"sum of your array is {sum}");

            }

            public void getAverage()
            {
                Console.WriteLine($" count is {count}");
                average = sum/count;
                Console.WriteLine($"the mean of your numbers is {average}");
            }
        
    }
}
