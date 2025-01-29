// THIS FILE IS AUTOMATICALLY GENERATED BY SPACETIMEDB. EDITS TO THIS FILE
// WILL NOT BE SAVED. MODIFY TABLES IN YOUR MODULE SOURCE CODE INSTEAD.

#nullable enable

using System;
using SpacetimeDB.BSATN;
using SpacetimeDB.ClientApi;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SpacetimeDB.Types
{
    public sealed partial class RemoteTables
    {
        public sealed class PlayerHandle : RemoteTableHandle<EventContext, Player>
        {
            protected override string Name => "player";

            public sealed class IdentityUniqueIndex : UniqueIndexBase<SpacetimeDB.Identity>
            {
                protected override SpacetimeDB.Identity GetKey(Player row) => row.Identity;

                public IdentityUniqueIndex(PlayerHandle table) : base(table) { }
            }

            public readonly IdentityUniqueIndex Identity;

            public sealed class PlayerIdUniqueIndex : UniqueIndexBase<uint>
            {
                protected override uint GetKey(Player row) => row.PlayerId;

                public PlayerIdUniqueIndex(PlayerHandle table) : base(table) { }
            }

            public readonly PlayerIdUniqueIndex PlayerId;

            internal PlayerHandle()
            {
                Identity = new(this);
                PlayerId = new(this);
            }

            protected override object GetPrimaryKey(Player row) => row.Identity;
        }

        public readonly PlayerHandle Player = new();
    }
}
