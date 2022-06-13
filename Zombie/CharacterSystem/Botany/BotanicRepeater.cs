using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Zombie.Properties;


namespace Zombie
{
    /// <summary>
    /// This is a historically reserved class name, BotanicRepeater is its original name
    /// However, it should be the class stand for peashooter not repeater, hence edited class content but name
    /// </summary>
    class BotanicRepeater : IBotany
    {
        private Point des;

        public BotanicRepeater()
        {
            idleimg = Resources.Peashooter;
            imgwidth = idleimg.Width;
            imgheight = idleimg.Height;
            des = new Point();
        }
        protected override void PlayEffect()
        {
            throw new NotImplementedException();
        }
        public override void Attack(ICharacter target)
        {
            //System.Diagnostics.Debug.Assert(false, "生产子弹");
            des.X = Position.X + imgwidth / 2;
            des.Y = Position.Y;
            GameFacade.Instance.GetBullet(typeof(SingleBullet), des, new Point(1300, Position.Y), GameFacade.Instance.Currform);
        }
        protected override void PlaySound()
        {
            throw new NotImplementedException();
        }
    }
}
