using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SWNetwork;

public class GameSceneManager : MonoBehaviour
{
    public void OnSpawnerReady(bool alreadyFinishedSceneSetup, SceneSpawner sceneSpawner)
    {
        if (!alreadyFinishedSceneSetup){
            int spawnPointIndex = Random.Range(0, 3);
            sceneSpawner.SpawnForPlayer(0, spawnPointIndex);

            NetworkClient.Instance.LastSpawner.PlayerFinishedSceneSetup();
        }
    }
}
