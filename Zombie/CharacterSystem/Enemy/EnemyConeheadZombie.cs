using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Zombie.Properties;


namespace Zombie
{
    class EnemyConeheadZombie : IEnemy
    {

        public EnemyConeheadZombie()
        {
            AtkRange = 11;
            attackimg = Resources.ConeheadZombieAttack;
            chaseimg = Resources.ConeheadZombie;
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
