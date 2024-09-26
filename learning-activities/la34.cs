namespace MyApplication
{
    public class LA34
    {
        public static void Run()
        {
            int age;
            bool validInput = false;

            while (!validInput)
            {
                Console.Clear();
                Console.Write("Please enter your age (between 10 and 50): ");
                string input = Console.ReadLine();

                validInput = int.TryParse(input, out age);

                if (validInput)
                {
                    validInput = age >= 10 && age <= 50;
                    if (validInput)
                    {
                        Console.WriteLine($"Thank you! Your age is: {age}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Age must be between 10 and 50. Please try again.");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Error: Please enter a valid number.");
                    Console.ReadLine();
                }
            }
        }
    }
}