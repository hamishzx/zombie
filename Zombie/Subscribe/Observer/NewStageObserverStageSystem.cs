#region << File Comment >>

/*----------------------------------------------------------------
// Author：Hamish Chengcheng Zou, hamish.zou@stu.hunau.edu.cn
// Date&Time：09 Jun 2022, Thursday @12:47 GMT+8
//===============================================================
// All scripts in this field is basically for course experiment use
// It may direct problems if use outside specific environment
// **NO** reference value
//----------------------------------------------------------------*/

#endregion

namespace Zombie
{
    public class NewStageObserverStageSystem : IObserver
    {
        private NewStageSubject _subject;
        private readonly StageSystem _stageSystem;
        public NewStageObserverStageSystem(StageSystem ss)
        {
            _stageSystem = ss;
        }

        public void Update()
        {
            _stageSystem.CountOfEnemyKilledBefore = _subject.KilledPerStage;
        }

        public void SetSubject(ISubject sub)
        {
            _subject = sub as NewStageSubject;
        }
    }
}