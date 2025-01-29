// THIS FILE IS AUTOMATICALLY GENERATED BY SPACETIMEDB. EDITS TO THIS FILE
// WILL NOT BE SAVED. MODIFY TABLES IN YOUR MODULE SOURCE CODE INSTEAD.

#nullable enable

using System;
using SpacetimeDB.ClientApi;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SpacetimeDB.Types
{
    public sealed partial class RemoteReducers : RemoteBase<DbConnection>
    {
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
    }

    public abstract partial class Reducer
    {
        [SpacetimeDB.Type]
        [DataContract]
        public sealed partial class Respawn : Reducer, IReducerArgs
        {
            string IReducerArgs.ReducerName => "respawn";
        }
    }

    public sealed partial class SetReducerFlags
    {
        internal CallReducerFlags RespawnFlags;
        public void Respawn(CallReducerFlags flags) { this.RespawnFlags = flags; }
    }
}
