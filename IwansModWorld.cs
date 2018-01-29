﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Generation;
using Terraria.World.Generation;
using System.Collections.Generic;

using System;
using Terraria.ModLoader.IO;
using System.IO;


namespace IwansMod
{
    public class IwansModWorld : ModWorld
    {
        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
        {
            int ShiniesIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Shinies"));
            if (ShiniesIndex != -1)
            {
                tasks.Insert(ShiniesIndex + 1, new PassLegacy("Iwan's Mod Ores", delegate (GenerationProgress progress)
                {
                    progress.Message = "Brushing up on Mythology";
                    for (int i = 0; i < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 6E-05); i++)
                    {
                        WorldGen.TileRunner(
                            WorldGen.genRand.Next(0, Main.maxTilesX), // X Coord of the tile
                            WorldGen.genRand.Next((int)WorldGen.worldSurfaceLow, Main.maxTilesY), // Y Coord of the tile
                            (double)WorldGen.genRand.Next(3, 6), // Strength (High = more) default = 3, 6
                            WorldGen.genRand.Next(2, 6), // Steps 
                            mod.TileType("VikingOreTile"), // The tile type that will be spawned
                            false, // Add Tile ???
                            0f, // Speed X ???
                            0f, // Speed Y ???
                            false, // noYChange ??? 
                            true); // Overrides existing tiles
                    }
                }));
            }
        }
    }
}
