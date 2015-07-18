namespace _01ReformatCode.Data
{
    public class Messages
    {
        private readonly Engine engine;

        public Messages(Engine engine)
        {
            this.engine = engine;
        }

        public void EventAdded()
        {
            this.engine.Output.Append("Event added\n");
        }

        public void EventDeleted(int x)
        {
            if (x == 0)
            {
                this.NoEventsFound();
            }
            else
            {
                this.engine.Output.AppendFormat("{0} events deleted\n", x);
            }
        }

        public void NoEventsFound()
        {
            this.engine.Output.Append("No events found\n");
        }

        public void PrintEvent(Event eventToPrint)
        {
            if (eventToPrint != null)
            {
                this.engine.Output.Append(eventToPrint + "\n");
            }
        }
    }
}
