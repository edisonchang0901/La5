namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player binarySearchAI = new BinarySearchAI();
            Game game_1 = new Game(binarySearchAI);
            game_1.run();
            bool gameResult_1 = game_1.hasWon();

            Player superAI = new SuperAI();
            Game game_2 = new Game(superAI);
            game_2.run();
            bool gameResult_2 = game_2.hasWon();

            Player humanPlayer = new HumanPlayer();
            Game game3 = new Game(humanPlayer);
            game3.run();
            bool gameResult_3 = game3.hasWon();

        }

    }
    
}