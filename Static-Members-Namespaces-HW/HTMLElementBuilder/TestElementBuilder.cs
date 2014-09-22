using System;

namespace HTMLElementBuilder
{
    public class TestElementBuilder
    {
        public static void Main()
        {
            ElementBuilder div = new ElementBuilder("div", true);

            div.AddAtribute("id", "myDiv");
            div.AddAtribute("style", "background: blue");
            div.AddContent("Zdraveite v novinite v 2 chasa");

            //Console.WriteLine(div * 3);

            string image = HTMLDispatcher.CreateImage("http://www.images.com/gallery/funny.png",
                "donkey", "Donkey with a carrot");
            string url = HTMLDispatcher.CreateURL("http://www.btv.bg/news", "The news today",
                "3 people killed");
            string input = HTMLDispatcher.CreateInput("button", "addRow", "Add Row");

            Console.WriteLine("{0}\n{1}\n{2}", image, url, input);
        }
    }
}
