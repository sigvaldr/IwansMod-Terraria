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
            npc.damage = 50;
            npc.defense = 10;
            npc.lifeMax = 2000;
            npc.knockBackResist = 0.75f;
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.ArmoredViking]; //Main.npcFrameCount[3];
            aiType = NPCID.ArmoredViking; // aiType = 3;
            animationType = NPCID.ArmoredViking; // animationType = 3;
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            //return SpawnCondition.OverworldNightMonster.Chance * 0.70f;
            if (Main.hardMode == true)
            {
                return SpawnCondition.OverworldNightMonster.Chance * 0.70f;
            }
            else
            {
                return 0f;
            }
        }

        public override void NPCLoot()
        {
            //Drop Muzm boss summon - 1/500
            if (Main.rand.Next(501) == 0)
            {
                Item.NewItem(npc.getRect(), mod.ItemType("MuzmBossSummon"), 1);
            }
        }
    }
}
