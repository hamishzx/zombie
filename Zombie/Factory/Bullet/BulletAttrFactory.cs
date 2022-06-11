using System;
using System.Collections.Generic;
using System.Text;
using Zombie.Properties;


namespace Zombie
{
    public class BulletAttrFactory
    {
        private Dictionary<Type, BulletBaseAttr> mBulletBaseAttrDict;
        public BulletAttrFactory()
        {
            InitBulletBaseAttr();
        }
        private void InitBulletBaseAttr()
        {
            mBulletBaseAttrDict = new Dictionary<Type, BulletBaseAttr>();
            mBulletBaseAttrDict.Add(typeof(SingleBullet), new BulletBaseAttr(Bulletype.single,25, 10, 0, Resources.SingleBullet, Resources.PeaBulletHit));
            mBulletBaseAttrDict.Add(typeof(DoubleBullet), new BulletBaseAttr(Bulletype.doubleBlt, 25, 20, 0, Resources.DoubleBullet, Resources.PeaBulletHit));
            mBulletBaseAttrDict.Add(typeof(TripleBullet), new BulletBaseAttr(Bulletype.triple, 25, 35, 0, Resources.TripleBullet, Resources.PeaBulletHit));
        }
        public BulletBaseAttr GetCharacterBaseAttr(Type t)
        {
            if (mBulletBaseAttrDict.ContainsKey(t) == false)
            {
                return null;
            }
            return mBulletBaseAttrDict[t];
        }
    }
}
