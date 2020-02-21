using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programming_exercise_05
{
    class sortingAnArray
    {
        public int[] userinput { get; set; }

        public sortingAnArray(int[] A)
        {
            userinput = A;
        }

        public void sortAction()
        
        {
            for(int i = 0; i<userinput.Length-1;i++)
            {
                for(int J = i+1;J<userinput.Length;J++)
                {
                    int temp = userinput[i];
                    if (userinput[J] < userinput[i])
                    {
                        userinput[i] = userinput[J];
                        userinput[J] = temp;
                       
                    }
                    
                }
            }

            for (int i = 0; i < userinput.Length ; i++)
            {
                Console.WriteLine($"item at array index {i} is {userinput[i]}");
            }
            Console.WriteLine("press enter to return");
            Console.ReadLine();

        }


    }
}
