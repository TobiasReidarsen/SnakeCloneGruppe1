namespace SnakeCloneGruppe1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake.\nA totally original game by team1!");
            while(true)
            { 
                DrawBoard.DrawBoardFunc();
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}