using System;
using System.Windows.Forms;
using NeltharionRPGGame.Helper;

namespace NeltharionRPGGame.Structure
{
    public abstract class Character : Creature
    {
        protected Character(Position position, ObjectSize size, SpriteType spriteType)
            : base(position, size, spriteType)
        {
            this.Properties.Add(Property.Inventory, null);
        }

        public void DropWeapon(int indexInventory)
        {
            this.Properties[Property.Inventory][indexInventory] = null;
        }

        public Weapon[] Inventory { get; private set; }

        public override void Move()
        {
            Timer asd = new Timer();
            asd.Interval = 40;
            asd.Tick += TakeASingleStepToDestination;
            asd.Start();
        }

        private void TakeASingleStepToDestination(object obj, EventArgs e)
        {
            if (this.Position.X <= this.Direction.X - 30)
            {
                this.Position.X++;
            }

            if (this.Position.Y <= this.Direction.Y - 15)
            {
                this.Direction.Y++;
            }

            if (this.Position.X > this.Direction.X - 30)
            {
                this.Position.X--;
            }

            if (this.Position.Y > this.Direction.Y - 15)
            {
                this.Position.Y--;
            }
        }

        public override void UseWeaponHeld()
        {
        }

        public void pickWeapon(Weapon weapon)
        {
            for (int i = 0; i < this.Properties[Property.Inventory].Length; i++)
            {
                if (this.Properties[Property.Inventory][i] == null)
                {
                    this.Properties[Property.Inventory][i] = weapon;
                    break;
                }
            }
        }
    }
}
