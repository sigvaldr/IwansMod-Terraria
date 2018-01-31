using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace IwansMod.Items.Trinkets
{
    class VikingShield : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Shield of the Viking God");

            Tooltip.SetDefault("A unfathomably strong shield previously owned" + "\n" + "a forgotten Viking God");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 28;
            item.value = 10000;
            item.rare = 2;
            item.accessory = true;
            //item.defense = 1000;
            item.lifeRegen = 19;
            item.value = Item.buyPrice(5, 0, 0, 0); //plat, gold, silver, copper
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            //if (player.name.Contains("Iwan"))
            //{
                //for iwan
            //    Main.NewText("Look alive friends, for the True Viking God, Iwan, has joined you!", 255, 242, 0);
            //}

            //debugging!
            //Main.NewText("Current def: " + player.statDefense.ToString(), 255, 255, 255);
            player.statDefense = player.statDefense + player.statDefense;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("VikingMythMetal"), 100);
            recipe.AddIngredient(ItemID.FragmentVortex, 20);
            recipe.AddIngredient(ItemID.FragmentNebula, 20);
            recipe.AddIngredient(ItemID.FragmentStardust, 20);
            recipe.AddIngredient(ItemID.FragmentSolar, 20);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
