using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*  TODO: Work as below
    1.增加僵尸的种类 Merged
    2.增加植物的种类 Merged
    3.增加金钱系统 Merged 
    4.僵尸移动至基地时可以攻击基地 Merged 
    5.游戏结束时切换界面 Merged*/

namespace Zombie
{
    public enum CharacterName
    {
        nZombie,
        nFlagZombie,
        nConeheadZombie,
        nBucketheadZombie,
        nPeashooter,
        nRepeater,
        nThreePeashooter
    }
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartForm());
        }
    }
}
