using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLDispatcher
{
    class HtmlDispatcher
    {
        public static string CreateImage(string src, string alt, string title)
        {
            ElementBuilder image = new ElementBuilder("image");
            image.AddAttribute("src", src);
            image.AddAttribute("alt", alt);
            image.AddContent(title);

            return image.ToString();
        }

        public static string CreateURL(string url, string title, string text)
        {
            ElementBuilder urlItem = new ElementBuilder("URL");
            urlItem.AddAttribute("url", url);
            urlItem.AddAttribute("title", title);
            urlItem.AddContent(text);

            return urlItem.ToString();
        }


        public static string CreateInput(string type, string name, string val)
        {
            ElementBuilder inputItem = new ElementBuilder("input");
            inputItem.AddAttribute("name", name);
            inputItem.AddAttribute("value", val);

            return inputItem.ToString();
        }
    }
}


