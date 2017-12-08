using Terraria.ModLoader;
using Terraria.ID;

namespace IwansMod.Items.Blocks
{
    public class VikingOre : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mythical Ore");
            Tooltip.SetDefault("This exists? I've only heard fairytales about it.");
        }

        public override void SetDefaults()
        {
            item.width = 12; // Hitbox Width
            item.height = 12; // Hitbox Height
            item.useTime = 20; // Speed before reuse
            item.useAnimation = 20; // Animation Speed
            item.useStyle = 1; // 1 = Broadsword 
            item.value = 50; // 10 | 00 | 00 | 00 : Platinum | Gold | Silver | Bronze
            item.rare = 10; // Item Tier
            item.UseSound = SoundID.Item1; // Sound effect of item on use 
            item.autoReuse = true; // Do you want to torture people with clicking? Set to false
            item.consumable = true; // Will consume the item when placed.
            item.createTile = mod.TileType("VikingOreTile");
            item.maxStack = 999; // The maximum number you can have of this item.
        }
    }
}