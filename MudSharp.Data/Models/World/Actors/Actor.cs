using System;
using System.Collections.Generic;
using System.Text;

namespace MudSharp.Data.Models.World.Actors
{
    public enum Gender
    {
        Unknown,
        Male,
        Female,
        Genderless
    }

    public enum ActorType
    {
        Unknown,
        Player,
        NonPlayer
    }

    public enum ActorClass
    {
        Undefined,
        Mage,
        Cleric,
        Thief,
        Fighter
    }

    public enum ActorAlignment
    {
        Good,
        Neutral,
        Evil
    }

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


    public struct ActorStats
    {
        uint Strength;
        uint Intelligence;
        uint Dexterity;
        uint Wisdom;
        uint Constitution;
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
