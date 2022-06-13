#region << File Comment >>

/* ----------------------------------------------------------------
 * Author：Hamish Chengcheng Zou, hamish.zou@stu.hunau.edu.cn
 * Date&Time：10 Jun 2022, Friday @19:06 GMT+8
 * ===============================================================
 * All scripts in this field is basically for course experiment use
 * It may direct problems if use outside specific environment
 * **NO** reference value
 * ===============================================================
 * Economy System main class, using Flyweight Pattern
 * ----------------------------------------------------------------*/

#endregion

using System.Collections.Generic;

namespace Zombie.EconomySystem
{
    public enum EcoEventType
    {
        AutoRaise,
        CreateBotany
    }
    class EconomySystem : IGameSystem
    {
        private Dictionary<EcoEventType, ISubject> _ecoEvents = new Dictionary<EcoEventType, ISubject>();

        public override void Init()
        {
            base.Init();
        }
        
        
    }
}