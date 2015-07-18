namespace MassEffect.Interfaces
{    
    using System.Collections.Generic;

    using MassEffect.Engine.Factories;
    using MassEffect.GameObjects;

    /// <summary>
    /// Engine interface
    /// </summary>
    public interface IGameEngine
    {
        /// <summary>
        /// A class for creating and initializing ships.
        /// </summary>
        ShipFactory ShipFactory { get; }

        /// <summary>
        /// A class for creating and initializing enhancements.
        /// </summary>
        EnhancementFactory EnhancementFactory { get; }

        /// <summary>
        /// A collection for keeping all starships.
        /// </summary>
        IList<IStarship> Starships { get; }

        Galaxy Galaxy { get; }

        /// <summary>
        /// A class that handles the user input and executes viable commands.
        /// </summary>
        ICommandManager CommandManager { get; }

        /// <summary>
        /// A bool variable that keeps the engine's current condition.
        /// </summary>
        bool IsRunning { get; set; }

        /// <summary>
        /// A method which initializes the engine resources and starts the main execution loop.
        /// </summary>
        void Run();
    }
}
