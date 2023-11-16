using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace MaxStartingStats
{
	public class SussyModPlayer : ModPlayer
	{
        public override IEnumerable<Item> AddStartingItems(bool mediumCoreDeath)
        {
        #if TML_2022_09
            Player.statLifeMax = 400;
            Player.statManaMax = 200;
        #else
            Player.ConsumedLifeCrystals = Player.LifeCrystalMax;
            Player.ConsumedManaCrystals = Player.ManaCrystalMax;
            Player.statLife = 500;
            Player.statMana = 200;

            if (ModContent.GetInstance<Config>().LifeFruitHP)
            Player.ConsumedLifeFruit = Player.LifeFruitMax; 
        #endif

            return base.AddStartingItems(mediumCoreDeath);
        }
    }
}