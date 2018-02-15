using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ConvertedWeapons.Projectiles
{
	public class MagicStarfury : ModProjectile
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("MStarfury");
        }

        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.Starfury);
            aiType = ProjectileID.Starfury;
            projectile.melee = false;
            projectile.magic = true;

        }

        public override bool PreKill(int timeLeft)
        {
            projectile.type = ProjectileID.Starfury;
            return true;
        }

    }
}
