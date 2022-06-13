#region << File Comment >>

/* ----------------------------------------------------------------
 * Author：Hamish Chengcheng Zou, hamish.zou@stu.hunau.edu.cn
 * Date&Time：11 June 2022, Saturday @00:55 GMT+8
 * ===============================================================
 * All scripts in this field is basically for course experiment use
 * It may direct problems if use outside specific environment
 * **NO** reference value
 * ----------------------------------------------------------------*/

#endregion

namespace Zombie
{
    public abstract class IEconomyHandler
    {
        private EconomySystem _economySystem;
        private IEconomyHandler _nextHandler;
        private int _raiseSpeed;

        public IEconomyHandler(EconomySystem economySystem, int raiseSpeed)
        {
            _economySystem = economySystem;
            _raiseSpeed = raiseSpeed;
        }

        public IEconomyHandler SetNextHandler(IEconomyHandler handler)
        {
            _nextHandler = handler;
            return _nextHandler;
        }

        protected virtual void Handle(int gold) { }
    }
}