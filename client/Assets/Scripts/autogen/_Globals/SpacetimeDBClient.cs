// THIS FILE IS AUTOMATICALLY GENERATED BY SPACETIMEDB. EDITS TO THIS FILE
// WILL NOT BE SAVED. MODIFY TABLES IN RUST INSTEAD.
// <auto-generated />

#nullable enable

using System;
using SpacetimeDB;
using SpacetimeDB.ClientApi;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SpacetimeDB.Types
{
	public sealed class RemoteTables
	{
		public class CircleHandle : RemoteTableHandle<EventContext, Circle>
		{

			public override void InternalInvokeValueInserted(IDatabaseRow row)
			{
				var value = (Circle)row;
				EntityId.Cache[value.EntityId] = value;
			}

			public override void InternalInvokeValueDeleted(IDatabaseRow row)
			{
				EntityId.Cache.Remove(((Circle)row).EntityId);
			}

			public class EntityIdUniqueIndex
			{
				internal readonly Dictionary<uint, Circle> Cache = new(16);
				public Circle? Find(uint value)
				{
					Cache.TryGetValue(value, out var r);
					return r;
				}

			}

			public EntityIdUniqueIndex EntityId = new();

			public class PlayerIdIndex
			{
				CircleHandle Handle;
				internal PlayerIdIndex(CircleHandle handle) => Handle = handle;
				public IEnumerable<Circle> Filter(uint value) =>
					Handle.Query(x => x.PlayerId == value);
			}

			public PlayerIdIndex PlayerId { get; init; }

			internal CircleHandle()
			{
				PlayerId = new(this);
			}
			public override object GetPrimaryKey(IDatabaseRow row) => ((Circle)row).EntityId;

		}

		public readonly CircleHandle Circle = new();

		public class CircleDecayTimerHandle : RemoteTableHandle<EventContext, CircleDecayTimer>
		{

			public override void InternalInvokeValueInserted(IDatabaseRow row)
			{
				var value = (CircleDecayTimer)row;
				ScheduledId.Cache[value.ScheduledId] = value;
			}

			public override void InternalInvokeValueDeleted(IDatabaseRow row)
			{
				ScheduledId.Cache.Remove(((CircleDecayTimer)row).ScheduledId);
			}

			public class ScheduledIdUniqueIndex
			{
				internal readonly Dictionary<ulong, CircleDecayTimer> Cache = new(16);
				public CircleDecayTimer? Find(ulong value)
				{
					Cache.TryGetValue(value, out var r);
					return r;
				}

			}

			public ScheduledIdUniqueIndex ScheduledId = new();

			internal CircleDecayTimerHandle()
			{
			}
			public override object GetPrimaryKey(IDatabaseRow row) => ((CircleDecayTimer)row).ScheduledId;

		}

		public readonly CircleDecayTimerHandle CircleDecayTimer = new();

		public class CircleRecombineTimerHandle : RemoteTableHandle<EventContext, CircleRecombineTimer>
		{

			public override void InternalInvokeValueInserted(IDatabaseRow row)
			{
				var value = (CircleRecombineTimer)row;
				ScheduledId.Cache[value.ScheduledId] = value;
			}

			public override void InternalInvokeValueDeleted(IDatabaseRow row)
			{
				ScheduledId.Cache.Remove(((CircleRecombineTimer)row).ScheduledId);
			}

			public class ScheduledIdUniqueIndex
			{
				internal readonly Dictionary<ulong, CircleRecombineTimer> Cache = new(16);
				public CircleRecombineTimer? Find(ulong value)
				{
					Cache.TryGetValue(value, out var r);
					return r;
				}

			}

			public ScheduledIdUniqueIndex ScheduledId = new();

			internal CircleRecombineTimerHandle()
			{
			}
			public override object GetPrimaryKey(IDatabaseRow row) => ((CircleRecombineTimer)row).ScheduledId;

		}

		public readonly CircleRecombineTimerHandle CircleRecombineTimer = new();

		public class ConfigHandle : RemoteTableHandle<EventContext, Config>
		{

			public override void InternalInvokeValueInserted(IDatabaseRow row)
			{
				var value = (Config)row;
				Id.Cache[value.Id] = value;
			}

			public override void InternalInvokeValueDeleted(IDatabaseRow row)
			{
				Id.Cache.Remove(((Config)row).Id);
			}

			public class IdUniqueIndex
			{
				internal readonly Dictionary<uint, Config> Cache = new(16);
				public Config? Find(uint value)
				{
					Cache.TryGetValue(value, out var r);
					return r;
				}

			}

			public IdUniqueIndex Id = new();

			internal ConfigHandle()
			{
			}
			public override object GetPrimaryKey(IDatabaseRow row) => ((Config)row).Id;

		}

		public readonly ConfigHandle Config = new();

		public class EntityHandle : RemoteTableHandle<EventContext, Entity>
		{

			public override void InternalInvokeValueInserted(IDatabaseRow row)
			{
				var value = (Entity)row;
				EntityId.Cache[value.EntityId] = value;
			}

			public override void InternalInvokeValueDeleted(IDatabaseRow row)
			{
				EntityId.Cache.Remove(((Entity)row).EntityId);
			}

			public class EntityIdUniqueIndex
			{
				internal readonly Dictionary<uint, Entity> Cache = new(16);
				public Entity? Find(uint value)
				{
					Cache.TryGetValue(value, out var r);
					return r;
				}

			}

			public EntityIdUniqueIndex EntityId = new();

			internal EntityHandle()
			{
			}
			public override object GetPrimaryKey(IDatabaseRow row) => ((Entity)row).EntityId;

		}

		public readonly EntityHandle Entity = new();

		public class FoodHandle : RemoteTableHandle<EventContext, Food>
		{

			public override void InternalInvokeValueInserted(IDatabaseRow row)
			{
				var value = (Food)row;
				EntityId.Cache[value.EntityId] = value;
			}

			public override void InternalInvokeValueDeleted(IDatabaseRow row)
			{
				EntityId.Cache.Remove(((Food)row).EntityId);
			}

			public class EntityIdUniqueIndex
			{
				internal readonly Dictionary<uint, Food> Cache = new(16);
				public Food? Find(uint value)
				{
					Cache.TryGetValue(value, out var r);
					return r;
				}

			}

			public EntityIdUniqueIndex EntityId = new();

			internal FoodHandle()
			{
			}
			public override object GetPrimaryKey(IDatabaseRow row) => ((Food)row).EntityId;

		}

		public readonly FoodHandle Food = new();

		public class LoggedOutCircleHandle : RemoteTableHandle<EventContext, LoggedOutCircle>
		{

			public override void InternalInvokeValueInserted(IDatabaseRow row)
			{
				var value = (LoggedOutCircle)row;
				LoggedOutId.Cache[value.LoggedOutId] = value;
			}

			public override void InternalInvokeValueDeleted(IDatabaseRow row)
			{
				LoggedOutId.Cache.Remove(((LoggedOutCircle)row).LoggedOutId);
			}

			public class LoggedOutIdUniqueIndex
			{
				internal readonly Dictionary<uint, LoggedOutCircle> Cache = new(16);
				public LoggedOutCircle? Find(uint value)
				{
					Cache.TryGetValue(value, out var r);
					return r;
				}

			}

			public LoggedOutIdUniqueIndex LoggedOutId = new();

			public class PlayerIdIndex
			{
				LoggedOutCircleHandle Handle;
				internal PlayerIdIndex(LoggedOutCircleHandle handle) => Handle = handle;
				public IEnumerable<LoggedOutCircle> Filter(uint value) =>
					Handle.Query(x => x.PlayerId == value);
			}

			public PlayerIdIndex PlayerId { get; init; }

			internal LoggedOutCircleHandle()
			{
				PlayerId = new(this);
			}
			public override object GetPrimaryKey(IDatabaseRow row) => ((LoggedOutCircle)row).LoggedOutId;

		}

		public readonly LoggedOutCircleHandle LoggedOutCircle = new();

		public class LoggedOutPlayerHandle : RemoteTableHandle<EventContext, LoggedOutPlayer>
		{

			public override void InternalInvokeValueInserted(IDatabaseRow row)
			{
				var value = (LoggedOutPlayer)row;
				Identity.Cache[value.Identity] = value;
			}

			public override void InternalInvokeValueDeleted(IDatabaseRow row)
			{
				Identity.Cache.Remove(((LoggedOutPlayer)row).Identity);
			}

			public class IdentityUniqueIndex
			{
				internal readonly Dictionary<SpacetimeDB.Identity, LoggedOutPlayer> Cache = new(16);
				public LoggedOutPlayer? Find(SpacetimeDB.Identity value)
				{
					Cache.TryGetValue(value, out var r);
					return r;
				}

			}

			public IdentityUniqueIndex Identity = new();

			internal LoggedOutPlayerHandle()
			{
			}
			public override object GetPrimaryKey(IDatabaseRow row) => ((LoggedOutPlayer)row).Identity;

		}

		public readonly LoggedOutPlayerHandle LoggedOutPlayer = new();

		public class MoveAllPlayersTimerHandle : RemoteTableHandle<EventContext, MoveAllPlayersTimer>
		{

			public override void InternalInvokeValueInserted(IDatabaseRow row)
			{
				var value = (MoveAllPlayersTimer)row;
				ScheduledId.Cache[value.ScheduledId] = value;
			}

			public override void InternalInvokeValueDeleted(IDatabaseRow row)
			{
				ScheduledId.Cache.Remove(((MoveAllPlayersTimer)row).ScheduledId);
			}

			public class ScheduledIdUniqueIndex
			{
				internal readonly Dictionary<ulong, MoveAllPlayersTimer> Cache = new(16);
				public MoveAllPlayersTimer? Find(ulong value)
				{
					Cache.TryGetValue(value, out var r);
					return r;
				}

			}

			public ScheduledIdUniqueIndex ScheduledId = new();

			internal MoveAllPlayersTimerHandle()
			{
			}
			public override object GetPrimaryKey(IDatabaseRow row) => ((MoveAllPlayersTimer)row).ScheduledId;

		}

		public readonly MoveAllPlayersTimerHandle MoveAllPlayersTimer = new();

		public class PlayerHandle : RemoteTableHandle<EventContext, Player>
		{

			public override void InternalInvokeValueInserted(IDatabaseRow row)
			{
				var value = (Player)row;
				Identity.Cache[value.Identity] = value;
				PlayerId.Cache[value.PlayerId] = value;
			}

			public override void InternalInvokeValueDeleted(IDatabaseRow row)
			{
				Identity.Cache.Remove(((Player)row).Identity);
				PlayerId.Cache.Remove(((Player)row).PlayerId);
			}

			public class IdentityUniqueIndex
			{
				internal readonly Dictionary<SpacetimeDB.Identity, Player> Cache = new(16);
				public Player? Find(SpacetimeDB.Identity value)
				{
					Cache.TryGetValue(value, out var r);
					return r;
				}

			}

			public IdentityUniqueIndex Identity = new();

			public class PlayerIdUniqueIndex
			{
				internal readonly Dictionary<uint, Player> Cache = new(16);
				public Player? Find(uint value)
				{
					Cache.TryGetValue(value, out var r);
					return r;
				}

			}

			public PlayerIdUniqueIndex PlayerId = new();

			internal PlayerHandle()
			{
			}
			public override object GetPrimaryKey(IDatabaseRow row) => ((Player)row).Identity;

		}

		public readonly PlayerHandle Player = new();

		public class SpawnFoodTimerHandle : RemoteTableHandle<EventContext, SpawnFoodTimer>
		{

			public override void InternalInvokeValueInserted(IDatabaseRow row)
			{
				var value = (SpawnFoodTimer)row;
				ScheduledId.Cache[value.ScheduledId] = value;
			}

			public override void InternalInvokeValueDeleted(IDatabaseRow row)
			{
				ScheduledId.Cache.Remove(((SpawnFoodTimer)row).ScheduledId);
			}

			public class ScheduledIdUniqueIndex
			{
				internal readonly Dictionary<ulong, SpawnFoodTimer> Cache = new(16);
				public SpawnFoodTimer? Find(ulong value)
				{
					Cache.TryGetValue(value, out var r);
					return r;
				}

			}

			public ScheduledIdUniqueIndex ScheduledId = new();

			internal SpawnFoodTimerHandle()
			{
			}
			public override object GetPrimaryKey(IDatabaseRow row) => ((SpawnFoodTimer)row).ScheduledId;

		}

		public readonly SpawnFoodTimerHandle SpawnFoodTimer = new();

	}

	public sealed class RemoteReducers : RemoteBase<DbConnection>
	{
		internal RemoteReducers(DbConnection conn, SetReducerFlags SetReducerFlags) : base(conn) { this.SetCallReducerFlags = SetReducerFlags; }
		internal readonly SetReducerFlags SetCallReducerFlags;
		public delegate void CircleDecayHandler(EventContext ctx, SpacetimeDB.Types.CircleDecayTimer timer);
		public event CircleDecayHandler? OnCircleDecay;

		public void CircleDecay(SpacetimeDB.Types.CircleDecayTimer timer)
		{
			conn.InternalCallReducer(new Reducer.CircleDecay(timer), this.SetCallReducerFlags.CircleDecayFlags);
		}

		public bool InvokeCircleDecay(EventContext ctx, Reducer.CircleDecay args)
		{
			if (OnCircleDecay == null) return false;
			OnCircleDecay(
				ctx,
				args.Timer
			);
			return true;
		}
		public delegate void CircleRecombineHandler(EventContext ctx, SpacetimeDB.Types.CircleRecombineTimer timer);
		public event CircleRecombineHandler? OnCircleRecombine;

		public void CircleRecombine(SpacetimeDB.Types.CircleRecombineTimer timer)
		{
			conn.InternalCallReducer(new Reducer.CircleRecombine(timer), this.SetCallReducerFlags.CircleRecombineFlags);
		}

		public bool InvokeCircleRecombine(EventContext ctx, Reducer.CircleRecombine args)
		{
			if (OnCircleRecombine == null) return false;
			OnCircleRecombine(
				ctx,
				args.Timer
			);
			return true;
		}
		public delegate void CreatePlayerHandler(EventContext ctx, string name);
		public event CreatePlayerHandler? OnCreatePlayer;

		public void CreatePlayer(string name)
		{
			conn.InternalCallReducer(new Reducer.CreatePlayer(name), this.SetCallReducerFlags.CreatePlayerFlags);
		}

		public bool InvokeCreatePlayer(EventContext ctx, Reducer.CreatePlayer args)
		{
			if (OnCreatePlayer == null) return false;
			OnCreatePlayer(
				ctx,
				args.Name
			);
			return true;
		}
		public delegate void MoveAllPlayersHandler(EventContext ctx, SpacetimeDB.Types.MoveAllPlayersTimer timer);
		public event MoveAllPlayersHandler? OnMoveAllPlayers;

		public void MoveAllPlayers(SpacetimeDB.Types.MoveAllPlayersTimer timer)
		{
			conn.InternalCallReducer(new Reducer.MoveAllPlayers(timer), this.SetCallReducerFlags.MoveAllPlayersFlags);
		}

		public bool InvokeMoveAllPlayers(EventContext ctx, Reducer.MoveAllPlayers args)
		{
			if (OnMoveAllPlayers == null) return false;
			OnMoveAllPlayers(
				ctx,
				args.Timer
			);
			return true;
		}
		public delegate void PlayerSplitHandler(EventContext ctx);
		public event PlayerSplitHandler? OnPlayerSplit;

		public void PlayerSplit()
		{
			conn.InternalCallReducer(new Reducer.PlayerSplit(), this.SetCallReducerFlags.PlayerSplitFlags);
		}

		public bool InvokePlayerSplit(EventContext ctx, Reducer.PlayerSplit args)
		{
			if (OnPlayerSplit == null) return false;
			OnPlayerSplit(
				ctx
			);
			return true;
		}
		public delegate void RespawnHandler(EventContext ctx);
		public event RespawnHandler? OnRespawn;

		public void Respawn()
		{
			conn.InternalCallReducer(new Reducer.Respawn(), this.SetCallReducerFlags.RespawnFlags);
		}

		public bool InvokeRespawn(EventContext ctx, Reducer.Respawn args)
		{
			if (OnRespawn == null) return false;
			OnRespawn(
				ctx
			);
			return true;
		}
		public delegate void SpawnFoodHandler(EventContext ctx, SpacetimeDB.Types.SpawnFoodTimer timer);
		public event SpawnFoodHandler? OnSpawnFood;

		public void SpawnFood(SpacetimeDB.Types.SpawnFoodTimer timer)
		{
			conn.InternalCallReducer(new Reducer.SpawnFood(timer), this.SetCallReducerFlags.SpawnFoodFlags);
		}

		public bool InvokeSpawnFood(EventContext ctx, Reducer.SpawnFood args)
		{
			if (OnSpawnFood == null) return false;
			OnSpawnFood(
				ctx,
				args.Timer
			);
			return true;
		}
		public delegate void UpdatePlayerInputHandler(EventContext ctx, SpacetimeDB.Types.DbVector2 direction);
		public event UpdatePlayerInputHandler? OnUpdatePlayerInput;

		public void UpdatePlayerInput(SpacetimeDB.Types.DbVector2 direction)
		{
			conn.InternalCallReducer(new Reducer.UpdatePlayerInput(direction), this.SetCallReducerFlags.UpdatePlayerInputFlags);
		}

		public bool InvokeUpdatePlayerInput(EventContext ctx, Reducer.UpdatePlayerInput args)
		{
			if (OnUpdatePlayerInput == null) return false;
			OnUpdatePlayerInput(
				ctx,
				args.Direction
			);
			return true;
		}
	}

	public sealed class SetReducerFlags
	{
		internal SetReducerFlags() { }
		internal CallReducerFlags CircleDecayFlags;
		public void CircleDecay(CallReducerFlags flags) { this.CircleDecayFlags = flags; }
		internal CallReducerFlags CircleRecombineFlags;
		public void CircleRecombine(CallReducerFlags flags) { this.CircleRecombineFlags = flags; }
		internal CallReducerFlags CreatePlayerFlags;
		public void CreatePlayer(CallReducerFlags flags) { this.CreatePlayerFlags = flags; }
		internal CallReducerFlags MoveAllPlayersFlags;
		public void MoveAllPlayers(CallReducerFlags flags) { this.MoveAllPlayersFlags = flags; }
		internal CallReducerFlags PlayerSplitFlags;
		public void PlayerSplit(CallReducerFlags flags) { this.PlayerSplitFlags = flags; }
		internal CallReducerFlags RespawnFlags;
		public void Respawn(CallReducerFlags flags) { this.RespawnFlags = flags; }
		internal CallReducerFlags SpawnFoodFlags;
		public void SpawnFood(CallReducerFlags flags) { this.SpawnFoodFlags = flags; }
		internal CallReducerFlags UpdatePlayerInputFlags;
		public void UpdatePlayerInput(CallReducerFlags flags) { this.UpdatePlayerInputFlags = flags; }
	}

	public partial record EventContext : DbContext<RemoteTables>, IEventContext
	{
		public readonly RemoteReducers Reducers;
		public readonly SetReducerFlags SetReducerFlags;
		public readonly Event<Reducer> Event;

		internal EventContext(DbConnection conn, Event<Reducer> reducerEvent) : base(conn.Db)
		{
			Reducers = conn.Reducers;
			SetReducerFlags = conn.SetReducerFlags;
			Event = reducerEvent;
		}
	}

	public abstract partial class Reducer
	{
		private Reducer() { }

		[SpacetimeDB.Type]
		[DataContract]
		public partial class CircleDecay : Reducer, IReducerArgs
		{
			[DataMember(Name = "_timer")]
			public SpacetimeDB.Types.CircleDecayTimer Timer;

			public CircleDecay(SpacetimeDB.Types.CircleDecayTimer Timer)
			{
				this.Timer = Timer;
			}

			public CircleDecay()
			{
				this.Timer = new();
			}

			string IReducerArgs.ReducerName => "circle_decay";
		}

		[SpacetimeDB.Type]
		[DataContract]
		public partial class CircleRecombine : Reducer, IReducerArgs
		{
			[DataMember(Name = "timer")]
			public SpacetimeDB.Types.CircleRecombineTimer Timer;

			public CircleRecombine(SpacetimeDB.Types.CircleRecombineTimer Timer)
			{
				this.Timer = Timer;
			}

			public CircleRecombine()
			{
				this.Timer = new();
			}

			string IReducerArgs.ReducerName => "circle_recombine";
		}

		[SpacetimeDB.Type]
		[DataContract]
		public partial class CreatePlayer : Reducer, IReducerArgs
		{
			[DataMember(Name = "name")]
			public string Name;

			public CreatePlayer(string Name)
			{
				this.Name = Name;
			}

			public CreatePlayer()
			{
				this.Name = "";
			}

			string IReducerArgs.ReducerName => "create_player";
		}

		[SpacetimeDB.Type]
		[DataContract]
		public partial class MoveAllPlayers : Reducer, IReducerArgs
		{
			[DataMember(Name = "_timer")]
			public SpacetimeDB.Types.MoveAllPlayersTimer Timer;

			public MoveAllPlayers(SpacetimeDB.Types.MoveAllPlayersTimer Timer)
			{
				this.Timer = Timer;
			}

			public MoveAllPlayers()
			{
				this.Timer = new();
			}

			string IReducerArgs.ReducerName => "move_all_players";
		}

		[SpacetimeDB.Type]
		[DataContract]
		public partial class PlayerSplit : Reducer, IReducerArgs
		{
			string IReducerArgs.ReducerName => "player_split";
		}

		[SpacetimeDB.Type]
		[DataContract]
		public partial class Respawn : Reducer, IReducerArgs
		{
			string IReducerArgs.ReducerName => "respawn";
		}

		[SpacetimeDB.Type]
		[DataContract]
		public partial class SpawnFood : Reducer, IReducerArgs
		{
			[DataMember(Name = "_timer")]
			public SpacetimeDB.Types.SpawnFoodTimer Timer;

			public SpawnFood(SpacetimeDB.Types.SpawnFoodTimer Timer)
			{
				this.Timer = Timer;
			}

			public SpawnFood()
			{
				this.Timer = new();
			}

			string IReducerArgs.ReducerName => "spawn_food";
		}

		[SpacetimeDB.Type]
		[DataContract]
		public partial class UpdatePlayerInput : Reducer, IReducerArgs
		{
			[DataMember(Name = "direction")]
			public SpacetimeDB.Types.DbVector2 Direction;

			public UpdatePlayerInput(SpacetimeDB.Types.DbVector2 Direction)
			{
				this.Direction = Direction;
			}

			public UpdatePlayerInput()
			{
				this.Direction = new();
			}

			string IReducerArgs.ReducerName => "update_player_input";
		}

		public class StdbNone : Reducer {}
		public class StdbIdentityConnected : Reducer {}
		public class StdbIdentityDisconnected : Reducer {}
	}

	public class DbConnection : DbConnectionBase<DbConnection, Reducer>
	{
		public readonly RemoteTables Db = new();
		public readonly RemoteReducers Reducers;
		public readonly SetReducerFlags SetReducerFlags;

		public DbConnection()
		{
			SetReducerFlags = new();
			Reducers = new(this, this.SetReducerFlags);

			clientDB.AddTable<Circle>("circle", Db.Circle);
			clientDB.AddTable<CircleDecayTimer>("circle_decay_timer", Db.CircleDecayTimer);
			clientDB.AddTable<CircleRecombineTimer>("circle_recombine_timer", Db.CircleRecombineTimer);
			clientDB.AddTable<Config>("config", Db.Config);
			clientDB.AddTable<Entity>("entity", Db.Entity);
			clientDB.AddTable<Food>("food", Db.Food);
			clientDB.AddTable<LoggedOutCircle>("logged_out_circle", Db.LoggedOutCircle);
			clientDB.AddTable<LoggedOutPlayer>("logged_out_player", Db.LoggedOutPlayer);
			clientDB.AddTable<MoveAllPlayersTimer>("move_all_players_timer", Db.MoveAllPlayersTimer);
			clientDB.AddTable<Player>("player", Db.Player);
			clientDB.AddTable<SpawnFoodTimer>("spawn_food_timer", Db.SpawnFoodTimer);
		}

		protected override Reducer ToReducer(TransactionUpdate update)
		{
			var encodedArgs = update.ReducerCall.Args;
			return update.ReducerCall.ReducerName switch {
				"circle_decay" => BSATNHelpers.Decode<Reducer.CircleDecay>(encodedArgs),
				"circle_recombine" => BSATNHelpers.Decode<Reducer.CircleRecombine>(encodedArgs),
				"create_player" => BSATNHelpers.Decode<Reducer.CreatePlayer>(encodedArgs),
				"move_all_players" => BSATNHelpers.Decode<Reducer.MoveAllPlayers>(encodedArgs),
				"player_split" => BSATNHelpers.Decode<Reducer.PlayerSplit>(encodedArgs),
				"respawn" => BSATNHelpers.Decode<Reducer.Respawn>(encodedArgs),
				"spawn_food" => BSATNHelpers.Decode<Reducer.SpawnFood>(encodedArgs),
				"update_player_input" => BSATNHelpers.Decode<Reducer.UpdatePlayerInput>(encodedArgs),
				"<none>" => new Reducer.StdbNone(),
				"__identity_connected__" => new Reducer.StdbIdentityConnected(),
				"__identity_disconnected__" => new Reducer.StdbIdentityDisconnected(),
				"" => new Reducer.StdbNone(),
				var reducer => throw new ArgumentOutOfRangeException("Reducer", $"Unknown reducer {reducer}")
			};
		}

		protected override IEventContext ToEventContext(Event<Reducer> reducerEvent) =>
		new EventContext(this, reducerEvent);

		protected override bool Dispatch(IEventContext context, Reducer reducer)
		{
			var eventContext = (EventContext)context;
			return reducer switch {
				Reducer.CircleDecay args => Reducers.InvokeCircleDecay(eventContext, args),
				Reducer.CircleRecombine args => Reducers.InvokeCircleRecombine(eventContext, args),
				Reducer.CreatePlayer args => Reducers.InvokeCreatePlayer(eventContext, args),
				Reducer.MoveAllPlayers args => Reducers.InvokeMoveAllPlayers(eventContext, args),
				Reducer.PlayerSplit args => Reducers.InvokePlayerSplit(eventContext, args),
				Reducer.Respawn args => Reducers.InvokeRespawn(eventContext, args),
				Reducer.SpawnFood args => Reducers.InvokeSpawnFood(eventContext, args),
				Reducer.UpdatePlayerInput args => Reducers.InvokeUpdatePlayerInput(eventContext, args),
				Reducer.StdbNone or
				Reducer.StdbIdentityConnected or
				Reducer.StdbIdentityDisconnected => true,
				_ => throw new ArgumentOutOfRangeException("Reducer", $"Unknown reducer {reducer}")
			};
		}

		public SubscriptionBuilder<EventContext> SubscriptionBuilder() => new(this);
	}
}
