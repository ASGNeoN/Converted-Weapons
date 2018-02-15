using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ConvertedWeapons.Items.Weapons
{
    public class MWaterGun : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Water Gun");
            Tooltip.SetDefault("Not so harmless anymore, works better in the rain!");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.WaterGun);
            item.ranged = false;
            item.magic = true;
            item.autoReuse = true;
            item.mana = 6;
            item.damage = 15;
            item.noMelee = true;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if (Main.raining) // or ProjectileID.WoodenArrowFriendly
            {
                item.mana = 0;
            }
            else
            {
                item.mana = 6;
            }
            int p = Projectile.NewProjectile(position, new Vector2(speedX, speedY), type, damage, knockBack, item.owner);
            Projectile pro = Main.projectile[p];
            pro.magic = true;
            pro.friendly = true;
            return false;
        }


        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.WaterGun);
            recipe.AddIngredient(mod, "MageConverter");
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
