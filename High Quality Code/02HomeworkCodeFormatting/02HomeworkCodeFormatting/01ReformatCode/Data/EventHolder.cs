namespace _01ReformatCode.Data
{
    using System;
    using Wintellect.PowerCollections;

    public class EventHolder
    {
        private readonly MultiDictionary<string, Event> eventsByTitle = new MultiDictionary<string, Event>(true);

        private readonly OrderedBag<Event> eventsByDate = new OrderedBag<Event>();

        public void AddEvent(string command)
        {
            DateTime date = DateTime.Parse(command.Substring("AddEvent".Length + 1, 20));
            int firstPipeIndex = command.IndexOf('|');
            int lastPipeIndex = command.LastIndexOf('|');
            string title;
            string location;
            if (firstPipeIndex == lastPipeIndex)
            {
                title = command.Substring(firstPipeIndex + 1).Trim();
                location = string.Empty;
            }
            else
            {
                title =
                    command.Substring(firstPipeIndex + 1, lastPipeIndex - firstPipeIndex - 1).Trim();
                location = command.Substring(lastPipeIndex + 1).Trim();
            }

            Event newEvent = new Event(date, title, location);
            this.eventsByTitle.Add(title.ToLower(), newEvent);
            this.eventsByDate.Add(newEvent);
            Messages.EventAdded();
        }

        public void DeleteEvents(string command)
        {
            string title = command.Substring("DeleteEvents".Length + 1).ToLower();
            int removed = 0;
            foreach (var eventToRemove in this.eventsByTitle[title])
            {
                removed++;
                this.eventsByDate.Remove(eventToRemove);
            }

            this.eventsByTitle.Remove(title);
            Messages.EventDeleted(removed);
        }

        public void ListEvents(string command)
        {
            int pipeIndex = command.IndexOf('|');
            DateTime date = DateTime.Parse(command.Substring("ListEvents".Length + 1, 20));
            string countString = command.Substring(pipeIndex + 1);
            int count = int.Parse(countString);

            OrderedBag<Event>.View eventsToShow = this.eventsByDate.RangeFrom(new Event(date, string.Empty, string.Empty), true);
            int showed = 0;
            foreach (var eventToShow in eventsToShow)
            {
                if (showed == count)
                {
                    break;
                }

                Messages.PrintEvent(eventToShow);

                showed++;
            }

            if (showed == 0)
            {
                Messages.NoEventsFound();
            }
        }
    }
}
