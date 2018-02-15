using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ConvertedWeapons.Items.Weapons
{
    public class RWaterGun : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Water Gun");
            Tooltip.SetDefault("Not so harmless anymore, requires snowballs and works better in the rain!");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.WaterGun);
            item.ranged = true;
            item.autoReuse = true;
            item.damage = 18;
            item.useAmmo = 949;
            item.noMelee = true;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if (Main.raining) // or ProjectileID.WoodenArrowFriendly
            {
                item.useAmmo = 0;
            }
            else
            {
                item.useAmmo = 949;
            }
            if (type != ProjectileID.WaterGun) // or ProjectileID.WoodenArrowFriendly
            {
                type = ProjectileID.WaterGun; // or ProjectileID.FireArrow;
            }
            int p = Projectile.NewProjectile(position, new Vector2(speedX, speedY), type, damage, knockBack, item.owner);
            Projectile pro = Main.projectile[p];
            pro.ranged = true;
            pro.friendly = true;
            return false;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.WaterGun);
            recipe.AddIngredient(mod, "RangedConverter");
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
