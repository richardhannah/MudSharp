using System;
using System.Collections.Generic;
using System.Text;

namespace MudSharp.Data.Models
{
    public interface IEntity
    {
        /// <summary>
        /// The id of the entity, used in commands and database lookups.
        /// </summary>
        int Id { get; set; }

        /// <summary>
        /// The instance id of the entity, used by the system for identifying unique instances of objects.
        /// </summary>
        Guid InstanceId { get; set; }
    }
}
