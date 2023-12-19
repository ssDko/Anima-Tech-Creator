using AnimaTechCreator.Common;

namespace AnimaTechCreator.Models
{
    public class DisadvantageModel
    {
        // Properties
        public string Name { get; } = "";
        public int MkReduction { get; } = 1;
        public Enums.Level MinimumLevel { get; } = Enums.Level.One;
        public Enums.ActionType ActionType { get; } = Enums.ActionType.Attack;

        // Constructors
        public DisadvantageModel(
            string name, 
            int mkReduction, 
            Enums.Level minimumLevel, 
            Enums.ActionType actionType
            )
        {
            Name = name;
            MkReduction = mkReduction;
            MinimumLevel = minimumLevel;
            ActionType = actionType;
        }
    }
}
