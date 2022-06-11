using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Zombie.Properties;


namespace Zombie
{
    class EnemyZombie : IEnemy
    {
        
        public EnemyZombie()
        {
            AtkRange = 10;
            attackimg = Resources.ZombieAttack;
            chaseimg = Resources.Zombie;
            Image bm = chaseimg;
            base.imgheight = bm.Height;
            base.imgwidth = bm.Width;
            bm.Dispose();
        }
        public override void PlayEffect()
        {
            throw new NotImplementedException();
        }
    }
}
