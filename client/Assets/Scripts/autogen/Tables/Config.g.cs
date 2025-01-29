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
        public sealed class ConfigHandle : RemoteTableHandle<EventContext, Config>
        {
            protected override string Name => "config";

            public sealed class IdUniqueIndex : UniqueIndexBase<uint>
            {
                protected override uint GetKey(Config row) => row.Id;

                public IdUniqueIndex(ConfigHandle table) : base(table) { }
            }

            public readonly IdUniqueIndex Id;

            internal ConfigHandle()
            {
                Id = new(this);
            }

            protected override object GetPrimaryKey(Config row) => row.Id;
        }

        public readonly ConfigHandle Config = new();
    }
}
