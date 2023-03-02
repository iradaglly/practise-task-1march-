namespace _1march_practise_task_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter number between 10 and 20:");

            string num = Console.ReadLine();
            int numbers = Convert.ToInt32(num);
            if (numbers > 10 && numbers < 20)
            {
                Console.WriteLine(numbers);

            }
            else
            {

                do
                {
                    Console.WriteLine("ERROR!Do you want to continue?");
                    Console.ReadLine();
                    string yes = Console.ReadLine();
                    Console.Write("enter new number:");
                    Console.ReadLine();
                    string num2 = Console.ReadLine();
                    int numbers = Convert.ToInt32(num2);
                    if (numbers % 2 == 0)
                    {
                        Console.Write("the number is even");

                    }
                    else if (numbers % 2 == 1)
                    {
                        Console.Write("the number is odd");
                    }




                } while (!(numbers > 10 && numbers < 20));
            }
        }
    }
}