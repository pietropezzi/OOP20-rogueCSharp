using System;
using System.Collections.Generic;

namespace Quarneti
{
  /// <summary>the default world implemetation.</summary>
  class World
  {
    //private static final MonsterFactory MONSTER_FACTORY = new MonsterFactoryImpl();
    //private static final ItemFactory ITEM_FACTORY = new ItemFactoryImpl();

    private Level currentLevel;
    private Entity player;

    /// <summary>change to the next level</summary>
    private void nextLevel()
    {
      List<Entity> entityList = new List<Entity>();
      entityList.Add(player);
      //entityList.addAll(MONSTER_FACTORY.createMonsterList(player.getLife().getLevel()));
      //entityList.addAll(ITEM_FACTORY.getItems());

      this.currentLevel = new Level(entityList.ToArray(), player);
    }

    public Tile[,] TileMap => this.currentLevel.tileMap;
    public Dictionary<Entity, Tile> EntityMap => this.currentLevel.entityMap;

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

    public int Width => this.currentLevel.WIDTH;
    public int Height => this.currentLevel.HEIGHT;
    public Entity Player => this.player;

    /// <param name="player">the player instance</param>
    public World(Entity player)
    {
      this.player = player;
      nextLevel();
    }
  }
}
