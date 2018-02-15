using Terraria.ID;
using Terraria.ModLoader;

namespace ConvertedWeapons.Items
{
	public class MageConverter : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Magic Converter");
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
			if(Thorium != null)
			{ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModLoader.GetMod("ThoriumMod").ItemType("ArcaneDust"), 10);
			recipe.AddIngredient(ItemID.ManaCrystal);		
            recipe.AddTile(TileID.WorkBenches);				
			recipe.SetResult(this);
			recipe.AddRecipe();}
			else
			{ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "StarPiece", 10);
			recipe.AddIngredient(ItemID.ManaCrystal);	
            recipe.AddTile(TileID.WorkBenches);	
			recipe.SetResult(this);
			recipe.AddRecipe();}
		}
	}
}
