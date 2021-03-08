using System;
using System.Collections.Generic;
using System.Linq;

namespace World
{
  /// <summary>
  /// the default level implementation.
  /// </summary>
  class Level
  {
    public static int WIDTH { get; } = 32;
    public static int HEIGHT { get; } = 32;
    //private static int FOOD_DECREASE_ON_COMBAT = 2;

    private static Random RANDOM = new Random();
    //private static Combat combat = new CombatImpl();
    public Tile[,] tileMap { get; } = new Tile[WIDTH, HEIGHT];
    private IEntity player;
    public Dictionary<IEntity, Tile> entityMap { get; } = new Dictionary<IEntity, Tile>();

    // freeTiles cache
    private List<Tile> freeTiles = new List<Tile>();

    /// <returns>a random tile from the freeTiles list</returns>
    private Tile RandomFreeTile => freeTiles[RANDOM.Next(this.freeTiles.Count)];

    /// <param name="t">the tile</param>
    /// <returns>can place an entity in tile t?</returns>
    private bool CanPlaceEntity(Tile t) => freeTiles.Contains(t);

    /// <summary>remove the entity and update the free tiles list.</summary>
    /// <param name="e">the entity to be removed</param>
    private void removeEntity(IEntity e)
    {
      this.freeTiles.Add(entityMap[e]);
      this.entityMap.Remove(e);
    }

    /// <param name="e">the entity to be placed</param>
    /// <param name="t">the tile for the entity to be placed in</param>
    private void placeEntity(IEntity e, Tile t)
    {
      if (this.entityMap.ContainsKey(e))
      {
        removeEntity(e);
      }

      entityMap[e] = t;
      freeTiles.Remove(t);
    }

    /// <summary>gets the tile next to an entity.</summary>
    /// <param name="e">the entity</param>
    /// <param name="d">the direction used to determine the tile</param>
    /// <returns>the tile next to e</returns>
    private Tile getRelativeTile(IEntity e, Direction d)
    {
      Tile currentTile = entityMap[e];
      if (currentTile == null)
        return null;

      int nextX = currentTile.x, nextY = currentTile.y;

      switch (d)
      {
        case Direction.NORTH:
          nextY--;
          break;
        case Direction.EAST:
          nextX++;
          break;
        case Direction.SOUTH:
          nextY++;
          break;
        case Direction.WEST:
          nextX--;
          break;
        default:
          break;
      }

      return this.tileMap[nextX, nextY];
    }

    /// <summary>place an entity in a random tile</summary>
    /// <param name="e">the entity to be spawned</param>
    public void spawn(IEntity e) => placeEntity(e, RandomFreeTile);

    public void spawn(IEntity[] l) => l.ToList().ForEach(spawn);

    /// <summary>generate the level map using CaveGenerator</summer>
    private void generate()
    {
      CaveGenerator cg = new CaveGenerator(WIDTH, HEIGHT);
      bool[,] cave = cg.cave;

      // tileMap
      Enumerable.Range(0, WIDTH).ToList().ForEach(x =>
      {
        Enumerable.Range(0, HEIGHT).ToList().ForEach(y =>
        {
          bool isWall = cave[x, y];

          Tile t = new Tile(x, y, isWall);

          // redundant but not slow
          this.tileMap[x, y] = t;

          // cache free tiles
          if (!isWall)
            this.freeTiles.Add(t);
        });
      });

      // door to next level
      Tile door = RandomFreeTile;
      door.isDoor = true;
    }

    /// <param name="e">the entity</param>
    /// <returns>the best direction to reach the player<returns>
    private Direction nearestDirectionToPlayer(IEntity e)
    {
      Tile playerTile = this.entityMap[this.player];
      Tile entityTile = this.entityMap[e];
      if (playerTile == null || entityTile == null)
      {
        return Direction.NONE;
      }

      int east = playerTile.x - entityTile.x;
      int west = entityTile.x - playerTile.x;
      int south = playerTile.y - entityTile.y;
      int north = entityTile.y - playerTile.y;

      Tuple<Direction, int> xDirection = east > 0 ? new Tuple<Direction, int>(Direction.EAST, east)
              : new Tuple<Direction, int>(Direction.WEST, west);
      Tuple<Direction, int> yDirection = south > 0 ? new Tuple<Direction, int>(Direction.SOUTH, south)
              : new Tuple<Direction, int>(Direction.NORTH, north);

      return xDirection.Item2 > yDirection.Item2 ? xDirection.Item1 : yDirection.Item1;
    }

    // movePlayer, moveMonster and moveEntities require foreign classes
    // getTileStream isn't implemented

    /// <summary>Create a new level.</summary>
    /// <param name="list">the entity list (player included)</param>
    /// <param name="player">the player instance<param>
    public Level(IEntity[] list, IEntity player)
    {
      this.player = player;
      this.generate();
      this.spawn(list);
    }
  }
}