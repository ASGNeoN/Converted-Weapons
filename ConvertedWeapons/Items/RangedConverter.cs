using Terraria.ID;
using Terraria.ModLoader;

namespace ConvertedWeapons.Items
{
	public class RangedConverter : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ranged Converter");
            Tooltip.SetDefault("Seems that the weapons start to behave in a different way when infused with this material.");
        }
        Mod Thorium = ModLoader.GetMod("ThoriumMod");
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = 500;
			item.rare = 1;
		}
		public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WoodenArrow, 25);	
			recipe.AddIngredient(ItemID.WoodenBow);	
            recipe.AddTile(TileID.WorkBenches);	
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
