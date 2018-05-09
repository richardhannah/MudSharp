using MudSharp.Data.Models.World.Actors;
using MudSharp.Data.Models.World.Environment.Rooms;
using MudSharp.Data.Models.World.Items;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MudSharp.World
{
    public sealed class WorldManager
    {
        private static WorldManager _instance = null;
        private static readonly object _lockObject = new object();

        private WorldManager()
        {
            Rooms = new ConcurrentDictionary<Guid, Room>();
        }

        public static WorldManager Instance
        {
            get
            {
                lock (_lockObject)
                {
                    if (_instance == null)
                        _instance = new WorldManager();

                    return _instance;
                }
            }
        }

        #region Properties

        public ConcurrentDictionary<Guid, Room> Rooms { get; set; }
        public ConcurrentDictionary<Guid, Item> Items { get; set; }
        public ConcurrentDictionary<Guid, NonPlayer> NPCs { get; set; }

        #endregion
    }
}
