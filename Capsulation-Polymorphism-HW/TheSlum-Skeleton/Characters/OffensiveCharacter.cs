namespace TheSlum.Characters
{
    public abstract class OffensiveCharacter : Character
    {
        public int AttackPoints { get; set; }

        protected OffensiveCharacter(string id,
            int x,
            int y,
            int healthPoints,
            int defensePoints,
            Team team,
            int range,
            int attackPoints) 
            : base(id, x, y, healthPoints, defensePoints, team, range)
        {
            this.AttackPoints = attackPoints;
        }

        public override void AddToInventory(Item item)
        {
            this.Inventory.Add(item);
            this.ApplyItemEffects(item);
        }

        public override void RemoveFromInventory(Item item)
        {
            this.Inventory.Remove(item);
            this.RemoveItemEffects(item);
        }

        protected void ApplyItemEffects(Item item)
        {
            base.ApplyItemEffects(item);
            this.AttackPoints += item.AttackEffect;
        }

        protected override void RemoveItemEffects(Item item)
        {
            base.RemoveItemEffects(item);
            this.AttackPoints -= item.AttackEffect;
        }

        public override string ToString()
        {
            return string.Format("{0}, Attack: {1}", base.ToString(), AttackPoints);
        }
    }
}
