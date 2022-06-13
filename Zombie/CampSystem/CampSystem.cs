using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;


namespace Zombie
{
    public class CampSystem:IGameSystem
    {
        private Dictionary<CharacterName, ICamp> mBotanyCamps = new Dictionary<CharacterName, ICamp>();
        public override void Init()
        {
            base.Init();
            InitCamp(CharacterName.nPeashooter);
            InitCamp(CharacterName.nRepeater);
            InitCamp(CharacterName.nThreePeashooter);
        }
        private void InitCamp(CharacterName botanyType)
        {
            // seems no use variable
            float trainTime = 0;
            switch (botanyType)
            {
                case CharacterName.nPeashooter:
                    trainTime = 3;
                    break;
                case CharacterName.nRepeater:
                    trainTime = 3;
                    break;
                case CharacterName.nThreePeashooter:
                    trainTime = 3;
                    break;
                default:
                    break;
            }
            ICamp camp = new ICamp(botanyType, trainTime);
            mBotanyCamps.Add(botanyType, camp);
        }
        public override void Update()
        {
            //更新所有兵营内部游戏逻辑
            foreach (ICamp camp in mBotanyCamps.Values)
            {
                camp.Update();
            }
        }
        public void SetCampCommand(CharacterName name,Point pt,int row)
        {
            mBotanyCamps[name].Train(pt,row);
        }
    }
}
