namespace Rogue.Armor
{
    /// <summary>
    /// A class for declaring armor types.
    /// The first field of each type keeps track the armor's AC, while the second its name.
    /// </summary>
    public class ArmorType
    {
        public static readonly ArmorType Leather = new ArmorType(8, "Leather");
        public static readonly ArmorType RingMail = new ArmorType(7, "Ring Mail");
        public static readonly ArmorType StuddedLeather = new ArmorType(7, "Studded leather");
        public static readonly ArmorType ScaleMail = new ArmorType(6, "Scale mail");
        public static readonly ArmorType ChainMail = new ArmorType(5, "Chain mail");
        public static readonly ArmorType SplintMail = new ArmorType(4, "Splint mail");
        public static readonly ArmorType BandedMail = new ArmorType(4, "Banded mail");
        public static readonly ArmorType PlateMail = new ArmorType(3, "Plate mail");

        public int Ac { get; private set; }
        public string Name { get; private set; }

        private ArmorType(int ac, string name) => (Ac, Name) = (ac, name);
    }
}