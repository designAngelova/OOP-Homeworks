using System;
using System.Collections.Generic;
using TheSlum.Interfaces;

namespace TheSlum.Characters
{
    public class Healer : Character, IHeal
    {
        public int HealingPoints { get; set; }

        public Healer(string id, int x, int y, Team team)
            : base(id, x, y, 40, 30, team, 30)
        {
            this.HealingPoints = 50;
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            Character optimalHealTarget = null;
            int leastHealthAmount = int.MaxValue;

            foreach (var character in targetsList)
            {
                if (character.HealthPoints < leastHealthAmount &&
                    character.Team == this.Team &&
                    character.IsAlive)
                {
                    optimalHealTarget = character;
                    leastHealthAmount = character.HealthPoints;
                }
            }

            return optimalHealTarget;
        }

        public override void AddToInventory(Item item)
        {
            this.Inventory.Add(item);
            base.ApplyItemEffects(item);
        }

        public override void RemoveFromInventory(Item item)
        {
            this.Inventory.Remove(item);
            base.RemoveItemEffects(item);
        }

        public override string ToString()
        {
            return string.Format("{0}, Healing: {1}", base.ToString(), HealingPoints);
        }
    }
}
