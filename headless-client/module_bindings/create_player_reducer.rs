// THIS FILE IS AUTOMATICALLY GENERATED BY SPACETIMEDB. EDITS TO THIS FILE
// WILL NOT BE SAVED. MODIFY TABLES IN RUST INSTEAD.

#![allow(unused)]
use spacetimedb_sdk::{
    self as __sdk,
    anyhow::{self as __anyhow, Context as _},
    lib as __lib, sats as __sats, ws_messages as __ws,
};

#[derive(__lib::ser::Serialize, __lib::de::Deserialize, Clone, PartialEq, Debug)]
#[sats(crate = __lib)]
pub struct CreatePlayer {
    pub name: String,
}

impl __sdk::spacetime_module::InModule for CreatePlayer {
    type Module = super::RemoteModule;
}

pub struct CreatePlayerCallbackId(__sdk::callbacks::CallbackId);

#[allow(non_camel_case_types)]
/// Extension trait for access to the reducer `create_player`.
///
/// Implemented for [`super::RemoteReducers`].
pub trait create_player {
    /// Request that the remote module invoke the reducer `create_player` to run as soon as possible.
    ///
    /// This method returns immediately, and errors only if we are unable to send the request.
    /// The reducer will run asynchronously in the future,
    ///  and its status can be observed by listening for [`Self::on_create_player`] callbacks.
    fn create_player(&self, name: String) -> __anyhow::Result<()>;
    /// Register a callback to run whenever we are notified of an invocation of the reducer `create_player`.
    ///
    /// The [`super::EventContext`] passed to the `callback`
    /// will always have [`__sdk::Event::Reducer`] as its `event`,
    /// but it may or may not have terminated successfully and been committed.
    /// Callbacks should inspect the [`__sdk::ReducerEvent`] contained in the [`super::EventContext`]
    /// to determine the reducer's status.
    ///
    /// The returned [`CreatePlayerCallbackId`] can be passed to [`Self::remove_on_create_player`]
    /// to cancel the callback.
    fn on_create_player(
        &self,
        callback: impl FnMut(&super::EventContext, &String) + Send + 'static,
    ) -> CreatePlayerCallbackId;
    /// Cancel a callback previously registered by [`Self::on_create_player`],
    /// causing it not to run in the future.
    fn remove_on_create_player(&self, callback: CreatePlayerCallbackId);
}

impl create_player for super::RemoteReducers {
    fn create_player(&self, name: String) -> __anyhow::Result<()> {
        self.imp
            .call_reducer("create_player", CreatePlayer { name })
    }
    fn on_create_player(
        &self,
        mut callback: impl FnMut(&super::EventContext, &String) + Send + 'static,
    ) -> CreatePlayerCallbackId {
        CreatePlayerCallbackId(self.imp.on_reducer::<CreatePlayer>(
            "create_player",
            Box::new(move |ctx: &super::EventContext, args: &CreatePlayer| {
                callback(ctx, &args.name)
            }),
        ))
    }
    fn remove_on_create_player(&self, callback: CreatePlayerCallbackId) {
        self.imp
            .remove_on_reducer::<CreatePlayer>("create_player", callback.0)
    }
}