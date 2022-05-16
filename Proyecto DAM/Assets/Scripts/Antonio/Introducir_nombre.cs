using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Introducir_nombre : MonoBehaviour
{
    public void OnValueChangedPlayerName()
    {
        GameObject.FindGameObjectWithTag("Game").GetComponent<GameController>().playerName = GetComponent<InputField>().text;
    }
}
