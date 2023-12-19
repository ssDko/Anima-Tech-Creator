namespace AnimaTechCreator.Common
{
    public class OptionalCharacteristic
    {
        public Enums.Characteristic Characteristic { get; } = Enums.Characteristic.Strength;
        public int AddedCost { get; } = 1;

        public OptionalCharacteristic(Enums.Characteristic characteristic, int addedCost) 
        {
            Characteristic = characteristic;
            AddedCost = addedCost;
        }
    }
}
