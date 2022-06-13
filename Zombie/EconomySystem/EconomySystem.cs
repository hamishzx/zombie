#region << File Comment >>

/* ----------------------------------------------------------------
 * Author：Hamish Chengcheng Zou, hamish.zou@stu.hunau.edu.cn
 * Date&Time：10 Jun 2022, Friday @19:06 GMT+8
 * ===============================================================
 * All scripts in this field is basically for course experiment use
 * It may direct problems if use outside specific environment
 * **NO** reference value
 * ===============================================================
 * Economy System main class, using State Pattern
 * ----------------------------------------------------------------*/

#endregion

using System.Collections.Generic;

namespace Zombie
{
    public class EconomySystem : IGameSystem
    {
        private int _currGold = 0;
        private IEconomyState _currState;
        public int currGold
        {
            get => _currGold;
            set => _currGold = value;
        }

        public IEconomyState currState
        {
            get => _currState;
            set => _currState = value;
        }
        
        public override void Init()
        {
            base.Init();
            InitEconomyChain();
        }

        public void InitEconomyChain()
        {
            
        }

        public void raiseGold(int qty)
        {
            currGold += qty;
        }

        public void deductGold(int qty)
        {
            currGold -= qty;
        }

        public void GoldIsEnough()
        {
            
        }
    }
}