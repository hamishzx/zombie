#region << File Comment >>

/* ----------------------------------------------------------------
 * Author：Hamish Chengcheng Zou, hamish.zou@stu.hunau.edu.cn
 * Date&Time：16 June 2022, Thursday @03:55 pm GMT+8
 * ===============================================================
 * All scripts in this field is basically for course experiment use
 * It may direct problems if use outside specific environment
 * **NO** reference value
 * ----------------------------------------------------------------*/

#endregion

namespace Zombie
{
    public class GameOverState : ISceneState
    {
        public GameOverState(string formty) : base(formty)
        {
            StartState();
        }

        public override void EndState()
        {
            myform.Close();
        }

        public override void Handle(SceneStateController context)
        {
            context.MState = new BattleState("Zombie.BattleForm");
        }

        public override void StartState()
        {
            myform.Visible = true;
        }
    }
}