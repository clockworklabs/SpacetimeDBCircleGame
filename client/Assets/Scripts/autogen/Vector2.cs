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
	public partial class Vector2
	{
		[DataMember(Name = "x")]
		public float X;
		[DataMember(Name = "y")]
		public float Y;

		public Vector2(
			float X,
			float Y
		)
		{
			this.X = X;
			this.Y = Y;
		}

		public Vector2()
		{
		}

	}
}