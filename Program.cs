using static System.Console;
namespace SnakeCloneGruppe1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Welcome to Snake.\nA totally original game by team1!");
            DrawBoard.DrawBoard_();
            Console.ReadKey();
        }
    }
}