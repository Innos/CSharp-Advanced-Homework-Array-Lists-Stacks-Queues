namespace MassEffect.Interfaces
{
    /// <summary>
    /// CommandManager interface
    /// </summary>
    public interface ICommandManager
    {
        /// <summary>
        /// An engine implementation to specify the engine to be used in the commands.
        /// </summary>
        IGameEngine Engine { get; set; }

        /// <summary>
        /// Processes the commands given by the user.
        /// </summary>
        /// <param name="command">Represents the command given by the user as a string.</param>
        void ProcessCommand(string command);

        /// <summary>
        /// Creates and initializes all viable commands. 
        /// </summary>
        void SeedCommands();
    }
}
