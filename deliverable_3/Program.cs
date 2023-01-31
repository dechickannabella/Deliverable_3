/* Author: AnnaBella DeChick 
 Date: 1/30/2023
 Description: C# Console Program Application with Iterative Statements
*/

namespace deliverable_3
{
    class program
    {
        static void Main(string[] args)
        {
            int input = 0;
            string series = "";

            try
            {

                while (true)
                {
                    Console.WriteLine("Enter an integer number between 1 and 100: ");
                    input = int.Parse(Console.ReadLine());

                    if (input >= 1 && input <= 100)
                    {
                        break;
                    }
                  }
                }

            catch (Exception ex)
            {
                Console.WriteLine("Not a valid integer.");
            }

            while (true)
            {
                try
                {
                    Console.Write("Specify the series type: Even or Odd: ");
                    series = Console.ReadLine();

                    if (series == "Even" || series == "Odd")
                    {
                        break;
                    }
                }

                catch (Exception ex)
                {
                    Console.WriteLine("Not a valid entry.");
                }
            }


            if (series == "Odd")
            {
                Console.WriteLine("You have selected " + series + "series. The numbers between 0 and " + input + "are: ");
                for (int i = 1; i <= input; i = i + 2)
                {
                    Console.WriteLine(i);
                }
            }

            if (series == "Even")
            {
                Console.WriteLine("You have selected " + series + "series. The numbers between 0 and " + input + "are: ");
                for (int i = 0; i <= input; i = i + 2)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

