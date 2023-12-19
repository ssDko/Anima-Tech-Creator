using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace AnimaTechCreator.Common
{
    static class Levels
    {
        private static readonly List<LevelData> levels = new List<LevelData>
        {
                new LevelData(20, 50, 1),
                new LevelData(40, 100, 2),
                new LevelData(60, 200, 3)
        };

        public static LevelData GetLevelData(int index) => levels[index];
        public static LevelData GetLevelData(Enums.Level level) => levels[(int)level];

        public static ObservableCollection<int> AvailableLevels { get; } = new ObservableCollection<int> { 1, 2, 3 };
    }
}
