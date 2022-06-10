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
        private readonly EconomySystem _economySystem;
        private readonly int _raiseSpeed;
        protected IEconomyState(EconomySystem economySystem, int raiseSpeed, int switchBorder)
        {
            _economySystem = economySystem;
            _raiseSpeed = raiseSpeed;
        }

        protected abstract void StartState();

        protected abstract void EndState();

        private void RaiseEconomy()
        {
            _economySystem.currGold += _raiseSpeed;
        }

        protected void Handle(bool ready)
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