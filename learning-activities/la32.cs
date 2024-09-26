namespace MyApplication
{
    public class LA32
    {
        public static void Run()
        {
            string[] classMateNames = new string[]
            {
                "Cat", "Keegan", "Lukas", "Lucas", "Mason", "Shea", "Emre",
                "Canyon", "Bruno", "Quan", "Camilo", "Maahin", "Jose", "Anna"
            };

            int[] classMateAges = new int[]
            {
                15, 16, 15, 17, 16, 15, 16,
                17, 15, 16, 17, 15, 16, 17
            };

            Console.WriteLine("Classmates and their ages:");
            for (int i = 0; i < classMateNames.Length; i++)
            {
                Console.WriteLine($"{classMateNames[i]} is {classMateAges[i]} years old.");
            }

            string[] greatWonders = new string[]
            {
                "Great Wall of China",
                "Petra",
                "Christ the Redeemer",
                "Machu Picchu",
                "Chichen Itza",
                "Roman Colosseum",
                "Taj Mahal"
            };

            for (int i = 0; i < greatWonders.Length; i++)
            {
                Console.WriteLine(greatWonders[i]);

            }
        }
    }
}