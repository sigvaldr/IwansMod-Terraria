using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace IwansMod.Items.Tools
{
    class VikingHook : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Viking Hook");
            Tooltip.SetDefault("A strange hook from the Viking Era.");
        }

        public override void SetDefaults()
        {
            /*
				this.noUseGraphic = true;
				this.damage = 0;
				this.knockBack = 7f;
				this.useStyle = 5;
				this.name = "Amethyst Hook";
				this.shootSpeed = 10f;
				this.shoot = 230;
				this.width = 18;
				this.height = 28;
				this.useSound = 1;
				this.useAnimation = 20;
				this.useTime = 20;
				this.rare = 1;
				this.noMelee = true;
				this.value = 20000;
			*/
            // Instead of copying these values, we can clone and modify the ones we want to copy
            item.CloneDefaults(ItemID.AmethystHook);
            item.shootSpeed = 20f; // how quickly the hook is shot.
            item.shoot = mod.ProjectileType("VikingHookProj");
            item.rare = -12;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("VikingMythMetal"), 15);
            recipe.AddIngredient(ItemID.Hook, 1);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
}
