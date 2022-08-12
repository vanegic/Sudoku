using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    internal class sudoku
    {
        public int[,] sud;

        public void Create()
        {
            this.sud = new int[9, 9];
            Random r = new Random();
            int b = 0;
            int[] c = new int[9];
            for (int i = 0; i < 9; i++) { c[i] = i + 1; }
            for (int l = 0; l < 9; l++)
            {

                for (int g = 0; g < 9; g++)
                {
                    
                    if (b < 9 ) 
                    { 
                        this.sud[l, g] = c[b]; 
                    } else
                    {
                        b = 0;
                        this.sud[l, g] = c[b];
                    }
                    b++;

                }
                b = b + 3 ;
                if (l == 2) { b++; }
                if (l == 5) { b++; }
                if ( b > 9 ) { b = b - 9; }
            }
            

        }
        public void Randomizer()
        {
            for (int i = 0; i < 100; i++)
            {
                this.SwapColumns();
                this.SwapLines();
            } 
        }
        private void SwapLines()
        {
            Random r = new Random();
            int a = r.Next(0, 3);
            int b = r.Next(0, 3);
            if (a == b) { return; }
            int c = r.Next(0, 3);
            a = a + c * 3;
            b = b + c * 3;
            for (int i = 0; i < 9; i++)
            {
                c = sud[a, i];
                sud[a, i] = sud[b, i];
                sud[b, i] = c;
            }
        }
        private void SwapColumns()
        {
            Random r = new Random();
            int a = r.Next(0, 3);
            int b = r.Next(0, 3);
            if (a == b) { return; }
            int c = r.Next(0, 3);
            a = a + c * 3;
            b = b + c * 3;
            for (int i = 0; i < 9; i++)
            {
                c = sud[i, a];
                sud[i, a] = sud[i, b];
                sud[i, b] = c;
            }

        }
        private void SwapThreeLines()
        {

        }
        private void SwapThreeColumns()
        {

        }
        private void ChangeColor(int a)
        {
            switch (a) 
            {
                case 1: Console.ForegroundColor = ConsoleColor.Red; break;
                case 2: Console.ForegroundColor = ConsoleColor.Green; break;
                case 3: Console.ForegroundColor = ConsoleColor.Blue; break;
                case 4: Console.ForegroundColor = ConsoleColor.Yellow; break;
                case 5: Console.ForegroundColor = ConsoleColor.White; break;
                case 6: Console.ForegroundColor = ConsoleColor.DarkMagenta; break;
                case 7: Console.ForegroundColor = ConsoleColor.Cyan; break;
                case 8: Console.ForegroundColor = ConsoleColor.DarkRed; break;
                case 9: Console.ForegroundColor = ConsoleColor.DarkBlue; break;
                default: Console.ResetColor(); break;
            }
        }


        public void Write(int [,] sudoku )
            {
            for (int i = 0; i < 9; i++)
            {
               
                for (int l = 0; l < 9; l++)
                {
                    this.ChangeColor(sudoku[i, l]);
                    Console.Write(" " + sudoku[ i , l] + " ");
                    if ((l + 1) % 3 == 0) { Console.Write(" "); }
                        
                }
                Console.WriteLine();
                if ((i + 1) % 3 == 0 ) { Console.WriteLine(); }
            }
            }

    }
}
