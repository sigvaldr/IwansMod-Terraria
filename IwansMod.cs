using Terraria.ModLoader;

namespace IwansMod
{
	class IwansMod : Mod
	{
		public IwansMod()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
