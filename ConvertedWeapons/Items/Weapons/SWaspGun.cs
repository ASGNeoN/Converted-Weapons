using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ConvertedWeapons.Items.Weapons
{
    public class SWaspGun : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Wasp Gun");
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.BeeGun);
            item.magic = false;
            item.summon = true;
            item.autoReuse = true;
            item.crit = 0;
            item.knocback = 0;

        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int p = Projectile.NewProjectile(position, new Vector2(speedX, speedY), type, damage, knockBack, item.owner);
            Projectile pro = Main.projectile[p];
            pro.magic = false;
            pro.minion = true;
            return false;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.WaspGun);
            recipe.AddIngredient(mod, "SummonConverter");
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
