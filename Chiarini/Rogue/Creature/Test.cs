using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Rogue.Creature
{
	
    [TestClass]
    class Test
    {
        private static readonly int IPOTETICAL_DAMAGE = 999;

        private static readonly int AIR_ELEMENTAL_EXPERIENCE = 20;
        private static readonly int AIR_ELEMENTAL_MONEY = 0;
        private static readonly int AIR_ELEMENTAL_ITEM_CHANGE = 20;
   	private static readonly int AIR_ELEMENTAL_HP_MIN = 4;
   	private static readonly int AIR_ELEMENTAL_HP_MAX = 32;
        private static readonly int AIR_ELEMENTAL_DAMAGE_MIN = 4;
        private static readonly int AIR_ELEMENTAL_DAMAGE_MAX = 24;
        private static readonly int AIR_ELEMENTAL_AC = 2;
        
        private static readonly int BAT_EXPERIENCE = 1;
        private static readonly int BAT_MONEY = 0;
        private static readonly int BAT_ITEM_CHANGE = 0;
        private static readonly int BAT_HP_MIN = 1;
        private static readonly int BAT_HP_MAX = 8;
        private static readonly int BAT_DAMAGE_MIN = 1;
        private static readonly int BAT_DAMAGE_MAX = 2;
        private static readonly int BAT_AC = 3;
        
        private static readonly int CENTAUR_EXPERIENCE = 17;
        private static readonly int CENTAUR_MONEY = 51;
        private static readonly int CENTAUR_ITEM_CHANGE = 10;
        private static readonly int CENTAUR_HP_MIN = 4;
        private static readonly int CENTAUR_HP_MAX = 32;
        private static readonly int CENTAUR_DAMAGE_MIN = 4;
        private static readonly int CENTAUR_DAMAGE_MAX = 32;
        private static readonly int CENTAUR_AC = 4;
            
	[TestMethod]
        public void testAirElemental() {
       	
	     Monster mon = new Monster(MonsterType.AIR_ELEMENTAL);

	     assertEquals(AIR_ELEMENTAL_EXPERIENCE, mon.getMonsterLife().getExperience());
	     assertEquals(AIR_ELEMENTAL_MONEY, mon.getMoney());
	     assertEquals(AIR_ELEMENTAL_ITEM_CHANGE, mon.getItemChange());
	     assertTrue(AIR_ELEMENTAL_HP_MIN <= mon.getMonsterLife().getHealthPoints() && mon.getMonsterLife().getHealthPoints() <= AIR_ELEMENTAL_HP_MAX);
	     assertTrue(AIR_ELEMENTAL_DAMAGE_MIN <= mon.attackDamage() && mon.attackDamage() <= AIR_ELEMENTAL_DAMAGE_MAX);
	     assertEquals(AIR_ELEMENTAL_AC, mon.getAC());

	     assertFalse(mon.getSpecial().isDrainLife());
	     assertFalse(mon.getSpecial().isFlyingRandom());
	     assertTrue(mon.getSpecial().isFlying());
	     assertFalse(mon.getSpecial().isGreedy());
	     assertTrue(mon.getSpecial().isHostile());
	     assertFalse(mon.getSpecial().isPoisonous());
	
	     mon.getMonsterLife().hurt(IPOTETICAL_DAMAGE);
	     assertTrue(mon.getMonsterLife().isDead());
        }
		
	[TestMethod]
    	public void testBat() {
        
       	    Monster mon = new Monster(MonsterType.BAT);

            assertEquals(BAT_EXPERIENCE, mon.getMonsterLife().getExperience());
	    assertEquals(BAT_MONEY, mon.getMoney());
	    assertEquals(BAT_ITEM_CHANGE, mon.getItemChange());
    	    assertTrue(BAT_HP_MIN <= mon.getMonsterLife().getHealthPoints() && mon.getMonsterLife().getHealthPoints() <= BAT_HP_MAX);
    	    assertTrue(BAT_DAMAGE_MIN <= mon.attackDamage() && mon.attackDamage() <= BAT_DAMAGE_MAX);
    	    assertEquals(BAT_AC, mon.getAC());
	
    	    assertFalse(mon.getSpecial().isDrainLife());
    	    assertTrue(mon.getSpecial().isFlyingRandom());
    	    assertTrue(mon.getSpecial().isFlying());
    	    assertFalse(mon.getSpecial().isGreedy());
    	    assertFalse(mon.getSpecial().isHostile());
    	    assertFalse(mon.getSpecial().isPoisonous());

    	    mon.getMonsterLife().hurt(IPOTETICAL_DAMAGE);
    	    assertTrue(mon.getMonsterLife().isDead());
    	}
		 
	[TestMethod]
    	public void testCentaur() {
	       
    	    Monster mon = new Monster(MonsterType.CENTAUR);

    	    assertEquals(CENTAUR_EXPERIENCE, mon.getMonsterLife().getExperience());
    	    assertEquals(CENTAUR_MONEY, mon.getMoney());
    	    assertEquals(CENTAUR_ITEM_CHANGE, mon.getItemChange());
    	    assertTrue(CENTAUR_HP_MIN <= mon.getMonsterLife().getHealthPoints() && mon.getMonsterLife().getHealthPoints() <= CENTAUR_HP_MAX);
    	    assertTrue(CENTAUR_DAMAGE_MIN <= mon.attackDamage() && mon.attackDamage() <= CENTAUR_DAMAGE_MAX);
    	    assertEquals(CENTAUR_AC, mon.getAC());

    	    assertFalse(mon.getSpecial().isDrainLife());
    	    assertFalse(mon.getSpecial().isFlyingRandom());
    	    assertFalse(mon.getSpecial().isFlying());
    	    assertFalse(mon.getSpecial().isGreedy());
    	    assertFalse(mon.getSpecial().isHostile());
    	    assertFalse(mon.getSpecial().isPoisonous());

    	    mon.getMonsterLife().hurt(IPOTETICAL_DAMAGE);
    	    assertTrue(mon.getMonsterLife().isDead());
    	}
    }
}
