namespace MyApplication
{
    public class LA31
    {
        public static void Run()
        {
            bool done = false;
            while (!done)
            {
                Console.Clear();
                Console.Write("Enter temperature: ");
                double temperature = double.Parse(Console.ReadLine());

                Console.Write("Is this temperature in Celsius or Fahrenheit? (C/F): ");
                char unit = Console.ReadKey().KeyChar;
                Console.WriteLine();

                if (unit == 'C' || unit == 'c')
                {
                    double fahrenheit = ConvertTemperature(temperature, "CtoF");
                    Console.WriteLine($"{temperature} °C is {fahrenheit} °F");
                    done = true;
                }
                else if (unit == 'F' || unit == 'f')
                {
                    double celsius = ConvertTemperature(temperature, "FtoC");
                    Console.WriteLine($"{temperature} °F is {celsius} °C");
                    done = true;
                }
                else
                {
                    Console.WriteLine("Invalid unit. Please enter 'C' for Celsius or 'F' for Fahrenheit.");
                    Console.ReadKey();
                }
            }
        }

        private static double ConvertTemperature(double temperature, string conversionType)
        {
            if (conversionType == "CtoF")
            {
                return (temperature * 9 / 5) + 32;
            }
            else if (conversionType == "FtoC")
            {
                return (temperature - 32) * 5 / 9;
            }
            else
            {
                throw new Exception("Error");
            }
        }

    }
}