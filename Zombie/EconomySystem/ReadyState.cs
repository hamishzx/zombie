﻿#region << File Comment >>

/* ----------------------------------------------------------------
 * Author：Hamish Chengcheng Zou, hamish.zou@stu.hunau.edu.cn
 * Date&Time：11 June 2022, Saturday @02:56 GMT+8
 * ===============================================================
 * All scripts in this field is basically for course experiment use
 * It may direct problems if use outside specific environment
 * **NO** reference value
 * ----------------------------------------------------------------*/

#endregion

namespace Zombie
{
    public class ReadyState : IEconomyState
    {
        public ReadyState(EconomySystem economySystem, int raiseSpeed, int switchBorder) : base(economySystem,
            raiseSpeed, switchBorder) { }

        protected override void StartState()
        {
            throw new System.NotImplementedException();
        }

        protected override void EndState(EconomyStateController controller)
        {
            controller.currEconomyState = new ProducingState(_economySystem, 5, 100);
        }

        protected override void CheckSwitchState(EconomyStateController controller)
        {
            if (_economySystem.currGold < _switchBorder)
            {
                EndState(controller);
            }
        }
    }
}