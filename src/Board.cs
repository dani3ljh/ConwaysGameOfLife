namespace ConwaysGameOfLife {
  public class Board  {
    public int width;
    public int height;
    bool[,] boardArr;

    public Board(int width, int height) {
      this.width = width;
      this.height = height;

      boardArr = new bool[width, height];
    }

    public bool this[int x, int y] {
        get => boardArr[x, y];
        set => boardArr[x, y] = value;
    }
  }
}
