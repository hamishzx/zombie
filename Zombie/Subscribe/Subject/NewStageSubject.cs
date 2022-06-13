#region << File Comment >>

/* ----------------------------------------------------------------
 * Author：Hamish Chengcheng Zou, hamish.zou@stu.hunau.edu.cn
 * Date&Time：09 Jun 2022, Thursday @11:31 GMT+8
 * ===============================================================
 * All scripts in this field is basically for course experiment use
 * It may direct problems if use outside specific environment
 * **NO** reference value
 * ----------------------------------------------------------------*/

#endregion

namespace Zombie
{
    class NewStageSubject : ISubject
    {
        private int _currStage = 1;
        private int _killedCountBefore = 0;
        private readonly int[] _killedPerStage = new[] { 3, 6, 100 };

        public int KilledPerStage
        {
            get
            {
                _killedCountBefore = 0;
                for (int i = 1; i < _currStage; i++)
                {
                    _killedCountBefore += _killedPerStage[i-1];
                }
                return _killedCountBefore;
            }
        }
        public override void Notify()
        {
            _currStage++;
            base.Notify();
        }
    }
}