﻿/*  Copyright 2016 Clive Pottinger
    This file is part of the WalkAbout Mod.

    WalkAbout is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    WalkAbout is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with WalkAbout.  If not, see<http://www.gnu.org/licenses/>.
*/

using System.Collections.Generic;

namespace KspWalkAbout.Entities
{
    /// <summary>Represents a user's request to place a kerbal at a location.</summary>
    internal class PlacementRequest
    {
        public ProtoCrewMember Kerbal { get; set; }
        public Location Location { get; set; }
        public List<InventoryItem> Items { get; set; }
    }
}