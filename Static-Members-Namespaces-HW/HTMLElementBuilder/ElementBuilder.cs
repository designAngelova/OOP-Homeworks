using System;
using System.Linq;
using System.Text;

namespace HTMLElementBuilder  
{
    public class ElementBuilder : IElementBuilder
    {
        private StringBuilder element;
        private string name;
        private bool isWithClosing;

        public ElementBuilder(string name, bool isWithClosing)
        {
            this.Name = name;
            this.element = new StringBuilder('<' + this.Name + (isWithClosing ? "></" + name + ">" : "/>"));
            this.isWithClosing = isWithClosing;
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Element name cannot be empty", "name");
                }

                this.name = value;
            }
        }

        public void AddAtribute(string attribute, string value)
        {
            int idx = isWithClosing ? this.element.ToString().IndexOf('>') : this.element.ToString().IndexOf("/>");

            this.element.Insert(idx, " " + attribute + "=\"" + value + "\"");
        }

        public void AddContent(string content)
        {
            if (this.isWithClosing)
            {
                int idx = this.element.ToString().LastIndexOf('<');
                this.element.Insert(idx, content);
            }
            else
            {
                Console.WriteLine("Cannot add content to {0} tag", this.name);
            }
        }

        private static string Repeat(StringBuilder str, int n)
        {
            return Enumerable.Repeat(str, n)
                .Aggregate((sb, s) => sb.Append(s))
                .ToString();
        }

        public static string operator *(ElementBuilder elementObj, int n)
        {
            return Repeat(elementObj.element, n);
        }

        public override string ToString()
        {
            return this.element.ToString();
        }
    }
}
