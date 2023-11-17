// THIS FILE IS AUTOMATICALLY GENERATED BY SPACETIMEDB. EDITS TO THIS FILE
// WILL NOT BE SAVED. MODIFY TABLES IN RUST INSTEAD.

using System;
using ClientApi;
using Newtonsoft.Json.Linq;
using SpacetimeDB;

namespace SpacetimeDB.Types
{
	public static partial class Reducer
	{
		public delegate void CircleDecayHandler(ReducerEvent reducerEvent);
		public static event CircleDecayHandler OnCircleDecayEvent;

		public static void CircleDecay()
		{
			var _argArray = new object[] {};
			var _message = new SpacetimeDBClient.ReducerCallRequest {
				fn = "circle_decay",
				args = _argArray,
			};
			SpacetimeDBClient.instance.InternalCallReducer(Newtonsoft.Json.JsonConvert.SerializeObject(_message, _settings));
		}

		[ReducerCallback(FunctionName = "circle_decay")]
		public static bool OnCircleDecay(ClientApi.Event dbEvent)
		{
			if(OnCircleDecayEvent != null)
			{
				var args = ((ReducerEvent)dbEvent.FunctionCall.CallInfo).CircleDecayArgs;
				OnCircleDecayEvent((ReducerEvent)dbEvent.FunctionCall.CallInfo
				);
				return true;
			}
			return false;
		}

		[DeserializeEvent(FunctionName = "circle_decay")]
		public static void CircleDecayDeserializeEventArgs(ClientApi.Event dbEvent)
		{
			var args = new CircleDecayArgsStruct();
			var bsatnBytes = dbEvent.FunctionCall.ArgBytes;
			using var ms = new System.IO.MemoryStream();
			ms.SetLength(bsatnBytes.Length);
			bsatnBytes.CopyTo(ms.GetBuffer(), 0);
			ms.Position = 0;
			using var reader = new System.IO.BinaryReader(ms);
			dbEvent.FunctionCall.CallInfo = new ReducerEvent(ReducerType.CircleDecay, "circle_decay", dbEvent.Timestamp, Identity.From(dbEvent.CallerIdentity.ToByteArray()), Address.From(dbEvent.CallerAddress.ToByteArray()), dbEvent.Message, dbEvent.Status, args);
		}
	}

	public partial class CircleDecayArgsStruct
	{
	}

}
