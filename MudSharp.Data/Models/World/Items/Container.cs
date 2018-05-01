using MudSharp.Data.Models.World.Common;
using System.Collections.Generic;

namespace MudSharp.Data.Models.World.Items
{
    /// <summary>
    /// Class describing a container-type item.
    /// </summary>
    public sealed class Container : Item
    {
        /// <summary>
        /// The container's contents.
        /// </summary>
        public List<Item> Contents { get; set; }

        /// <summary>
        /// The maximum amount of weight the container can hold.
        /// </summary>
        public uint MaxWeight { get; set; }

        /// <summary>
        /// The maximum amount of volume the container can hold.
        /// </summary>
        public uint MaxVolume { get; set; }

        /// <summary>
        /// Whether or not the container is currently open.
        /// </summary>
        public bool IsOpen { get; set; }

        /// <summary>
        /// The container's lock. <c>null</c> if there is no lock.
        /// </summary>
        public Lock Lock { get; set; }
    }
}
