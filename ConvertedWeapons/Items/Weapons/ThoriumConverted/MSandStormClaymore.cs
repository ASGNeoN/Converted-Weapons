using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ConvertedWeapons.Items.Weapons.ThoriumConverted
{
	public class MSandStormClaymore : ModItem
	{
        Mod Thorium = ModLoader.GetMod("ThoriumMod");

        public override void SetStaticDefaults()
        {
            if (Thorium != null)
            {
                DisplayName.SetDefault("Sand Storm Claymore");
            }
            else
            {
                DisplayName.SetDefault("Sand Storm Claymore");
                Tooltip.SetDefault("Please enable Thorium");
            }
        }

        public override void SetDefaults()
        {
            if (Thorium != null)
            {
                item.CloneDefaults(ModLoader.GetMod("ThoriumMod").ItemType("SandStormClaymore"));
                item.melee = false;
                item.magic = true;
                item.mana = 8;
                item.damage = 12;
                item.autoReuse = true;
            }

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
            if (Thorium != null)
            {
                ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModLoader.GetMod("ThoriumMod").ItemType("SandStormClaymore"));
            recipe.AddIngredient(mod, "MageConverter");
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
            }
        }
    }
}
