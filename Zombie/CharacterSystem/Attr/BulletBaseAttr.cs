using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;


namespace Zombie
{
    public enum Bulletype
    {
        single,
        doubleBlt,
        triple
    }
    public class BulletBaseAttr
    {
        private int moveSpeed;
        private int damage;
        private int range;
        private Bitmap flyimg;
        private Bitmap boomimg;
        private Bulletype mtype;

        public BulletBaseAttr(Bulletype itype,int speed,int damage,int range,Bitmap flyimg,Bitmap boomimg)
        {
            this.mtype = itype;
            this.moveSpeed = speed;
            this.damage = damage;
            this.range = range;
            this.flyimg = flyimg;
            this.boomimg = boomimg;
        }

        public Bitmap Flyimg
        {
            get
            {
                return flyimg;
            }
        }

        public Bitmap Boomimg
        {
            get
            {
                return boomimg;
            }
        }

        public int MoveSpeed
        {
            get
            {
                return moveSpeed;
            }
        }

        public int Damage
        {
            get
            {
                return damage;
            }
        }

        public int Range
        {
            get
            {
                return range;
            }
        }
    }
}
