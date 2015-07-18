namespace MassEffect.Interfaces
{
    /// <summary>
    /// Projectile interface
    /// </summary>
    public interface IProjectile
    {
        /// <summary>
        /// A variable that holds the damage that a projectile inflicts.
        /// </summary>
        int Damage { get; set; }

        /// <summary>
        /// A method that handles the consequences of a projectile hitting a starship.
        /// </summary>
        /// <param name="ship">Represents the starship that is hit.</param>
        /// <see cref="MassEffect.GameObjects.Ships"/>
        void Hit(IStarship ship);
    }
}
