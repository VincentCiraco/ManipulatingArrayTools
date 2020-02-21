using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programming_exercise_05
{
    class Program
    {

        static void Main(string[] args)
        {

            creatingString();


        }

        public static void creatingString()
        {

            Console.WriteLine("How long do you want your array to be");
            int limit = int.Parse(Console.ReadLine());
            int[] userinput = new int[limit];
            Console.WriteLine("enter each individual character for your string and press enter");

            for (int i = 0; i < limit; i++)
            {
                userinput[i] = int.Parse(Console.ReadLine());
            }
            userMenu(userinput);
        }
        public static void userMenu(int[] userinput)
        {
            Console.WriteLine("choose what to do with your array");
            Console.WriteLine("1.Find sum and mean of array");
            Console.WriteLine("2. Reverse your array");
            Console.WriteLine("3.Rotate array");
            Console.WriteLine("4.sort your array");
            Console.WriteLine("5. enter a new string");
            Console.WriteLine("6. exit application");
            string userchoice = Console.ReadLine();
            if (userchoice == "1")
            {
                callFunction1(userinput);
            }
            else if (userchoice == "2")
            {
                callFunction2(userinput);
            }
            else if (userchoice == "3")
            {
                callFunction3(userinput);
            }
            else if (userchoice == "4")
            {
                callFunction4(userinput);
            }
            else if (userchoice == "5")
            {
                creatingString();
            }
            else if (userchoice == "6")
            {
                return;
            }
            else
                userMenu(userinput);

        }
        public static void callFunction1(int[] userinput)
        {
            DoMaths A = new DoMaths(userinput);
            A.sumOfInput();
            A.getAverage();
            Console.ReadLine();
            userMenu(userinput);
        }
        public static void callFunction2(int[] userinput)
        {
            reverseArray B = new reverseArray(userinput);
            B.reverseAction();
            userMenu(userinput);
        }
        public static void callFunction3(int[] userinput)
        {
            rotateArray C = new rotateArray(userinput);
            C.choosingDirectionAndNumber();
            userMenu(userinput);
        }
        public static void callFunction4(int[] userinput)
        {
            sortingAnArray D = new sortingAnArray(userinput);
            D.sortAction();
            userMenu(userinput);
        }

    }
}
