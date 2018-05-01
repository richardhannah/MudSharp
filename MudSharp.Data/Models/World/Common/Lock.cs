namespace MudSharp.Data.Models.World.Common
{
    /// <summary>
    /// The strength of the lock.
    /// </summary>
    public enum LockStrength
    {
        None,
        Weak,
        Normal,
        NearImpenetrable,
        Impenetrable
    }


    /// <summary>
    /// Class describing a door or container lock.
    /// </summary>
    public sealed class Lock
    {
        /// <summary>
        /// The strength of the lock.
        /// </summary>
        public LockStrength Strength { get; set; }

        /// <summary>
        /// Whether or not the lock is currently locked.
        /// </summary>
        public bool IsLocked { get; set; }
    }
}
