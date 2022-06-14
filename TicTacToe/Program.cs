// dotnet new console --framework net6.0
internal class Program
{
    private static void Main(string[] args)
    {
        string[,] grid = new string[,] {{"1", "|", "2", "|", "3", "\n"}, {"-", "+", "-", "+", "-", "\n"},
            {"4", "|", "5", "|", "6", "\n"},  {"-", "+", "-", "+", "-", "\n"}, {"7", "|", "8", "|", "9", "\n"}};

        bool win = false;

        do
        {
            foreach (string item in grid)
            {
                Console.Write(item);
            }

            string placement = Console.ReadLine();
            int index = grid.FindIndex(grid, placement);

        } while (win == false);
    }
}