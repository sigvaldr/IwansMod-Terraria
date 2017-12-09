using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace IwansMod.NPCs
{
    class AncientViking : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ancient Viking");
        }

        public override void SetDefaults()
        {
            npc.CloneDefaults(NPCID.ArmoredViking);
            npc.damage = 200;
            npc.defense = 5;
            npc.lifeMax = 2000;
            npc.knockBackResist = 0.75f;
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.ArmoredViking]; //Main.npcFrameCount[3];
            aiType = NPCID.ArmoredViking; // aiType = 3;
            animationType = NPCID.ArmoredViking; // animationType = 3;
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.OverworldNightMonster.Chance * 0.50f;
        }

        public override void NPCLoot()
        {
            if (Main.rand.Next(1001) == 0)
                Item.NewItem(npc.getRect(), mod.ItemType("BlazeYoyo"), 1);
        }
    }
}
