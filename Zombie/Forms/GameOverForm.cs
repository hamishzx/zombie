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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zombie
{
    public partial class GameOverForm : Form
    {
        public GameOverForm()
        {
            InitializeComponent();
        }

        private void GameOverForm_Load(object sender, EventArgs e)
        {
            ControlBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SceneStateController.controll.Request("Zombie.MainMenuForm");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            SceneStateController.controll.Mainform.Close();
        }
    }
}
