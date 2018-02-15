using Terraria.ModLoader;

namespace ConvertedWeapons
{
	class ConvertedWeapons : Mod
	{
		public ConvertedWeapons()
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
