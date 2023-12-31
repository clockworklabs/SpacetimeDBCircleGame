using System;
using System.Collections;
using System.Collections.Generic;
using SpacetimeDB;
using SpacetimeDB.Types;
using UnityEngine;
using UnityEngine.UI;

public class UIUsernameChooser : MonoBehaviour
{
    public TMPro.TMP_InputField usernameInputField;
    public Button playButton;

    private bool sentCreatePlayer;

    private void Start()
    {
        Player.OnInsert += (newPlayer, _) =>
        {
            Debug.Log("Start - Checking identity");
            if (newPlayer.Identity == GameManager.localIdentity)
            {
                // We have a player
               gameObject.SetActive(false); 
            }
        };
    }

    public void PlayPressed()
    {
        if (sentCreatePlayer)
        {
            return;
        }

        sentCreatePlayer = true;
        Reducer.CreatePlayer(usernameInputField.text);
        playButton.interactable = false;
    }
}
