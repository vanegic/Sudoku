using Sudoku;

Console.WriteLine("Hello, Sudoku");
Console.WriteLine();
sudoku s = new sudoku();
s.Create();
s.Randomizer();
s.Write(s.sud);

Console.ReadKey();