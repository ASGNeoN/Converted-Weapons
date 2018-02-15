using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ConvertedWeapons.Projectiles
{
	public class LaserBullet : ModProjectile
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("LaserBullet");
        }
        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.PurpleLaser);
			projectile.ranged = true;
            projectile.magic = false;
            aiType = ProjectileID.PurpleLaser;			
			
        }
	
	}
}
