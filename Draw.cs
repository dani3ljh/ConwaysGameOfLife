// Imported from TextBasedSnake
namespace ConwaysGameOfLife {
  public class Draw {
    private static int originalRow;
    private static int originalCol;

    private static char cellOn  = '█';
    private static char cellOff = ' ';

    public static void Setup() {
      Console.CursorVisible = false;

      Console.Clear();

      originalRow = Console.CursorTop;
      originalCol = Console.CursorLeft;
      
      Console.CancelKeyPress += new ConsoleCancelEventHandler(OnCtrlCHandler);
    }

    private static void PrintAt(ConsoleColor color, Point point){
      try {
        Console.SetCursorPosition(originalCol + point.x, originalRow + point.y);
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
