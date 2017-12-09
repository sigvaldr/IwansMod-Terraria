using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace IwansMod.Items.Tools
{
    class VikingPickhamaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Viking Pickhamaxe");
            Tooltip.SetDefault("The only tool you'll need!");
        }

        public override void SetDefaults()
        {


            item.CloneDefaults(ItemID.AdamantitePickaxe);
            item.useTime = 20; // Speed before reuse
            item.rare = 10; // Item Tier
            item.autoReuse = true; // Do you want to torture people with clicking? Set to false

            item.pick = 190; // Pick Power - Higher Value = Better
            item.axe = 200;
            item.hammer = 200;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("VikingMythMetal"), 20);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
}
