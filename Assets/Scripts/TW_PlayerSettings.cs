using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;
using Unity.Collections;

public class TW_PlayerSettings : NetworkBehaviour
{
    [SerializeField] private GameObject player;
    public List<GameObject> children = new List<GameObject>();

    public override void OnNetworkSpawn()
    {
        children[(int)OwnerClientId].SetActive(true);
    }

}
