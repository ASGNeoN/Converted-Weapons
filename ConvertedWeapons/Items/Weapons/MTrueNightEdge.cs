using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ConvertedWeapons.Items.Weapons
{
	public class MTrueNightEdge : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("True Night's Edge");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.TrueNightsEdge);
			item.melee = false;
            item.magic = true;
			item.autoReuse = true;
			item.useTime = 25;
			item.useAnimation = 25;
			item.mana = 25;
			item.damage = 75;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int p = Projectile.NewProjectile(position, new Vector2(speedX, speedY), type, damage, knockBack, item.owner);
            Projectile pro = Main.projectile[p];
            pro.melee = false;
            pro.magic = true;
            return false;
        }

        public override void AddRecipes()
		{
           ModRecipe recipe = new ModRecipe(mod);
           recipe.AddIngredient(ItemID.TrueNightsEdge);
           recipe.AddIngredient(mod, "MageConverter");		   
           recipe.AddTile(TileID.Anvils);
           recipe.SetResult(this);
           recipe.AddRecipe();
		}
	}
}
