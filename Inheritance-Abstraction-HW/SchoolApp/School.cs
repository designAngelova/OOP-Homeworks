using System.Collections.Generic;
using Microsoft.SqlServer.Server;

namespace SchoolApp
{
    public class School : INameable
    {
        private string name;
        private ICollection<Class> classes;

        public School()
        {
            this.classes = new SortedSet<Class>();
        }

        public ICollection<Class> Classes { get; private set; }
        public string Name { get; set; }
    }
}
