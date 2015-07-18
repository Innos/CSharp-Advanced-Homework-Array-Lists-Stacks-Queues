namespace _03Game
{
    #region

    using System;
    using System.Collections.Generic;

    #endregion

    public class Engine
    {
        internal const int BoardRows = 5;

        internal const int BoardCols = 10;

        internal const int NumberOfBombs = 15;

        internal static readonly Cell[,] Field = new Cell[BoardRows, BoardCols];

        private static readonly Random Random = new Random();

        private static bool gameStart = true;

        private static readonly List<Placement> HighScores = new List<Placement>(6);

        public void Start()
        {
            Initialize();
            Run();  
        }
        private static void Initialize()
        {
            CreatePlayingField();
            InsertBombs();
        }

        private static void ExecuteGameOver(object sender, OnOpenCellEventArgs args)
        {
            DrawTheBoard(Field);
            Console.Write("\nA heroic death with {0} points. What is your nickname?: ", args.OpenedCells);
            AddHighScore(args.OpenedCells);
            gameStart = true;
            Initialize();
        }

        private static void ExecuteWinGame(object sender, OnOpenCellEventArgs args)
        {
            Console.WriteLine("\nCongratulations! You win.");
            DrawTheBoard(Field);
            Console.WriteLine("What is your nickname?: ");
            AddHighScore(args.OpenedCells);
            gameStart = true;
            Initialize();
        }

        private static void AddHighScore(int openedCells)
        {
            string nickname = Console.ReadLine();
            Placement placement = new Placement(nickname, openedCells);
            if (HighScores.Count < 5)
            {
                HighScores.Add(placement);
            }
            else
            {
                for (int position = 0; position < HighScores.Count; position++)
                {
                    if (HighScores[position].Points < placement.Points)
                    {
                        HighScores.Insert(position, placement);
                        HighScores.RemoveAt(HighScores.Count - 1);
                        break;
                    }
                }
            }

            HighScores.Sort((r1, r2) => string.Compare(r2.PlayerName, r1.PlayerName, StringComparison.InvariantCulture));
            HighScores.Sort((r1, r2) => r2.Points.CompareTo(r1.Points));
            DisplayHighScores(HighScores);
        }
        private static void Run()
        {
            string command;
            do
            {
                if (gameStart)
                {
                    Console.WriteLine(
                        "Let's play “Minesweeper”. Try to find the fields without mines."
                        + "The command 'top' shows high scores, 'restart' starts a new game, 'exit' exits the game!");
                    DrawTheBoard(Field);
                    gameStart = false;
                }

                Console.Write("Specify row and column : ");
                command = Console.ReadLine().Trim();
                int row = 0;
                int col = 0;
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) && int.TryParse(command[2].ToString(), out col)
                        && row <= Field.GetLength(0) && col <= Field.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        DisplayHighScores(HighScores);
                        break;
                    case "restart":
                        Initialize();
                        gameStart = true;
                        break;
                    case "exit":
                        Console.WriteLine("Bye,bye,bye!");
                        break;
                    case "turn":
                        Field[row, col].OpenCell();
                        if (gameStart)
                        {
                            break;
                        }
                        DrawTheBoard(Field);
                        break;
                    default:
                        Console.WriteLine("\nInvalid command!\n");
                        break;
                }
            }
            while (command != "exit");
            Console.WriteLine("Made in Bulgaria!");
        }

        private static void DisplayHighScores(List<Placement> points)
        {
            Console.WriteLine("\nPoints:");
            if (points.Count > 0)
            {
                for (int place = 0; place < points.Count; place++)
                {
                    Console.WriteLine("{0}. {1} --> {2} boxes", place + 1, points[place].PlayerName, points[place].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("No High Scores currently!\n");
            }
        }

        private static void DrawTheBoard(Cell[,] board)
        {
            int rows = board.GetLength(0);
            int cols = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < rows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < cols; j++)
                {
                    Console.Write("{0} ", board[i, j]);
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static void CreatePlayingField()
        {
            for (int row = 0; row < Field.GetLength(0); row++)
            {
                for (int col = 0; col < Field.GetLength(1); col++)
                {
                    Field[row, col] = new Cell(row, col);
                    Field[row, col].OpenBomb += ExecuteGameOver;
                    Field[row, col].OpenNonBomb += ExecuteWinGame;
                }
            }
            for (int row = 0; row < Field.GetLength(0); row++)
            {
                for (int col = 0; col < Field.GetLength(1); col++)
                {
                    Field[row, col].Initialize();
                }
            }
        }

        private static void InsertBombs()
        {
            List<int> bombs = new List<int>();
            while (bombs.Count < NumberOfBombs)
            {
                int randomBomb = Random.Next((int)Field.LongLength);
                if (!bombs.Contains(randomBomb))
                {
                    bombs.Add(randomBomb);
                }
            }

            foreach (int bomb in bombs)
            {
                int row = bomb / BoardCols;
                int col = bomb % BoardCols;
                Field[row, col].IsBomb = true;
            }
        }
    }
}
