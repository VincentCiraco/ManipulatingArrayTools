using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programming_exercise_05
{
    class reverseArray
    {
        public int[] userinput { get; set; }


        public reverseArray(int[] A)
        {
            userinput = A;

        }
         
        public void reverseAction()
        {
            int[] reversedArray = new int[userinput.Length];

            int i = 0;
            int j = 0; 
            for(i = 0,j = userinput.Length - 1; i < userinput.Length ; i++)
            {
                reversedArray[i] += userinput[j--];
                Console.WriteLine($"item at array {i} is {reversedArray[i]}");
            }
            Console.ReadLine();
            /*for( i = 0; i < reversedArray.Length - 1; i++)
            {
                Console.WriteLine(reversedArray[i]);
            }*/

        }

    }
}
