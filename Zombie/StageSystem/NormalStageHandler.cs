using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;


namespace Zombie
{
    public class NormalStageHandler : IStageHandler
    {
        private CharacterName mEnemyType;
        private int mCount;
        private Point mPosition;
        private float speed;
        private int mSpawnTime = 5;
        private float mSpawnTimer = 0;
        private int mCountSpawned = 0;
        
        /// <summary>
        /// Stage handler, Chain of Responsibility Pattern
        /// used to switch stage
        /// </summary>
        /// <param name="stageSystem">inherited from IGameSystem</param>
        /// <param name="lv">level</param>
        /// <param name="countToFinished">kill-count to finish current stage</param>
        /// <param name="et">enemy type</param>
        /// <param name="count">max enemy in stage</param>
        /// <param name="speed">enemy spawn time deduct on every UpdateStage()</param>
        public NormalStageHandler(StageSystem stageSystem, int lv, int countToFinished, CharacterName et, int count, float speed)
            : base(stageSystem, lv, countToFinished)
        {
            mEnemyType = et;
            mCount = count;
            mSpawnTimer = mSpawnTime;
            this.speed = speed;
        }
        protected override void UpdateStage()
        {
            base.UpdateStage();
            if (mCountSpawned < mCount)
            {
                mSpawnTimer -= speed;
                if (mSpawnTimer <= 0)
                {
                    SpawnEnemy();
                    mSpawnTimer = mSpawnTime;
                }
            }
        }
        void SpawnEnemy()
        {
            mCountSpawned++;
            int t;
            t=new Random().Next(0, GameFacade.Instance.enyrowPos.Length);
            mPosition = new Point(1300, GameFacade.Instance.enyrowPos[t]);
            switch (mEnemyType)
            {
                case CharacterName.nZombie:
                    FactoryManager.EnemyFactory.CreateCharacter<EnemyZombie>(mPosition,t, GameFacade.Instance.Currform);
                    break;
                case CharacterName.nConeheadZombie:
                    FactoryManager.EnemyFactory.CreateCharacter<EnemyConeheadZombie>(mPosition, t, GameFacade.Instance.Currform);
                    break;
                default:
                    break;
            }
        }
    }
}
