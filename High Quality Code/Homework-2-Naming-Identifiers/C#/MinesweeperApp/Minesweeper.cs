using System;
using System.Collections.Generic;

namespace MinesweeperApp
{
    public class Minesweeper
    {
        public class Player
        {
            private string name;
            private int points;

            public Player()
            {
            }

            public Player(string name, int points)
            {
                this.Name = name;
                this.Points = points;
            }

            public string Name { get; set; }
            public int Points { get; set; }
        }

        private static void Main(string[] args)
        {
            string command = string.Empty;
            char[,] field = InstantiateGameField();
            char[,] bombPositionsInField = PlaceBombs();
            int counter = 0;
            bool isExploded = false;
            List<Player> players = new List<Player>(6);
            int row = 0;
            int column = 0;
            bool isReadyToStart = true;
            const int MaxPoints = 35;
            bool isWinner = false;

            do
            {
                if (isReadyToStart)
                {
                    Console.WriteLine(
                        "Let`s play 'Minesweepers'. Test your luck as you find all fields that are not mined."
                        + " 'top' command shows ranking, 'restart' - restarts the game, 'exit' - exits the game");
                    ReDrawGameBoard(field);
                    isReadyToStart = false;
                }

                Console.Write("Please enter row and column (row col) : ");
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) && int.TryParse(command[2].ToString(), out column)
                        && row < field.GetLength(0) && column < field.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        GenerateRankings(players);
                        break;
                    case "restart":
                        field = InstantiateGameField();
                        bombPositionsInField = PlaceBombs();
                        ReDrawGameBoard(field);
                        isExploded = false;
                        isReadyToStart = false;
                        break;
                    case "exit":
                        Console.WriteLine("Bye bye!");
                        break;
                    case "turn":
                        if (bombPositionsInField[row, column] != '*')
                        {
                            if (bombPositionsInField[row, column] == '-')
                            {
                                GetSurroundingBombsCount(field, bombPositionsInField, row, column);
                                counter++;
                            }

                            if (MaxPoints == counter)
                            {
                                isWinner = true;
                            }
                            else
                            {
                                ReDrawGameBoard(field);
                            }
                        }
                        else
                        {
                            isExploded = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nError! Invalid position\n");
                        break;
                }

                if (isExploded)
                {
                    ReDrawGameBoard(bombPositionsInField);
                    Console.Write("\nHrrrrrr! You died with {0} points. " + "Please provide a nickname: ", counter);
                    string niknejm = Console.ReadLine();
                    Player t = new Player(niknejm, counter);
                    if (players.Count < 5)
                    {
                        players.Add(t);
                    }
                    else
                    {
                        for (int i = 0; i < players.Count; i++)
                        {
                            if (players[i].Points < t.Points)
                            {
                                players.Insert(i, t);
                                players.RemoveAt(players.Count - 1);
                                break;
                            }
                        }
                    }

                    players.Sort((Player r1, Player r2) => r2.Name.CompareTo(r1.Name));
                    players.Sort((Player r1, Player r2) => r2.Points.CompareTo(r1.Points));
                    GenerateRankings(players);

                    field = InstantiateGameField();
                    bombPositionsInField = PlaceBombs();
                    counter = 0;
                    isExploded = false;
                    isReadyToStart = true;
                }

                if (isWinner)
                {
                    Console.WriteLine("\nGot job. You opened all cells!");
                    ReDrawGameBoard(bombPositionsInField);
                    Console.WriteLine("Please provide nickname: ");
                    string name = Console.ReadLine();
                    Player player = new Player(name, counter);
                    players.Add(player);
                    GenerateRankings(players);
                    field = InstantiateGameField();
                    bombPositionsInField = PlaceBombs();
                    counter = 0;
                    isWinner = false;
                    isReadyToStart = true;
                }
            }
            while (command != "exit");
            Console.WriteLine("Made in Bulgaria");
            Console.WriteLine("Goodbye.");
            Console.Read();
        }

        private static void GenerateRankings(List<Player> players)
        {
            Console.WriteLine("\nPoints:");

            if (players.Count > 0)
            {
                for (int i = 0; i < players.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} boxes", i + 1, players[i].Name, players[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty rankings!\n");
            }
        }

        private static void GetSurroundingBombsCount(char[,] field, char[,] bombsField, int row, int column)
        {
            char bombCount = GetMinesCountAroundCell(bombsField, row, column);
            bombsField[row, column] = bombCount;
            field[row, column] = bombCount;
        }

        private static void ReDrawGameBoard(char[,] board)
        {
            int rowCount = board.GetLength(0);
            int columnCount = board.GetLength(1);

            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");

            for (int i = 0; i < rowCount; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < columnCount; j++)
                {
                    Console.Write("{0} ", board[i, j]);
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] InstantiateGameField()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];

            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] PlaceBombs()
        {
            int rows = 5;
            int columns = 10;
            char[,] field = new char[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    field[i, j] = '-';
                }
            }

            List<int> randomPositionList = new List<int>();

            while (randomPositionList.Count < 15)
            {
                Random random = new Random();
                int randomNumber = random.Next(50);
                if (!randomPositionList.Contains(randomNumber))
                {
                    randomPositionList.Add(randomNumber);
                }
            }

            foreach (int position in randomPositionList)
            {
                int row = position % columns;
                int column = position / columns;

                if (row == 0 && position != 0)
                {
                    column--;
                    row = columns;
                }
                else
                {
                    row++;
                }

                field[column, row - 1] = '*';
            }

            return field;
        }

        private static void AddMineCountToField(char[,] field)
        {
            int column = field.GetLength(0);
            int row = field.GetLength(1);

            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (field[i, j] != '*')
                    {
                        char mineCount = GetMinesCountAroundCell(field, i, j);
                        field[i, j] = mineCount;
                    }
                }
            }
        }

        private static char GetMinesCountAroundCell(char[,] field, int row, int col)
        {
            int count = 0;
            int rowsCount = field.GetLength(0);
            int colsCount = field.GetLength(1);

            if (row - 1 >= 0)
            {
                if (field[row - 1, col] == '*')
                {
                    count++;
                }
            }

            if (row + 1 < rowsCount)
            {
                if (field[row + 1, col] == '*')
                {
                    count++;
                }
            }

            if (col - 1 >= 0)
            {
                if (field[row, col - 1] == '*')
                {
                    count++;
                }
            }

            if (col + 1 < colsCount)
            {
                if (field[row, col + 1] == '*')
                {
                    count++;
                }
            }

            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (field[row - 1, col - 1] == '*')
                {
                    count++;
                }
            }

            if ((row - 1 >= 0) && (col + 1 < colsCount))
            {
                if (field[row - 1, col + 1] == '*')
                {
                    count++;
                }
            }

            if ((row + 1 < rowsCount) && (col - 1 >= 0))
            {
                if (field[row + 1, col - 1] == '*')
                {
                    count++;
                }
            }

            if ((row + 1 < rowsCount) && (col + 1 < colsCount))
            {
                if (field[row + 1, col + 1] == '*')
                {
                    count++;
                }
            }

            return char.Parse(count.ToString());
        }
    }
}