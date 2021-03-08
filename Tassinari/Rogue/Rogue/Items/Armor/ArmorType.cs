namespace Rogue.Items.Armor
{
    /// <summary>
    /// A class for declaring armor types, each described with an AC value and a name.
    /// </summary>
    public class ArmorType
    {
        /// <summary> Leather armor. </summary>
        public static readonly ArmorType Leather = new ArmorType(8, "Leather");
        /// <summary> Ring mail. </summary>
        public static readonly ArmorType RingMail = new ArmorType(7, "Ring Mail");
        /// <summary> Studded leather. </summary>
        public static readonly ArmorType StuddedLeather = new ArmorType(7, "Studded leather");
        /// <summary> Scale mail. </summary>
        public static readonly ArmorType ScaleMail = new ArmorType(6, "Scale mail");
        /// <summary> Chain mail. </summary>
        public static readonly ArmorType ChainMail = new ArmorType(5, "Chain mail");
        /// <summary> Splint mail. </summary>
        public static readonly ArmorType SplintMail = new ArmorType(4, "Splint mail");
        /// <summary> Banded mail. </summary>
        public static readonly ArmorType BandedMail = new ArmorType(4, "Banded mail");
        /// <summary> Plate mail. </summary>
        public static readonly ArmorType PlateMail = new ArmorType(3, "Plate mail");

        /// <summary>
        /// Gets the default AC armor value.
        /// </summary>
        public int Ac { get; private set; }
        
        /// <summary>
        /// Gets the armor name.
        /// </summary>
        public string Name { get; private set; }

        private ArmorType(int ac, string name) => (Ac, Name) = (ac, name);
    }
}