// THIS FILE IS AUTOMATICALLY GENERATED BY SPACETIMEDB. EDITS TO THIS FILE
// WILL NOT BE SAVED. MODIFY TABLES IN RUST INSTEAD.

#![allow(unused)]
use spacetimedb_sdk::{
    self as __sdk,
    anyhow::{self as __anyhow, Context as _},
    lib as __lib, sats as __sats, ws_messages as __ws,
};

use super::vector_2_type::Vector2;

#[derive(__lib::ser::Serialize, __lib::de::Deserialize, Clone, PartialEq, Debug)]
#[sats(crate = __lib)]
pub struct UpdatePlayerInput {
    pub velocity: Vector2,
}

impl __sdk::spacetime_module::InModule for UpdatePlayerInput {
    type Module = super::RemoteModule;
}

pub struct UpdatePlayerInputCallbackId(__sdk::callbacks::CallbackId);

#[allow(non_camel_case_types)]
/// Extension trait for access to the reducer `update_player_input`.
///
/// Implemented for [`super::RemoteReducers`].
pub trait update_player_input {
    /// Request that the remote module invoke the reducer `update_player_input` to run as soon as possible.
    ///
    /// This method returns immediately, and errors only if we are unable to send the request.
    /// The reducer will run asynchronously in the future,
    ///  and its status can be observed by listening for [`Self::on_update_player_input`] callbacks.
    fn update_player_input(&self, velocity: Vector2) -> __anyhow::Result<()>;
    /// Register a callback to run whenever we are notified of an invocation of the reducer `update_player_input`.
    ///
    /// The [`super::EventContext`] passed to the `callback`
    /// will always have [`__sdk::Event::Reducer`] as its `event`,
    /// but it may or may not have terminated successfully and been committed.
    /// Callbacks should inspect the [`__sdk::ReducerEvent`] contained in the [`super::EventContext`]
    /// to determine the reducer's status.
    ///
    /// The returned [`UpdatePlayerInputCallbackId`] can be passed to [`Self::remove_on_update_player_input`]
    /// to cancel the callback.
    fn on_update_player_input(
        &self,
        callback: impl FnMut(&super::EventContext, &Vector2) + Send + 'static,
    ) -> UpdatePlayerInputCallbackId;
    /// Cancel a callback previously registered by [`Self::on_update_player_input`],
    /// causing it not to run in the future.
    fn remove_on_update_player_input(&self, callback: UpdatePlayerInputCallbackId);
}

impl update_player_input for super::RemoteReducers {
    fn update_player_input(&self, velocity: Vector2) -> __anyhow::Result<()> {
        self.imp
            .call_reducer("update_player_input", UpdatePlayerInput { velocity })
    }
    fn on_update_player_input(
        &self,
        mut callback: impl FnMut(&super::EventContext, &Vector2) + Send + 'static,
    ) -> UpdatePlayerInputCallbackId {
        UpdatePlayerInputCallbackId(self.imp.on_reducer::<UpdatePlayerInput>(
            "update_player_input",
            Box::new(move |ctx: &super::EventContext, args: &UpdatePlayerInput| {
                callback(ctx, &args.velocity)
            }),
        ))
    }
    fn remove_on_update_player_input(&self, callback: UpdatePlayerInputCallbackId) {
        self.imp
            .remove_on_reducer::<UpdatePlayerInput>("update_player_input", callback.0)
    }
}
