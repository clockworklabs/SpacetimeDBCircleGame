// THIS FILE IS AUTOMATICALLY GENERATED BY SPACETIMEDB. EDITS TO THIS FILE
// WILL NOT BE SAVED. MODIFY TABLES IN YOUR MODULE SOURCE CODE INSTEAD.

#nullable enable

using System;
using SpacetimeDB.ClientApi;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SpacetimeDB.Types
{
    public sealed partial class RemoteReducers : RemoteBase
    {
        public delegate void EnterGameHandler(ReducerEventContext ctx, string name);
        public event EnterGameHandler? OnEnterGame;

        public void EnterGame(string name)
        {
            conn.InternalCallReducer(new Reducer.EnterGame(name), this.SetCallReducerFlags.EnterGameFlags);
        }

        public bool InvokeEnterGame(ReducerEventContext ctx, Reducer.EnterGame args)
        {
            if (OnEnterGame == null) return false;
            OnEnterGame(
                ctx,
                args.Name
            );
            return true;
        }
    }

    public abstract partial class Reducer
    {
        [SpacetimeDB.Type]
        [DataContract]
        public sealed partial class EnterGame : Reducer, IReducerArgs
        {
            [DataMember(Name = "name")]
            public string Name;

            public EnterGame(string Name)
            {
                this.Name = Name;
            }

            public EnterGame()
            {
                this.Name = "";
            }

            string IReducerArgs.ReducerName => "enter_game";
        }
    }

    public sealed partial class SetReducerFlags
    {
        internal CallReducerFlags EnterGameFlags;
        public void EnterGame(CallReducerFlags flags) => EnterGameFlags = flags;
    }
}
