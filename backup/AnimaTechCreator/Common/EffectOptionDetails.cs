
namespace AnimaTechCreator.Common
{
    public class EffectOptionDetails
    {       

        public EffectOption EffectOption { get; }

        public bool IsEnabled { get; set; } = false;

        public EffectOptionDetails(EffectOption effectOption)
        {
            EffectOption = effectOption;
        }

    }
}
