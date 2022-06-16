using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Zombie
{
    public class SceneStateController
    {
        private ISceneState mState;
        private Form mainform;
        private string _targetForm;
        public static SceneStateController controll;
        public ISceneState MState { get => mState; set => mState = value; }
        public Form Mainform { get => mainform; set => mainform = value; }
        
        public string targetForm
        {
            get => _targetForm;
            set => _targetForm = value;
        }

        public SceneStateController(ISceneState state)
        {
            this.MState = state;
        }
        public void Request(string target)
        {
            targetForm = target;
            if (mState != null)
            {
                mState.EndState();
            }
            
            mState?.Handle(this);
        }
    }
}
