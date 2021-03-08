namespace Rogue.Creature
{
	
	/// <summary>
	/// A class rapresenting a pair of object.
	/// </summary>
	public class Pair<TFirst, Tsecond> { 

   		private TFirst first;
   		private Tsecond second;

	  	 /// <summary>
	   	/// The class constructor.
	    /// </summary>
 	   /// <param name="first">the first value</param>
	    /// <param name="second">the second value</param>
	    public Pair(TFirst first, Tsecond second)
	    {
 	       this.first = first;
 	       this.second = second;
 	   }

 	   /// <summary>
 	   /// return the first value.
 	   /// </summary>
 	   /// <returns>the first value.</returns>
 	   public TFirst GetFirst() {
        return this.first;
  	   }

	    /// <summary>
	    /// return the second value.
	    /// </summary>
	    /// <returns>the second value.</returns>
 	    public Tsecond GetSecond() {
       		return this.second;
    	}

 	   /// <summary>
 	   /// return i to string of the pair.
	    /// </summary>
	    /// <returns>the string</returns>
 	   public override string ToString() {
 	       return "<" + first + "," + second + ">";
  	   }
	}
}
