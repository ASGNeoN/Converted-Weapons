using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ConvertedWeapons.Items.Weapons.ThoriumConverted
{
	public class MSoulSiphon : ModItem
	{
        Mod Thorium = ModLoader.GetMod("ThoriumMod");

        public override void SetStaticDefaults()
        {
            if (Thorium != null)
            {
                DisplayName.SetDefault("Soul Siphon");
            }
            else
            {
                DisplayName.SetDefault("Soul Siphon");
                Tooltip.SetDefault("Please enable Thorium");
            }
        }

        public override void SetDefaults()
        {
            if (Thorium != null)
            {
                item.CloneDefaults(ModLoader.GetMod("ThoriumMod").ItemType("eeSoulSiphon"));
                item.melee = false;
                item.magic = true;
                item.autoReuse = true;
            }

        }
        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            player.statMana += (int)damage / 4;
            player.ManaEffect((int)damage / 4);
        }
        public override void AddRecipes()
        {
            if (Thorium != null)
            {
                ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModLoader.GetMod("ThoriumMod").ItemType("eeSoulSiphon"));
            recipe.AddIngredient(mod, "MageConverter");
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
            }
        }
    }
}
