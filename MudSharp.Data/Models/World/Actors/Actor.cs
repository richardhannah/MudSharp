namespace MudSharp.Data.Models.World.Actors
{
    /// <summary>
    /// The actor's gender.
    /// </summary>
    public enum Gender
    {
        Unknown,
        Male,
        Female,
        Genderless
    }

    /// <summary>
    /// The actor type (PC or NPC).
    /// </summary>
    public enum ActorType
    {
        Unknown,
        Player,
        NonPlayer
    }

    /// <summary>
    /// The actor's class.
    /// </summary>
    public enum ActorClass
    {
        Undefined,
        Mage,
        Cleric,
        Thief,
        Fighter
    }

    /// <summary>
    /// The actor's alignment.
    /// </summary>
    public enum ActorAlignment
    {
        Good,
        Neutral,
        Evil
    }

    /// <summary>
    /// The actor's position.
    /// </summary>
    public enum ActorPosition
    {
        Dead,
        Dying,
        Incapacitated,
        Stunned,
        Sleeping,
        Resting,
        Sitting,
        Fighting,
        Standing
    }

    /// <summary>
    /// Supported wear slots for all actors.
    /// </summary>
    public enum WearSlot
    {
        Head,
        Neck,
        Shoulders,
        Torso,
        Arms,
        Hands,
        WristRight,
        WristLeft,
        WristBoth,
        FingerRight,
        FingerLeft,
        Waist,
        Legs,
        AnkleRight,
        AnkleLeft,
        AnkleBoth,
        Feet,
        Weapon,
        Held,
        Shield
    }

    /// <summary>
    /// Statistics for all actors.
    /// </summary>
    public struct ActorStats
    {
        /// <summary>
        /// The actor's strength.
        /// </summary>
        uint Strength;

        /// <summary>
        /// The actor's intelligence.
        /// </summary>
        uint Intelligence;

        /// <summary>
        /// The actor's dexterity.
        /// </summary>
        uint Dexterity;

        /// <summary>
        /// The actor's wisdom. Used primarily by clerics to determine how much power they can have
        /// </summary>
        uint Wisdom;

        /// <summary>
        /// The actor's constitution. Used primarily for hit points.
        /// </summary>
        uint Constitution;

        /// <summary>
        /// The actor's charisma. Used primarily for how many actors can follow the actor.
        /// </summary>
        uint Charisma;

        uint MaxHealth;
        int CurrentHealth;
        uint MaxPower;
        int CurrentPower;
        uint MaxMoves;
        int CurrentMoves;

        uint HitBonus;
        uint DamageBonus;

        int ArmorClass;
    }

    public abstract class Actor
    {
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string Title { get; set; }
        public Gender Gender { get; set; }
        public ActorType Type { get; set; }
        public ActorStats Stats { get; set; }
        public ActorClass Class { get; set; }
        ActorPosition Position { get; set; }
        ActorAlignment Alignment { get; set; }
    }
}
