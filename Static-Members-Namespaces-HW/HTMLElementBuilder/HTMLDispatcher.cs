namespace HTMLElementBuilder
{
    public static class HTMLDispatcher
    {
        public static string CreateImage(string src, string alt, string title)
        {
            ElementBuilder image = new ElementBuilder("img", false);

            image.AddAtribute("src", src);
            image.AddAtribute("alt", alt);
            image.AddAtribute("title", title);

            return image.ToString();
        }

        public static string CreateURL(string url, string title, string text)
        {
            ElementBuilder anchor = new ElementBuilder("a", true);

            anchor.AddAtribute("href", url);
            anchor.AddAtribute("title", title);
            anchor.AddContent(text);

            return anchor.ToString();
        }

        public static string CreateInput(string type, string name, string value)
        {
            ElementBuilder input = new ElementBuilder("input", false);

            input.AddAtribute("type", type);
            input.AddAtribute("name", name);
            input.AddAtribute("value", value);

            return input.ToString();
        }
    }
}
