using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace IwansMod.Tiles
{
    class MuzmBossTrophyTile : ModTile
    {
        /**
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = false; // Is the tile solid
            Main.tileMergeDirt[Type] = false; // Will tile merge with dirt?
            Main.tileLighted[Type] = true; // ???
            Main.tileBlockLight[Type] = false; // Emits Light

            drop = mod.ItemType("MuzmBossTrophy"); // What item drops after destorying the tile
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Muzm Boss Trophy");
            minPick = 1; // What power pick minimum is needed to mine this block.
        }
        **/

        public override void SetDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileLavaDeath[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x3Wall);
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.newTile.StyleWrapLimit = 42;
            TileObjectData.addTile(Type);
            disableSmartCursor = true;
        }
        public override void KillMultiTile(int i, int j, int frameX, int frameY) //this make that when you break the Trophy it will give you the TrophyItem
        {
            Item.NewItem(i * 16, j * 16, 32, 16, mod.ItemType("MuzmBossTrophy"));
        }
    }
}
