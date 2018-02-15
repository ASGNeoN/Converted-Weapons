using Terraria.ID;
using Terraria.ModLoader;

namespace ConvertedWeapons.Items
{
	public class StarPiece : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Star Pieces");
            Tooltip.SetDefault("Seems that even when shattered, the fallen stars have still got magical powers.");
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
			if(Thorium == null)
			{ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FallenStar);
            recipe.AddTile(TileID.WorkBenches);				
			recipe.SetResult(this, 5);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 5);
            recipe.AddTile(TileID.WorkBenches);	
			recipe.SetResult(ItemID.FallenStar);
			recipe.AddRecipe();}
			else
			{ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 5);
            recipe.AddTile(TileID.WorkBenches);	
			recipe.SetResult(ItemID.FallenStar);
			recipe.AddRecipe();}
		}
	}
}
