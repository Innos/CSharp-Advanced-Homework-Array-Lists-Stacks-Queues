using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLDispatcher
{
    class ElementBuilder
    {
        private string name;
        private List<KeyValuePair<string, string>> attributes = new List<KeyValuePair<string, string>>();
        private List<string> contents = new List<string>();

        public ElementBuilder(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if(String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("value", "Name cannot be empty.");
                }
                this.name = value;
            }
        }

        public void AddAtribute(string attribute, string value)
        {
            if(String.IsNullOrEmpty(attribute))
            {
                throw new ArgumentNullException("attribute","Attribute cannot be empty.");
            }
            if(String.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("value", "Value cannot be empty.");
            }
            attributes.Add(new KeyValuePair<string,string>(attribute,value));

        }
        public void AddContent(string content)
        {
            contents.Add(content);
        }
        public static string operator *(ElementBuilder elBuilder, int number)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < number; i++)
			{
                if(i == number-1)
                {
                    sb.Append(elBuilder.ToString());
                    break;
                }
			    sb.AppendLine(elBuilder.ToString());
			}
            return sb.ToString();
        }
        public override string ToString()
        {
            var sub = this.attributes.Select(attribute => attribute.Key + "=\"" + attribute.Value + "\"").Aggregate((previous, next) => previous + " " + next);
            StringBuilder elBuilderToString = new StringBuilder();
            elBuilderToString.Append(String.Format("<{0} ", this.Name));
            elBuilderToString.Append(sub);
            elBuilderToString.Append(">");
            elBuilderToString.Append(String.Join("", this.contents));
            elBuilderToString.Append(String.Format("</{0}>", this.Name));
            return elBuilderToString.ToString();
        }
    }
}
