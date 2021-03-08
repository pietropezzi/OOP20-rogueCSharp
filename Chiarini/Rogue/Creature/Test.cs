using System;

namespace Rogue.Creature
{
	class Test
	{
		public static void Main(string[] args)
		{			
			Monster air = new Monster(MonsterType.AIR_ELEMENTAL);
			
			Console.WriteLine("Name " + air.getMonsterType().ToString());
			
			if(air.getSpecial().isHostile()){
				Console.WriteLine("isHostile");
			}
			
			if(air.getSpecial().isFlying()){
				Console.WriteLine("isFlying");
			}
			
			if(air.getSpecial().isDrainLife()){
				Console.WriteLine("isDrainLife");
			}
			
			if(air.getSpecial().isFlyingRandom()){
				Console.WriteLine("isFlyingRandom");
			}
			
			if(air.getSpecial().isGreedy()){
				Console.WriteLine("isGreedy");
			}
			
			if(air.getSpecial().isPoisonous()){
				Console.WriteLine("isPoisonous");
			}
			
			Console.WriteLine("AC " + air.getAC());
			Console.WriteLine("Damage " + air.getDamage().ToString());
			Console.WriteLine("ItemChange " + air.getItemChange());
			Console.WriteLine("Money " + air.getMoney());
			Console.WriteLine("Attack " + air.attackDamage());
			Console.WriteLine("DropItem " + air.dropItem());
			Console.WriteLine("HP " + air.getMonsterLife().getHealthPoints());
			Console.WriteLine("EXP " + air.getMonsterLife().getExperience() + "\n");
			
			Monster bat = new Monster(MonsterType.BAT);
			
			Console.WriteLine("Name " + bat.getMonsterType().ToString());
			
			if(bat.getSpecial().isHostile()){
				Console.WriteLine("isHostile");
			}
			
			if(bat.getSpecial().isFlying()){
				Console.WriteLine("isFlying");
			}
			
			if(bat.getSpecial().isDrainLife()){
				Console.WriteLine("isDrainLife");
			}
			
			if(bat.getSpecial().isFlyingRandom()){
				Console.WriteLine("isFlyingRandom");
			}
			
			if(bat.getSpecial().isGreedy()){
				Console.WriteLine("isGreedy");
			}
			
			if(bat.getSpecial().isPoisonous()){
				Console.WriteLine("isPoisonous");
			}
			
			Console.WriteLine("AC " + bat.getAC());
			Console.WriteLine("Damage " + bat.getDamage().ToString());
			Console.WriteLine("ItemChange " + bat.getItemChange());
			Console.WriteLine("Money " + bat.getMoney());
			Console.WriteLine("Attack " + bat.attackDamage());
			Console.WriteLine("DropItem " + bat.dropItem());
			Console.WriteLine("HP " + bat.getMonsterLife().getHealthPoints());
			Console.WriteLine("EXP " + bat.getMonsterLife().getExperience() + "\n");


			Monster centaur = new Monster(MonsterType.CENTAUR);
			
			Console.WriteLine("Name " + centaur.getMonsterType().ToString());
			
			if(centaur.getSpecial().isHostile()){
				Console.WriteLine("isHostile");
			}
			
			if(centaur.getSpecial().isFlying()){
				Console.WriteLine("isFlying");
			}
			
			if(centaur.getSpecial().isDrainLife()){
				Console.WriteLine("isDrainLife");
			}
			
			if(centaur.getSpecial().isFlyingRandom()){
				Console.WriteLine("isFlyingRandom");
			}
			
			if(centaur.getSpecial().isGreedy()){
				Console.WriteLine("isGreedy");
			}
			
			if(centaur.getSpecial().isPoisonous()){
				Console.WriteLine("isPoisonous");
			}
			
			Console.WriteLine("AC " + centaur.getAC());
			Console.WriteLine("Damage " + centaur.getDamage().ToString());
			Console.WriteLine("ItemChange " + centaur.getItemChange());
			Console.WriteLine("Money " + centaur.getMoney());
			Console.WriteLine("Attack " + centaur.attackDamage());
			Console.WriteLine("DropItem " + centaur.dropItem());
			Console.WriteLine("HP " + centaur.getMonsterLife().getHealthPoints());
			Console.WriteLine("EXP " + centaur.getMonsterLife().getExperience() + "\n");
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}