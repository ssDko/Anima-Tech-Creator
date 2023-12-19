using AnimaTechCreator.Common;
using AnimaTechCreator.Models;

namespace AnimaTechCreator.Entities
{
    public class Disadvantage
    {
        public DisadvantageModel Model { get; }
        public string Name { get { return Model.Name; } }
        public int MkReduction { get { return Model.MkReduction; } }
        public Enums.Level MinimumLevel { get { return Model.MinimumLevel; } }
        public Enums.ActionType ActionType { get { return Model.ActionType; } }

        public int IntMinimumLevel { get { return Model.IntMinimumLevel; } }
        public Disadvantage(DisadvantageModel model)
        {
            Model = model;
        }
    }
}
