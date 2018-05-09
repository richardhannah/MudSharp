using System;
using MudSharp.Data.Models.World.Actors;

namespace MudSharp.Data.Models.World.Items
{
    /// <summary>
    /// The material the item is made out of.
    /// </summary>
    public enum ItemMaterial
    {
        Unknown,
        Paper,
        Wood,
        Metal,
        Stone
    }

    /// <summary>
    /// The item's type.
    /// </summary>
    public enum ItemType
    {
        Light,
        Wand,
        Weapon,
        Treasure,
        Armor,
        Potion,
        Container,
        Key,
        Food,
        Money,
        Fountain,
        Wearable
    }

    /// <summary>
    /// Class describing an item.
    /// </summary>
    public class Item : IEntity
    {
        /// <summary>
        /// The item's short description (a sharp sword).
        /// </summary>
        public string ShortDescription { get; set; }

        /// <summary>
        /// The item's long description (A sharp sword sits here, looking really sharp.)
        /// </summary>
        public string LongDescription { get; set; }

        /// <summary>
        /// The current amount of "health" the item has. Used for destructible items.
        /// </summary>
        public int CurrentHealth { get; set; }

        /// <summary>
        /// The maximum amount of "health" the item has. <c>-1</c> for an indestructible item.
        /// </summary>
        public int MaxHealth { get; set; }

        /// <summary>
        /// The material the item is made out of.
        /// </summary>
        public ItemMaterial Material { get; set; }

        /// <summary>
        /// The type of the item.
        /// </summary>
        public ItemType Type { get; set; }

        /// <summary>
        /// The PC or NPC that currently owns the item.
        /// </summary>
        public virtual Actor Owner { get; set; }

        /// <inheritdoc/>
        public int Id { get; set; }

        /// <inheritdoc/>
        public Guid InstanceId { get; set; }
    }
}
