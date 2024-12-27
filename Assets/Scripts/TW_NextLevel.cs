using UnityEngine;
using Unity.Netcode;
using UnityEngine.SceneManagement;

public class TW_NextLevel : NetworkBehaviour
{
    public string sceneToLoad;
    private int playersInTrigger = 0;

    private void OnTriggerEnter(Collider other)
    {
        // Check if the object entering the trigger is a player
        if (IsPlayer(other))
        {
            playersInTrigger++;
            Debug.Log("Player entered trigger zone. Current players in trigger: " + playersInTrigger);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        // Check if all players are in the trigger zone and the local player presses the interaction key
        if (IsLocalPlayer(other) && playersInTrigger >= 2)
        {
            if (IsServer)
            {
                ChangeSceneForAllClients();
            }
            else
            {
                
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Decrease the player count when a player leaves the trigger zone
        if (IsPlayer(other))
        {
            playersInTrigger--;
        }
    }

    private void ChangeSceneForAllClients()
    {
        NetworkManager.SceneManager.LoadScene(sceneToLoad, LoadSceneMode.Single); 
    }

    private new bool IsLocalPlayer(Collider other)
    {
        // Check if the object has a NetworkObject and is the local player
        var networkObject = other.GetComponent<NetworkObject>();
        return networkObject != null && networkObject.IsLocalPlayer;
    }

    private bool IsPlayer(Collider other)
    {
        // Check if the object has a NetworkObject and is a player
        var networkObject = other.GetComponent<NetworkObject>();
        return networkObject != null && networkObject.IsPlayerObject;
    }
}