#region << File Comment >>

/* ----------------------------------------------------------------
 * Author：Hamish Chengcheng Zou, hamish.zou@stu.hunau.edu.cn
 * Date&Time：10 Jun 2022, Friday @01:28 GMT+8
 * ===============================================================
 * All scripts in this field is basically for course experiment use
 * It may direct problems if use outside specific environment
 * **NO** reference value
 * ----------------------------------------------------------------*/

#endregion

using System;
using System.Drawing;

namespace Zombie
{
    class ThreePeashooter : IBotany
    {
        private Point _point;

        public ThreePeashooter()
        {
            idleimg = "images/Plants/Threepeater/Threepeater.gif";
            Image img = Image.FromFile(idleimg);
            imgwidth = img.Width;
            imgheight = img.Height;
            _point = new Point();
        }

        public override void Attack(ICharacter target)
        {
            _point.X = Position.X + imgwidth / 2;
            _point.Y = Position.Y;
            GameFacade.Instance.GetBullet(typeof(TripleBullet), _point, new Point(1300, Position.Y), GameFacade.Instance.Currform);
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