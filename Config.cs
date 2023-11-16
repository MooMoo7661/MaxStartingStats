using System.ComponentModel;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;

namespace MaxStartingStats
{
    public class Config : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        [Label("Include Life Fruit hearts")]
        [DefaultValue(true)]
        public bool LifeFruitHP { get; set; }
    }
}