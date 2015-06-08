using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLDispatcher
{
    static class HTMLDispatcher
    {
        public static string CreateImage(string imageSource,string alt, string title)
        {
            ElementBuilder image = new ElementBuilder("img");
            image.AddAtribute("src", imageSource);
            image.AddAtribute("alt", alt);
            image.AddAtribute("title", title);
            return image.ToString();
        }

        public static string CreateURL(string url,string text, string title)
        {
            ElementBuilder link = new ElementBuilder("a");
            link.AddAtribute("href", url);
            link.AddAtribute("text", text);
            link.AddAtribute("title", title);
            return link.ToString();
        }
        public static string CreateInput(string inputType,string name,string value)
        {
            ElementBuilder input = new ElementBuilder("input");
            input.AddAtribute("type",inputType);
            input.AddAtribute("name",name);
            input.AddAtribute("value",value);
            return input.ToString();
        }
    }
}
