using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ConvertedWeapons.Items.Weapons
{
	public class RSpaceGun: ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Space Gun");
            Tooltip.SetDefault("Requires Laser Bullets");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.SpaceGun);
			item.magic = false;
            item.ranged = true;
			item.autoReuse = true;
			item.mana = 0;
			item.damage = 25;
			item.shoot = mod.ProjectileType("LaserBullet");
			item.useAmmo = mod.ItemType("LaserBullet");	
        }
		
		
	    public override void AddRecipes()
		{
           ModRecipe recipe = new ModRecipe(mod);
           recipe.AddIngredient(ItemID.SpaceGun);
           recipe.AddIngredient(mod, "RangedConverter");		   
           recipe.AddTile(TileID.Anvils);
           recipe.SetResult(this);
           recipe.AddRecipe();
		}
	}
}
