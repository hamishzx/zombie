#region << File Comment >>

/* ----------------------------------------------------------------
 * Author：Hamish Chengcheng Zou, hamish.zou@stu.hunau.edu.cn
 * Date&Time：10 Jun 2022, Friday @00:59 GMT+8
 * ===============================================================
 * All scripts in this field is basically for course experiment use
 * It may direct problems if use outside specific environment
 * **NO** reference value
 * ----------------------------------------------------------------*/

#endregion

using System;
using System.Drawing;
using Zombie.Properties;

namespace Zombie
{
    class Repeater : IBotany
    {
        private Point _point;

        public Repeater()
        {
            idleimg = Resources.Repeater;
            imgwidth = idleimg.Width;
            imgheight = idleimg.Height;
            _point = new Point();
        }

        public override void Attack(ICharacter target)
        {
            _point.X = Position.X + imgwidth / 2;
            _point.Y = Position.Y;
            GameFacade.Instance.GetBullet(typeof(DoubleBullet), _point, new Point(1300, Position.Y), GameFacade.Instance.Currform);
        }

        protected override void PlaySound()
        {
            throw new NotImplementedException();
        }

        protected override void PlayEffect()
        {
            throw new NotImplementedException();
        }
    }
}