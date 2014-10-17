using NeltharionRPGGame.Helper;
using NeltharionRPGGame.Structure;

namespace NeltharionRPGGame
{
    public class Mage : Character
    {
        public const int MageSizeX = 70;
        public const int MageSizeY = 70;
        public const int MageHealthPoints = 300;
        public const int MageDefensePoints = 50;
        public const int MageAttackPoints = 150;
        public const int MageMovementSpeed = 10;
        public const int MageAttackRange = 250;
        public const SpriteType MageSpriteType = SpriteType.Mage;

        public Mage(Position position)
            : base(position, new ObjectSize(MageSizeX, MageSizeY), MageSpriteType)
        {
            this.Properties[Property.HealthPoints] = MageHealthPoints;
            this.Properties[Property.DefensePoints] = MageDefensePoints;
            this.Properties[Property.AttackPoints] = MageAttackPoints;
            this.Properties[Property.MovementSpeed] = MageMovementSpeed;
            this.Properties[Property.AttackRange] = MageAttackRange;
            this.Properties[Property.Inventory] = new Weapon[3];
        }
    }
}
