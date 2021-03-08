namespace World
{
  /// <summary>
  /// the default tile implementation.
  /// </summary>
  public class Tile
  {
    public int x { get; }
    public int y { get; }
    public bool isWall { get; }
    public bool isDoor { get; set; }

    /// <param name="x">the x coordinate</param>
    /// <param name="y">the y coordinate</param>
    /// <param name="madeOf">the tile's material</param>
    /// <param name="isWall">if the tile is a wall</param>
    public Tile(int x, int y, bool isWall)
    {
      this.x = x;
      this.y = y;
      this.isWall = isWall;
    }
  }
}