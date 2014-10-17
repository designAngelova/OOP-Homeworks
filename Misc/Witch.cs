using NeltharionRPGGame.Helper;
using NeltharionRPGGame.Structure;

namespace NeltharionRPGGame
{
    public class Witch : Enemy
    {
        public const int WitchSizeX = 70;
        public const int WitchSizeY = 70;
        public const int WitchHealthPoints = 300;
        public const int WitchDefensePoints = 50;
        public const int WitchAttackPoints = 150;
        public const int WitchMovementSpeed = 10;
        public const int WitchAttackRange = 250;
        public const SpriteType WitchSpriteType = SpriteType.Witch;

        public Witch(Position position)
            : base(position, new ObjectSize(WitchSizeX, WitchSizeY), WitchSpriteType)
        {
            this.Properties[Property.HealthPoints] = WitchHealthPoints;
            this.Properties[Property.DefensePoints] = WitchDefensePoints;
            this.Properties[Property.AttackPoints] = WitchAttackPoints;
            this.Properties[Property.MovementSpeed] = WitchMovementSpeed;
            this.Properties[Property.AttackRange] = WitchAttackRange;
        }

        public override NextMoveDecision DecideNextMove()
        {
            int decision = RandomGenerator.Next(0, 4);
            switch (decision)
            {
                case 0:
                    return NextMoveDecision.UseWeaponHeld;
                case 1:
                    return NextMoveDecision.Move;
                default:
                    return NextMoveDecision.None;
            }
        }
    }
}
