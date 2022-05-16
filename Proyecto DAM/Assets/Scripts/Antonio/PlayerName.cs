using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerName : MonoBehaviour
{
    void Start()
    {
        gameObject.transform.GetChild(0).GetComponent<Text>().text = GameObject.FindGameObjectWithTag("Game").GetComponent<GameController>().playerName;
    }
}
