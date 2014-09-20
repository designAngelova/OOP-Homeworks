using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using HTMLDispatcher;

class ElementBuilder
{
    private StringBuilder element;
    private string elementName;
    private Dictionary<string, string> elementAttributes;
    private string content;

    public ElementBuilder(string name, string content = "")
    {
        this.Element = new StringBuilder("<" + name + ">" + content + "</" + name + ">");
        this.ElementName = name;
        this.content = content;
        elementAttributes = new Dictionary<string, string>();
    }

    public string ElementName
    {
        get { return elementName; }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("elementName", "Please enter a correct html tag");
            }
        }
    }

    public StringBuilder Element
    {
        get { return element; }
        private set { element = value; }
    }

    public string Content
    {
        get { return content; }
        private set { content = value; }
    }

    public static string[] GetAllTags()
    {
        string allTags = File.ReadAllText("html-tags.txt");
        return allTags.Split(new string[] {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries);
    }

    public void AddAttribute(string attribute, string value)
    {
        //if performance is important for the project use char loop instead it`s a lot faster!
        int attrIndex = this.element.ToString().IndexOf(">");
        this.element.Insert(attrIndex, " " + attribute + "=\"" + value + "\"");
    }

    public void AddContent(string content)
    {
        int contentIndex = this.element.ToString().IndexOf("<", 1);

        this.element.Insert(contentIndex, content);
    }


    public static string Repeat(StringBuilder str, int n)
    {
        return Enumerable.Repeat(str, n)
                         .Aggregate(
                            new StringBuilder(), (sb, s) => sb.Append(s))
                         .ToString();
    }

    public static string operator *(ElementBuilder elBuilder, int n)
    {
        return Repeat(elBuilder.element, n);
    }

    public override string ToString()
    {
        return string.Format("{0}", element);
    }
}


class DispatcherTester
{
    public static void Main()
    {
        // Testing functionality of the class above
        ElementBuilder div = new ElementBuilder("div");
        div.AddAttribute("id", "welcome");
        div.AddAttribute("style", "background-color:blue");
        div.AddContent("Zdraveite!");
        Console.WriteLine(div * 3);

        // Testing HTMLDispatcher class static functionality
        Console.WriteLine(HtmlDispatcher.CreateImage("http://www.images.com/myImage", "wedding", "My wedding"));
        Console.WriteLine(HtmlDispatcher.CreateURL("http://www.softuni.com", "SoftUni", "Best University in Earth"));
        Console.WriteLine(HtmlDispatcher.CreateInput("phone", "homePhone", "Phone"));
    }
}

// Sample Output
//<div id="welcome" style="background-color:blue">Zdraveite!</div><div id="welcome
//" style="background-color:blue">Zdraveite!</div><div id="welcome" style="backgro
//und-color:blue">Zdraveite!</div>
//<image src="http://www.images.com/myImage" alt="wedding">My wedding</image>
//<URL url="http://www.softuni.com" title="SoftUni">Best University in Earth</URL>
//<input name="homePhone" value="Phone"></input>
//Press any key to continue . . .

