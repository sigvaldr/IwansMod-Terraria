using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace IwansMod.Items.Bags
{
    class MuzmBossBag : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Treasure Bag");
            Tooltip.SetDefault("{$CommonItemTooltip.RightClickToOpen}");
        }

        public override void SetDefaults()
        {
            item.maxStack = 999;
            item.consumable = true;
            item.width = 24;
            item.height = 24;
            item.rare = 9;
            item.expert = true; // Treasure Bags are expert mode only.
            bossBagNPC = mod.NPCType("MuzmBoss"); // The NPC this bag drops from
        }

        public override bool CanRightClick()
        {
            return true; // This bag is opened with right click
        }

        public override void OpenBossBag(Player player)
        {
            player.TryGettingDevArmor(); // This will have a chance to spawn the Dev Armour.

            //Yoyo - 1/25
            if (Main.rand.Next(26) == 0) 
            {
                player.QuickSpawnItem(mod.ItemType("BlazeYoyo"));
            }

            //Ancient Sword - 1/20
            if (Main.rand.Next(21) == 0)
            {
                player.QuickSpawnItem(mod.ItemType("AncientVikingSword"));
            }

            //Viking Hook - 1/15
            if (Main.rand.Next(16) == 0)
            {
                player.QuickSpawnItem(mod.ItemType("VikingHook"));
            }

            //Trophy - 1/5
            if (Main.rand.Next(6) == 0)
            {
                player.QuickSpawnItem(mod.ItemType("MuzmBossTrophy"));
            }

            player.QuickSpawnItem(mod.ItemType("VikingMythMetal"), 5); // For Items that you want to always drop
        }
    }
}
