using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ConvertedWeapons.Items.Weapons
{
	public class MagicStarfury : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Starfury");
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.Starfury);
			item.melee = false;
            item.magic = true;
			item.autoReuse = true;
			item.shootSpeed *= 0.75f;
			item.useTime = 10;
			item.useAnimation = 10;
			item.mana = 16;
			item.damage = 16;
        }
		
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			type = mod.ProjectileType("MagicStarfury");
			return base.Shoot(player, ref position, ref speedX, ref speedY, ref type, ref damage, ref knockBack);
		}

        public override void AddRecipes()
		{
           ModRecipe recipe = new ModRecipe(mod);
           recipe.AddIngredient(ItemID.Starfury);
           recipe.AddIngredient(mod, "MageConverter");		   
           recipe.AddTile(TileID.Anvils);
           recipe.SetResult(this);
           recipe.AddRecipe();
		}
	}
}
