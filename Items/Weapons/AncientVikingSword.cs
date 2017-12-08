using Terraria.ID;
using Terraria.ModLoader;

namespace IwansMod.Items.Weapons
{
	public class AncientVikingSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ancient Viking Sword");
			Tooltip.SetDefault("An ancient sword from the Viking Era.");
		}
		public override void SetDefaults()
		{
			item.damage = 500;
			item.melee = true;
            item.crit = 46;
			item.width = 40;
			item.height = 40;
			item.useTime = 55;
			item.useAnimation = 55;
			item.useStyle = 1;
			item.knockBack = 12;
			item.value = 10000;
			item.rare = -12;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("VikingMythMetal"), 30);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
