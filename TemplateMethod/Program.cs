using System;

namespace TemplateMethod
{
    public abstract class GameRule
    {
        public void RunGame()
        {
            Start();
            while (!IsHaveWinner)
                TakeTurn();
            Console.WriteLine($"Player {WinningPlayer} wins.");
        }

        protected abstract void Start();
        protected abstract bool IsHaveWinner { get; }
        protected abstract void TakeTurn();
        protected abstract int WinningPlayer { get; }

        protected int currentPlayer;
        protected readonly int numberOfPlayers;

        public GameRule(int numberOfPlayers)
        {
            this.numberOfPlayers = numberOfPlayers;
        }
    }

    // simulate a game of chess
    public class Chess : GameRule
    {
        public Chess() : base(2)
        {
        }

        protected override void Start()
        {
            Console.WriteLine($"Starting a game of chess with {numberOfPlayers} players.");
        }

        protected override bool IsHaveWinner => turn == maxTurns;

        protected override void TakeTurn()
        {
            Console.WriteLine($"Turn {turn++} taken by player {currentPlayer}.");
            currentPlayer = (currentPlayer + 1) % numberOfPlayers;
        }

        protected override int WinningPlayer => currentPlayer;

        private int maxTurns = 10;
        private int turn = 1;
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Chess chess = new Chess();
            chess.RunGame();
            Console.ReadKey();
        }
    }
}
