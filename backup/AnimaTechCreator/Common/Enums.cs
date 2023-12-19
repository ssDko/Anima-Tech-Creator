namespace AnimaTechCreator.Common
{
    public class Enums
    {
        public enum Level
        {
            One = 1,
            Two = 2,
            Three = 3,
        }

        public enum ActionType
        {
            Attack,
            Counterattack,
            Defense,
            Variable,
        }

        public enum Frequency
        {
            Action,
            Turn,
            Mixed,
        }

        // Techniques don't directly use INT and PER but added anyway
        public enum Characteristic
        {
            Strength,
            Dexterity,
            Agility,
            Constitution,
            Intelligence,
            Power,
            Willpower,
            Perception,
        }

        public enum CharacteristicAbriviation
        {
            STR,
            DEX,
            AGI,
            CON,
            Int,
            POW,
            WP,
            Perception,
        }

        public enum Element
        {
            Air,
            Fire,
            Earth,
            Water,
            Light,
            Darkness,
        }
    }
}
