using System;
using System.Linq;

namespace World
{
  /// <summary>
  /// Generates a cave.
  ///
  /// <see href="https://gamedevelopment.tutsplus.com/tutorials/generate-random-cave-levels-using-cellular-automata--gamedev-9664" />
  /// </summary>
  class CaveGenerator
  {
    private const int CHANCE_TO_START_ALIVE = 20;
    private const int BIRTH_LIMIT = 3;
    private const int DEATH_LIMIT = 2;
    private const int STEP_COUNT = 10;
    private static Random RANDOM = new Random();
    public bool[,] cave { get; set; }

    /// <summary>
    /// Initializes a basic random map.
    /// </summary>
    private void intialize()
    {
      Enumerable.Range(0, cave.GetLength(0)).ToList().ForEach(x =>
      {
        Enumerable.Range(0, cave.GetLength(1)).ToList().ForEach(y =>
        {
          cave[x, y] = RANDOM.Next(100) < CHANCE_TO_START_ALIVE;
        });
      });
    }

    /// <returns>
    /// the number of cells in a ring around (x, y) that are alive
    /// </returns>
    private int countAliveNeighbors(int x, int y)
    {
      int count = 0;

      Enumerable.Range(-1, 2).ToList().ForEach(i =>
      {
        Enumerable.Range(-1, 2).ToList().ForEach(j =>
        {
          int neighborX = x + i, neighborY = y + j;

          // If we're looking at the middle point
          if (i == 0 && j == 0)
          {
            // Do nothing, we don't want to add ourselves in!
          }
          // In case the index we're looking at it off the edge of the map
          else if (neighborX < 0 || neighborY < 0 || neighborX >= cave.GetLength(0) || neighborY >= cave.GetLength(1))
          {
            count++;
          }
          // Otherwise, a normal check of the neighbour
          else if (cave[neighborX, neighborY])
          {
            count++;
          }
        });
      });

      return count;
    }

    /**
     * Cave adjustments.
     */
    private void doSimulationStep(int i)
    {
      bool[,] newCave = new bool[cave.GetLength(0), cave.GetLength(1)];

      // Loop over each row and column of the map
      Enumerable.Range(0, cave.GetLength(0)).ToList().ForEach(x =>
      {
        Enumerable.Range(0, cave.GetLength(1)).ToList().ForEach(y =>
        {
          int neighborCount = countAliveNeighbors(x, y);

          // The new value is based on our simulation rules
          // First, if a cell is alive but has too few neighbors, kill it.
          if (cave[x, y])
          {
            if (neighborCount < DEATH_LIMIT)
            {
              newCave[x, y] = false;
            }
            else
            {
              newCave[x, y] = true;
            }
          }
          // Otherwise, if the cell is dead now, check if it has the right number of
          // neighbours to be 'born'
          else
          {
            if (neighborCount > BIRTH_LIMIT)
            {
              newCave[x, y] = true;
            }
            else
            {
              newCave[x, y] = false;
            }
          }
        });
      });

      cave = newCave;
    }

    /// <param name="width">the cave's width (max x)</param>
    /// <param name="height">the cave's height (max y)</param>
    public CaveGenerator(int width, int height)
    {
      cave = new bool[width, height];
      this.intialize();
      Enumerable.Range(0, STEP_COUNT).ToList().ForEach(doSimulationStep);
    }
  }
}