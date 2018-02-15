using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ConvertedWeapons.Items.Weapons
{
	public class MHarpoon : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Harpoon");
        } 

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.Harpoon);
            item.ranged = false;
            item.melee = true;
            item.autoReuse = true;

        }
		
		
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
            int p = Projectile.NewProjectile(position, new Vector2(speedX, speedY), type, damage, knockBack, item.owner);
            Projectile pro = Main.projectile[p];
            pro.ranged = false;
            pro.melee = true;
            return false;
		}
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Harpoon);
            recipe.AddIngredient(mod, "MeleeConverter");
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
