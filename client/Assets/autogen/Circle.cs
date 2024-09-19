// THIS FILE IS AUTOMATICALLY GENERATED BY SPACETIMEDB. EDITS TO THIS FILE
// WILL NOT BE SAVED. MODIFY TABLES IN RUST INSTEAD.
// <auto-generated />

#nullable enable

using System;
using SpacetimeDB;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace SpacetimeDB.Types
{
	[SpacetimeDB.Type]
	[DataContract]
	public partial class Circle : SpacetimeDB.DatabaseTableWithPrimaryKey<Circle, SpacetimeDB.Types.ReducerEvent>
	{
		[DataMember(Name = "entity_id")]
		public uint EntityId;
		[DataMember(Name = "player_id")]
		public uint PlayerId;
		[DataMember(Name = "direction")]
		public SpacetimeDB.Types.Vector2 Direction = new();
		[DataMember(Name = "magnitude")]
		public float Magnitude;
		[DataMember(Name = "last_split_time")]
		public ulong LastSplitTime;

		private static Dictionary<uint, Circle> EntityId_Index = new(16);

		public override void InternalOnValueInserted()
		{
			EntityId_Index[EntityId] = this;
		}

		public override void InternalOnValueDeleted()
		{
			EntityId_Index.Remove(EntityId);
		}

		public static Circle? FindByEntityId(uint value)
		{
			EntityId_Index.TryGetValue(value, out var r);
			return r;
		}

		public static IEnumerable<Circle> FilterByEntityId(uint value)
		{
			if (FindByEntityId(value) is {} found)
			{
				yield return found;
			}
		}

		public static IEnumerable<Circle> FilterByPlayerId(uint value)
		{
			return Query(x => x.PlayerId == value);
		}

		public static IEnumerable<Circle> FilterByMagnitude(float value)
		{
			return Query(x => x.Magnitude == value);
		}

		public static IEnumerable<Circle> FilterByLastSplitTime(ulong value)
		{
			return Query(x => x.LastSplitTime == value);
		}

		public override object GetPrimaryKeyValue() => EntityId;

	}
}
