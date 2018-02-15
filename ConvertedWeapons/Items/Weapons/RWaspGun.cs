using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ConvertedWeapons.Items.Weapons
{
    public class RWaspGun : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Wasp Gun");
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.WaspGun);
            item.magic = false;
            item.autoReuse = true;
            item.ranged = true;
            item.useAmmo = AmmoID.Bullet;
            item.mana = 0;
            item.damage = 25;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if (type != ProjectileID.Wasp) // or ProjectileID.WoodenArrowFriendly
            {
                type = ProjectileID.Wasp; // or ProjectileID.FireArrow;
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
            recipe.AddIngredient(ItemID.WaspGun);
            recipe.AddIngredient(mod, "RangedConverter");
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
