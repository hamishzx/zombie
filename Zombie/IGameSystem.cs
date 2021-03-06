using System;
using System.Collections.Generic;
using System.Text;


namespace Zombie
{
    public class IGameSystem
    {
        protected GameFacade mFacade;
        public virtual void Init()
        {
            mFacade = GameFacade.Instance;
        }
        public virtual void Update() { }
        public virtual void Release() { }
    }
}
