namespace _01ReformatCode.Data
{
    using System;

    public class CommandManager
    {
        private readonly Engine engine;

        public CommandManager(Engine engine)
        {
            this.engine = engine;
        }

        public bool ExecuteNextCommand()
        {
            string command = Console.ReadLine();
            if (command[0] == 'A')
            {
                this.engine.Events.AddEvent(command);
                return true;
            }

            if (command[0] == 'D')
            {
                this.engine.Events.DeleteEvents(command);
                return true;
            }


            if (command[0] == 'L')
            {
                this.engine.Events.ListEvents(command);
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
