using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ConvertedWeapons.Items.Weapons.ThoriumConverted
{
	public class TSpearmint : ModItem
	{
        Mod Thorium = ModLoader.GetMod("ThoriumMod");

        public override void SetStaticDefaults()
        {
            if (Thorium != null)
            {
                DisplayName.SetDefault("Spearmint");
            }
            else
            {
                DisplayName.SetDefault("Spearmint");
                Tooltip.SetDefault("Please enable Thorium");
            }
        }

        public override void SetDefaults()
        {
            if (Thorium != null)
            {
                item.CloneDefaults(ModLoader.GetMod("ThoriumMod").ItemType("Spearmint"));
                item.melee = false;
                item.thrown = true;
                item.autoReuse = true;
                item.noMelee = true; //so the item's animation doesn't do damage
                item.autoReuse = true;
            }

        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int p = Projectile.NewProjectile(position, new Vector2(speedX, speedY), type, damage, knockBack, item.owner);
            Projectile pro = Main.projectile[p];
            pro.melee = false;
            pro.thrown = true;
            return false;
        }
        public override void AddRecipes()
        {
            if (Thorium != null)
            {
                ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModLoader.GetMod("ThoriumMod").ItemType("Spearmint"));
            recipe.AddIngredient(mod, "ThrowingConverter");
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
            }
        }
    }
}
