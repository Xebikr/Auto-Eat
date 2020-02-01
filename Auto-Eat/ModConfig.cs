using StardewModdingAPI;

namespace AutoEat
{
    internal class ModConfig
    {
        public float StaminaThreshold { get; set; }

        public float HealthThreshold { get; set; }
        
        public bool AutoEatFood { get; set; }
        
        public bool EatCheapestFood { get; set; }
        
        public SButton InstantEatKey { get; set; }
    }
}
