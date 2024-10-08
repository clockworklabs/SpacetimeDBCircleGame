// THIS FILE IS AUTOMATICALLY GENERATED BY SPACETIMEDB. EDITS TO THIS FILE
// WILL NOT BE SAVED. MODIFY TABLES IN RUST INSTEAD.
// <auto-generated />

#nullable enable

using System;
using SpacetimeDB;

namespace SpacetimeDB.Types
{
	[SpacetimeDB.Type]
	public partial class PlayerSplitArgsStruct : IReducerArgs
	{
		ReducerType IReducerArgs.ReducerType => ReducerType.PlayerSplit;
		string IReducerArgsBase.ReducerName => "player_split";
		bool IReducerArgs.InvokeHandler(ReducerEvent reducerEvent) => Reducer.OnPlayerSplit(reducerEvent, this);
	}

	public static partial class Reducer
	{
		public delegate void PlayerSplitHandler(ReducerEvent reducerEvent);
		public static event PlayerSplitHandler? OnPlayerSplitEvent;

		public static void PlayerSplit()
		{
			SpacetimeDBClient.instance.InternalCallReducer(new PlayerSplitArgsStruct {  });
		}

		public static bool OnPlayerSplit(ReducerEvent reducerEvent, PlayerSplitArgsStruct args)
		{
			if (OnPlayerSplitEvent == null) return false;
			OnPlayerSplitEvent(
				reducerEvent
			);
			return true;
		}
	}

}
