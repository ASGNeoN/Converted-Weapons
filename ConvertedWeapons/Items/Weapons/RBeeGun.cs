using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ConvertedWeapons.Items.Weapons
{
    public class RBeeGun : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bee Gun");
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.BeeGun);
            item.magic = false;
            item.ranged = true;
            item.autoReuse = true;
            item.damage = 12;
            item.useAmmo = AmmoID.Bullet;
            
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if (type != ProjectileID.Bee) // or ProjectileID.WoodenArrowFriendly
            {
                type = ProjectileID.Bee; // or ProjectileID.FireArrow;
            }
            int p = Projectile.NewProjectile(position, new Vector2(speedX, speedY), type, damage, knockBack, item.owner);
            Projectile pro = Main.projectile[p];
            pro.magic = false;
            pro.ranged = true;
            return false;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BeeGun);
            recipe.AddIngredient(mod, "RangedConverter");
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
