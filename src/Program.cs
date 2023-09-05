using ConwaysGameOfLife;

public class Program {
  public static Logic logicManager;
  public static int windowWidth;
  public static int windowHeight;

  public static void Main() {
    Draw.Setup();

    windowWidth = Console.WindowWidth;
    windowHeight = Console.WindowHeight;

    logicManager = new Logic(windowWidth, windowHeight);

    /*
    // Glider
    (int, int)[] points = new (int, int)[] {
      (1, 0),
      (2, 1),
      (0, 2),
      (1, 2),
      (2, 2),
    };
    */

    // Glider Gun
    (int, int)[] points = new (int, int)[] {
      // Left Stopper
      (0, 4),
      (0, 5),
      (1, 4),
      (1, 5),

      // Left Curve
      (13, 2),
      (12, 2),
      (11, 3),
      (10, 4),
      (10, 5),
      (10, 6),
      (11, 7),
      (12, 8),
      (13, 8),

      // Dot
      (14, 5),

      // Arrow?
      (15, 3),
      (16, 4),
      (16, 5),
      (17, 5),
      (16, 6),
      (15, 7),

      // Block thingy
      (22, 1),
      (20, 2),
      (21, 2),
      (20, 3),
      (21, 3),
      (20, 4),
      (21, 4),
      (22, 5),

      // Line Window thingy
      (24, 0),
      (24, 1),
      (24, 5),
      (24, 6),

      // Right Stopper
      (34, 2),
      (35, 2),
      (34, 3),
      (35, 3),
    };

    foreach ((int, int) point in points) {
      logicManager.board[point.Item1, point.Item2] = true;
    }

    Draw.Run(logicManager.board);

    Thread.Sleep(200);

    while(true) {
      Thread.Sleep(200);

      logicManager.Run();

      Draw.Run(logicManager.board);
    }
  }
}
