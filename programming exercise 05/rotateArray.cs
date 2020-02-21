using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programming_exercise_05
{
    class rotateArray
    {
        public int[] userinput { get; set; }
        public string direction { get; set; }
        public int NumberOfMoves { get; set; }
    
        public rotateArray(int [] A)
        {
            userinput = A;
        }
        public void choosingDirectionAndNumber()
        {
            Console.WriteLine("Which Direction would you liek to move your array? type LEFT or RIGHT and press enter");
            direction = Console.ReadLine();
            Console.WriteLine("Enter the NUMBER of times you wish to shift your array in the direction previously chosen and press enter ");
            NumberOfMoves = int.Parse(Console.ReadLine());
            if (direction == "right")
            {
                rotaterRight();
            }
            else if (direction == "left")
            {
                rotaterLeft();
            }
            else
                choosingDirectionAndNumber();

        }

        public void rotaterRight()
        {
            int J = userinput.Length - 1;
            int I = userinput.Length - 2;
            int T = userinput[J];
            while (NumberOfMoves > 0)
            {
                while (J > 0)
                {
                    userinput[J] = userinput[I];
                    J--;
                    I--;
                }
                userinput[0] = T;
                NumberOfMoves--;
            }
            
            for(int i = 0; i < userinput.Length; i++)
            {
                Console.WriteLine($"item at array index {i} is {userinput[i]}");
            }
            Console.WriteLine("press enter to return");
            Console.ReadLine();

        }

        public void rotaterLeft()
        {
            int J = userinput.Length - 1;
            int I = 0;
            int temp = userinput[0];
            while(NumberOfMoves>0)
            {
                while(J > 0)
                {
                    userinput[I] = userinput[++I];
                    J--;
                }
                userinput[userinput.Length - 1] = temp;
                NumberOfMoves--;
            }

            for (int i = 0; i < userinput.Length; i++)
            {
                Console.WriteLine($"item at array index {i} is {userinput[i]}");
            }
            Console.WriteLine("press enter to return");
            Console.ReadLine();

        }




    }
}
