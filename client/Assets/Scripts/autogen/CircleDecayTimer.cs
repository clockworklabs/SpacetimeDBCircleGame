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
	public partial class CircleDecayTimer : IDatabaseRow
	{
		[DataMember(Name = "scheduled_id")]
		public ulong ScheduledId;
		[DataMember(Name = "scheduled_at")]
		public SpacetimeDB.ScheduleAt ScheduledAt;

		public CircleDecayTimer(
			ulong ScheduledId,
			SpacetimeDB.ScheduleAt ScheduledAt
		)
		{
			this.ScheduledId = ScheduledId;
			this.ScheduledAt = ScheduledAt;
		}

		public CircleDecayTimer()
		{
			this.ScheduledAt = null!;
		}

	}
}
