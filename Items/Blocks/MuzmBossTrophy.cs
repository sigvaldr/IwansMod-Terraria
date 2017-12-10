using System;
using Terraria.ModLoader;
using Terraria.ID;
namespace IwansMod.Items.Blocks
{
    class MuzmBossTrophy : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Muzm Trophy");
            Tooltip.SetDefault("You defeated Muzm the Muslim!");
        }

        public override void SetDefaults()
        {
            item.width = 48; // Hitbox Width
            item.height = 48; // Hitbox Height
            item.useTime = 20; // Speed before reuse
            item.useAnimation = 20; // Animation Speed
            item.useStyle = 1; // 1 = Broadsword 
            item.value = 666000000; //Plat, Gold, Silver, Copper
            item.rare = 10; // Item Tier
            item.UseSound = SoundID.Item1; // Sound effect of item on use 
            item.autoReuse = true; // Do you want to torture people with clicking? Set to false
            item.consumable = true; // Will consume the item when placed.
            item.createTile = mod.TileType("MuzmBossTrophyTile");
            item.maxStack = 999; // The maximum number you can have of this item.
        }
    }
}
