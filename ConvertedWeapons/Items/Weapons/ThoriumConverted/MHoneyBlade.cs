using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ConvertedWeapons.Items.Weapons.ThoriumConverted
{
	public class MHoneyBlade : ModItem
	{
        Mod Thorium = ModLoader.GetMod("ThoriumMod");

        public override void SetStaticDefaults()
        {
            if (Thorium != null)
            {
                DisplayName.SetDefault("Honey Blade");
            }
            else
            {
                DisplayName.SetDefault("Honey Blade");
                Tooltip.SetDefault("Please enable Thorium");
            }
        }

        public override void SetDefaults()
        {
            if (Thorium != null)
            {
                item.CloneDefaults(ModLoader.GetMod("ThoriumMod").ItemType("HoneyBlade"));
                item.summon = false;
                item.melee = true;
                item.mana = 0;
                item.damage = 32;
                item.autoReuse = true;
            }

        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int p = Projectile.NewProjectile(position, new Vector2(speedX, speedY), type, damage, knockBack, item.owner);
            Projectile pro = Main.projectile[p];
            pro.minion = false;
            pro.melee = true;
            return false;
        }

        public override void AddRecipes()
        {
            if (Thorium != null)
            {
                ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModLoader.GetMod("ThoriumMod").ItemType("HoneyBlade"));
            recipe.AddIngredient(mod, "MeleeConverter");
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
            }
        }
    }
}
