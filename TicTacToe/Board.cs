namespace TicTacToe
{
    public class Board
    {

        string[] grid;
        public Board()
        {
        }
    

        // creates a new board to play on
        public void GenerateBoard()
        {
            grid = new string[] {"1", "|", "2", "|", "3", "\n", "-", "+", "-", "+", "-", "\n",
                "4", "|", "5", "|", "6", "\n",  "-", "+", "-", "+", "-", "\n", 
                "7", "|", "8", "|", "9", "\n"};
        }

        // displays the board on the console
        public void PrintBoard()
        {
            Console.WriteLine();

            foreach (string item in grid)
            {
                Console.Write(item);
            }

            Console.WriteLine();
        }

        
        // places the mark in a valid position
        public void PlaceMark(string mark)
        {
            
            string[] validPlacements = new string[] {"1", "2", "3", "4", "5", "6", "7", "8", "9"};

            while(true)
            {
                Console.WriteLine($"Choose a spot to place {mark}: ");
                string placement = Console.ReadLine();

                int index = Array.FindIndex(grid, 0, grid.Count(), p => p == placement);

                if (index != -1 && (validPlacements.Contains(placement)))
                {
                    grid[index] = mark;
                    return;
                }
                else{
                    Console.WriteLine("Invalid spot. Try again");
                }
            }
        }


        // checks to see if any win conditions have been met
        public bool CheckVictory(string mark)
        {
            if ((grid[0] == grid[2] && grid[2] == grid[4]) || 
                (grid[12] == grid[14] && grid[14] == grid[16]) ||
                (grid[24] == grid[26] && grid[26] == grid[28]) ||
                (grid[0] == grid[12] && grid[12] == grid[24]) ||
                (grid[2] == grid[14] && grid[14] == grid[26]) ||
                (grid[4] == grid[16] && grid[16] == grid[28]) ||
                (grid[0] == grid[14] && grid[14] == grid[28]) ||
                (grid[4] == grid[14] && grid[14] == grid[24])
                )
            {
                Console.WriteLine($"Conglaturations, {mark} is winner!");
                return true;
            }

            return false;
        }

        // checks for a stalemate
        public bool CheckStalemate()
        {
            if ((grid[0] != "1") && (grid[2] != "2") && (grid[4] != "3") &&
                (grid[12] != "4") && (grid[14] != "5") && (grid[16] != "6") &&
                (grid[24] != "7") && (grid[26] != "8") && (grid[28] != "9")
                )
            {
                Console.WriteLine("Alright then, we'll call it a draw!");
                return true;
            }

            return false;
        }
    }
}