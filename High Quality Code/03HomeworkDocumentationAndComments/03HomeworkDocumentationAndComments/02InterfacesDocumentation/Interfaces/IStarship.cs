namespace MassEffect.Interfaces
{
    using MassEffect.GameObjects.Locations;

    /// <summary>
    /// Starship interface
    /// </summary>
    public interface IStarship : IEnhanceable
    {
        /// <summary>
        /// The name of the starship
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// The total durability of a ship, when it reaches 0 the ship is destroyed.
        /// </summary>
        int Health { get; set; }

        /// <summary>
        /// A resource that acts as a buffer to protect the ship's Health, damage is first subtracted from Shields before Health.
        /// Some ships and projectile have special effects that interact with Shields.
        /// </summary>
        int Shields { get; set; }

        /// <summary>
        /// Represents the ship's damage potential, a projectile produced by a starship has damage equal to the starship's damage.
        /// </summary>
        int Damage { get; set; }

        /// <summary>
        /// A resource used for the ship to perform movement.
        /// </summary>
        double Fuel { get; set; }

        /// <summary>
        /// A class representing the current position of the ship in the galaxy.
        /// </summary>
        StarSystem Location { get; set; }

        /// <summary>
        /// A method for producing projectiles.
        /// </summary>
        IProjectile ProduceAttack();

        /// <summary>
        /// A method which dictates how a ship responds to attack.
        /// </summary>
        /// <param name="attack">Represents the projectile that is attacking the starship.</param>
        /// <see cref="MassEffect.GameObjects.Projectiles"/>
        void RespondToAttack(IProjectile attack);
    }
}
