using System;
using System.Collections.Generic;
using System.Text;

namespace MudSharp.Data.Models.World.Actors
{
    /// <summary>
    /// Class describing a non-player character (NPC).
    /// </summary>
    public class NonPlayer : Actor, IEntity
    {
        /// <inheritdoc/>
        public int Id { get; set; }

        /// <inheritdoc/>
        public Guid InstanceId { get; set; }
    }
}
