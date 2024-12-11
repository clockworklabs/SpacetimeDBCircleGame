using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using SpacetimeDB;
using SpacetimeDB.Types;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour
{
    public CircleController circlePrefab;
    public PlayerController playerPrefab;

    public static GameManager instance;
    public static Camera localCamera;
    public static Dictionary<uint, PlayerController> playerIdToPlayerController =
        new Dictionary<uint, PlayerController>();

    public static Identity? localIdentity;
    public static DbConnection conn;

    private void Start()
    {
        instance = this;
        Application.targetFrameRate = 60;

        // Now that we’ve registered all our callbacks, lets connect to spacetimedb
        conn = DbConnection.Builder().OnConnect((_conn, identity, token) => {
            // Called when we connect to SpacetimeDB and receive our client identity
            Debug.Log("Connected.");
            AuthToken.SaveToken(token);
            localIdentity = identity;

            conn.Db.Circle.OnInsert += CircleOnInsert;
            conn.Db.Circle.OnDelete += CircleOnDelete;
            conn.Db.Entity.OnUpdate += EntityOnUpdate;

            // Request all tables
            conn.SubscriptionBuilder().OnApplied(ctx =>
            {
                Debug.Log("Subscription applied!");
            }).Subscribe("SELECT * FROM *");
        }).OnConnectError((message) =>
        {
            // Called when we have an error connecting to SpacetimeDB
            Debug.LogError($"Connection error: {message}");
        }).OnDisconnect((_conn, error) =>
        {
            // Called when we are disconnected from SpacetimeDB
            Debug.Log("Disconnected.");
        }).WithUri("http://localhost:3000")
            .WithModuleName("untitled-circle-game")
            .Build();

#pragma warning disable CS0612 // Type or member is obsolete
        conn.onUnhandledReducerError += InstanceOnUnhandledReducerError;
#pragma warning restore CS0612 // Type or member is obsolete

        localCamera = Camera.main;
    }

    private void InstanceOnUnhandledReducerError(ReducerEvent<Reducer> reducerEvent)
    {
        Debug.LogError("There was an error!");
    }

    private void EntityOnUpdate(EventContext context, Entity oldEntity, Entity newEntity)
    {
        var circle = conn.Db.Circle.EntityId.Find(newEntity.Id);
        if (circle == null)
        {
            return;
        }

        var player = GetOrCreatePlayer(circle.EntityId);
        player.CircleUpdate(oldEntity, newEntity);
    }

    private void CircleOnDelete(EventContext context, Circle deletedCircle)
    {
        var player = GetOrCreatePlayer(deletedCircle.EntityId);
        player.DespawnCircle(deletedCircle);
    }

    private void CircleOnInsert(EventContext context, Circle insertedValue)
    {
        var player = GetOrCreatePlayer(insertedValue.EntityId);
        // Spawn the new circle
        player.SpawnCircle(insertedValue, circlePrefab);
    }

    PlayerController GetOrCreatePlayer(uint playerId)
    {
        // Get the PlayerController for this circle
        if (!playerIdToPlayerController.TryGetValue(playerId, out var playerController))
        {
            playerController = Instantiate(playerPrefab);
            playerIdToPlayerController[playerId] = playerController;
            playerController.Spawn();
        }

        return playerController;
    }

    public static float MassToRadius(uint mass)
    {
        return Mathf.Sqrt(mass);
    }

    public void Update()
    {
        Debug.Log("FPS: " + (1.0f / Time.deltaTime));
    }
}
