﻿using System;
using System.Collections.Generic;
using System.Text;


namespace Zombie
{
    class EnemyBuilder : ICharacterBuilder
    {
        public EnemyBuilder(ICharacter character, System.Type t, System.Drawing.Point spawnPosition,int posRow,object fm) : base(character, t, spawnPosition, posRow,fm)
        {

        }
        public override void AddCharacterAnimate()
        {
            AnimateImage image = new AnimateImage(mForm, mCharacter);
            mCharacter.MAnim = image;
        }

        public override void AddCharacterAttr()
        {
            CharacterBaseAttr attr = FactoryManager.AttrFactory.GetCharacterBaseAttr(mT);
            ICharacterAttr iattr = new ICharacterAttr(attr, attr.MaxHP);
            mCharacter.Attr = iattr;
            mCharacter.Position = mSpawnPosition;
            mCharacter.PosRow = mPosRow;
        }

        public override void AddInCharacterSystem()
        {
            GameFacade.Instance.AddEnemy(mCharacter as IEnemy);
        }

        public override ICharacter GetResult()
        {
            return mCharacter;
        }
    }
}
