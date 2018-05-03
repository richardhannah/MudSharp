using System;

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

        /// <summary>
        /// The maximum amount of health points the actor can have.
        /// </summary>
        uint MaxHealth;

        /// <summary>
        /// The current amount of health points the actor has. If less than 0, the actor is dead.
        /// </summary>
        int CurrentHealth;

        /// <summary>
        /// The maximum amount of spellcasting power the actor has.
        /// </summary>
        uint MaxPower;

        /// <summary>
        /// The current amount of spellcasting power the actor has.
        /// </summary>
        int CurrentPower;

        /// <summary>
        /// The maximum amount of move points the actor has.
        /// </summary>
        uint MaxMoves;

        /// <summary>
        /// The current amount of move points the actor has.
        /// </summary>
        int CurrentMoves;

        /// <summary>
        /// Any bonuses to hit another actor.
        /// </summary>
        uint HitBonus;

        /// <summary>
        /// Any bonuses to damage dealt to another actor.
        /// </summary>
        uint DamageBonus;

        /// <summary>
        /// The actor's base armor class.
        /// </summary>
        int ArmorClass;
    }

    /// <summary>
    /// Class describing an actor (PC or NPC).
    /// </summary>
    public abstract class Actor
    {
        /// <summary>
        /// The actor's name, <c>null</c> for NPCs.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The actor's short description (Joe Sixpack, a large red dragon).
        /// </summary>
        public string ShortDescription { get; set; }

        /// <summary>
        /// The actor's long description (A large red dragon is here, looking none too happy.)
        /// </summary>
        public string LongDescription { get; set; }

        /// <summary>
        /// The actor's title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The actor's gender.
        /// </summary>
        public Gender Gender { get; set; }

        /// <summary>
        /// The actor's type (PC or NPC).
        /// </summary>
        public ActorType Type { get; set; }

        /// <summary>
        /// The actor's statistics.
        /// </summary>
        public ActorStats Stats { get; set; }

        /// <summary>
        /// The actor's class.
        /// </summary>
        public ActorClass Class { get; set; }

        /// <summary>
        /// The actor's current position (standing, sleeping, dead...)
        /// </summary>
        ActorPosition Position { get; set; }

        /// <summary>
        /// The actor's alignment (good, neutral, or evil.)
        /// </summary>
        ActorAlignment Alignment { get; set; }

        /// <summary>
        /// Moves the actor from one room to another.
        /// </summary>
        /// <param name="fromRoom">Identifier of the room the actor is moving from.</param>
        /// <param name="toRoom">Identifier of the room the actor is moving to.</param>
        /// <returns><c>true</c> if the move was successful, otherwise <c>false</c>.</returns>
        public bool Move(Guid fromRoom, Guid toRoom)
        {
            // TODO: Implement this
            return true;
        }
    }
}
