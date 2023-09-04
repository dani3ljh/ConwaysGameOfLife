namespace ConwaysGameOfLife {
  public class Logic {
    public Board board;

    public Logic(int width, int height) {
      board = new Board(width, height);
    }

    public static readonly (int, int)[] neighborDirections = new (int, int)[] {
      (0, 1),
      (1, 1),
      (1, 0),
      (1, -1),
      (0, -1),
      (-1, -1),
      (-1, 0),
      (-1, 1)
    };

    public void Run() {
      int[,] neighbors = new int[board.width, board.height];

      for (int x = 0; x < board.width; x++) {
        for (int y = 0; y < board.height; y++) {
          if (!board[x, y]) continue;

          foreach ((int deltaX, int deltaY) in neighborDirections) {
            int newX = x + deltaX;
            int newY = y + deltaY;

            if (
              newX < 0 ||
              newX >= board.width ||
              newY < 0 ||
              newY >= board.height
            ) continue;
            
            neighbors[newX, newY]++;
          }
        }
      } 

      for (int x = 0; x < board.width; x++) {
        for (int y = 0; y < board.height; y++) {
          int neighborCount = neighbors[x, y];

          // If Cell Alive
          if (board[x, y]) {
            if (neighborCount < 2 || neighborCount > 3) {
              board[x, y] = false;
            }
          }

          // If Cell Dead
          else if (neighborCount == 3) {
            board[x, y] = true;
          }
        }
      }
    }
  }
}
