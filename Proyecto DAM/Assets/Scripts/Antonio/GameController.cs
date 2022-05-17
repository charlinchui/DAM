﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController instance;

    public List<AudioClip> clips;

    public float volume;

    public string playerName;

    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Game");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }
}