using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun; 
public class spawnPlayers : MonoBehaviour
{
    public GameObject playerPrefab;

    public Transform[] spawns = new Transform[4];

    private void Start() {
        PhotonNetwork.Instantiate(playerPrefab.name, spawns[Random.Range(0,3)].position, Quaternion.identity);
    }
}
