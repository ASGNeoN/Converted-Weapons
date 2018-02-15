using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ConvertedWeapons.Items.Weapons.CalamityConverted
{
	public class TMeteorFist : ModItem
	{
        Mod Calamity = ModLoader.GetMod("CalamityMod");

        public override void SetStaticDefaults()
        {
            if (Calamity != null)
            {
                DisplayName.SetDefault("Meteor Fist");
            }
            else
            {
                DisplayName.SetDefault("Meteor Fist");
                Tooltip.SetDefault("Please enable Calamity");
            }
        }

        public override void SetDefaults()
        {
            if (Calamity != null)
            {
                item.CloneDefaults(ModLoader.GetMod("CalamityMod").ItemType("MeteorFist"));
                item.melee = false;
                item.thrown = true;
                item.autoReuse = true;
                item.useTime = 31;
                item.useAnimation = 31;
                item.damage = 15;
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
            if (Calamity != null)
            {
                ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModLoader.GetMod("CalamityMod").ItemType("MeteorFist"));
            recipe.AddIngredient(mod, "ThrowingConverter");
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
            }
        }
    }
}
