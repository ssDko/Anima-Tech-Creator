namespace AnimaTechCreator.Common
{    
    public class LevelData
    {
        public int MinMk { get; set; }
        public int MaxMk { get; set; }
        public int MaxDisadvantages { get; set; }

        public LevelData(int minMk, int maxMk, int maxDisadvantages)
        {
            MinMk = minMk;
            MaxMk = maxMk;
            MaxDisadvantages = maxDisadvantages;
        }
    }
}
