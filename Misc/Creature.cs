﻿using System.Collections.Generic;
using System.Drawing;
using NeltharionRPGGame.Helper;
using NeltharionRPGGame.Structure;

namespace NeltharionRPGGame
{
    public abstract class Creature : GameObject, IMovable
    {
        protected const int AttackPointsCap = 5000;
        protected const int DefensePointsCap = 5000;
        protected const int MovementSpeedCap = 1000;
        protected const int AttackRangeCap = 500;

        public Dictionary<Property, dynamic> Properties;

        protected Creature(Position position, ObjectSize size,
            SpriteType spriteType)
            : base(position, size, spriteType)
        {
            Properties = new Dictionary<Property, dynamic>()
            {
                {Property.MaxHealthPoints, null},
                {Property.HealthPoints, null},
                {Property.DefensePoints, null},
                {Property.AttackPoints, null},
                {Property.AttackRange, null},
                {Property.IsAlive, true},
                {Property.MovementSpeed, null},
                {Property.WeaponHeld, null}
            };
        }

        public Direction Direction { get; set; }

        public virtual void Move()
        {
            this.Position.X += this.Direction.X * Properties[Property.MovementSpeed];
            this.Position.Y += this.Direction.Y * Properties[Property.MovementSpeed];
        }

        public virtual void UseWeaponHeld()
        {
        }

        // The value for this method is generated by
        // the Combat system
        public virtual void UpdateHealthPoints(int healthPointsEffect)
        {
            this.Properties[Property.HealthPoints] += healthPointsEffect;
        }

        public virtual void UpdateDefencePoints(int defencePoints)
        {
            this.Properties[Property.DefensePoints] += defencePoints;
        } 
    }
}
                                   