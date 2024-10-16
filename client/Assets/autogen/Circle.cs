// THIS FILE IS AUTOMATICALLY GENERATED BY SPACETIMEDB. EDITS TO THIS FILE
// WILL NOT BE SAVED. MODIFY TABLES IN RUST INSTEAD.
// <auto-generated />

#nullable enable

using System;
using SpacetimeDB;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SpacetimeDB.Types
{
	[SpacetimeDB.Type]
	[DataContract]
	public partial class Circle : IDatabaseRow
	{
		[DataMember(Name = "entity_id")]
		public uint EntityId;
		[DataMember(Name = "player_id")]
		public uint PlayerId;
		[DataMember(Name = "direction")]
		public SpacetimeDB.Types.Vector2 Direction;
		[DataMember(Name = "magnitude")]
		public float Magnitude;
		[DataMember(Name = "last_split_time")]
		public ulong LastSplitTime;

		public Circle(
			uint EntityId,
			uint PlayerId,
			SpacetimeDB.Types.Vector2 Direction,
			float Magnitude,
			ulong LastSplitTime
		)
		{
			this.EntityId = EntityId;
			this.PlayerId = PlayerId;
			this.Direction = Direction;
			this.Magnitude = Magnitude;
			this.LastSplitTime = LastSplitTime;
		}

		public Circle()
		{
			this.Direction = new();
		}

	}
}
