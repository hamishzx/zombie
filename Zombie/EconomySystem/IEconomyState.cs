#region << File Comment >>

/* ----------------------------------------------------------------
 * Author：Hamish Chengcheng Zou, hamish.zou@stu.hunau.edu.cn
 * Date&Time：11 June 2022, Saturday @02:30 GMT+8
 * ===============================================================
 * All scripts in this field is basically for course experiment use
 * It may direct problems if use outside specific environment
 * **NO** reference value
 * ----------------------------------------------------------------*/

#endregion

namespace Zombie
{
    public abstract class IEconomyState
    {
        protected readonly EconomySystem _economySystem;
        protected readonly int _raiseSpeed;
        protected readonly int _switchBorder;
        protected IEconomyState(EconomySystem economySystem, int raiseSpeed, int switchBorder)
        {
            _economySystem = economySystem;
            _raiseSpeed = raiseSpeed;
            _switchBorder = switchBorder;
        }

        protected abstract void StartState();

        protected abstract void EndState();

        private void RaiseEconomy()
        {
            _economySystem.currGold += _raiseSpeed;
        }

        public void Handle(bool ready)
        {
            if (ready)
            {
                RaiseEconomy();
                CheckIsReady();
            }
            else
            {
                _economySystem.currState.EndState();
            }
        }

        protected abstract void CheckIsReady();
    }
}