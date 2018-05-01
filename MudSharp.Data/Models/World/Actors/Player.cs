using MudSharp.Data.Models.World.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace MudSharp.Data.Models.World.Actors
{
    public class Player : Actor
    {
        public List<Item> Inventory { get; set; }
    }
}
