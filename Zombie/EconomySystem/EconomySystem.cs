#region << File Comment >>

/* ----------------------------------------------------------------
 * Author：Hamish Chengcheng Zou, hamish.zou@stu.hunau.edu.cn
 * Date&Time：10 Jun 2022, Friday @19:06 GMT+8
 * ===============================================================
 * All scripts in this field is basically for course experiment use
 * It may direct problems if use outside specific environment
 * **NO** reference value
 * ===============================================================
 * Economy System main class, the system is using State Pattern
 * ----------------------------------------------------------------*/

#endregion

namespace Zombie
{
    public class EconomySystem : IGameSystem
    {
        private EconomyStateController _controller;
        private int _currGold;
        private IEconomyState _initState;

        public int currGold
        {
            get => _currGold;
            set => _currGold = value;
        }

        public override void Init()
        {
            base.Init();
            InitEconomy();
        }

        public override void Update()
        {
            base.Update();
            _controller.Request();
        }

        private void InitEconomy()
        {
            currGold = 300;
            _initState = new ReadyState(this, 10, 100);
            _controller = new EconomyStateController(_initState);
        }

        public void deductGold(int qty)
        {
            currGold -= qty;
        }

        public bool GoldIsEnough(int economyCost)
        {
            return currGold >= economyCost;
        }
    }
}