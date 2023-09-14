// Imported from TextBasedSnake
namespace ConwaysGameOfLife {
  public class Draw {
    public static void Run(Board board) {
      string output = "";

      for (int y = 0; y < board.height; y++) {
        for (int x = 0; x < board.width; x++) {
          output += board[x, y] ? '@' : ' ';
        }
        output += '\n';
      }

      Console.Clear();
      Console.Write(output);
    }

    public static void Setup() {
      Console.CursorVisible = false;

      Console.Clear();
      
      Console.CancelKeyPress += new ConsoleCancelEventHandler(OnCtrlCHandler);
    }

    private static void PrintAt(ConsoleColor color, Point point){
      try {
        Console.SetCursorPosition(point.x, point.y);
        Console.BackgroundColor = color;
        Console.Write(" ");
        Console.ResetColor();
      } catch (ArgumentOutOfRangeException e) {
        Console.ResetColor();
        Console.Clear();
        Console.WriteLine(e.Message);
      }
    }

    // idk why this is protected i just copied some code
    protected static void OnCtrlCHandler(object? sender, ConsoleCancelEventArgs args) {
      CleanUp();
    }

    public static void CleanUp() {
      Console.ResetColor();
      Console.Clear();

      Console.CursorVisible = true;
    }

    public Draw() {
      // Setup();
    }
  }
}
