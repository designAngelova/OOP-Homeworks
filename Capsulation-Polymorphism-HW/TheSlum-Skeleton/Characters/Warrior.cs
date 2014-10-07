using System.Collections.Generic;
using System.Linq;
using TheSlum.Interfaces;

namespace TheSlum.Characters
{
    public class Warrior : OffensiveCharacter, IAttack
    {
        public Warrior(string id, int x, int y, Team team)
            : base(id, x, y, 80, 50, team, 10, 50)
        {
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            return targetsList.Where(c => c.IsAlive && c.Team != this.Team).FirstOrDefault();
        }
    }
}
