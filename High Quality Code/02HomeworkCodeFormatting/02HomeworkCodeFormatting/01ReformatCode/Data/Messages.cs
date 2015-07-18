namespace _01ReformatCode.Data
{
    public static class Messages
    { 
        public static void EventAdded()
        {
            EventTestMain.Output.Append("Event added\n");
        }

        public static void EventDeleted(int x)
        {
            if (x == 0)
            {
                NoEventsFound();
            }

            else
            {
                EventTestMain.Output.AppendFormat("{0} events deleted\n", x);
            }
        }

        public static void NoEventsFound()
        {
            EventTestMain.Output.Append("No events found\n");
        }

        public static void PrintEvent(Event eventToPrint)
        {
            if (eventToPrint != null)
            {
                EventTestMain.Output.Append(eventToPrint + "\n");
            }
        }
    }
}
