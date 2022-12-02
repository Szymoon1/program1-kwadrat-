namespace program1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj szerokość boku x: ");
            string xs = Console.ReadLine();

            Console.Write("Podaj długość boku y: ");
            string ys = Console.ReadLine();

            int x = int.Parse(xs);
            int y = int.Parse(ys);


            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}