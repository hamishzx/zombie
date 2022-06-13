using System;
using System.Collections.Generic;
using System.Text;


namespace Zombie
{
    public class AttrFactory : IAttrFactory
    {
        private Dictionary<Type, CharacterBaseAttr> mCharacterBaseAttrDict;
        public AttrFactory()
        {
            InitCharacterBaseAttr();
        }
        private void InitCharacterBaseAttr()
        {
            mCharacterBaseAttrDict = new Dictionary<Type, CharacterBaseAttr>();
            mCharacterBaseAttrDict.Add(typeof(EnemyZombie), new CharacterBaseAttr("丧尸", 100, 2, 10, 20));
            mCharacterBaseAttrDict.Add(typeof(EnemyConeheadZombie), new CharacterBaseAttr("路障僵尸", 100, 3, 15, 30));
            mCharacterBaseAttrDict.Add(typeof(BotanicRepeater), new CharacterBaseAttr("豌豆射手", 100, 2, 5, 25));   
            mCharacterBaseAttrDict.Add(typeof(Repeater), new CharacterBaseAttr("双发射手", 150, 2, 5, 30));
            mCharacterBaseAttrDict.Add(typeof(ThreePeashooter), new CharacterBaseAttr("三发射手", 200, 2, 5, 40));
        }
        public CharacterBaseAttr GetCharacterBaseAttr(Type t)
        {
            if (mCharacterBaseAttrDict.ContainsKey(t) == false)
            {
               return null;
            }
            return mCharacterBaseAttrDict[t];
        }
    }
}
