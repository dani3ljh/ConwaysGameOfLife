using ConwaysGameOfLife;

public class Program {
  public static Logic logicManager;

  public static void Main() {
    Draw.Setup();

    logicManager = new Logic(Console.WindowWidth, Console.WindowHeight);

    // Glider
    logicManager.board[1, 0] = true;
    logicManager.board[2, 1] = true;
    logicManager.board[0, 2] = true;
    logicManager.board[1, 2] = true;
    logicManager.board[2, 2] = true;

    Draw.Run(logicManager.board);

    Thread.Sleep(500);

    while(true) {
      Thread.Sleep(500);

      logicManager.Run();

      Draw.Run(logicManager.board);
    }
  }
}
