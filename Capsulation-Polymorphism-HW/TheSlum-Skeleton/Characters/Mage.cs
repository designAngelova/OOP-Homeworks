using System.Linq;
using TheSlum.Interfaces;

namespace TheSlum.Characters
{
    public class Mage : OffensiveCharacter, IAttack
    {
        public Mage(string id, int x, int y, Team team) 
            : base(id, x, y, 40, 30, team, 40, 60)
        {
        }

        public override Character GetTarget(System.Collections.Generic.IEnumerable<Character> targetsList)
        {
            return targetsList.Where(c => c.IsAlive && c.Team != this.Team).LastOrDefault();
        }   
    }
}
