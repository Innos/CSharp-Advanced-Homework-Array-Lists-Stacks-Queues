using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01ReformatCode.Data
{
    public class Engine
    {
        private readonly StringBuilder output;

        private readonly EventHolder events;

        private readonly CommandManager commandManager;

        private readonly Messages messages;

        public Engine()
        {
            this.output = new StringBuilder();
            this.events = new EventHolder(this);
            this.commandManager = new CommandManager(this);
            this.messages = new Messages(this);
        }

        public StringBuilder Output
        {
            get
            {
                return this.output;
            }
        }

        public EventHolder Events
        {
            get
            {
                return this.events;
            }
        }

        public CommandManager CommandManager
        {
            get
            {
                return this.commandManager;
            }
        }

        public Messages Messages
        {
            get
            {
                return this.messages;
            }
        }

        public void Run()
        {
            while (this.CommandManager.ExecuteNextCommand())
            {
            }

            Console.WriteLine(this.Output);
        }
    }
}
