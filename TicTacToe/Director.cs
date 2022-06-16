namespace TicTacToe
{
    public class Director
    {

        bool isPlaying = true;

        public void PlayGame()
        {
            Board board = new Board();
            

            while (isPlaying)
            {
                board.GenerateBoard();
                
                while (true)
                {
                    board.PrintBoard();
                    board.PlaceMark("X");
                    if (board.CheckVictory("X"))
                    {
                        break;
                    }
                    board.PrintBoard();
                    board.PlaceMark("O");
                    if (board.CheckVictory("O"))
                    {
                        break;
                    }
                }

                Console.WriteLine("Play Again? [y/n]");
                if (Console.ReadLine() != "y")
                {
                    isPlaying = false;
                }
            }
            Console.WriteLine("That's all folks!");
        }

    }
}