// THIS FILE IS AUTOMATICALLY GENERATED BY SPACETIMEDB. EDITS TO THIS FILE
// WILL NOT BE SAVED. MODIFY TABLES IN RUST INSTEAD.
// <auto-generated />

#nullable enable

using System;
using SpacetimeDB;

namespace SpacetimeDB.Types
{
	[SpacetimeDB.Type]
	public partial class SpawnFoodArgsStruct : IReducerArgs
	{
		ReducerType IReducerArgs.ReducerType => ReducerType.SpawnFood;
		string IReducerArgsBase.ReducerName => "spawn_food";
		bool IReducerArgs.InvokeHandler(ReducerEvent reducerEvent) => Reducer.OnSpawnFood(reducerEvent, this);

		public SpacetimeDB.Types.SpawnFoodTimer Timer = new();
	}

	public static partial class Reducer
	{
		public delegate void SpawnFoodHandler(ReducerEvent reducerEvent, SpacetimeDB.Types.SpawnFoodTimer timer);
		public static event SpawnFoodHandler? OnSpawnFoodEvent;

		public static void SpawnFood(SpacetimeDB.Types.SpawnFoodTimer timer)
		{
			SpacetimeDBClient.instance.InternalCallReducer(new SpawnFoodArgsStruct { Timer = timer });
		}

		public static bool OnSpawnFood(ReducerEvent reducerEvent, SpawnFoodArgsStruct args)
		{
			if (OnSpawnFoodEvent == null) return false;
			OnSpawnFoodEvent(
				reducerEvent,
				args.Timer
			);
			return true;
		}
	}

}
