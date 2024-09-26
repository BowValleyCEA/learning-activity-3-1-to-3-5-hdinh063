namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int opt = 0;
            while (opt <= 5)
            {
                Console.Clear();
                Console.WriteLine("1. Run Activity 3.1");
                Console.WriteLine("2. Run Activity 3.2");
                Console.WriteLine("3. Run Activity 3.3");
                Console.WriteLine("4. Run Activity 3.4");
                Console.WriteLine("5. Run Activity 3.5");
                Console.WriteLine("6. Stop program");
                Console.Write("Enter your option: ");
                opt = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opt)
                {
                    case 1:
                        LA31.Run();
                        break;

                    case 2:
                        LA32.Run();
                        break;

                    case 3:
                        LA33.Run();
                        break;

                    case 4:
                        LA34.Run();
                        break;

                    case 5:
                        LA35.Run();
                        break;

                    default:
                        opt = 6;
                        Console.WriteLine("Thanks for playing game");
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}

