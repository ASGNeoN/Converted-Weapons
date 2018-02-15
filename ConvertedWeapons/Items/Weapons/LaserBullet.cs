using Terraria.ID;
using Terraria.ModLoader;

namespace ConvertedWeapons.Items.Weapons
{
	public class LaserBullet : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Laser Bullet");
            Tooltip.SetDefault("It comes from a Meteor!");
        }

        public override void SetDefaults()
		{
			item.damage = 5;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 999;
			item.consumable = true;             //You need to set the item consumable so that the ammo would automatically consumed
			item.value = 10;
			item.rare = 2;
			item.shoot = mod.ProjectileType("LaserBullet");//The projectile shoot when your weapon using this ammo                //The speed of the projectile
			item.ammo=item.type;             //The ammo class this ammo belongs to.
		}
		
	    public override void AddRecipes()
		{
           ModRecipe recipe = new ModRecipe(mod);
           recipe.AddIngredient(ItemID.MeteorShot, 70); 	
           recipe.AddIngredient(ItemID.FallenStar); 		   
           recipe.AddTile(TileID.Anvils);
           recipe.SetResult(this, 70);
           recipe.AddRecipe();
		}
		
	}
}
