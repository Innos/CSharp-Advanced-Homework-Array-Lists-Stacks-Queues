

namespace _01ReformatCode
{
    #region UsingDirectives

    using System;
    using System.Text;

    using _01ReformatCode.Data;

    #endregion

    public class EventTestMain
    {
        public static readonly StringBuilder Output = new StringBuilder();

        private static readonly EventHolder Events = new EventHolder();

        private static void Main()
        {
            while (ExecuteNextCommand())
            {
            }

            Console.WriteLine(Output);
        }

        private static bool ExecuteNextCommand()
        {
            string command = Console.ReadLine();
            if (command[0] == 'A')
            {
                Events.AddEvent(command);
                return true;
            }

            if (command[0] == 'D')
            {
                Events.DeleteEvents(command);
                return true;
            }


            if (command[0] == 'L')
            {
                Events.ListEvents(command);
                return true;
            }

            if (command[0] == 'E')
            {
                return false;
            }

            return false;
        }
    }
}