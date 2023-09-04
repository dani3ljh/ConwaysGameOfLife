namespace ConwaysGameOfLife {
  public class Point {
    public int x;
    public int y;

    public Point(int x, int y) {
        this.x = x;
        this.y = y;
    }

    public override bool Equals(object? obj) {
        if (obj == null || GetType() != obj.GetType()) {
            return false;
        }

        Point otherPoint = (Point)obj;
        return x == otherPoint.x && y == otherPoint.y;
    }

    public override int GetHashCode() {
        return HashCode.Combine(x, y);
    }

    public static bool operator ==(Point point1, Point point2) {
        if (ReferenceEquals(point1, point2)) {
            return true;
        }
        
        if ((object)point1 == null || (object)point2 == null) {
            return false;
        }

        return point1.Equals(point2);
    }

    public static bool operator !=(Point point1, Point point2) {
        return !(point1 == point2);
    }
  }
}
