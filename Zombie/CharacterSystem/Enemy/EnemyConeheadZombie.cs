using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;


namespace Zombie
{
    class EnemyConeheadZombie : IEnemy
    {

        public EnemyConeheadZombie()
        {
            AtkRange = 11;
            attackimg = "images/Zombies/ConeheadZombie/ConeheadZombieAttack.gif";
            chaseimg = "images/Zombies/ConeheadZombie/ConeheadZombie.gif";
            Image bm = Image.FromFile(chaseimg);
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
