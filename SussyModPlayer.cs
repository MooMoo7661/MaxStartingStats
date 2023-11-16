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
        #endif
            return base.AddStartingItems(mediumCoreDeath);
        }
    }
}