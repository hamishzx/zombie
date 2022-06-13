using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zombie
{
    
    public  class CharacterBaseAttr
    { 
        private int maxHP;
        private int moveSpeed;
        private int dmgDescValue;
        private string name;
        private int damage;

        /// <summary>
        /// See ICharacter.Attack() and related func for more information
        /// </summary>
        /// <param name="name">name</param>
        /// <param name="maxHP">maxHP</param>
        /// <param name="moveSpeed">moveSpeed</param>
        /// <param name="DmgDescValue">DamageDescentValue, see ICharacterAttr.TakeDamage()</param>
        /// <param name="damage">damage</param>
        public CharacterBaseAttr(string name, int maxHP, int moveSpeed,int DmgDescValue,int damage)
        {
            this.name = name;
            this.maxHP = maxHP;
            this.moveSpeed = moveSpeed;
            this.dmgDescValue = DmgDescValue;
            this.damage = damage;
        }
        public int MaxHP { get { return maxHP; } }
        public int MoveSpeed { get { return moveSpeed; } }
        public int DmgDescValue { get { return dmgDescValue; } }
        public string Name { get { return name; } }
        public int Damage { get { return damage; } }
    }
}
