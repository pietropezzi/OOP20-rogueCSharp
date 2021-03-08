namespace Rogue.Creature
{
	public class MonsterLife {

    	private int healthPoints;
    	private int experience;

	public MonsterLife(int healthPoints, int experience) {
    	    this.healthPoints = healthPoints;
    	    this.experience = experience;
    	}


    	protected int checkNotNegative(int value) {
    	    return value < 0 ? 0 : value;
    	}


    	public void hurt(int damage) {
    	    this.healthPoints = checkNotNegative(this.healthPoints - damage);
   		}

    	public int getHealthPoints() {
            return this.healthPoints;
    	}


    	protected void setHealthPoints(int healthPoints) {
            this.healthPoints = healthPoints;
   		}


    	public int getExperience() {
            return this.experience;
    	}


    	protected void setExperience(int experience) {
            this.experience = experience;
    	}


    	public bool isDead() {
            return this.healthPoints == 0;
    	}

    	public string toString() {
            return "AbstractLife [healthPoints=" + healthPoints + ", experience=" + experience + "]";
        }
    }
}
	

