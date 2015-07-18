namespace _01ReformatCode.Data
{
    #region

    using System;
    using System.Text;

    #endregion

    public class Event : IComparable
    {
        private readonly string location;

        private readonly string title;

        private DateTime date;

        public Event(DateTime date, string title, string location)
        {
            this.date = date;
            this.title = title;
            this.location = location;
        }

        public DateTime Date
        {
            get
            {
                return this.date;
            }
        }

        public string Location
        {
            get
            {
                return this.location;
            }
        }

        public string Title
        {
            get
            {
                return this.title;
            }
        }

        public int CompareTo(object obj)
        {
            var other = obj as Event;
            var compareByDate = this.date.CompareTo(other.date);
            var compareByTitle = string.Compare(this.title, other.title, StringComparison.Ordinal);
            var compareByLocation = string.Compare(this.location, other.location, StringComparison.Ordinal);

            if (compareByDate == 0)
            {
                if (compareByTitle == 0)
                {
                    return compareByLocation;
                }

                return compareByTitle;
            }

            return compareByDate;
        }

        public override string ToString()
        {
            var output = new StringBuilder();
            output.Append(this.date.ToString("yyyy-MM-ddTHH:mm:ss"));

            output.Append(" | " + this.title);
            if (!string.IsNullOrEmpty(this.location))
            {
                output.Append(" | " + this.location);
            }

            return output.ToString();
        }
    }
}