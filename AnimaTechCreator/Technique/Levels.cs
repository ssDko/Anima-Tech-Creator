using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimaTechCreator.Technique
{
    internal static class Levels
    {
        public enum LevelNum
        {
            One = 1,
            Two = 2,
            Three = 3
        }

        public class Level
        {
            public int MinMk { get; set; }
            public int MaxMk { get; set; }
            public int MaxDisadvantages { get; set; }

            public Level(int minMk, int maxMk, int maxDisadvantages)
            {
                MinMk = minMk;
                MaxMk = maxMk;
                MaxDisadvantages = maxDisadvantages;
            }
        }

        private static readonly List<Level> levels = new List<Level>
        {
                new Level(20, 50, 1),
                new Level(40, 100, 2),
                new Level(60, 200, 3)
        };

        public static Level GetLevel(int index) => levels[index];
        public static Level GetLevel(LevelNum levelNum) => levels[(int)levelNum];

    }
}
