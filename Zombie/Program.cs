using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

// TODO: 1.增加僵尸的种类 2.增加植物的种类 3.增加金钱系统
namespace Zombie
{
    public enum CharacterName
    {
        nZombie,
        nFlagZombie,
        nConeheadZombie,
        nBucketheadZombie,
        nPeashooter,
        nRepeater
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
