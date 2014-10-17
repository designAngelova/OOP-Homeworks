using System;
using NeltharionRPGGame.Helper;
using NeltharionRPGGame.Interfaces;

namespace NeltharionRPGGame.Structure
{
    public abstract class Enemy : Creature, IArtificialIntelligence
    {
        protected static Random RandomGenerator = new Random();

        protected Enemy(Position position, ObjectSize objectSize, SpriteType spriteType)
            : base(position, objectSize, spriteType)
        {
            this.Properties.Add(Property.BonusWeaponHeld, null);
        }

        public Weapon DropBonus()
        {
            return this.Properties[Property.BonusWeaponHeld];
        }

        public abstract NextMoveDecision DecideNextMove();

        public override void Move()
        {
            int nextRandomXPosition = RandomGenerator.Next(-1, 2);
            int nextRandomYPosition = RandomGenerator.Next(-1, 2);

            if ((this.Position.X + nextRandomXPosition) < (GlobalData.WindowWidth - this.Size.Y) &&
                this.Position.X + nextRandomXPosition > 0)
            {
                this.Direction.X = nextRandomXPosition;
            }
            else
            {
                this.Direction.X = 0;
            }

            if ((this.Position.Y + nextRandomYPosition) < (GlobalData.WindowHeight - this.Size.X) &&
                this.Position.Y + nextRandomYPosition > 0)
            {
                this.Direction.Y = nextRandomYPosition;
            }
            else
            {
                this.Direction.Y = 0;
            }
            
            base.Move();
        }
    }
}
