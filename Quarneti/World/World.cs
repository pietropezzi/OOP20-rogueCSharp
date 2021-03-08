using System.Collections.Generic;

namespace World
{
  /// <summary>the default world implemetation.</summary>
  public class World
  {
    //private static final MonsterFactory MONSTER_FACTORY = new MonsterFactoryImpl();
    //private static final ItemFactory ITEM_FACTORY = new ItemFactoryImpl();

    private Level currentLevel;
    public IEntity player { get; }

    /// <summary>change to the next level</summary>
    private void nextLevel()
    {
      List<IEntity> entityList = new List<IEntity>();
      entityList.Add(player);
      //entityList.addAll(MONSTER_FACTORY.createMonsterList(player.getLife().getLevel()));
      //entityList.addAll(ITEM_FACTORY.getItems());

      this.currentLevel = new Level(entityList.ToArray(), player);
    }

    public Tile[,] TileMap => this.currentLevel.tileMap;
    public Dictionary<IEntity, Tile> EntityMap => this.currentLevel.entityMap;

    public bool round(Direction d)
    {
      bool nextlvl = false;

      // if (currentLevel.moveEntities(direction)) {
      //   nextLevel.run(); // change level
      //   nextlvl = true;
      // }
      // if (player.getInventory().getScrollContainer().getActiveScroll().isPresent()) {
      //   player.getInventory().getScrollContainer().updateEffectDuration(1);
      // }

      return nextlvl;
    }

    public int Width => Level.WIDTH;
    public int Height => Level.HEIGHT;

    /// <param name="player">the player instance</param>
    public World(IEntity player)
    {
      this.player = player;
      nextLevel();
    }
  }
}
