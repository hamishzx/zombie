using System;
using System.Collections.Generic;
using System.Text;


namespace Zombie
{
    public class StageSystem: IGameSystem
    {
        int mLv = 1;
        private int mCountOfEnemyKilled=0;
        private int _houseHP = 0;
        IStageHandler mRootHandler;

        public int CountOfEnemyKilledBefore { get; set; } = 0;

        public int countOfEnemyKilled
        {
            set
            {
                mCountOfEnemyKilled = value;
            }
        }

        public int houseHP
        {
            get => _houseHP;
            set => _houseHP = value;
        }
        
        public override void Init()
        {
            base.Init();
            InitStageChain();
            mFacade.RegisterObserver(GameEventType.EnemyKilled, new EnemyKilledObserverStageSystem(this));
            mFacade.RegisterObserver(GameEventType.NewStage, new NewStageObserverStageSystem(this));
        }

        public override void Update()
        {
            base.Update();
            mRootHandler.Handle(mLv);
        }

        private void InitStageChain()
        {
            // ALWAYS REMEMBER TO ADD countToFinished TO NewStageSubject._killedPerStage
            int lv = 1;
            NormalStageHandler handler1 = new NormalStageHandler(this, lv++, 3, CharacterName.nZombie, 6, 0.05f);
            NormalStageHandler handler2 = new NormalStageHandler(this, lv++, 6, CharacterName.nConeheadZombie, 12, 0.1f);
            NormalStageHandler handler3 = new NormalStageHandler(this, lv++, 100, CharacterName.nZombie, 100, 1f);


            handler1.SetNextHandler(handler2)
                .SetNextHandler(handler3);
            mRootHandler = handler1;

            houseHP = 200;
        }
        public int CountOfEnemyKilled
        {
            set
            {
                mCountOfEnemyKilled = value;
            }
        }
        public int GetCountOfEnemyKilled()
        {
            return mCountOfEnemyKilled;
        }
        public void EnterNextStage()
        {
            
            mLv++;
            GameFacade.Instance.NotifySubject(GameEventType.NewStage);
           // mFacade.NotifySubject(GameEventType.NewStage);
        }

        public int GetHouseHP()
        {
            return houseHP;
        }
    }
}
