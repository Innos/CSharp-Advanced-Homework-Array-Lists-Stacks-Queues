namespace MassEffect.Interfaces
{
    using System.Collections.Generic;

    using MassEffect.GameObjects.Enhancements;

    /// <summary>
    /// Enhanceable interface
    /// </summary>
    public interface IEnhanceable
    {
        /// <summary>
        /// A collection to keep all current enhancements.
        /// </summary>
        IEnumerable<Enhancement> Enhancements { get; }

        /// <summary>
        /// A method to add an ehnancement to the collection of current enhancements.
        /// </summary>
        /// <param name="enhancement">Represents the ehancement to be added.</param>
        /// <see cref="MassEffect.GameObjects.Enhancements"/>
        void AddEnhancement(Enhancement enhancement);
    }
}
