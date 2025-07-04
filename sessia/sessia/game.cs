using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sessia
{
    internal class Game
    {
        int pwin = 0;
        int aiwin = 0;
        int draw = 0;


        private static Game game;
        private Game() { }

        public static Game GetInstance()
        {
            if (game == null)
                game = new Game();
            return game;
        }

        public List<string> grid = new List<string>()
        {
            " ", " ", " ", " ", " ", " ", " ", " ", " "
        };

        public List<string> truegrid = new List<string>()
        {
            " ", " ", " ", " ", " ", " ", " ", " ", " "
        };

        public bool PlayerStep(int step)
        {
            if (grid[step] == " " || grid[step] == "x" || grid[step] == "0")
            {
                grid[step] = "x";
                return true;
            }
            return false;
        }

        public int AIStep()
        {
            List<int> emptyCells = new List<int>();
            for (int i = 0; i < grid.Count; i++)
            {
                if (grid[i] == " ")
                    emptyCells.Add(i);
            }

            if (emptyCells.Count == 0)
                return -1; // Нет доступных ходов

            Random rand = new Random();
            int index = rand.Next(emptyCells.Count);
            int step = emptyCells[index];
            grid[step] = "0";
            return step;
        }

        public string CheckEnd()
        {
            // Проверка победы
            int[][] winningCombinations = new int[][]
            {
                new int[] {0,1,2}, new int[] {3,4,5}, new int[] {6,7,8}, // Горизонталь
                new int[] {0,3,6}, new int[] {1,4,7}, new int[] {2,5,8}, // Вертикаль
                new int[] {0,4,8}, new int[] {2,4,6} // Диагонали
            };

            foreach (var combo in winningCombinations)
            {
                if (grid[combo[0]] == "x" && grid[combo[1]] == "x" && grid[combo[2]] == "x")
                {
                    pwin++;
                    ResetGrid();
                    return "Победа игрока";
                }
                if (grid[combo[0]] == "0" && grid[combo[1]] == "0" && grid[combo[2]] == "0")
                {
                    aiwin++;
                    ResetGrid();
                    return "Победа компьютера";
                }
            }

            // Проверка ничьей
            if (!grid.Contains(" "))
            {
                draw++;
                ResetGrid();
                return "Ничья";
            }

            return string.Empty; // Игра продолжается
        }

        private void ResetGrid()
        {
            for (int i = 0; i < grid.Count; i++)
            {
                grid[i] = " ";
            }
        }
    }
}